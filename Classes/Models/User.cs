using SmartStock.Classes.Utils;
using System.ComponentModel.DataAnnotations;

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
        public string Role { get; set; }

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
        public void CreateUser(User newUser, string plainPassword)
        {
            using (var db = new SmartStockContext())
            {
                string salt = SecurityService.GenerateSalt();
                string hash = SecurityService.HashPassword(plainPassword, salt);

                newUser.Salt = salt;
                newUser.PasswordHash = hash;

                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        public User Authenticate(string username, string password)
        {
            using (var db = new SmartStockContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);

                if (user == null) return null;

                // 1. Verificăm dacă este blocat (IsActive = 0)
                if (!user.IsActive)
                {
                    throw new Exception("The account is locked due to too many failed login attempts. Please contact the administrator.");
                }

                // 2. Verificăm parola
                bool isPasswordCorrect = SecurityService.VerifyPassword(password, user.PasswordHash, user.Salt);

                if (isPasswordCorrect)
                {
                    // Resetăm contorul la succes
                    user.AccessFailedCount = 0;
                    user.LastLoginDate = DateTime.Now;
                    user.IsLoggedIn = 1;
                    db.SaveChanges();

                    SessionManager.CurrentUser = user;
                    return user;
                }
                else
                {
                    // 3. Parolă greșită: incrementăm eșecurile
                    user.AccessFailedCount++;

                    if (user.AccessFailedCount >= 3)
                    {
                        user.IsActive = false; // Blocăm contul
                        db.SaveChanges();
                        throw new Exception("Account locked! You have entered the wrong password 3 times.");
                    }

                    db.SaveChanges();
                    throw new Exception($"Incorrect password! Remaining attempts: {3 - user.AccessFailedCount}");
                }
            }
        }

        public static void Logout(int userId)
        {
            using (var db = new SmartStockContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.IsLoggedIn = 0;
                    db.SaveChanges();
                }
                SessionManager.CurrentUser = null;
            }
        }

        public void DeactivateUser(int userId)
        {
            using (var db = new SmartStockContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    user.IsActive = false;
                    db.SaveChanges();
                }
            }
        }
    }
}