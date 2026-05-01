using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control;

namespace SmartStock.Forms.AddForms
{
    public partial class AddAccount : UserControl
    {
        private bool _passwordVisible = false;

        public AddAccount()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            view_pass_btn.Click += TogglePasswordVisibility;
            username_tb.KeyDown += OnEnterPressed;
            password_tb.KeyDown += OnEnterPressed;
            fullname_tb.KeyDown += OnEnterPressed;
            email_tb.KeyDown += OnEnterPressed;
        }

        private void OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                create_btn_Click(sender, e);
            }
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Login());
        }

        private async void create_btn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(password_tb.Text) || string.IsNullOrWhiteSpace(fullname_tb.Text) || string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("All fields are mandatory!", "Completion Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username_tb.Text.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long!", "Username Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password_tb.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Password Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fullname_tb.Text.Length < 4 && !fullname_tb.Text.Contains(" "))
            {
                MessageBox.Show("Full name must be at least 4 characters long!", "Full Name Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email_tb.Text))
            {
                MessageBox.Show("Please enter a valid email address!", "Email Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check username availability
            try
            {
                create_btn.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                var userService = new UserService(new GenericRepository<User>(new SmartStockContext()));
                var existing = await userService.GetByUsernameAsync(username_tb.Text.Trim());
                if (existing != null)
                {
                    MessageBox.Show($"Username '{username_tb.Text.Trim()}' is already taken. Please choose a different one.",
                                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username_tb.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not verify username: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                create_btn.Enabled = true;
                Cursor.Current = Cursors.Default;
            }

            string generatedCode = EmailService.SendVerificationCode(email_tb.Text);
            var confirmationUC = new MailConfirmation(generatedCode, username_tb.Text, password_tb.Text, fullname_tb.Text, email_tb.Text);
            DataLayer.OpenUserControl(this.FindForm(), confirmationUC);
        }

        private void TogglePasswordVisibility(object? sender, EventArgs e)
        {
            _passwordVisible = !_passwordVisible;
            password_tb.UseSystemPasswordChar = !_passwordVisible;
            view_pass_btn.IconChar = _passwordVisible
                ? FontAwesome.Sharp.IconChar.Eye
                : FontAwesome.Sharp.IconChar.EyeSlash;
        }

        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email.Trim();
            }
            catch
            {
                return false;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
