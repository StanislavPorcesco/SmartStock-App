
using System.Runtime.InteropServices;
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

        // ── Borderless window support ─────────────────────────────────────────

        private const int ResizeBorder = 6;

        private const int HTLEFT        = 10;
        private const int HTRIGHT       = 11;
        private const int HTTOP         = 12;
        private const int HTTOPLEFT     = 13;
        private const int HTTOPRIGHT    = 14;
        private const int HTBOTTOM      = 15;
        private const int HTBOTTOMLEFT  = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST  = 0x0084;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST && WindowState == FormWindowState.Normal)
            {
                var pos   = PointToClient(new Point(m.LParam.ToInt32() & 0xFFFF,
                                                     m.LParam.ToInt32() >> 16));
                bool left   = pos.X <= ResizeBorder;
                bool right  = pos.X >= ClientSize.Width  - ResizeBorder;
                bool top    = pos.Y <= ResizeBorder;
                bool bottom = pos.Y >= ClientSize.Height - ResizeBorder;

                if      (top    && left)  m.Result = (IntPtr)HTTOPLEFT;
                else if (top    && right) m.Result = (IntPtr)HTTOPRIGHT;
                else if (bottom && left)  m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (bottom && right) m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (left)            m.Result = (IntPtr)HTLEFT;
                else if (right)           m.Result = (IntPtr)HTRIGHT;
                else if (top)             m.Result = (IntPtr)HTTOP;
                else if (bottom)          m.Result = (IntPtr)HTBOTTOM;
                else base.WndProc(ref m);
                return;
            }
            base.WndProc(ref m);
        }

        // Drag the titlebar to move the window.
        private void titlebar_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1 /*WM_NCLBUTTONDOWN*/, 0x2 /*HTCAPTION*/, 0);
            }
        }

        // Double-click the titlebar to maximise / restore.
        private void titlebar_pnl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                maximize_btn_Click(maximize_btn, EventArgs.Empty);
        }

        private void minimize_btn_Click(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                maximize_btn.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximize_btn.IconChar = IconChar.WindowRestore;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
            => Close();

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
