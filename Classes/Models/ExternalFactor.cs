using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.Classes.Models
{
    public class ExternalFactor
    {
        [Key]
        public int FactorId { get; set; }

        [Required]
        [StringLength(50)]
        public string FactorType { get; set; } // Ex: Economic, Social, Weather

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ImpactValue { get; set; } // Valoarea numerică a factorului pentru regresie

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public List<ExternalFactor> GetFactorsByPeriod(DateTime start, DateTime end, string region = null)
        {
            using (var db = new SmartStockContext())
            {
                var query = db.ExternalFactors
                    .AsNoTracking()
                    .Where(f => f.Date >= start && f.Date <= end);

                if (!string.IsNullOrEmpty(region))
                    query = query.Where(f => f.Region == region);

                return query.OrderBy(f => f.Date).ToList();
            }
        }
        public void AddExternalFactor(ExternalFactor factor)
        {
            using (var db = new SmartStockContext())
            {
                db.ExternalFactors.Add(factor);
                db.SaveChanges(); // Conexiunea se închide automat
            }
        }
        public dynamic GetImpactSummaryByRegion(string region)
        {
            using (var db = new SmartStockContext())
            {
                return db.ExternalFactors
                    .AsNoTracking()
                    .Where(f => f.Region == region)
                    .GroupBy(f => f.FactorType)
                    .Select(g => new
                    {
                        Type = g.Key,
                        AvgImpact = g.Average(f => f.ImpactValue),
                        MaxImpact = g.Max(f => f.ImpactValue)
                    })
                    .ToList();
            }
        }
    }
}
