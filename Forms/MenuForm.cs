
using FontAwesome.Sharp;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control;

namespace SmartStock.Forms
{
    public partial class MenuForm : Form
    {
        private IconButton currentBtn = new IconButton();
        private Panel leftBorderBtn;
        private Form currentChildForm = new Form();

        public MenuForm()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            this.Refresh();
            ThemeManager.OnThemeChanged += HandleThemeUpdate;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 52);
            menu_buttons_pnl.Controls.Add(leftBorderBtn);
            leftBorderBtn.Visible = false;

            PopulateUserCard();

            add_btn_Click(this.add_btn, EventArgs.Empty);
        }

        private void PopulateUserCard()
        {
            var user = SessionManager.CurrentUser;
            if (user != null)
            {
                user_name_lbl.Text = string.IsNullOrWhiteSpace(user.FullName) ? user.Username : user.FullName;
                user_role_lbl.Text = (user.Role ?? "USER").ToUpperInvariant();
                status_lbl.Text    = $"Signed in as {user.Username}";
            }
            else
            {
                user_name_lbl.Text = "Guest";
                user_role_lbl.Text = "OFFLINE";
                status_lbl.Text    = "Ready";
            }
        }

        //Metode 

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            ApplyThemeToChildForms();
            this.Refresh();
        }

        private void ApplyThemeToChildForms()
        {
            foreach (Control control in desktop_pnl.Controls)
            {
                if (control is Form childForm)
                {
                    ThemeManager.Apply(childForm);
                    childForm.Invalidate(true);
                    childForm.Update();
                    childForm.Refresh();
                }
            }
        }

        private void ActivateButton(object senderBtn)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                var p = ThemeManager.GetCurrentPalette();
                currentBtn.BackColor = p.Surface;
                currentBtn.ForeColor = p.TextPrimary;
                currentBtn.IconColor = p.Accent;

                // Left border: amber accent strip marks the active section
                leftBorderBtn.BackColor = p.Accent;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Height   = currentBtn.Height;
                leftBorderBtn.Visible  = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                var p = ThemeManager.GetCurrentPalette();
                currentBtn.ForeColor = p.TextSecondary;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.TextAlign  = ContentAlignment.MiddleLeft;
                currentBtn.IconColor  = p.TextSecondary;
                leftBorderBtn.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Size = desktop_pnl.Size;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            ThemeManager.Apply(childForm);

            desktop_pnl.Controls.Add(childForm);
            desktop_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BaseAddInstance form = new BaseAddInstance();
            OpenChildForm(form);
            //DataLayer.OpenUserControl(form, new AddProduct());
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SettingsForm());
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SearchForm());
        }

        private void analyze_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AnalyzeForm());
        }

        private async void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Logout using UserService (refactored N-Tier)
            if (SessionManager.CurrentUser != null)
            {
                try
                {
                    var userRepository = new GenericRepository<User>(new SmartStockContext());
                    var userService = new UserService(userRepository);
                    await userService.LogoutAsync(SessionManager.CurrentUser.UserId);
                }
                catch (Exception ex)
                {
                    // Log error but don't block the application exit
                    Console.WriteLine($"Logout error: {ex.Message}");
                }
            }

            // Exit the application
            Application.Exit();
        }
    }
}
