using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.Classes.Models
{
    public class SaleDetails
    {
        [Key]
        public int DetailId { get; set; }

        [Required]
        public int SaleId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPriceAtSale { get; set; }

        // Proprietăți de navigare pentru EF Core
        [ForeignKey("SaleId")]
        public virtual Sale Sale { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        // Proprietate calculată pentru UI (Subtotal per linie)
        [NotMapped]
        public decimal LineTotal => Quantity * UnitPriceAtSale;
        public List<SaleDetails> GetItemsBySaleId(int saleId)
        {
            using (var db = new SmartStockContext())
            {
                return db.SaleDetails
                    .AsNoTracking()
                    .Include(sd => sd.Product) // Aduce denumirea produsului
                    .Where(sd => sd.SaleId == saleId)
                    .ToList();
            }
        }
        public dynamic GetTopSellingProducts(int limit = 5)
        {
            using (var db = new SmartStockContext())
            {
                return db.SaleDetails
                    .AsNoTracking()
                    .GroupBy(sd => sd.Product.ProductId)
                    .Select(group => new
                    {
                        ProductId = group.Key,
                        TotalQuantity = group.Sum(sd => sd.Quantity),
                        TotalRevenue = group.Sum(sd => sd.Quantity * sd.UnitPriceAtSale)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .Take(limit)
                    .ToList();
            }
        }
        public List<Product> GetDeadStock(DateTime sinceDate)
        {
            using (var db = new SmartStockContext())
            {
                var soldProductIds = db.SaleDetails
                    .Where(sd => sd.Sale.SaleDate >= sinceDate)
                    .Select(sd => sd.ProductId)
                    .Distinct()
                    .ToList();

                return db.Products
                    .AsNoTracking()
                    .Where(p => !soldProductIds.Contains(p.ProductId))
                    .ToList();
            }
        }
    }
}
