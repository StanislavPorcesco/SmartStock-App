using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Utils
{
    public enum PaddingSide { Left, Top, Right, Bottom }

    public static class UIHelper
    {
        /// <summary>
        /// Verifică dacă UserControl-ul depășește dimensiunea părintelui și aplică padding unui control țintă.
        /// </summary>
        /// <param name="uc">UserControl-ul care este verificat pentru scroll</param>
        /// <param name="target">Controlul (Panel/TableLayout) căruia i se modifică padding-ul</param>
        /// <param name="side">Latura pe care se aplică padding-ul</param>
        /// <param name="value">Valoarea padding-ului dacă apare scroll-ul</param>
        public static void SyncScrollPadding(this UserControl uc, Control target, PaddingSide side, int value)
        {
            // 1. Gărzi de siguranță: fără părinte sau handle, nu avem ce măsura
            if (uc == null || target == null || uc.Parent == null || !uc.IsHandleCreated) return;

            uc.PerformLayout();

            // 2. Calculăm dacă UC-ul „vrea” să fie mai mare decât Părintele său
            // uc.PreferredSize = dimensiunea dorită de conținut
            // uc.Parent.ClientSize = spațiul real disponibil în SearchForm (panel-ul de filtre)
            bool needsScroll = uc.PreferredSize.Height > uc.Parent.ClientSize.Height;

            int finalPadding = needsScroll ? value : 0;
            Padding p = target.Padding;

            // 3. Aplicăm padding-ul selectiv pe latura dorită
            switch (side)
            {
                case PaddingSide.Left:
                    target.Padding = new Padding(finalPadding, p.Top, p.Right, p.Bottom);
                    break;
                case PaddingSide.Top:
                    target.Padding = new Padding(p.Left, finalPadding, p.Right, p.Bottom);
                    break;
                case PaddingSide.Right:
                    target.Padding = new Padding(p.Left, p.Top, finalPadding, p.Bottom);
                    break;
                case PaddingSide.Bottom:
                    target.Padding = new Padding(p.Left, p.Top, p.Right, finalPadding);
                    break;
            }
        }
    }
}
