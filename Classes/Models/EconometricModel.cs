using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartStock.Classes.Models
{
    public class EconometricModel
    {
        [Key]
        public int ModelId { get; set; }

        [Required]
        public int ProductId { get; set; }

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

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
