using SmartStock.Classes.Models;

namespace SmartStock.Classes.Utils
{
    /// <summary>
    /// Runtime data seeder for a representative café dataset (1 March – 8 July 2026).
    ///
    /// WHY RUNTIME (not EF HasData): the dataset is tens of thousands of sales rows.
    /// HasData would bake every row into a migration (multi-MB file, slow apply, fragile
    /// hand-managed PK ranges). Here PKs are DB-assigned and seeding runs once when the
    /// Sales table is empty (Program.cs, right after Database.Migrate()).
    ///
    /// STATISTICAL DESIGN (see docs/ANALYSIS_MODULE_REVIEW.md):
    /// The date-aligned correlation needs DENSE, daily, varying factors. So:
    ///   • Weather / "Daily Max Temperature"  → continuous daily  → CORRELATION + trend
    ///       hot drinks fall as temp rises (r ≈ −0.9), cold drinks rise (r ≈ +0.9)
    ///   • Weather / "Daily Precipitation"    → continuous daily  → CORRELATION
    ///       comfort drinks (Hot Chocolate) rise on rainy/gloomy days (dominant +r)
    ///   • Event   / "Public Holiday"         → sparse (≈8 days)  → ANOMALY spikes
    ///       a sparse constant factor is mathematically r ≈ 0, so holidays are modelled
    ///       as sales SPIKES detected by Anomaly Detection, not as a correlation.
    /// Each product has ONE dominant driver so its correlation comes out clean; the
    /// pastries are a flat baseline whose holiday spikes are the anomaly-detection demo.
    ///
    /// Factor vocabulary (FactorType/Description) mirrors ExternalFactorsFetchService so
    /// seeded and live-fetched factors are interchangeable in the analysis UI.
    /// </summary>
    public static class DataSeeder
    {
        private static readonly DateTime Start = new(2026, 3, 1);
        private static readonly DateTime End   = new(2026, 7, 8);
        private static readonly int Days = (End - Start).Days + 1; // 130 days inclusive

        // Romanian public holidays / observances in range — drive sales SPIKES (anomalies)
        private static readonly HashSet<DateTime> HolidayDates = new()
        {
            new(2026, 3, 8),   // International Women's Day (observance)
            new(2026, 4, 10),  // Orthodox Good Friday
            new(2026, 4, 11),  // Holy Saturday
            new(2026, 4, 12),  // Orthodox Easter Sunday
            new(2026, 4, 13),  // Easter Monday
            new(2026, 5, 1),   // Labour Day
            new(2026, 5, 31),  // Orthodox Pentecost
            new(2026, 6, 1),   // Children's Day / Pentecost Monday
        };

        // Product IDs — MUST match the HasData products in SmartStockContext.OnModelCreating
        private const int Americano = 1, Cappuccino = 2, HotTea = 3, HotChocolate = 4,
                          ColdBrew = 5, IcedLatte = 6, Lemonade = 7, IcedTea = 8,
                          Croissant = 9, Cheesecake = 10;

        private static readonly (int Id, decimal Price)[] ProductSpecs =
        {
            (Americano, 14m), (Cappuccino, 16m), (HotTea, 12m), (HotChocolate, 18m),
            (ColdBrew, 20m),  (IcedLatte, 22m),  (Lemonade, 15m), (IcedTea, 14m),
            (Croissant, 8m),  (Cheesecake, 12m),
        };

        private static bool IsDrink(int productId) => productId <= IcedTea; // 1..8 drinks, 9-10 pastries

        // ─── Default per-role demo accounts ──────────────────────────────────────────
        // Idempotent: keyed on Username (NOT a fixed PK), so it never collides with users
        // created at runtime through the UI, and re-running inserts nothing. Convention:
        // username == password. Admin (UserId 1) is already seeded via HasData/migrations.
        private static readonly (string Username, string Role, string FullName)[] DefaultAccounts =
        {
            ("manager",  "Manager",  "Default Manager"),
            ("operator", "Operator", "Default Operator"),
        };

