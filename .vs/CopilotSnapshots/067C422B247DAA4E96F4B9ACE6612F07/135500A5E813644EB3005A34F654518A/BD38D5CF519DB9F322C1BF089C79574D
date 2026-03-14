using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.Classes.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } // Cash, Card, Transfer

        [Required]
        [StringLength(50)]
        public string PaymentStatus { get; set; } // Paid, Pending, Cancelled
        [Required]
        public bool IsActive{ get; set; }

        // Proprietăți de navigare
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        // Relație One-to-Many către detaliile vânzării
        public virtual ICollection<SaleDetails> SaleDetails { get; set; } = new List<SaleDetails>();
        public void ProcessSale(Sale sale, List<SaleDetails> details)
        {
            using (var db = new SmartStockContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Adăugăm vânzarea (antetul)
                        db.Sales.Add(sale);
                        db.SaveChanges();

                        // 2. Adăugăm detaliile și actualizăm stocul
                        foreach (var item in details)
                        {
                            item.SaleId = sale.SaleId;
                            db.SaleDetails.Add(item);

                            var product = db.Products.Find(item.ProductId);
                            if (product != null)
                            {
                                product.CurrentStock -= item.Quantity; // Scădere automată din stoc
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit(); // Salvare definitivă
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); // Anulare în caz de eroare pentru a nu corupe stocul
                        throw;
                    }
                }
            }
        }
        public List<Sale> FilterSales(int? customerId, string status, DateTime? fromDate, DateTime? toDate)
        {
            using (var db = new SmartStockContext())
            {
                var query = db.Sales
                    .AsNoTracking()
                    .Include(s => s.Customer)
                    .Include(s => s.User)
                    .AsQueryable();

                if (customerId.HasValue) query = query.Where(s => s.CustomerId == customerId);
                if (!string.IsNullOrEmpty(status)) query = query.Where(s => s.PaymentStatus == status);
                if (fromDate.HasValue) query = query.Where(s => s.SaleDate >= fromDate);
                if (toDate.HasValue) query = query.Where(s => s.SaleDate <= toDate);

                return query.OrderByDescending(s => s.SaleDate).ToList();
            }
        }
        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            using (var db = new SmartStockContext())
            {
                return db.Sales
                    .AsNoTracking()
                    .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate && s.PaymentStatus == "Paid")
                    .Sum(s => s.TotalAmount);
            }
        }
        public List<SaleDetails> GetRelatedDetails()
        {
            using (var db = new SmartStockContext())
            {
                return db.SaleDetails.AsNoTracking()
                          .Where(d => d.SaleId == this.SaleId)
                          .ToList();
            }
        }
    }
}
