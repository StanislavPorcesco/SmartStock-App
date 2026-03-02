using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control;

namespace SmartStock.Forms.AddForms
{
    public partial class AddAccount : UserControl
    {
        public AddAccount()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
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

        private void create_btn_Click(object sender, EventArgs e)
        {
            // Validări rapide
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
            if (!email_tb.Text.Contains("@") || !email_tb.Text.Contains(".") || !email_tb.Text.Equals(email_tb.Text.ToLower()))
            {
                MessageBox.Show("Please enter a valid email address!", "Email Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(password_tb.Text) || string.IsNullOrWhiteSpace(fullname_tb.Text) || string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("All fields are mandatory!", "Completion Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trimitem codul
            Cursor.Current = Cursors.WaitCursor;
            string generatedCode = EmailService.SendVerificationCode(email_tb.Text);
            Cursor.Current = Cursors.WaitCursor;
            
            var confirmationUC = new MailConfirmation(generatedCode, username_tb.Text, password_tb.Text, fullname_tb.Text, email_tb.Text);
            DataLayer.OpenUserControl(this.FindForm(), confirmationUC);
        }
    }
}
