using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SmartStock.Classes.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required]
        public bool IsActive { get; set; }

        // Relație One-to-Many: O categorie are mai multe produse
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        public List<Category> GetAllCategories()
        {
            using (var db = new SmartStockContext())
            {
                return db.Categories
                    .AsNoTracking() // Performanță ridicată pentru citire
                    .OrderBy(c => c.CategoryName)
                    .ToList();
            }
        }

        public void AddCategory(string name)
        {
            using (var db = new SmartStockContext())
            {
                var category = new Category { CategoryName = name };
                db.Categories.Add(category);
                db.SaveChanges(); // Conexiunea se închide automat aici
            }
        }

        public dynamic GetCategoryStats()
        {
            using (var db = new SmartStockContext())
            {
                return db.Categories
                    .AsNoTracking()
                    .Select(c => new
                    {
                        c.CategoryName,
                        ProductCount = c.Products.Count
                    })
                    .ToList();
            }
        }
    }
}
