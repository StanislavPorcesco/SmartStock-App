using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;

namespace SmartStock.Forms.User_Control
{
    public partial class MailConfirmation : UserControl
    {
        string generatedCode;
        string username;
        string password;
        string fullname;
        string email;
        public MailConfirmation(string _generatedCode, string _username, string _password, string _fullname, string _email)
        {
            InitializeComponent();
            generatedCode = _generatedCode;
            username = _username;
            password = _password;
            fullname = _fullname;
            email = _email;
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += () => ThemeManager.Apply(this);
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if(generatedCode == textBox0.Text + textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text)
            {
                FinalizeAccountCreation(username, password, fullname, email);
            }
            else
            {
                MessageBox.Show("The code you entered is incorrect. Please check your email and try again.", "Invalid Code",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox0.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox3.Clear();
            }
        }
        private async void FinalizeAccountCreation(string username, string password, string fullName, string email)
        {
            try
            {
                // Create new user using UserService (refactored N-Tier)
                var userRepository = new GenericRepository<User>(new SmartStockContext());
                var userService = new UserService(userRepository);

                User newAgent = new User
                {
                    Username = username,
                    FullName = fullName,
                    Email = email,
                    Role = "Operator", // Default role for new accounts (was "Agent")
                    IsActive = true,
                    IsLoggedIn = 0
                };

                bool success = await userService.CreateUserAsync(newAgent, password);

                if (success)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.FindForm().Hide();
                    MessageBox.Show("The account has been created successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create account.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Account creation error: {ex.Message}", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Validation error: {ex.Message}", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating the account: {ex.Message}", "Critical Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTb = sender as TextBox;

            // Verificăm dacă s-a introdus un caracter
            if (currentTb != null && currentTb.Text.Length > 0)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTb = sender as TextBox;

            // 1. Logica pentru BackSpace (Salt înapoi)
            if (e.KeyCode == Keys.Back && currentTb.Text.Length == 0)
            {
                SendKeys.Send("+{TAB}");
                e.Handled = true;
            }

            // 2. Logica pentru PASTE (Ctrl + V)
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Dezactivăm acțiunea default de paste a Windows-ului
                e.SuppressKeyPress = true;

                string clipboardText = Clipboard.GetText().Trim();
                // Păstrăm doar cifrele folosind Regex
                string digitsOnly = System.Text.RegularExpressions.Regex.Replace(clipboardText, @"[^\d]", "");

                if (digitsOnly.Length >= 6)
                {
                    // IMPORTANT: Asigură-te că numele acestor controale coincid cu cele din Designer-ul tău
                    TextBox[] boxes = { textBox0, textBox1, textBox2, textBox3, textBox4, textBox5 };

                    for (int i = 0; i < 6; i++)
                    {
                        boxes[i].Text = digitsOnly[i].ToString();
                    }

                    // Mutăm focusul pe ultima căsuță pentru a finaliza experiența UX
                    boxes[5].Focus();

                    // Opțional: Poți apela aici automat funcția de confirmare
                    // btnConfirm_Click(null, null);
                }
            }
        }

    }
}
