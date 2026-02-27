using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartStock.Utils
{
    public static class ToolTipHelp
    {
        private static ToolTip _sharedToolTip;

        static ToolTipHelp()
        {
            // Inițializăm ToolTip-ul o singură dată pentru toată aplicația
            _sharedToolTip = new ToolTip
            {
                OwnerDraw = true,
                InitialDelay = 0,
                ReshowDelay = 0,
                AutoPopDelay = 32000,
                IsBalloon = true,
            };

            // Abonăm metoda de desenare Dark Mode
            _sharedToolTip.Draw += ToolTip_Draw;
        }

        public static void AddToolTip(Control control, string description)
        {
            if (control == null) return;

            // Atașăm logica de afișare la evenimentele controlului
            control.MouseEnter += (s, e) =>
            {
                // Poziționăm ToolTip-ul cu 45 pixeli deasupra controlului
                _sharedToolTip.Show(description, control, 0, -45);
            };

            control.MouseLeave += (s, e) =>
            {
                // Ascundem ToolTip-ul când mouse-ul părăsește zona
                _sharedToolTip.Hide(control);
            };
        }

        private static void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Culori SmartStock (Dark Mode)
            Color bgColor = Color.FromArgb(45, 45, 48);
            Color borderColor = Color.White;
            Color textColor = Color.White;

            // Desenăm fundalul
            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            // Desenăm bordura
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1);
            }

            // Desenăm textul (centrat)
            TextRenderer.DrawText(e.Graphics, e.ToolTipText, e.Font, e.Bounds, textColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }
    }
}