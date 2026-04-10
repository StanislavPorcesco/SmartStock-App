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
            // Construim calea completă: Debug/net8.0-windows/Resources/SmartStock.db
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            string dbPath = Path.Combine(folderPath, "SmartStock.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
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
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Coffee",
                IsActive = true
            });
            modelBuilder.Entity<Supplier>().HasData(new Supplier
            {
                SupplierId = 1,
                SupplierName = "Coffee Supplier Inc.",
                ContactPerson = "John Doe",
                Email = "coffee.john@gmail.com",
                Phone = "1234567890",
                Address = "123 Coffee St, Caffeine City",
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Americano Coffee",
                    CategoryId = 1,
                    SupplierId = 1,
                    UnitPrice = 20,
                    UnitOfMeasure = "cup",
                    CurrentStock = 500,
                    SafetyStock = 100,
                    IsActive = true
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Espresso",
                    CategoryId = 1,
                    SupplierId = 1,
                    UnitPrice = 18,
                    UnitOfMeasure = "cup",
                    CurrentStock = 350,
                    SafetyStock = 70,
                    IsActive = true
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Cold Brew",
                    CategoryId = 1,
                    SupplierId = 1,
                    UnitPrice = 25,
                    UnitOfMeasure = "cup",
                    CurrentStock = 180,
                    SafetyStock = 40,
                    IsActive = true
                });

            var factorData = DataSeeder.GenerateFactors();
            var forecastData = DataSeeder.GenerateForecasts();
            var (saleData, detailData, transactionData) = DataSeeder.GenerateTransactionalData();

            modelBuilder.Entity<ExternalFactor>().HasData(factorData.ToArray());
            modelBuilder.Entity<AiForecast>().HasData(forecastData.ToArray());
            modelBuilder.Entity<Sale>().HasData(saleData.ToArray());
            modelBuilder.Entity<SaleDetails>().HasData(detailData.ToArray());
            modelBuilder.Entity<Transaction>().HasData(transactionData.ToArray());
            base.OnModelCreating(modelBuilder);
        }
    }
}
