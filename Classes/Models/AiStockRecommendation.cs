using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Models
{
    public class AiStockRecommendation
    {
        [Key]
        public int RecommendationId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int SuggestedQuantity { get; set; }

        [Required]
        [StringLength(20)]
        public string PriorityLevel { get; set; } // "Low", "Medium", "High"

        [Required]
        [StringLength(500)]
        public string Reasoning { get; set; } // Ex: "Stocul va scădea sub limita de siguranță în 3 zile conform analizei sezoniere."

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Proprietate de navigare către produs
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public void AddRecommendation(AiStockRecommendation recommendation)
        {
            using (var db = new SmartStockContext())
            {
                // Adăugăm recomandarea nouă
                db.AiStockRecommendations.Add(recommendation);
                db.SaveChanges(); // Conexiunea se închide automat
            }
        }
        public List<AiStockRecommendation> GetUrgentRecommendations()
        {
            using (var db = new SmartStockContext())
            {
                return db.AiStockRecommendations
                    .AsNoTracking()
                    .Include(r => r.Product) // Include datele produsului pentru a vedea numele
                    .Where(r => r.PriorityLevel == "High")
                    .OrderByDescending(r => r.CreatedAt)
                    .ToList();
            }
        }
        public void RemoveObsoleteRecommendations(int daysOld = 7)
        {
            using (var db = new SmartStockContext())
            {
                var cutoffDate = DateTime.Now.AddDays(-daysOld);
                var oldItems = db.AiStockRecommendations.Where(r => r.CreatedAt < cutoffDate);

                db.AiStockRecommendations.RemoveRange(oldItems);
                db.SaveChanges();
            }
        }
    }
}
