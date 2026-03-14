using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;

namespace SmartStock.Forms.User_Control
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new AddAccount());
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Settings());
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Please enter both the username and the password.", "Completion Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginAsync();
        }

        /// <summary>
        /// Autentifică utilizatorul using UserService (refactored N-Tier).
        /// </summary>
        private async void LoginAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var userRepository = new GenericRepository<User>(new SmartStockContext());
                var userService = new UserService(userRepository);

                User authenticatedUser = await userService.AuthenticateAsync(
                    username_tb.Text.Trim(),
                    password_tb.Text
                );

                if (authenticatedUser != null)
                {
                    MenuForm mainForm = new MenuForm();
                    mainForm.Show();
                    this.FindForm().Hide();
                }
            }
            catch (InvalidOperationException ex)
            {
                // Authentication failed (wrong password, locked account, etc.)
                MessageBox.Show($"Authentication error: {ex.Message}",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_tb.Clear();
                password_tb.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"System error: {ex.Message}",
                                "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}

