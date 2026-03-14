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
        private void FinalizeAccountCreation(string username, string password, string fullName, string email)
        {
            try
            {
                // 1. Instanțiem clasa de logică
                User userLogic = new User();

                // 2. Pregătim obiectul nou cu datele de bază
                User newAgent = new User
                {
                    Username = username,
                    FullName = fullName,
                    Email = email,
                    Role = "Agent", // Setăm fix rolul de Agent
                    IsActive = true,    // Contul este activ implicit
                    IsLoggedIn = 0   // Nu este logat încă
                };

                // 3. Apelăm metoda CreateUser care se ocupă de Salt, Hash și SaveChanges
                // Aceasta este metoda pe care am scris-o anterior în clasa User
                userLogic.CreateUser(newAgent, password);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.FindForm().Hide();
                MessageBox.Show("The Agent account has been created successfully!", "Succes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    TextBox[] boxes = { textBox0, textBox1, textBox2, textBox5, textBox4, textBox3 };

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
