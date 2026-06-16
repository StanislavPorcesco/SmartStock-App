using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartStock.Classes.Models
{
    public class SmartStockContext : DbContext
    {
        // Mapează fiecare tabel din baza de date către un DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }
        public DbSet<ExternalFactor> ExternalFactors { get; set; }
        public DbSet<EconometricModel> EconometricModels { get; set; }
        public DbSet<AiForecast> AiForecasts { get; set; }
        public DbSet<AiStockRecommendation> AiStockRecommendations { get; set; }
        public DbSet<User> Users { get; set; }

        // Configurarea conexiunii către fișierul SQLite local
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={SmartStock.Classes.Settings.PathsManager.DatabasePath}");
        }

        // Definirea relațiilor complexe și a constrângerilor (Fluent API)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relația Product -> Category
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relația Product -> Supplier
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);
            string adminSalt = "StaticSaltForAdmin123!";
            string adminHash = SecurityService.HashPassword("admin", adminSalt);
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Username = "admin",
                PasswordHash = adminHash,
                Salt = adminSalt,
                FullName = "System Administrator",
                Role = "Admin",
                Email = "admin@gmail.com",
                IsActive = true,
                IsLoggedIn = 0
            });
            // NOTE: the per-role demo accounts (manager/operator) are NOT seeded via HasData.
            // HasData needs fixed primary keys, which collide with users created at runtime
            // through the UI (SQLite hands them UserId 2, 3, ...). They are seeded idempotently
            // by username in DataSeeder.SeedDefaultAccounts, called after Database.Migrate().
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                FullName = "Default Customer",
                City = "Default City",
                Email = "default@gmail.com",
                Phone = "0000000000",
                RegistrationDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Hot Drinks", IsActive = true },
                new Category { CategoryId = 2, CategoryName = "Cold Drinks", IsActive = true },
                new Category { CategoryId = 3, CategoryName = "Pastries", IsActive = true });

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    SupplierId = 1,
                    SupplierName = "Coffee Supplier Inc.",
                    ContactPerson = "John Doe",
                    Email = "coffee.john@gmail.com",
                    Phone = "1234567890",
                    Address = "123 Coffee St, Caffeine City",
                    IsActive = true
                },
                new Supplier
                {
                    SupplierId = 2,
                    SupplierName = "Bakery Goods Ltd.",
                    ContactPerson = "Jane Roe",
                    Email = "bakery.jane@gmail.com",
                    Phone = "0987654321",
                    Address = "45 Pastry Ave, Doughville",
                    IsActive = true
                });

            // Café catalogue. Product IDs MUST match DataSeeder's driver constants.
            // Hot Drinks (cat 1) → negative temperature correlation;
            // Cold Drinks (cat 2) → positive temperature correlation;
            // Pastries (cat 3) → flat baseline + holiday spikes (anomaly demo).
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1,  ProductName = "Americano",     CategoryId = 1, SupplierId = 1, UnitPrice = 14, UnitOfMeasure = "cup", CurrentStock = 800, SafetyStock = 150, IsActive = true },
                new Product { ProductId = 2,  ProductName = "Cappuccino",    CategoryId = 1, SupplierId = 1, UnitPrice = 16, UnitOfMeasure = "cup", CurrentStock = 720, SafetyStock = 150, IsActive = true },
                new Product { ProductId = 3,  ProductName = "Hot Tea",       CategoryId = 1, SupplierId = 1, UnitPrice = 12, UnitOfMeasure = "cup", CurrentStock = 600, SafetyStock = 120, IsActive = true },
                new Product { ProductId = 4,  ProductName = "Hot Chocolate", CategoryId = 1, SupplierId = 1, UnitPrice = 18, UnitOfMeasure = "cup", CurrentStock = 300, SafetyStock = 90,  IsActive = true },
                new Product { ProductId = 5,  ProductName = "Cold Brew",     CategoryId = 2, SupplierId = 1, UnitPrice = 20, UnitOfMeasure = "cup", CurrentStock = 500, SafetyStock = 120, IsActive = true },
                new Product { ProductId = 6,  ProductName = "Iced Latte",    CategoryId = 2, SupplierId = 1, UnitPrice = 22, UnitOfMeasure = "cup", CurrentStock = 480, SafetyStock = 120, IsActive = true },
                new Product { ProductId = 7,  ProductName = "Lemonade",      CategoryId = 2, SupplierId = 1, UnitPrice = 15, UnitOfMeasure = "cup", CurrentStock = 450, SafetyStock = 110, IsActive = true },
                new Product { ProductId = 8,  ProductName = "Iced Tea",      CategoryId = 2, SupplierId = 1, UnitPrice = 14, UnitOfMeasure = "cup", CurrentStock = 100, SafetyStock = 110, IsActive = true },
                new Product { ProductId = 9,  ProductName = "Croissant",     CategoryId = 3, SupplierId = 2, UnitPrice = 8,  UnitOfMeasure = "piece", CurrentStock = 400, SafetyStock = 100, IsActive = true },
                new Product { ProductId = 10, ProductName = "Cheesecake",    CategoryId = 3, SupplierId = 2, UnitPrice = 12, UnitOfMeasure = "slice", CurrentStock = 250, SafetyStock = 80,  IsActive = true });

            // NOTE: ExternalFactors, AiForecasts, Sales, SaleDetails and Transactions are
            // NO LONGER seeded via HasData. The café dataset (tens of thousands of rows)
            // is seeded at runtime by DataSeeder.SeedRuntimeData(context) in Program.cs,
            // right after Database.Migrate(), gated on an empty Sales table.
            base.OnModelCreating(modelBuilder);
        }
    }
}
