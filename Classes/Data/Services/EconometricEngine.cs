using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    public class EconometricEngine : IEconometricEngine
    {
        private readonly IRepository<SaleDetails> _saleDetailsRepository;
        private readonly IRepository<ExternalFactor> _externalFactorRepository;

        public EconometricEngine(
            IRepository<SaleDetails> saleDetailsRepository,
            IRepository<ExternalFactor> externalFactorRepository)
        {
            _saleDetailsRepository = saleDetailsRepository ?? throw new ArgumentNullException(nameof(saleDetailsRepository));
            _externalFactorRepository = externalFactorRepository ?? throw new ArgumentNullException(nameof(externalFactorRepository));
        }

        public decimal CalculateCorrelation(List<decimal> sales, List<decimal> factors)
        {
            if (sales == null)
                throw new ArgumentNullException(nameof(sales));
            if (factors == null)
                throw new ArgumentNullException(nameof(factors));

            var n = Math.Min(sales.Count, factors.Count);
            if (n < 2)
                return 0m;

            var x = factors.Take(n).Select(v => (double)v).ToArray();
            var y = sales.Take(n).Select(v => (double)v).ToArray();

            var meanX = x.Average();
            var meanY = y.Average();

            var numerator = 0d;
            var sumSqX = 0d;
            var sumSqY = 0d;

            for (var i = 0; i < n; i++)
            {
                var dx = x[i] - meanX;
                var dy = y[i] - meanY;
                numerator += dx * dy;
                sumSqX += dx * dx;
                sumSqY += dy * dy;
            }

            if (sumSqX == 0 || sumSqY == 0)
                return 0m;

            var correlation = numerator / Math.Sqrt(sumSqX * sumSqY);
            correlation = Math.Max(-1d, Math.Min(1d, correlation));
            return (decimal)correlation;
        }

        public async Task<EconometricModel> GetTrendAnalysisAsync(
            int productId,
            List<ExternalFactor>? factors = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            List<decimal>? aggregatedSales = null) // Parametrul cheie pentru sincronizarea cu Facade
        {
            // 1. Pregătirea datelor (Data Sourcing)
            List<decimal> salesSeries;

            if (aggregatedSales != null && aggregatedSales.Count >= 2)
            {
                // Folosim datele deja grupate venite din Facade (Zgomot redus)
                salesSeries = aggregatedSales;
            }
            else
            {
                // Fallback: Dacă nu avem date agregate, le tragem brut din DB (Daily)
                var dailyTotals = await _saleDetailsRepository.GetAll()
                    .Include(sd => sd.Sale)
                    .Where(sd => sd.ProductId == productId &&
                                 (!startDate.HasValue || sd.Sale.SaleDate >= startDate) &&
                                 (!endDate.HasValue || sd.Sale.SaleDate <= endDate))
                    .GroupBy(sd => sd.Sale.SaleDate.Date)
                    .OrderBy(g => g.Key)
                    .Select(g => g.Sum(x => x.Quantity))
                    .ToListAsync();

                salesSeries = dailyTotals.Select(v => (decimal)v).ToList();
            }

            // 2. Verificare de siguranță: Avem nevoie de minim 2 puncte pentru un trend
            if (salesSeries.Count < 2)
            {
                return new EconometricModel
                {
                    ModelName = "Infallible Linear Regression",
                    RSquared = 0,
                    CoefficientValue = 0,
                    PValue = 1,
                    LastTrainedDate = DateTime.Now
                };
            }

            // 3. Calculul Regresiei Liniare Simple: y = ax + b
            var n = salesSeries.Count;
            var x = Enumerable.Range(1, n).Select(i => (double)i).ToArray();
            var y = salesSeries.Select(v => (double)v).ToArray();

            var stats = CalculateLinearRegression(x, y);

            // Corelația este calculată folosind DOAR lista de factori transmisă din Facade
            // (dacă există), altfel fallback la factori din DB pe interval.
            List<decimal> factorSeries;
            if (factors != null)
            {
                factorSeries = factors
                    .Where(f => f.IsActive)
                    .OrderBy(f => f.Date)
                    .Select(f => f.ImpactValue)
                    .ToList();
            }
            else
            {
                factorSeries = await _externalFactorRepository.GetAll()
                    .Where(f => f.IsActive &&
                                (!startDate.HasValue || f.Date >= startDate) &&
                                (!endDate.HasValue || f.Date <= endDate))
                    .OrderBy(f => f.Date)
                    .Select(f => f.ImpactValue)
                    .ToListAsync();
            }

            var correlation = factorSeries.Count >= 2
                ? CalculateCorrelation(salesSeries, factorSeries)
                : 0m;

            // P-value pentru corelația Pearson: t = r·√(n-2) / √(1-r²)
            // cu n = numărul de perechi aliniate utilizate în calcul
            decimal pValue;
            if (factorSeries.Count >= 4)
            {
                int corrN = Math.Min(salesSeries.Count, factorSeries.Count);
                double r = (double)correlation;
                double tR = Math.Abs(r) < 1.0
                    ? Math.Abs(r) * Math.Sqrt(corrN - 2) / Math.Sqrt(1.0 - r * r)
                    : double.PositiveInfinity;
                pValue = (decimal)TwoTailedPValue(tR, corrN - 2);
            }
            else
            {
                pValue = (decimal)stats.PValue;
            }

            // 4. Construirea Modelului Rezultat
            return new EconometricModel
            {
                // Dinamic: Numele reflectă dacă am făcut netezirea datelor (Smoothing)
                ModelName = salesSeries.Count < 15 ? "Aggregated Trend (High Reliability)" : "Daily Regression (High Granularity)",
                CoefficientValue = (decimal)stats.Slope,
                RSquared = (decimal)stats.RSquared,
                PValue = pValue,
                LastTrainedDate = DateTime.Now
            };
        }

        // Metodă Helper pentru Logica Matematică (y = ax + b)
        private (double Slope, double Intercept, double RSquared, double PValue, double StandardError) CalculateLinearRegression(double[] x, double[] y)
        {
            int n = x.Length;
            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumXY = 0;
            double sumX2 = 0;
            double sumY2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumXY += x[i] * y[i];
                sumX2 += x[i] * x[i];
                sumY2 += y[i] * y[i];
            }

            // Calcul Panta (a) și Intercept (b) — OLS standard
            var denominator = (n * sumX2 - sumX * sumX);
            double slope = denominator == 0 ? 0 : (n * sumXY - sumX * sumY) / denominator;
            double intercept = (sumY - slope * sumX) / n;

            // Calcul Coeficient de Determinare (R-Squared)
            double ssTot = sumY2 - (sumY * sumY) / n;
            double ssRes = 0;
            for (int i = 0; i < n; i++)
            {
                double prediction = slope * x[i] + intercept;
                ssRes += Math.Pow(y[i] - prediction, 2);
            }

            double rSquared = ssTot == 0 ? 0 : 1 - (ssRes / ssTot);

            int df = Math.Max(1, n - 2);
            double mse = ssRes / df;                 // MSE = SSres / (n-2)
            double standardError = Math.Sqrt(mse);   // SEE — standard error of the estimate

            // P-Value corect: t-test pentru coeficientul pantei
            // SE(slope) = sqrt(MSE / Sxx), unde Sxx = Σ(xᵢ - x̄)²
            // Sxx = sumX2 - sumX²/n  (formă computațională echivalentă)
            double sxx = sumX2 - sumX * sumX / n;
            double slopeStdErr = sxx > 0 ? Math.Sqrt(mse / sxx) : double.PositiveInfinity;
            double tSlope = slopeStdErr > 0 && !double.IsInfinity(slopeStdErr)
                ? Math.Abs(slope) / slopeStdErr
                : 0.0;
            double pValue = n >= 4 ? TwoTailedPValue(tSlope, df) : 1.0;

            return (slope, intercept, rSquared, pValue, standardError);
        }

        // ─── Distribuție t — P-Value exact ────────────────────────────────────────

        /// <summary>
        /// P-value bilateral pentru testul t cu <paramref name="df"/> grade de libertate.
        /// Formula: P(|T| > t | df) = I_{df/(df+t²)}(df/2, 1/2)
        /// unde I_x(a,b) este funcția beta incompletă regularizată.
        /// </summary>
        private static double TwoTailedPValue(double tAbs, int df)
        {
            if (df < 1 || double.IsNaN(tAbs)) return 1.0;
            if (tAbs <= 0.0) return 1.0;
            if (double.IsPositiveInfinity(tAbs)) return 0.0;

            double x = (double)df / (df + tAbs * tAbs);
            return Math.Clamp(RegularizedIncompleteBeta(x, df / 2.0, 0.5), 0.0, 1.0);
        }

        /// <summary>
        /// Funcția beta incompletă regularizată I_x(a,b) via fracții continue (metoda Lentz).
        /// Numerical Recipes in C, §6.4.
        /// </summary>
        private static double RegularizedIncompleteBeta(double x, double a, double b)
        {
            if (x <= 0.0) return 0.0;
            if (x >= 1.0) return 1.0;

            // Simetrie: I_x(a,b) = 1 − I_{1-x}(b,a) — convergență mai bună
            if (x > (a + 1.0) / (a + b + 2.0))
                return 1.0 - RegularizedIncompleteBeta(1.0 - x, b, a);

            double logBeta = LogGamma(a) + LogGamma(b) - LogGamma(a + b);
            double front = Math.Exp(a * Math.Log(x) + b * Math.Log(1.0 - x) - logBeta) / a;

            // Fracție continuă Lentz
            const double fpMin = 1e-30, eps = 3e-7;
            double c = 1.0;
            double d = 1.0 - (a + b) * x / (a + 1.0);
            if (Math.Abs(d) < fpMin) d = fpMin;
            d = 1.0 / d;
            double h = d;

            for (int m = 1; m <= 200; m++)
            {
                double dm = m;

                // Pas par (m)
                double num = dm * (b - dm) * x / ((a + 2.0 * dm - 1.0) * (a + 2.0 * dm));
                d = 1.0 + num * d; if (Math.Abs(d) < fpMin) d = fpMin;
                c = 1.0 + num / c; if (Math.Abs(c) < fpMin) c = fpMin;
                d = 1.0 / d;
                h *= c * d;

                // Pas impar (m)
                num = -(a + dm) * (a + b + dm) * x / ((a + 2.0 * dm) * (a + 2.0 * dm + 1.0));
                d = 1.0 + num * d; if (Math.Abs(d) < fpMin) d = fpMin;
                c = 1.0 + num / c; if (Math.Abs(c) < fpMin) c = fpMin;
                d = 1.0 / d;
                double delta = c * d;
                h *= delta;

                if (Math.Abs(delta - 1.0) < eps) break;
            }

            return front * h;
        }

        /// <summary>
        /// Log-Gamma via aproximarea Lanczos (g=5, n=6). Precizie ~15 cifre semnificative.
        /// </summary>
        private static double LogGamma(double z)
        {
            double[] coef = { 76.18009172947146, -86.50532032941677, 24.01409824083091,
                              -1.231739572450155, 1.208650973866179e-3, -5.395239384953e-6 };
            double y = z, x = z;
            double tmp = x + 5.5;
            tmp -= (x + 0.5) * Math.Log(tmp);
            double ser = 1.000000000190015;
            for (int j = 0; j < coef.Length; j++)
                ser += coef[j] / ++y;
            return -tmp + Math.Log(2.5066282746310005 * ser / x);
        }
    }
}
