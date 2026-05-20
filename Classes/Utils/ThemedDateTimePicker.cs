using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartStock.Classes.Utils
{
    public class ThemedDateTimePicker : DateTimePicker
    {
        // ── Anularea visual styles native ────────────────────────────────────
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        // ── Paint API ────────────────────────────────────────────────────────
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

        // DateTimePicker.SetBoundsCore clampuiește forțat Height = PreferredHeight.
        // MethodInfo.Invoke face virtual dispatch → recursie infinită → SO crash.
        // Construim un DynamicMethod cu OpCodes.Call (non-virtual) care apelează
        // DIRECT Control.SetBoundsCore, ocolind override-ul DateTimePicker.
        private static readonly Action<Control, int, int, int, int, BoundsSpecified>? _controlSetBoundsCore =
            BuildControlSetBoundsCore();

        private static Action<Control, int, int, int, int, BoundsSpecified>? BuildControlSetBoundsCore()
        {
            try
            {
                var mi = typeof(Control).GetMethod("SetBoundsCore",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                if (mi == null) return null;

                var dm = new DynamicMethod(
                    name: "Control_SetBoundsCore_NonVirtual",
                    returnType: typeof(void),
                    parameterTypes: new[] {
                        typeof(Control), typeof(int), typeof(int),
                        typeof(int), typeof(int), typeof(BoundsSpecified)
                    },
                    owner: typeof(ThemedDateTimePicker),
                    skipVisibility: true);

                var il = dm.GetILGenerator();
                il.Emit(OpCodes.Ldarg_0);             // this
                il.Emit(OpCodes.Ldarg_1);             // x
                il.Emit(OpCodes.Ldarg_2);             // y
                il.Emit(OpCodes.Ldarg_3);             // width
                il.Emit(OpCodes.Ldarg_S, (byte)4);    // height
                il.Emit(OpCodes.Ldarg_S, (byte)5);    // specified
                il.Emit(OpCodes.Call, mi);            // non-virtual call
                il.Emit(OpCodes.Ret);

                return (Action<Control, int, int, int, int, BoundsSpecified>)
                    dm.CreateDelegate(typeof(Action<Control, int, int, int, int, BoundsSpecified>));
            }
            catch
            {
                return null;
            }
        }

        private int _targetHeight = -1;
        private bool _layingOut;

        public ThemedDateTimePicker()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd MMM yyyy";
            Font = new Font("Segoe UI", 11F);

            ThemeManager.OnThemeChanged += Invalidate;

            // ultimul ca să fie tracked dupa Font (PreferredHeight depinde de Font)
            Height = 36;
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            _layingOut = true;
            try { base.OnLayout(levent); }
            finally { _layingOut = false; }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Capturăm înălțimea intenționată de utilizator (constructor/Designer Size/cod).
            // Excludem: layout engine (Anchor/Dock recompute) și auto-clamp la PreferredHeight.
            if (!_layingOut &&
                (specified & BoundsSpecified.Height) != 0 &&
                height > 0 &&
                height != PreferredHeight)
            {
                _targetHeight = height;
            }

            int actualHeight = _targetHeight > 0 ? _targetHeight : height;

            if (_controlSetBoundsCore != null)
                _controlSetBoundsCore(this, x, y, width, actualHeight, specified);
            else
                base.SetBoundsCore(x, y, width, actualHeight, specified);
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

        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);
            if (IsHandleCreated) Invalidate();
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            if (IsHandleCreated) Invalidate();
        }

        // ── Closed-state chrome overdraw ─────────────────────────────────────

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0014) // WM_ERASEBKGND
            {
                m.Result = (IntPtr)1;
                return;
            }

            if (m.Msg == 0x000F) // WM_PAINT — gestionăm complet, fără base
            {
                var ps = new PAINTSTRUCT();
                IntPtr hdc = BeginPaint(Handle, out ps);
                try
                {
                    using var g = Graphics.FromHdc(hdc);
                    DrawChrome(g);
                }
                finally
                {
                    EndPaint(Handle, ref ps);
                }
                return;
            }

            base.WndProc(ref m);
        }

        private void DrawChrome(Graphics g)
        {
            var p = ThemeManager.GetCurrentPalette();

            int btnW = SystemInformation.VerticalScrollBarWidth;

            // Acoperim TOT clientul cu Surface (peste fundalul alb nativ)
            using (var bgBrush = new SolidBrush(p.Surface))
                g.FillRectangle(bgBrush, 1, 1, Width - 2, Height - 2);

            // Redesenăm textul datei manual cu TextPrimary
            string text;
            try
            {
                text = Value.ToString(string.IsNullOrEmpty(CustomFormat) ? "dd MMM yyyy" : CustomFormat,
                                     System.Globalization.CultureInfo.CurrentCulture);
            }
            catch
            {
                text = Value.ToShortDateString();
            }

            var textRect = new Rectangle(8, 0, Width - btnW - 10, Height);
            TextRenderer.DrawText(
                g, text, Font, textRect, p.TextPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // Chevron centrat în coloana butonului
            var chevronRect = new Rectangle(Width - btnW, 0, btnW, Height);
            DrawChevron(g, chevronRect, p.TextSecondary);

            // Border 1px deasupra a tot
            using var pen = new Pen(p.Border, 1);
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
