using SmartStock.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Models
{
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
        public string Role { get; set; } // Admin, Manager, Agent

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [Required]
        public int IsActive { get; set; } = 1; // 1 pentru Activ, 0 pentru Inactiv
        public void CreateUser(User newUser, string plainPassword)
        {
            using (var db = new SmartStockContext())
            {
                // Generăm un Salt unic
                byte[] saltBytes = RandomNumberGenerator.GetBytes(16);
                string salt = Convert.ToBase64String(saltBytes);

                // Calculăm Hash-ul (Parolă + Salt)
                string hash = HashPassword(plainPassword, salt);

                newUser.Salt = salt;
                newUser.PasswordHash = hash;

                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        private string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public User Authenticate(string username, string password)
        {
            using (var db = new SmartStockContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.IsActive == 1);

                if (user == null) return null;

                // Re-calculăm hash-ul cu parola introdusă și salt-ul din DB
                string computedHash = HashPassword(password, user.Salt);

                if (computedHash == user.PasswordHash)
                {
                    user.LastLoginDate = DateTime.Now;
                    db.SaveChanges();
                    return user;
                }

                return null;
            }
        }
        public void DeactivateUser(int userId)
        {
            using (var db = new SmartStockContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.IsActive = 0;
                    db.SaveChanges();
                }
            }
        }
    }
}
