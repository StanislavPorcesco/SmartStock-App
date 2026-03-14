using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SmartStock.Classes.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [StringLength(150)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        public bool IsActive { get; set; }

        // Relație One-to-Many: Un furnizor oferă mai multe produse
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public List<Supplier> GetAllSuppliers()
        {
            using (var db = new SmartStockContext())
            {
                return db.Suppliers
                    .AsNoTracking() // Optimizează memoria pentru liste lungi
                    .OrderBy(s => s.SupplierName)
                    .ToList();
            }
        }
        public void AddSupplier(Supplier newSupplier)
        {
            using (var db = new SmartStockContext())
            {
                db.Suppliers.Add(newSupplier);
                db.SaveChanges(); // Conexiunea se eliberează imediat
            }
        }
        public List<Supplier> SearchSuppliers(string searchTerm)
        {
            using (var db = new SmartStockContext())
            {
                return db.Suppliers
                    .AsNoTracking()
                    .Where(s => s.SupplierName.Contains(searchTerm) || s.ContactPerson.Contains(searchTerm))
                    .ToList();
            }
        }
        public List<Product> GetRelatedProducts()
        {
            using (var db = new SmartStockContext())
            {
                return db.Products.AsNoTracking()
                          .Where(p => p.SupplierId == this.SupplierId)
                          .ToList();
            }
        }
    }
}
