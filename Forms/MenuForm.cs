
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

        // ── Borderless window: manual resize + drag ──────────────────────────

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int ResizeBorder = 5;

        [Flags]
        private enum ResizeDir { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }

        private bool      _resizing   = false;
        private ResizeDir _resizeDir  = ResizeDir.None;
        private Point     _resizeStart;
        private Rectangle _startBounds;

        private ResizeDir HitDir(Point p)
        {
            var d = ResizeDir.None;
            if (p.X <= ResizeBorder)                        d |= ResizeDir.Left;
            if (p.X >= ClientSize.Width  - ResizeBorder)   d |= ResizeDir.Right;
            if (p.Y <= ResizeBorder)                        d |= ResizeDir.Top;
            if (p.Y >= ClientSize.Height - ResizeBorder)   d |= ResizeDir.Bottom;
            return d;
        }

        private static Cursor CursorFor(ResizeDir d) => d switch
        {
            ResizeDir.Left                          => Cursors.SizeWE,
            ResizeDir.Right                         => Cursors.SizeWE,
            ResizeDir.Top                           => Cursors.SizeNS,
            ResizeDir.Bottom                        => Cursors.SizeNS,
            ResizeDir.Top    | ResizeDir.Left       => Cursors.SizeNWSE,
            ResizeDir.Bottom | ResizeDir.Right      => Cursors.SizeNWSE,
            ResizeDir.Top    | ResizeDir.Right      => Cursors.SizeNESW,
            ResizeDir.Bottom | ResizeDir.Left       => Cursors.SizeNESW,
            _                                       => Cursors.Default,
        };

        private const int WM_SETCURSOR    = 0x0020;
        private const int WM_ERASEBKGND   = 0x0014;

        protected override void WndProc(ref Message m)
        {
            // Suppress background erase — prevents the white flash before repaint.
            if (m.Msg == WM_ERASEBKGND) { m.Result = (IntPtr)1; return; }

            // WM_SETCURSOR fires per-HWND: child controls handle it themselves,
            // so this only runs when the cursor is over the form background (5px border)
            // or during active resize (Capture=true routes all messages here).
            if (m.Msg == WM_SETCURSOR && WindowState == FormWindowState.Normal)
            {
                var dir = _resizing ? _resizeDir : HitDir(PointToClient(Cursor.Position));
                if (dir != ResizeDir.None)
                {
                    Cursor.Current = CursorFor(dir);
                    m.Result = (IntPtr)1;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!_resizing || WindowState != FormWindowState.Normal) return;

            int dx = e.X + Location.X - _resizeStart.X;
            int dy = e.Y + Location.Y - _resizeStart.Y;
            var b  = _startBounds;

            if ((_resizeDir & ResizeDir.Right)  != 0) b.Width  = Math.Max(MinimumSize.Width,  _startBounds.Width  + dx);
            if ((_resizeDir & ResizeDir.Bottom) != 0) b.Height = Math.Max(MinimumSize.Height, _startBounds.Height + dy);
            if ((_resizeDir & ResizeDir.Left)   != 0) { b.X = _startBounds.Right - Math.Max(MinimumSize.Width,  _startBounds.Width  - dx); b.Width  = _startBounds.Right  - b.X; }
            if ((_resizeDir & ResizeDir.Top)    != 0) { b.Y = _startBounds.Bottom - Math.Max(MinimumSize.Height, _startBounds.Height - dy); b.Height = _startBounds.Bottom - b.Y; }

            Bounds = b;
            Invalidate(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left || WindowState != FormWindowState.Normal) return;

            var dir = HitDir(e.Location);
            if (dir == ResizeDir.None) return;

            _resizing    = true;
            _resizeDir   = dir;
            _resizeStart = new Point(e.X + Location.X, e.Y + Location.Y);
            _startBounds = Bounds;
            Capture      = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (_resizing) { _resizing = false; Capture = false; }
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
          /*if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                maximize_btn.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maximize_btn.IconChar = IconChar.WindowRestore;
            }*/
            if (WindowState == FormWindowState.Maximized)
            {
                // Scoatem limita de dimensiune când revenim la normal
                this.MaximumSize = new Size(0, 0);
                WindowState = FormWindowState.Normal;
                maximize_btn.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                // Obținem ecranul pe care se află fereastra în acest moment (suportă multi-monitor)
                Screen currentScreen = Screen.FromHandle(this.Handle);

                // Setăm dimensiunea maximă la zona de lucru (WorkingArea exclude taskbar-ul)
                this.MaximizedBounds = currentScreen.WorkingArea;
                this.MaximumSize = currentScreen.WorkingArea.Size;

                WindowState = FormWindowState.Maximized;
                maximize_btn.IconChar = IconChar.WindowRestore;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
            => Close();

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            maximize_btn.IconChar = WindowState == FormWindowState.Maximized
                ? IconChar.WindowRestore
                : IconChar.WindowMaximize;
        }

        public MenuForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            ThemeManager.Apply(this);
            this.Refresh();
            ThemeManager.OnThemeChanged += HandleThemeUpdate;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 52);
            menu_buttons_pnl.Controls.Add(leftBorderBtn);
            leftBorderBtn.Visible = false;

            PopulateUserCard();
            InitMenuButtonStates();
            add_btn_Click(this.add_btn, EventArgs.Empty);

            maximize_btn_Click(maximize_btn, EventArgs.Empty);
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

        private void InitMenuButtonStates()
        {
            var p = ThemeManager.GetCurrentPalette();
            foreach (Control c in menu_buttons_pnl.Controls)
            {
                if (c is IconButton btn)
                {
                    btn.ForeColor = p.TextSecondary;
                    btn.BackColor = Color.Transparent;
                    btn.IconColor = p.TextSecondary;
                }
            }
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            InitMenuButtonStates();
            ActivateButton(currentBtn);
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
                currentBtn.Refresh();
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
