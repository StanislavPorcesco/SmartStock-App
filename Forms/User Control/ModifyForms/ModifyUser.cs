using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyUser : UserControl
    {
        public ModifyUser()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.PopulateRoleSelector(role_selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(user_id_tb.Text, out int userId))
            {
                MessageBox.Show("Please search for a user first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserId == userId);

                    if (user != null)
                    {
                        // 3. Actualizăm câmpurile de bază
                        user.Username = username_tb.Text;
                        user.FullName = fullname_tb.Text;
                        user.Email = email_tb.Text;
                        user.Role = role_selector_cb.SelectedItem?.ToString();
                        user.IsActive = is_active_ck.Checked ? 1 : 0;

                        // Opțional: Permitem resetarea manuală a contorului de eșecuri
                        if (int.TryParse(failed_count_tb.Text, out int failedCount))
                            user.AccessFailedCount = failedCount;

                        // 4. LOGICA PENTRU PAROLĂ (Resetare)
                        if (!string.IsNullOrWhiteSpace(password_tb.Text))
                        {
                            // Dacă s-a introdus o parolă nouă, generăm Hash și Salt noi
                            string newSalt = SecurityService.GenerateSalt();
                            string newHash = SecurityService.HashPassword(password_tb.Text, newSalt);

                            user.Salt = newSalt;
                            user.PasswordHash = newHash;
                            user.AccessFailedCount = 0;
                        }
                        db.SaveChanges();
                        ClearUserFields();
                        ThemeManager.Apply(this);
                        MessageBox.Show($"User {user.Username} has been updated successfully!", "Update Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Curățăm câmpul de parolă după salvare
                        password_tb.Clear();
                    }
                    else
                    {
                        MessageBox.Show("User not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "System Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(user_id_tb.Text, out int userId))
            {
                MessageBox.Show("Please enter a valid numeric User ID.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user_id_tb.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    var user = db.Users.AsNoTracking().FirstOrDefault(u => u.UserId == userId);

                    if (user != null)
                    {
                        username_tb.Text = user.Username;
                        fullname_tb.Text = user.FullName;
                        password_tb.Text = ""; 
                        email_tb.Text = user.Email;
                        role_selector_cb.SelectedItem = user.Role;
                        is_active_ck.Checked = (user.IsActive == 1);
                        failed_count_tb.Text = user.AccessFailedCount.ToString();

                        user_id_tb.BackColor = Color.LightGreen;
                        user_id_tb.ForeColor = Color.Black;
                    }
                    else
                    {
                        // 4. Dacă ID-ul nu există, afișăm mesajul cerut și curățăm câmpurile
                        MessageBox.Show($"User with ID {userId} does not exist.", "User Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearUserFields();
                        user_id_tb.BackColor = Color.LightCoral;
                        user_id_tb.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void ClearUserFields()
        {
            username_tb.Clear();
            fullname_tb.Clear();
            password_tb.Clear();
            email_tb.Clear();
            role_selector_cb.SelectedIndex = -1;
            is_active_ck.Checked = false;
            failed_count_tb.Clear();
        }
    }
}