        public static void SeedDefaultAccounts(SmartStockContext context)
        {
            bool added = false;
            foreach (var (username, role, fullName) in DefaultAccounts)
            {
                if (context.Users.Any(u => u.Username == username)) continue;

                string salt = SecurityService.GenerateSalt();
                context.Users.Add(new User
                {
                    Username     = username,
                    PasswordHash = SecurityService.HashPassword(username, salt), // password == username
                    Salt         = salt,
                    FullName     = fullName,
                    Role         = role,
                    Email        = $"{username}@gmail.com",
                    IsActive     = true,
                    IsLoggedIn   = 0,
                });
                added = true;
            }

            if (added) context.SaveChanges();
        }

        // ─── Public entry point ──────────────────────────────────────────────────────
        public static void SeedRuntimeData(SmartStockContext context)
        {
            // Idempotent: only seed an empty database.
            if (context.Sales.Any()) return;

            var env       = BuildEnvironment();
            var factors   = GenerateFactors(env);
            var forecasts = GenerateForecasts(env);
            var (sales, transactions) = GenerateTransactionalData(env);

            var previous = context.ChangeTracker.AutoDetectChangesEnabled;
            context.ChangeTracker.AutoDetectChangesEnabled = false; // bulk-insert perf
            try
            {
                context.ExternalFactors.AddRange(factors);
                context.AiForecasts.AddRange(forecasts);
                context.Sales.AddRange(sales);            // nested SaleDetails inserted via navigation
                context.Transactions.AddRange(transactions);
                context.SaveChanges();
            }
            finally
            {
                context.ChangeTracker.AutoDetectChangesEnabled = previous;
            }
        }

        // ─── Deterministic daily environment ─────────────────────────────────────────
        // Built with a fixed seed so the factor values stored in the DB are IDENTICAL to
        // the values that drive sales — this is what makes the correlation strong and the
        // forecast trend coherent. Sales add their own (independent) noise on top.
        private readonly record struct DailyEnv(
            DateTime Date, double Temp, double Precip, bool IsHoliday, bool IsWeekend);

        private static DailyEnv[] BuildEnvironment()
        {
            var env = new DailyEnv[Days];
            var rng = new Random(2026); // fixed seed → deterministic across every call

            for (int i = 0; i < Days; i++)
            {
                var date = Start.AddDays(i);

                // Seasonal warming 8 °C (March) → 30 °C (July) with a biweekly wave.
                double trend = 8.0 + 22.0 * i / (Days - 1);
                double wave  = 3.0 * Math.Sin(2 * Math.PI * i / 14.0);
                double temp  = Math.Round(trend + wave, 1);

                // ~35% of days are rainy; amount 1–22 mm. Dry days are 0 (kept in the
                // series so precipitation is a dense daily correlate, not a sparse one).
                bool rainy    = rng.NextDouble() < 0.35;
                double precip = rainy ? Math.Round(1 + rng.NextDouble() * 21, 1) : 0.0;

                bool isWeekend = date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

                env[i] = new DailyEnv(date, temp, precip, HolidayDates.Contains(date), isWeekend);
            }
            return env;
        }

        // ─── External Factors ────────────────────────────────────────────────────────
        private static List<ExternalFactor> GenerateFactors(DailyEnv[] env)
        {
            var factors = new List<ExternalFactor>(env.Length * 3);

            foreach (var d in env)
            {
                // Dense daily continuous → correlation + forecast trend driver.
                factors.Add(Factor("Weather", "Daily Max Temperature", (decimal)d.Temp, "Absolute", d.Date));

                // Dense daily (0 on dry days) → correlation driver for comfort drinks.
                factors.Add(Factor("Weather", "Daily Precipitation", (decimal)d.Precip, "Absolute", d.Date));

                // Sparse → drives sales SPIKES (anomaly detection), NOT correlation.
                if (d.IsHoliday)
                    factors.Add(Factor("Event", "Public Holiday", 1.5m, "Multiplier", d.Date));
            }

            return factors;
        }

        private static ExternalFactor Factor(
            string type, string description, decimal value, string valueType, DateTime date) => new()
        {
            FactorType  = type,
            Description = description,
            Region      = "Bucharest",
            ImpactValue = value,
            ValueType   = valueType,
            Date        = date,
            IsActive    = true,
        };

