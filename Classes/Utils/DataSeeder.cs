using SmartStock.Classes.Models;

namespace SmartStock.Classes.Utils
{
    public static class DataSeeder
    {
        // ─── Shared date sets ──────────────────────────────────────────────────────
        private static readonly HashSet<DateTime> HolidayDates = new()
        {
            new DateTime(2026, 3, 8),  // International Women's Day
            new DateTime(2026, 4, 10), // Good Friday (Orthodox)
            new DateTime(2026, 4, 11), // Holy Saturday
            new DateTime(2026, 4, 12), // Orthodox Easter Sunday
            new DateTime(2026, 4, 13)  // Easter Monday
        };

        private static readonly HashSet<DateTime> PromotionDates = BuildPromotionDates();

        private static HashSet<DateTime> BuildPromotionDates()
        {
            var set = new HashSet<DateTime>();
            // Four promotion rounds, 3 days each, spaced ~2 weeks apart
            foreach (var promoStart in new[]
            {
                new DateTime(2026, 3, 5),
                new DateTime(2026, 3, 19),
                new DateTime(2026, 4, 2),
                new DateTime(2026, 4, 16)
            })
            {
                for (var d = 0; d < 3; d++)
                    set.Add(promoStart.AddDays(d));
            }
            return set;
        }

        // Returns the same daily temperature used for the Weather factor so that
        // products derived from it are numerically aligned with the factor series.
        // i is the day index (0-based) in the transaction loop (March 1 = 0).
        private static int DailyTemperature(int i)
        {
            // Factor loop starts at i=1 (March 2), transaction loop at i=0 (March 1).
            // Shift by 1 so Cold Brew / Americano correlate with the factor from the
            // previous day — which is the natural 1-day lag in the factor series.
            int fi = i + 1; // align to the factor index
            return fi < 31 ? 5 + (fi % 10) : 15 + (fi % 10);
        }

        // ─── External Factors ──────────────────────────────────────────────────────
        public static List<ExternalFactor> GenerateFactors()
        {
            var factors = new List<ExternalFactor>();
            var start = new DateTime(2026, 3, 1);

            for (int i = 1; i < 61; i++) // March 2 – April 30 (60 days)
            {
                var date = start.AddDays(i);

                // Weather — temperature rises from March (5-14 °C) to April (15-24 °C),
                // oscillating with a 10-day period to create a distinct wave pattern.
                int temp = i < 31 ? 5 + (i % 10) : 15 + (i % 10);
                factors.Add(new ExternalFactor
                {
                    FactorId = i,
                    FactorType = "Weather",
                    Region = "Bucharest",
                    Description = "Daily Temperature",
                    ImpactValue = temp,
                    ValueType = "Absolute",
                    Date = date,
                    IsActive = true
                });

                // Holiday — binary: 1 on public holidays, 0 otherwise
                factors.Add(new ExternalFactor
                {
                    FactorId = 60 + i,
                    FactorType = "Holiday",
                    Region = "Bucharest",
                    Description = HolidayDates.Contains(date) ? "Public Holiday" : "Regular Day",
                    ImpactValue = HolidayDates.Contains(date) ? 1m : 0m,
                    ValueType = "Binary",
                    Date = date,
                    IsActive = true
                });

                // Promotion — binary: 1 during active promotion windows, 0 otherwise
                factors.Add(new ExternalFactor
                {
                    FactorId = 120 + i,
                    FactorType = "Promotion",
                    Region = "Bucharest",
                    Description = PromotionDates.Contains(date) ? "Active Promotion" : "No Promotion",
                    ImpactValue = PromotionDates.Contains(date) ? 1m : 0m,
                    ValueType = "Binary",
                    Date = date,
                    IsActive = true
                });
            }

            return factors;
        }

        // ─── AI Forecasts ──────────────────────────────────────────────────────────
        public static List<AiForecast> GenerateForecasts()
        {
            var forecasts = new List<AiForecast>();
            var rand = new Random(123);
            var start = new DateTime(2026, 3, 1);
            int forecastId = 1;

            for (int productId = 1; productId <= 3; productId++)
            {
                for (int i = 0; i < 90; i++)
                {
                    var date = start.AddDays(i);
                    int temp = DailyTemperature(i);

                    decimal predicted = productId switch
                    {
                        // Americano: inversely tied to temperature
                        1 => Math.Round(Math.Max(1m, 42m - (temp * 0.9m) + (decimal)(rand.NextDouble() * 8 - 4)), 2),
                        // Espresso: higher on promotion days
                        2 => Math.Round(PromotionDates.Contains(date) ? 55m + (decimal)(rand.NextDouble() * 10 - 5) : 16m + (decimal)(rand.NextDouble() * 6 - 3), 2),
                        // Cold Brew: directly tied to temperature
                        _ => Math.Round(Math.Max(1m, temp * 1.6m + (decimal)(rand.NextDouble() * 6 - 3)), 2)
                    };

                    decimal confidence = productId switch
                    {
                        1 => Math.Round(0.72m + (decimal)(rand.NextDouble() * 0.22), 4),
                        2 => Math.Round(0.65m + (decimal)(rand.NextDouble() * 0.25), 4),
                        _ => Math.Round(0.60m + (decimal)(rand.NextDouble() * 0.30), 4)
                    };

                    forecasts.Add(new AiForecast
                    {
                        ForecastId = forecastId++,
                        ProductId = productId,
                        ForecastDate = date,
                        PredictedDemand = predicted,
                        ConfidenceScore = Math.Min(0.99m, confidence),
                        ModelVersion = "v1.0"
                    });
                }
            }

            return forecasts;
        }

