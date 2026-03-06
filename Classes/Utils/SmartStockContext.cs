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
            base.OnModelCreating(modelBuilder);
        }
    }
}