        // ─── Transactional data (Sales + nested SaleDetails + Transactions) ──────────
        private static (List<Sale> Sales, List<Transaction> Transactions) GenerateTransactionalData(DailyEnv[] env)
        {
            var sales        = new List<Sale>();
            var transactions = new List<Transaction>();

            int seed = 100;
            foreach (var (productId, unitPrice) in ProductSpecs)
            {
                var rand = new Random(seed++); // per-product stream → reproducible

                foreach (var day in env)
                {
                    int count = DailyCount(productId, rand, day);

                    for (int j = 0; j < count; j++)
                    {
                        int qty = rand.Next(1, 4); // 1–3 units per sale
                        var timestamp = day.Date.AddHours(rand.Next(7, 20)).AddMinutes(rand.Next(0, 60));

                        sales.Add(new Sale
                        {
                            CustomerId    = 1,
                            UserId        = 1,
                            TotalAmount   = qty * unitPrice,
                            SaleDate      = timestamp,
                            PaymentMethod = rand.Next(0, 2) == 0 ? "Card" : "Cash",
                            PaymentStatus = "Paid",
                            IsActive      = true,
                            SaleDetails   = new List<SaleDetails>
                            {
                                new() { ProductId = productId, Quantity = qty, UnitPrice = unitPrice }
                            }
                        });

                        transactions.Add(new Transaction
                        {
                            ProductId = productId,
                            EntityId  = 1,
                            UserId    = 1,
                            Quantity  = qty,
                            Type      = "Stock Out",
                            Date      = timestamp,
                        });
                    }
                }
            }

            return (sales, transactions);
        }

        // Deterministic expected daily transaction count per product (the "signal").
        // Sales add weekend/holiday lift + noise; forecasts read it directly.
        private static double BaseCount(int productId, DailyEnv e) => productId switch
        {
            // Hot drinks — NEGATIVE temperature correlation (fall as it warms)
            Americano    => 48 - 1.00 * e.Temp,
            Cappuccino   => 44 - 0.95 * e.Temp,
            HotTea       => 38 - 0.85 * e.Temp,

            // Hot Chocolate — DOMINANT positive precipitation correlation (gloomy/rainy days)
            HotChocolate => 14 + 1.30 * e.Precip - 0.25 * e.Temp,

            // Cold drinks — POSITIVE temperature correlation (rise as it warms)
            ColdBrew     => 8  + 1.15 * e.Temp,
            IcedLatte    => 6  + 1.10 * e.Temp,
            Lemonade     => 5  + 1.20 * e.Temp,
            IcedTea      => 7  + 1.00 * e.Temp,

            // Pastries — FLAT baseline + large holiday spike → anomaly-detection demo
            Croissant    => 32 + (e.IsHoliday ? 45 : 0),
            Cheesecake   => 24 + (e.IsHoliday ? 35 : 0),

            _ => 10,
        };

        private static int DailyCount(int productId, Random r, DailyEnv e)
        {
            double v = BaseCount(productId, e);

            if (IsDrink(productId))
            {
                if (e.IsWeekend) v += r.Next(5, 12);   // weekend footfall
                if (e.IsHoliday) v += r.Next(4, 9);    // mild holiday lift for drinks
            }
            else if (e.IsWeekend && !e.IsHoliday)
            {
                v += r.Next(4, 9);                      // pastries: mild weekend lift (holiday spike is in BaseCount)
            }

            v += r.Next(-3, 4);                          // daily noise
            return Math.Max(0, (int)Math.Round(v));
        }

        // ─── AI Forecasts (populate the table; ~daily expected units per product) ────
        private static List<AiForecast> GenerateForecasts(DailyEnv[] env)
        {
            var forecasts = new List<AiForecast>(ProductSpecs.Length * env.Length);
            var rand = new Random(321);

            foreach (var (productId, _) in ProductSpecs)
            {
                foreach (var day in env)
                {
                    // ~2 units per sale on average → expected daily demand in units.
                    double predicted = Math.Max(1, BaseCount(productId, day) * 2.0);

                    decimal confidence = IsDrink(productId)
                        ? Math.Round(0.80m + (decimal)(rand.NextDouble() * 0.12), 4)  // clear driver
                        : Math.Round(0.62m + (decimal)(rand.NextDouble() * 0.13), 4); // noisier

                    forecasts.Add(new AiForecast
                    {
                        ProductId       = productId,
                        ForecastDate    = day.Date,
                        PredictedDemand = Math.Round((decimal)predicted, 2),
                        ConfidenceScore = Math.Min(0.99m, confidence),
                        ModelVersion    = "seed-v2",
                    });
                }
            }

            return forecasts;
        }
    }
}
