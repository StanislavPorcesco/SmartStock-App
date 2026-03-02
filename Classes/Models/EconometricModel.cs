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
    public class EconometricModel
    {
        [Key]
        public int ModelId { get; set; }

        [Required]
        [StringLength(100)]
        public string ModelName { get; set; } // Ex: "Linear Regression", "ARIMA"

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CoefficientValue { get; set; } // Ponderea factorului în ecuație

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PValue { get; set; } // Semnificația (trebuie să fie < 0.05)

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal RSquared { get; set; } // Precizia modelului (0 la 1)

        [Required]
        public DateTime LastTrainedDate { get; set; } = DateTime.Now;
        public bool IsModelStatisticallySignificant(int modelId)
        {
            using (var db = new SmartStockContext())
            {
                var model = db.EconometricModels
                    .AsNoTracking()
                    .FirstOrDefault(m => m.ModelId == modelId);

                // Dacă p-value este mic, factorul are impact real, nu e întâmplător
                return model != null && model.PValue < 0.05m;
            }
        }
        public void UpdateModelParameters(int modelId, decimal coeff, decimal pVal, decimal rSq)
        {
            using (var db = new SmartStockContext())
            {
                var model = db.EconometricModels.Find(modelId);
                if (model != null)
                {
                    model.CoefficientValue = coeff;
                    model.PValue = pVal;
                    model.RSquared = rSq;
                    model.LastTrainedDate = DateTime.Now;

                    db.SaveChanges(); // Conexiunea se închide automat
                }
            }
        }
        public EconometricModel GetBestPerformingModel()
        {
            using (var db = new SmartStockContext())
            {
                return db.EconometricModels
                    .AsNoTracking()
                    .OrderByDescending(m => m.RSquared)
                    .FirstOrDefault();
            }
        }
    }
}
