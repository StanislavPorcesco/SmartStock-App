using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business și actualizări este delegată UserService.
    /// Add mode: creates a new user account (password_tb used as plain-text password).
    /// Modify mode: updates profile fields (username, full name, email, role, active state).
    /// </summary>
    public partial class ModifyUser : UserControl, ISaveableControl
    {
        private UserService _userService;
        private int _currentUserId;
        private User _loadedUser;

        public ModifyUser()
        {
            InitializeComponent();
            InitializeService();
            DataLayer.PopulateRoleSelector(role_cb);
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<User>(new SmartStockContext());
            _userService = new UserService(repository);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(user_id_tb.Text, out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.", "Search Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchAndLoadUser(userId);
        }

        private async void SearchAndLoadUser(int userId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var user = await _userService.GetByIdAsync(userId);

                if (user != null)
                {
                    _currentUserId = user.UserId;
                    _loadedUser    = user;
                    DisplayUserData(user);
                }
                else
                {
                    user_id_tb.BackColor = Color.DarkRed;
                    user_id_tb.ForeColor = Color.White;
                    MessageBox.Show("User not found.", "Search Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void DisplayUserData(User user)
        {
            username_tb.Text              = user.Username;
            fullname_tb.Text              = user.FullName;
            email_tb.Text                 = user.Email;
            role_cb.SelectedItem = user.Role;
            is_active_ck.Checked          = user.IsActive;
            failed_count_tb.Text          = user.AccessFailedCount.ToString();
            password_tb.Clear(); // Never display the password hash

            user_id_tb.BackColor = user.IsActive ? Color.DarkGreen : Color.DarkOrange;
            user_id_tb.ForeColor = Color.White;

            if (!user.IsActive)
                MessageBox.Show("This user is currently inactive.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool TryCollectUserData(out User user)
        {
            user = null;

            string username = username_tb.Text.Trim();
            string fullName = fullname_tb.Text.Trim();
            string email    = email_tb.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (role_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(email) && (!email.Contains("@") || !email.Contains(".")))
            {
                MessageBox.Show("The email format is invalid.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            user = new User
            {
                Username = username,
                FullName = fullName,
                Email    = email,
                Role     = role_cb.SelectedItem.ToString(),
                IsActive = is_active_ck.Checked
            };

            return true;
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<bool> PerformSave(bool isAddMode)
        {
            if (!TryCollectUserData(out var user)) return false;

            try
            {
                if (isAddMode)
                {
                    string password = password_tb.Text;
                    if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters.", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return await _userService.CreateUserAsync(user, password);
                }
                else
                {
                    // Mutate the tracked entity — avoids EF duplicate-key tracking conflict
                    _loadedUser.Username = user.Username;
                    _loadedUser.FullName = user.FullName;
                    _loadedUser.Email    = user.Email;
                    _loadedUser.Role     = user.Role;
                    _loadedUser.IsActive = user.IsActive;
                    return await _userService.UpdateUserAsync(_loadedUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> PerformArchive(int userId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _userService.DeactivateUserAsync(userId);

                if (success)
                {
                    MessageBox.Show("User has been deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return success;
        }

        public void UpdateUIState(bool isAddMode)
        {
            var searchButton = this.Controls.Find("search_btn", true).FirstOrDefault();
            var idTextBox    = this.Controls.Find("user_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(user_id_tb.Text, out int id) ? id : -1;
        }

        public void ClearControls()
        {
            user_id_tb.Clear();
            username_tb.Clear();
            fullname_tb.Clear();
            email_tb.Clear();
            password_tb.Clear();
            role_cb.SelectedIndex = -1;
            is_active_ck.Checked = false;
            failed_count_tb.Clear();
            ThemeManager.Apply(this);
        }
    }
}
