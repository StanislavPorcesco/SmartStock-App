using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SmartStock.Classes.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        [Required]
        public int CurrentStock { get; set; }

        [Required]
        public int SafetyStock { get; set; }

        [Required]
        [StringLength(50)]
        public string UnitOfMeasure { get; set; }

        // Proprietăți de navigare pentru EF Core
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        // Proprietate calculată pentru UI
        [NotMapped]
        public bool IsUnderSafetyLimit => CurrentStock < SafetyStock;

        public List<Product> GetLowStockProducts()
        {
            using (var db = new SmartStockContext())
            {
                return db.Products
                    .AsNoTracking()
                    .Include(p => p.Category)
                    .Where(p => p.CurrentStock < p.SafetyStock)
                    .ToList();
            }
        }

        public void UpdateStockQuantity(int productId, int changeAmount)
        {
            using (var db = new SmartStockContext())
            {
                var product = db.Products.Find(productId);
                if (product != null)
                {
                    product.CurrentStock += changeAmount;
                    db.SaveChanges(); // Conexiunea se închide automat după salvare
                }
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var db = new SmartStockContext())
            {
                return db.Products
                    .AsNoTracking()
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .FirstOrDefault(p => p.ProductId == id);
            }
        }
    }
}
