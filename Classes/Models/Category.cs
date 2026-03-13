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
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public static List<Category> GetAllCategories()
        {
            using (var db = new SmartStockContext())
            {
                return db.Categories
                    .AsNoTracking()
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
                db.SaveChanges();
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
        public List<Product> GetRelatedProducts()
        {
            using (var db = new SmartStockContext())
            {
                return db.Products.AsNoTracking()
                          .Where(p => p.CategoryId == this.CategoryId)
                          .ToList();
            }
        }
    }
}
