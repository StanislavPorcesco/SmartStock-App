using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartStock.Classes.Utils
{
    public class ThemedComboBox : ComboBox
    {
        // ── Trucul pentru anularea animațiilor native Windows ─────────────────
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        public ThemedComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            FlatStyle = FlatStyle.Flat;
            ItemHeight = 30;
            Font = new Font("Segoe UI", 10F);

            ThemeManager.OnThemeChanged += Invalidate;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWindowTheme(Handle, "", "");
            BeginInvoke(new Action(Invalidate));
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible && IsHandleCreated) BeginInvoke(new Action(Invalidate));
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            if (IsHandleCreated) BeginInvoke(new Action(Invalidate));
        }

        // ── Dropdown items ────────────────────────────────────────────────────

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= Items.Count) return;

            var p = ThemeManager.GetCurrentPalette();
            bool selected = (e.State & DrawItemState.Selected) != 0;

            using var bgBrush = new SolidBrush(selected ? p.SurfaceHover : p.Surface);
            e.Graphics.FillRectangle(bgBrush, e.Bounds);

            if (selected)
            {
                using var accentBrush = new SolidBrush(p.Border);
                e.Graphics.FillRectangle(accentBrush, new Rectangle(e.Bounds.X, e.Bounds.Y, 3, e.Bounds.Height));
            }

            string text = GetItemText(Items[e.Index]);
            TextRenderer.DrawText(
                e.Graphics, text, e.Font ?? Font,
                new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height),
                p.TextPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        // ── Closed-state chrome overdraw ──────────────────────────────────────

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0014) // WM_ERASEBKGND
            {
                m.Result = (IntPtr)1; // Îi spunem sistemului că am "rezolvat" noi fundalul
                return;
            }

            base.WndProc(ref m);

            if (m.Msg == 0x000F) // WM_PAINT
            {
                using var g = Graphics.FromHwnd(Handle);
                DrawChrome(g);
            }
        }

        private void DrawChrome(Graphics g)
        {
            var p = ThemeManager.GetCurrentPalette();

            int btnW = SystemInformation.VerticalScrollBarWidth;
            int fillX = Width - btnW - 2;
            var fillRect = new Rectangle(fillX, 1, Width - fillX - 1, Height - 2);

            using var bgBrush = new SolidBrush(p.Surface);
            g.FillRectangle(bgBrush, fillRect);

            // Chevron centred within the actual button column
            var chevronRect = new Rectangle(Width - btnW, 0, btnW, Height);
            DrawChevron(g, chevronRect, p.TextSecondary);

            // Border drawn last — sits on top of everything
            Color borderColor = p.Border;
            using var pen = new Pen(borderColor, 1);
            g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }

        private static void DrawChevron(Graphics g, Rectangle rect, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int cx = rect.Left + rect.Width / 2;
            int cy = rect.Top + rect.Height / 2 - 1;
            int w = 5, h = 3;
            using var pen = new Pen(color, 1.5f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            g.DrawLine(pen, cx - w, cy - h, cx, cy + h);
            g.DrawLine(pen, cx, cy + h, cx + w, cy - h);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) ThemeManager.OnThemeChanged -= Invalidate;
            base.Dispose(disposing);
        }
    }
}