        // ─── Transactional Data ────────────────────────────────────────────────────
        // Each product's daily sales volume is derived directly from the factor it
        // should correlate with, so EconometricEngine.CalculateCorrelation (Pearson r)
        // produces a strong coefficient when that factor is selected in the UI.
        public static (List<Sale> Sales, List<SaleDetails> Details, List<Transaction> Transactions) GenerateTransactionalData()
        {
            var sales = new List<Sale>();
            var details = new List<SaleDetails>();
            var transactions = new List<Transaction>();

            var start = new DateTime(2026, 3, 1);

            // ── Product 1: Americano Coffee ──────────────────────────────────────
            // Target: strong NEGATIVE correlation with Weather.
            // Formula: txCount = 42 - temp * 0.9 + weekend/holiday bonus + noise
            // As temperature rises (5→24), base count falls (38→20), mirroring the
            // factor curve in reverse so Pearson r approaches -1 for Weather.
            GenerateProductTransactions(
                productId: 1, unitPrice: 20m,
                saleIdStart: 1, detailIdStart: 1, transIdStart: 1, seed: 42,
                start,
                (rand, i, date) =>
                {
                    int temp = DailyTemperature(i);
                    int baseCount = Math.Max(2, 42 - (int)(temp * 0.9) + rand.Next(-3, 4));
                    bool isWeekend = date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
                    return baseCount
                        + (isWeekend ? rand.Next(8, 15) : 0)
                        + (HolidayDates.Contains(date) ? rand.Next(5, 10) : 0);
                },
                sales, details, transactions);

            // ── Product 2: Espresso ──────────────────────────────────────────────
            // Target: strong POSITIVE correlation with Promotion.
            // Formula: txCount = 8 (base) + 18-24 promo spike + small weekend noise
            // The spike is large enough relative to weekend noise that the binary
            // Promotion series aligns tightly with the sales series (Pearson r > 0.85).
            GenerateProductTransactions(
                productId: 2, unitPrice: 18m,
                saleIdStart: 5000, detailIdStart: 5000, transIdStart: 5000, seed: 99,
                start,
                (rand, i, date) =>
                {
                    bool isPromo = PromotionDates.Contains(date);
                    bool isWeekend = date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
                    return 8
                        + (isPromo ? rand.Next(18, 24) : 0)   // dominant promo signal
                        + (isWeekend ? rand.Next(3, 6) : 0)   // minor weekend noise
                        + rand.Next(-1, 2);
                },
                sales, details, transactions);

            // ── Product 3: Cold Brew ─────────────────────────────────────────────
            // Target: strong POSITIVE correlation with Weather.
            // Formula: txCount = temp * 1.6 + weekend bonus + noise
            // Daily count is directly proportional to temperature (same oscillation
            // pattern as the Weather factor), so Pearson r approaches +1 for Weather.
            GenerateProductTransactions(
                productId: 3, unitPrice: 25m,
                saleIdStart: 10000, detailIdStart: 10000, transIdStart: 10000, seed: 77,
                start,
                (rand, i, date) =>
                {
                    int temp = DailyTemperature(i);
                    int baseCount = Math.Max(1, (int)(temp * 1.6) + rand.Next(-3, 4));
                    bool isWeekend = date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
                    return baseCount + (isWeekend ? rand.Next(5, 10) : 0);
                },
                sales, details, transactions);

            return (sales, details, transactions);
        }

        private static void GenerateProductTransactions(
            int productId,
            decimal unitPrice,
            int saleIdStart,
            int detailIdStart,
            int transIdStart,
            int seed,
            DateTime start,
            Func<Random, int, DateTime, int> dailyVolume,
            List<Sale> sales,
            List<SaleDetails> details,
            List<Transaction> transactions)
        {
            var rand = new Random(seed);
            int saleId = saleIdStart;
            int detailId = detailIdStart;
            int transId = transIdStart;

            for (int i = 0; i < 61; i++)
            {
                var date = start.AddDays(i);
                int txCount = Math.Max(0, dailyVolume(rand, i, date));

                for (int j = 0; j < txCount; j++)
                {
                    int qty = rand.Next(1, 4);
                    var saleDate = date.AddHours(rand.Next(7, 20)).AddMinutes(rand.Next(0, 60));

                    sales.Add(new Sale
                    {
                        SaleId = saleId,
                        CustomerId = 1,
                        UserId = 1,
                        TotalAmount = qty * unitPrice,
                        SaleDate = saleDate,
                        PaymentMethod = rand.Next(0, 2) == 0 ? "Card" : "Cash",
                        PaymentStatus = "Paid",
                        IsActive = true
                    });

                    details.Add(new SaleDetails
                    {
                        DetailId = detailId,
                        SaleId = saleId,
                        ProductId = productId,
                        Quantity = qty,
                        UnitPrice = unitPrice
                    });

                    transactions.Add(new Transaction
                    {
                        TransactionId = transId,
                        ProductId = productId,
                        EntityId = 1,
                        UserId = 1,
                        Quantity = qty,
                        Type = "Stock Out",
                        Date = saleDate
                    });

                    saleId++;
                    detailId++;
                    transId++;
                }
            }
        }
    }
}
