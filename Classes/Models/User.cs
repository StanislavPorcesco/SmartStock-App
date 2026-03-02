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
        public int IsActive { get; set; } = 1;

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
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.IsActive == 1);

                if (user == null) return null;
                bool isPasswordCorrect = SecurityService.VerifyPassword(password, user.PasswordHash, user.Salt);

                if (isPasswordCorrect)
                {
                    user.LastLoginDate = DateTime.Now;
                    user.IsLoggedIn = 1;
                    db.SaveChanges();

                    SessionManager.CurrentUser = user;
                    return user;
                }
                return null;
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
                    user.IsActive = 0;
                    db.SaveChanges();
                }
            }
        }
    }
}