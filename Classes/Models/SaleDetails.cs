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
        public decimal UnitPrice{ get; set; }

        // Proprietăți de navigare pentru EF Core
        [ForeignKey("SaleId")]
        public virtual Sale Sale { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        // Proprietate calculată pentru UI (Subtotal per linie)
        [NotMapped]
        public decimal LineTotal => Quantity * UnitPrice;
    }
}
