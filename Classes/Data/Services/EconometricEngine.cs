using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
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

            // 4. Construirea Modelului Rezultat — DOAR trendul temporal.
            //
            // SEPARAREA RELAȚIILOR: acest model descrie regresia vânzări-vs-TIMP.
            //   CoefficientValue = panta trendului temporal
            //   RSquared         = R² al trendului
            //   PValue           = semnificația PANTEI (testul t pe coeficient, df=n-2)
            // Corelația cu factorii externi este o relație DIFERITĂ și este calculată
            // separat în Facade prin AnalyzeFactorCorrelation (pe serii aliniate pe dată).
            // Parametrul `factors` nu mai este folosit aici intenționat.
            _ = factors;
            return new EconometricModel
            {
                ModelName = salesSeries.Count < 15 ? "Aggregated Trend (High Reliability)" : "Daily Regression (High Granularity)",
                CoefficientValue = (decimal)stats.Slope,
                RSquared = (decimal)stats.RSquared,
                PValue = (decimal)stats.PValue,
                LastTrainedDate = DateTime.Now
            };
        }

        /// <summary>
        /// Corelație factorială pe serii deja aliniate pe dată (vezi IEconometricEngine).
        /// </summary>
        public (decimal Correlation, decimal PValue, int N) AnalyzeFactorCorrelation(
            List<decimal> alignedSales,
            List<decimal> alignedFactors)
        {
            if (alignedSales == null || alignedFactors == null)
                return (0m, 1m, 0);

            int n = Math.Min(alignedSales.Count, alignedFactors.Count);
            if (n < 2)
                return (0m, 1m, n);

            var r = CalculateCorrelation(alignedSales, alignedFactors);

            // Cu mai puțin de 3 perechi nu există grade de libertate pentru un t-test (df=n-2).
            if (n < 3)
                return (r, 1m, n);

            double rd = (double)r;
            double t = Math.Abs(rd) < 1.0
                ? Math.Abs(rd) * Math.Sqrt(n - 2) / Math.Sqrt(1.0 - rd * rd)
                : double.PositiveInfinity;
            var p = (decimal)TwoTailedPValue(t, n - 2);
            return (r, p, n);
        }

        /// <summary>
        /// Multiplicator t-Student bilateral pentru benzile de confidență/predicție.
        /// </summary>
        public decimal GetConfidenceMultiplier(int confidencePercent, int df)
        {
            int conf = Math.Max(50, Math.Min(99, confidencePercent));
            double alpha = 1.0 - conf / 100.0; // masa totală pe ambele cozi
            if (df < 1)
                return 1.96m; // fallback degenerat (nefolosit: benzile sunt plate la n<3)
            return (decimal)TwoTailedTCritical(alpha, df);
        }

        // ─── Regresie liniară multiplă (OLS) ─────────────────────────────────────────

        public MultipleRegressionResult FitMultipleRegression(
            List<decimal> response,
            List<List<decimal>> regressors)
        {
            var invalid = new MultipleRegressionResult { IsValid = false };

            if (response == null || regressors == null || regressors.Count == 0)
                return invalid;

            int n = response.Count;
            int k = regressors.Count;       // numărul de regresori (fără intercept)
            int p = k + 1;                  // parametri = intercept + regresori

            // Avem nevoie de mai multe observaţii decât parametri pentru df > 0.
            if (n < p + 1) return invalid;
            if (regressors.Any(c => c.Count != n)) return invalid;

            var y = response.Select(v => (double)v).ToArray();

            // Matricea de design X (n×p): coloana 0 = intercept (1), apoi regresorii.
            var X = new double[n, p];
            for (int i = 0; i < n; i++)
            {
                X[i, 0] = 1.0;
                for (int j = 0; j < k; j++)
                    X[i, j + 1] = (double)regressors[j][i];
            }

            // XᵀX (p×p) şi Xᵀy (p)
            var xtx = new double[p, p];
            var xty = new double[p];
            for (int a = 0; a < p; a++)
            {
                for (int b = 0; b < p; b++)
                {
                    double s = 0;
                    for (int i = 0; i < n; i++) s += X[i, a] * X[i, b];
                    xtx[a, b] = s;
                }
                double sy = 0;
                for (int i = 0; i < n; i++) sy += X[i, a] * y[i];
                xty[a] = sy;
            }

            var xtxInv = InvertMatrix(xtx);
            if (xtxInv == null) return invalid; // singulară / coliniaritate severă

            // β = (XᵀX)⁻¹ Xᵀy
            var beta = new double[p];
            for (int a = 0; a < p; a++)
            {
                double s = 0;
                for (int b = 0; b < p; b++) s += xtxInv[a, b] * xty[b];
                beta[a] = s;
            }

            // Sume de pătrate
            double meanY = y.Average();
            double ssTot = 0, ssRes = 0;
            for (int i = 0; i < n; i++)
            {
                double fit = 0;
                for (int a = 0; a < p; a++) fit += beta[a] * X[i, a];
                ssRes += (y[i] - fit) * (y[i] - fit);
                ssTot += (y[i] - meanY) * (y[i] - meanY);
            }

            double rSquared = ssTot <= 0 ? 0 : 1.0 - ssRes / ssTot;
            int dfRes = n - p;
            double adjR2 = (ssTot <= 0 || dfRes <= 0)
                ? 0
                : 1.0 - (1.0 - rSquared) * (n - 1) / dfRes;
            double mse = dfRes > 0 ? ssRes / dfRes : 0;
            double see = Math.Sqrt(Math.Max(0, mse));

            // Testul F pentru semnificaţia globală: F = (SSreg/k) / (SSres/(n-p))
            double ssReg = ssTot - ssRes;
            double fStat = (k > 0 && mse > 0) ? (ssReg / k) / mse : 0;
            double fp = FTailProbability(fStat, k, dfRes);

            // Erori standard, t şi p per coeficient: SE(βⱼ) = SEE·√((XᵀX)⁻¹ⱼⱼ)
            var se = new double[p];
            var tStat = new double[p];
            var pVal = new double[p];
            for (int a = 0; a < p; a++)
            {
                double diag = xtxInv[a, a];
                se[a] = (diag > 0) ? see * Math.Sqrt(diag) : 0;
                tStat[a] = se[a] > 0 ? beta[a] / se[a] : 0;
                pVal[a] = (dfRes >= 1) ? TwoTailedPValue(Math.Abs(tStat[a]), dfRes) : 1.0;
            }

            return new MultipleRegressionResult
            {
                IsValid = true,
                Coefficients = beta,
                XtXInverse = xtxInv,
                RSquared = Math.Clamp(rSquared, 0, 1),
                AdjustedRSquared = adjR2,
                StandardError = see,
                FStatistic = fStat,
                FPValue = fp,
                CoefficientStdErrors = se,
                CoefficientTStats = tStat,
                CoefficientPValues = pVal,
                N = n,
                P = p
            };
        }

        /// <summary>
        /// Inversă prin Gauss-Jordan cu pivotare parţială; null dacă matricea e singulară.
        /// </summary>
        private static double[,]? InvertMatrix(double[,] a)
        {
            int n = a.GetLength(0);
            var m = new double[n, 2 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) m[i, j] = a[i, j];
                m[i, n + i] = 1.0;
            }

            for (int col = 0; col < n; col++)
            {
                // Pivot parţial: cel mai mare element în valoare absolută
                int pivot = col;
                double best = Math.Abs(m[col, col]);
                for (int r = col + 1; r < n; r++)
                {
                    double v = Math.Abs(m[r, col]);
                    if (v > best) { best = v; pivot = r; }
                }
                if (best < 1e-12) return null; // singulară / coliniaritate severă

                if (pivot != col)
                    for (int j = 0; j < 2 * n; j++)
                        (m[col, j], m[pivot, j]) = (m[pivot, j], m[col, j]);

                double diag = m[col, col];
                for (int j = 0; j < 2 * n; j++) m[col, j] /= diag;

                for (int r = 0; r < n; r++)
                {
                    if (r == col) continue;
                    double factor = m[r, col];
                    if (factor == 0) continue;
                    for (int j = 0; j < 2 * n; j++) m[r, j] -= factor * m[col, j];
                }
            }

            var inv = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    inv[i, j] = m[i, n + j];
            return inv;
        }

        /// <summary>
        /// P(F &gt; f) pentru distribuţia F(df1, df2): I_x(df2/2, df1/2), x = df2/(df2+df1·f).
        /// </summary>
        private static double FTailProbability(double f, int df1, int df2)
        {
            if (f <= 0 || df1 < 1 || df2 < 1) return 1.0;
            double x = df2 / (df2 + df1 * f);
            return Math.Clamp(RegularizedIncompleteBeta(x, df2 / 2.0, df1 / 2.0), 0.0, 1.0);
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
        /// Valoarea critică t bilaterală: t ≥ 0 astfel încât P(|T| &gt; t | df) = <paramref name="alpha"/>.
        /// Inversare prin bisecție — TwoTailedPValue este strict descrescătoare în t
        /// (P(0)=1, P(∞)=0), deci bisecția converge garantat.
        /// Verificare: df=8, α=0.05 → ≈2.306; df mare, α=0.05 → ≈1.96.
        /// </summary>
        private static double TwoTailedTCritical(double alpha, int df)
        {
            if (alpha <= 0.0) return double.PositiveInfinity;
            if (alpha >= 1.0) return 0.0;

            double lo = 0.0, hi = 1000.0;
            for (int i = 0; i < 100; i++)
            {
                double mid = 0.5 * (lo + hi);
                double p = TwoTailedPValue(mid, df);
                if (p > alpha) lo = mid; // încă prea mult în cozi → mărim t
                else hi = mid;           // cozi prea mici → micșorăm t
            }
            return 0.5 * (lo + hi);
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
