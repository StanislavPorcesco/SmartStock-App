using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.Classes.Models
{
    public class AiForecast
    {
        [Key]
        public int ForecastId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public DateTime ForecastDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PredictedDemand { get; set; } // Cantitatea estimată a fi vândută

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ConfidenceScore { get; set; } // Probabilitatea de acuratețe (0-1)

        [Required]
        [StringLength(50)]
        public string ModelVersion { get; set; } // Identificator pentru versiunea algoritmului

        // Proprietate de navigare către produs
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public void AddForecast(AiForecast forecast)
        {
            using (var db = new SmartStockContext())
            {
                db.AiForecasts.Add(forecast);
                db.SaveChanges(); // Conexiunea se închide automat după inserare
            }
        }
        public AiForecast GetLatestForecast(int productId)
        {
            using (var db = new SmartStockContext())
            {
                return db.AiForecasts
                    .AsNoTracking()
                    .Where(f => f.ProductId == productId)
                    .OrderByDescending(f => f.ForecastDate)
                    .FirstOrDefault();
            }
        }
        public List<AiForecast> GetHighConfidenceForecasts(decimal minScore)
        {
            using (var db = new SmartStockContext())
            {
                return db.AiForecasts
                    .AsNoTracking()
                    .Include(f => f.Product)
                    .Where(f => f.ConfidenceScore >= minScore)
                    .OrderByDescending(f => f.ConfidenceScore)
                    .ToList();
            }
        }
    }
}
