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

            try
            {
                Cursor = Cursors.WaitCursor;

                User userLogic = new User();
                User authenticatedUser = userLogic.Authenticate(username_tb.Text, password_tb.Text);
                if (authenticatedUser != null)
                {
                    MenuForm mainForm = new MenuForm();
                    mainForm.Show();    
                    this.FindForm().Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password, or the account is disabled.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_tb.Clear();
                    password_tb.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Authentification error: {ex.Message}",
                                "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
