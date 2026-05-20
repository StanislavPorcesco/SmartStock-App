using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartStock.Classes.Utils
{
    public class ThemedNumericUpDown : NumericUpDown, ISupportInitialize
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        private TextBoxOverlay? _textBoxOverlay;
        private SpinnerOverlay? _spinnerOverlay;
        private int _designerHeight = -1;

        public ThemedNumericUpDown()
        {
            BorderStyle = BorderStyle.None;
            Font = new Font("Segoe UI", 11F);
            ThemeManager.OnThemeChanged += OnThemeChanged;
        }

        // Re-implementarea ISupportInitialize ne permite să interceptăm EndInit()
        // apelat de Designer (((ISupportInitialize)x).EndInit()) — momentul cel mai
        // sigur pentru a captura Height-ul final (după ce Size a fost setat).
        public new void BeginInit() => base.BeginInit();

        public new void EndInit()
        {
            base.EndInit();
            if (Height > 0) _designerHeight = Height;
        }

        // UpDownBase.OnFontChanged resetează Height = PreferredHeight (calculat din Font),
        // ignorând valoarea din Designer. Restaurăm Height-ul capturat la EndInit().
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            if (_designerHeight > 0 && Height != _designerHeight)
                Height = _designerHeight;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (DesignMode) return;
            SetWindowTheme(Handle, "", "");
            BeginInvoke(new Action(Initialize));
        }

        private void Initialize()
        {
            foreach (Control child in Controls)
            {
                if (child is TextBox tb)
                {
                    SetWindowTheme(tb.Handle, "", "");
                    tb.BorderStyle = BorderStyle.None;
                    _textBoxOverlay?.ReleaseHandle();
                    _textBoxOverlay = new TextBoxOverlay(tb, this);
                }
                else
                {
                    _spinnerOverlay?.ReleaseHandle();
                    _spinnerOverlay = new SpinnerOverlay(child, this);
                }
            }
            ApplyColors();
            Invalidate();
        }

        private void OnThemeChanged()
        {
            if (DesignMode) return;
            ApplyColors();
            Invalidate();
            _textBoxOverlay?.InvalidateOverlay();
            _spinnerOverlay?.InvalidateSpinner();
        }

        private void ApplyColors()
        {
            if (!ThemeManager.Themes.ContainsKey(ThemeManager.CurrentThemeName)) return;
            var p = ThemeManager.GetCurrentPalette();
            BackColor = p.Surface;
            ForeColor = p.TextPrimary;
            foreach (Control child in Controls)
            {
                child.BackColor = p.Surface;
                child.ForeColor = p.TextPrimary;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            _textBoxOverlay?.InvalidateOverlay();
            _spinnerOverlay?.InvalidateSpinner();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _textBoxOverlay?.InvalidateOverlay();
            _spinnerOverlay?.InvalidateSpinner();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ThemeManager.OnThemeChanged -= OnThemeChanged;
                _textBoxOverlay?.ReleaseHandle();
                _spinnerOverlay?.ReleaseHandle();
                _textBoxOverlay = null;
                _spinnerOverlay = null;
            }
            base.Dispose(disposing);
        }

        // ── TextBox overlay ─────────────────────────────────────────────────────
        // Desenează top, bottom și left ale borderului peste TextBox-ul intern.

        private sealed class TextBoxOverlay : NativeWindow
        {
            private readonly ThemedNumericUpDown _owner;
            private readonly Control _target;

            public TextBoxOverlay(Control tb, ThemedNumericUpDown owner)
            {
                _owner = owner;
                _target = tb;
                AssignHandle(tb.Handle);
            }

            public void InvalidateOverlay() => _target.Invalidate();

            protected override void WndProc(ref Message m)
            {
                if (_owner.DesignMode)
                {
                    base.WndProc(ref m);
                    return;
                }

                base.WndProc(ref m);

                if (m.Msg == 0x000F) // WM_PAINT — chrome după paintul nativ
                {
                    using var g = Graphics.FromHwnd(Handle);
                    var p = ThemeManager.GetCurrentPalette();
                    int w = _target.Width;
                    int h = _target.Height;
                    using var pen = new Pen(p.Border, 1);
                    g.DrawLine(pen, 0, 0, w - 1, 0);             // top
                    g.DrawLine(pen, 0, h - 1, w - 1, h - 1);     // bottom
                    g.DrawLine(pen, 0, 0, 0, h - 1);             // left
                }
            }
        }

        // ── Spinner overlay ─────────────────────────────────────────────────────
        // Desenează top, bottom, right (și separator vertical + chevroni).

        private sealed class SpinnerOverlay : NativeWindow
        {
            [DllImport("user32.dll")]
            private static extern IntPtr BeginPaint(IntPtr hwnd, out PAINTSTRUCT lpPaint);

            [DllImport("user32.dll")]
            private static extern bool EndPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

            [StructLayout(LayoutKind.Sequential)]
            private struct PAINTSTRUCT
            {
                public IntPtr hdc;
                public bool fErase;
                public RECT rcPaint;
                public bool fRestore;
                public bool fIncUpdate;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
                public byte[] rgbReserved;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct RECT { public int Left, Top, Right, Bottom; }

            private readonly ThemedNumericUpDown _owner;
            private readonly Control _target;

            public SpinnerOverlay(Control spinnerControl, ThemedNumericUpDown owner)
            {
                _owner = owner;
                _target = spinnerControl;
                AssignHandle(spinnerControl.Handle);
            }

            public void InvalidateSpinner() => _target.Invalidate();

            protected override void WndProc(ref Message m)
            {
                if (_owner.DesignMode)
                {
                    base.WndProc(ref m);
                    return;
                }

                if (m.Msg == 0x0014) // WM_ERASEBKGND
                {
                    m.Result = (IntPtr)1;
                    return;
                }

                if (m.Msg == 0x000F) // WM_PAINT — gestionăm complet (fără base)
                {
                    var ps = new PAINTSTRUCT();
                    IntPtr hdc = BeginPaint(Handle, out ps);
                    try
                    {
                        using var g = Graphics.FromHdc(hdc);
                        DrawSpinner(g);
                    }
                    finally
                    {
                        EndPaint(Handle, ref ps);
                    }
                    return;
                }

                base.WndProc(ref m);
            }

            private void DrawSpinner(Graphics g)
            {
                var p = ThemeManager.GetCurrentPalette();
                int w = _target.Width;
                int h = _target.Height;
                int half = h / 2;

                using (var bg = new SolidBrush(p.Surface))
                    g.FillRectangle(bg, 0, 0, w, h);

                using (var pen = new Pen(p.Border, 1))
                {
                    g.DrawLine(pen, 0, 0, w - 1, 0);             // top
                    g.DrawLine(pen, 0, h - 1, w - 1, h - 1);     // bottom
                    g.DrawLine(pen, w - 1, 0, w - 1, h - 1);     // right
                    g.DrawLine(pen, 0, 0, 0, h - 1);             // separator vertical TextBox/Spinner
                    g.DrawLine(pen, 1, half, w - 2, half);       // separator orizontal up/down
                }

                DrawChevron(g, new Rectangle(0, 0, w, half), up: true, p.TextSecondary);
                DrawChevron(g, new Rectangle(0, half, w, h - half), up: false, p.TextSecondary);
            }

            private static void DrawChevron(Graphics g, Rectangle rect, bool up, Color color)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int cx = rect.Left + rect.Width / 2;
                int cy = rect.Top + rect.Height / 2;
                const int rw = 4, rh = 2;
                using var pen = new Pen(color, 1.5f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
                if (up)
                {
                    g.DrawLine(pen, cx - rw, cy + rh, cx, cy - rh);
                    g.DrawLine(pen, cx, cy - rh, cx + rw, cy + rh);
                }
                else
                {
                    g.DrawLine(pen, cx - rw, cy - rh, cx, cy + rh);
                    g.DrawLine(pen, cx, cy + rh, cx + rw, cy - rh);
                }
            }
        }
    }
}
