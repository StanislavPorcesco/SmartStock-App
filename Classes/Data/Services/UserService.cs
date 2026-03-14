using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a entității User.
    /// Conține autentificare, permisiuni, validări și logica de acces.
    /// IMPORTANT: Toate operațiile de securitate sunt centralizate aici.
    /// </summary>
    public class UserService
    {
        private readonly IRepository<User> _userRepository;
        private const int MAX_LOGIN_ATTEMPTS = 3;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        /// <summary>
        /// Obține toți utilizatorii activi.
        /// </summary>
        public async Task<List<User>> GetAllActiveAsync()
        {
            return await _userRepository
                .GetAll()
                .Where(u => u.IsActive)
                .OrderBy(u => u.Username)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Filtrează utilizatorii conform criteriilor furnizate.
        /// </summary>
        public async Task<List<User>> GetFilteredAsync(UserFilterCriteria criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException(nameof(criteria));

            IQueryable<User> query = _userRepository.GetAll();

            // Filtru după stare
            if (criteria.IsActive.HasValue)
            {
                query = query.Where(u => u.IsActive == criteria.IsActive.Value);
            }

            // Filtru după rol
            if (!string.IsNullOrWhiteSpace(criteria.Role))
            {
                var roleLower = criteria.Role.ToLower();
                query = query.Where(u => u.Role.ToLower() == roleLower);
            }

            // Filtru după status logare
            if (criteria.IsLoggedIn.HasValue)
            {
                var isLoggedInValue = criteria.IsLoggedIn.Value ? 1 : 0;
                query = query.Where(u => u.IsLoggedIn == isLoggedInValue);
            }

            // Căutare text (în username, FullName, Email)
            if (!string.IsNullOrWhiteSpace(criteria.SearchText))
            {
                var searchLower = criteria.SearchText.ToLower();
                query = query.Where(u => u.Username.ToLower().Contains(searchLower) ||
                                         u.FullName.ToLower().Contains(searchLower) ||
                                         u.Email.ToLower().Contains(searchLower));
            }

            // Filtru după data ultimei logări (de la)
            if (criteria.LastLoginFrom.HasValue)
            {
                query = query.Where(u => u.LastLoginDate >= criteria.LastLoginFrom.Value);
            }

            // Filtru după data ultimei logări (până la)
            if (criteria.LastLoginTo.HasValue)
            {
                var endDate = criteria.LastLoginTo.Value.AddDays(1);
                query = query.Where(u => u.LastLoginDate < endDate);
            }

            // Sortare
            query = ApplySorting(query, criteria.SortBy, criteria.SortOrder);

            // Paginare
            if (criteria.PageSize > 0)
            {
                query = query.Skip((criteria.PageNumber - 1) * criteria.PageSize)
                             .Take(criteria.PageSize);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// AUTENTIFICARE - Validează credențialele și loghează utilizatorul.
        /// ATENȚIE: Conține logică critică de securitate!
        /// </summary>
        public async Task<User> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username and password are required.");

            var user = await _userRepository
                .GetAll()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
                throw new InvalidOperationException("User not found.");

            // 1. Verifică dacă contul este activ
            if (!user.IsActive)
                throw new InvalidOperationException("The account is locked or disabled. Please contact the administrator.");

            // 2. Verifică parola
            bool isPasswordCorrect = SecurityService.VerifyPassword(password, user.PasswordHash, user.Salt);

            if (isPasswordCorrect)
            {
                // Resetează contorul de eșecuri și actualizează data ultimei logări
                user.AccessFailedCount = 0;
                user.LastLoginDate = DateTime.Now;
                user.IsLoggedIn = 1;

                _userRepository.Update(user);
                await _userRepository.SaveAsync();

                SessionManager.CurrentUser = user;
                return user;
            }
            else
            {
                // 3. Parolă greșită: incrementează contorul
                user.AccessFailedCount++;

                if (user.AccessFailedCount >= MAX_LOGIN_ATTEMPTS)
                {
                    user.IsActive = false; // Blochează contul
                    _userRepository.Update(user);
                    await _userRepository.SaveAsync();
                    throw new InvalidOperationException($"Account locked! Too many failed login attempts ({MAX_LOGIN_ATTEMPTS}).");
                }

                _userRepository.Update(user);
                await _userRepository.SaveAsync();

                throw new InvalidOperationException($"Incorrect password! Attempts remaining: {MAX_LOGIN_ATTEMPTS - user.AccessFailedCount}");
            }
        }

        /// <summary>
        /// LOGOUT - Deloghează utilizatorul.
        /// </summary>
        public async Task<bool> LogoutAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            try
            {
                user.IsLoggedIn = 0;
                _userRepository.Update(user);
                await _userRepository.SaveAsync();

                SessionManager.CurrentUser = null;
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to logout.", ex);
            }
        }

        /// <summary>
        /// Crează un nou utilizator cu parolă hash.
        /// ATENȚIE: Parolă trebuie validată înainte!
        /// </summary>
        public async Task<bool> CreateUserAsync(User newUser, string plainPassword)
        {
            if (newUser == null)
                throw new ArgumentNullException(nameof(newUser));

            ValidateUser(newUser);

            if (string.IsNullOrWhiteSpace(plainPassword) || plainPassword.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters long.");

            // Verifică duplicate
            var existingUser = await _userRepository
                .GetAll()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == newUser.Username.ToLower());

            if (existingUser != null)
                throw new InvalidOperationException($"User '{newUser.Username}' already exists.");

            try
            {
                // Generează salt și hash
                string salt = SecurityService.GenerateSalt();
                string hash = SecurityService.HashPassword(plainPassword, salt);

                newUser.Salt = salt;
                newUser.PasswordHash = hash;
                newUser.AccessFailedCount = 0;
                newUser.IsLoggedIn = 0;

                _userRepository.Add(newUser);
                await _userRepository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to create user.", ex);
            }
        }

        /// <summary>
        /// Actualizează datele unui utilizator (nu parola).
        /// </summary>
        public async Task<bool> UpdateUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            ValidateUser(user);

            // Verifică duplicate (excluzând ID-ul curent)
            var existingUser = await _userRepository
                .GetAll()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == user.Username.ToLower() && u.UserId != user.UserId);

            if (existingUser != null)
                throw new InvalidOperationException($"Username '{user.Username}' is already in use by another user.");

            try
            {
                _userRepository.Update(user);
                await _userRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update user.", ex);
            }
        }

        /// <summary>
        /// Schimbă parola unui utilizator.
        /// Necesită parola veche pentru validare.
        /// </summary>
        public async Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("Old and new passwords are required.");

            if (newPassword.Length < 6)
                throw new ArgumentException("New password must be at least 6 characters long.");

            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            // Verifică parola veche
            bool isOldPasswordCorrect = SecurityService.VerifyPassword(oldPassword, user.PasswordHash, user.Salt);

            if (!isOldPasswordCorrect)
                throw new InvalidOperationException("Old password is incorrect.");

            try
            {
                // Generează salt și hash nouă
                string newSalt = SecurityService.GenerateSalt();
                string newHash = SecurityService.HashPassword(newPassword, newSalt);

                user.Salt = newSalt;
                user.PasswordHash = newHash;
                user.AccessFailedCount = 0; // Resetează contorul

                _userRepository.Update(user);
                await _userRepository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to change password.", ex);
            }
        }

        /// <summary>
        /// Resetează parola unui utilizator (pentru admin).
        /// Fără validare parolei vechi.
        /// </summary>
        public async Task<bool> ResetPasswordAsync(int userId, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
                throw new ArgumentException("New password must be at least 6 characters long.");

            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            try
            {
                string newSalt = SecurityService.GenerateSalt();
                string newHash = SecurityService.HashPassword(newPassword, newSalt);

                user.Salt = newSalt;
                user.PasswordHash = newHash;
                user.AccessFailedCount = 0;

                _userRepository.Update(user);
                await _userRepository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to reset password.", ex);
            }
        }

        /// <summary>
        /// Deactivează un utilizator (soft delete).
        /// </summary>
        public async Task<bool> DeactivateUserAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            user.IsActive = false;
            user.IsLoggedIn = 0;

            try
            {
                _userRepository.Update(user);
                await _userRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to deactivate user.", ex);
            }
        }

        /// <summary>
        /// Activează un utilizator deactivat.
        /// </summary>
        public async Task<bool> ActivateUserAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            user.IsActive = true;
            user.AccessFailedCount = 0;

            try
            {
                _userRepository.Update(user);
                await _userRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to activate user.", ex);
            }
        }

        /// <summary>
        /// Resetează contorul de eșecuri de logare.
        /// </summary>
        public async Task<bool> ResetAccessFailedCountAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
                return false;

            user.AccessFailedCount = 0;

            try
            {
                _userRepository.Update(user);
                await _userRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to reset access failed count.", ex);
            }
        }

        /// <summary>
        /// Obține utilizatorul după ID.
        /// </summary>
        public async Task<User> GetByIdAsync(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        /// <summary>
        /// Obține utilizatorul după username.
        /// </summary>
        public async Task<User> GetByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            return await _userRepository
                .GetAll()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
        }

        /// <summary>
        /// Obține toți utilizatorii dintr-un anumit rol.
        /// </summary>
        public async Task<List<User>> GetUsersByRoleAsync(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role is required.");

            return await _userRepository
                .GetAll()
                .Where(u => u.Role == role && u.IsActive)
                .OrderBy(u => u.Username)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Verifică permisiuni - Admin only.
        /// </summary>
        public bool IsAdmin(User user)
        {
            return user != null && user.Role == "Admin" && user.IsActive;
        }

        /// <summary>
        /// Verifică permisiuni - Manager+.
        /// </summary>
        public bool IsManager(User user)
        {
            return user != null && (user.Role == "Admin" || user.Role == "Manager") && user.IsActive;
        }

        /// <summary>
        /// Obține numărul de utilizatori activi.
        /// </summary>
        public async Task<int> GetActiveUserCountAsync()
        {
            return await _userRepository
                .GetAll()
                .Where(u => u.IsActive)
                .CountAsync();
        }

        /// <summary>
        /// Obține statistici de utilizatori.
        /// </summary>
        public async Task<dynamic> GetUserStatsAsync()
        {
            var stats = await _userRepository
                .GetAll()
                .GroupBy(u => 1)
                .Select(g => new
                {
                    TotalUsers = g.Count(),
                    ActiveUsers = g.Count(u => u.IsActive),
                    InactiveUsers = g.Count(u => !u.IsActive),
                    AdminCount = g.Count(u => u.Role == "Admin"),
                    ManagerCount = g.Count(u => u.Role == "Manager"),
                    OperatorCount = g.Count(u => u.Role == "Operator"),
                    LoggedInCount = g.Count(u => u.IsLoggedIn == 1)
                })
                .FirstOrDefaultAsync();

            return stats ?? new { TotalUsers = 0, ActiveUsers = 0, InactiveUsers = 0, AdminCount = 0, ManagerCount = 0, OperatorCount = 0, LoggedInCount = 0 };
        }

        /// <summary>
        /// Validează datele utilizatorului.
        /// </summary>
        private void ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || user.Username.Length < 3)
                throw new ArgumentException("Username must be at least 3 characters long.");

            if (user.Username.Length > 50)
                throw new ArgumentException("Username cannot exceed 50 characters.");

            if (string.IsNullOrWhiteSpace(user.FullName))
                throw new ArgumentException("Full name is required.");

            if (user.FullName.Length > 150)
                throw new ArgumentException("Full name cannot exceed 150 characters.");

            if (!string.IsNullOrWhiteSpace(user.Email) && user.Email.Length > 100)
                throw new ArgumentException("Email cannot exceed 100 characters.");

            var validRoles = new[] { "Admin", "Manager", "Operator" };
            if (string.IsNullOrWhiteSpace(user.Role) || !validRoles.Contains(user.Role))
                throw new ArgumentException($"Invalid role. Must be one of: {string.Join(", ", validRoles)}");
        }

        /// <summary>
        /// Aplică sortarea query-ului.
        /// </summary>
        private IQueryable<User> ApplySorting(IQueryable<User> query, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Username";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "username" => isDescending
                    ? query.OrderByDescending(u => u.Username)
                    : query.OrderBy(u => u.Username),
                "fullname" => isDescending
                    ? query.OrderByDescending(u => u.FullName)
                    : query.OrderBy(u => u.FullName),
                "role" => isDescending
                    ? query.OrderByDescending(u => u.Role)
                    : query.OrderBy(u => u.Role),
                "lastlogin" => isDescending
                    ? query.OrderByDescending(u => u.LastLoginDate)
                    : query.OrderBy(u => u.LastLoginDate),
                "userid" => isDescending
                    ? query.OrderByDescending(u => u.UserId)
                    : query.OrderBy(u => u.UserId),
                _ => query.OrderBy(u => u.Username)
            };
        }
    }
}
