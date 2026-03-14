using System.ComponentModel.DataAnnotations;

namespace SmartStock.Classes.Models
{
    /// <summary>
    /// Entitatea de domeniu User - curată de orice logică de bază de date.
    /// Logica de autentificare, permisiuni și acces este delegată UserService.
    /// </summary>
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } // Admin, Manager, Operator

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [Required]
        public int IsLoggedIn { get; set; } = 0;

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public int AccessFailedCount { get; set; } = 0;

        /// <summary>
        /// Colecție virtuală de tranzacții efectuate de acest utilizator.
        /// Lazy loading - se încarcă cu Include() în serviciu.
        /// </summary>
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

        /// <summary>
        /// Colecție virtuală de vânzări efectuate de acest utilizator.
        /// Lazy loading - se încarcă cu Include() în serviciu.
        /// </summary>
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
