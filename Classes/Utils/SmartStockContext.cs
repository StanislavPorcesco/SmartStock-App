using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
            // Se folosește calea relativă către fișierul bazei de date
            optionsBuilder.UseSqlite("Data Source=SmartStock.db");
        }

        // Definirea relațiilor complexe și a constrângerilor (Fluent API)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Exemplu: Relația One-to-Many între Categorie și Produse
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);

            // Exemplu: Relația One-to-Many între Furnizor și Produse
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany()
                .HasForeignKey(p => p.SupplierId);

            // Constrângere de unicitate pentru Username
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Seeding: Crearea unui cont de Admin implicit la prima pornire
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Username = "admin",
                FullName = "System Administrator",
                Role = "Admin",
                IsActive = 1,
                // Notă: Aici ar trebui să pui un hash real generat
                PasswordHash = "InitialAdminHash",
                Salt = "InitialSalt"
            });
        }
    }
}
