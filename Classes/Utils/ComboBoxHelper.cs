using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Utils
{
    public static class ComboBoxHelper
    {
        /// <summary>
        /// Activează filtrarea de tip "Contains" pentru orice ComboBox.
        /// </summary>
        /// <typeparam name="T">Tipul de date din listă (Product, Category, etc.)</typeparam>
        /// <param name="cb">Controlul ComboBox</param>
        /// <param name="fullList">Lista completă de date (sursa originală)</param>
        /// <param name="displaySelector">Funcție care extrage string-ul de afișat (ex: p => p.ProductName)</param>
        public static void EnableFilterSearch<T>(ComboBox cb, List<T> fullList, Func<T, string> displaySelector)
        {
            // Setăm proprietățile de bază pentru a permite scrierea
            cb.DropDownStyle = ComboBoxStyle.DropDown;

            cb.TextUpdate += (sender, e) =>
            {
                string filterText = cb.Text;

                // Suspendăm Layout-ul pentru a evita pâlpâirea listei
                cb.BeginUpdate();
                cb.Items.Clear();

                if (string.IsNullOrWhiteSpace(filterText))
                {
                    cb.Items.AddRange(fullList.Cast<object>().ToArray());
                }
                else
                {
                    var filteredItems = fullList
                        .Where(item => displaySelector(item)
                            .ToLower()
                            .Contains(filterText.ToLower()))
                        .Cast<object>()
                        .ToArray();

                    cb.Items.AddRange(filteredItems);
                }

                // Redeschidem lista și păstrăm cursorul
                cb.DroppedDown = true;
                cb.EndUpdate();

                cb.SelectionStart = filterText.Length;
                cb.SelectionLength = 0;
                Cursor.Current = Cursors.Default;
            };
        }
        public static void DisableMouseWheelScroll(this ComboBox cb)
        {
            cb.MouseWheel += (s, e) =>
            {
                // Dacă utilizatorul doar trece cu mouse-ul peste el (fără să deschidă lista)
                if (!cb.DroppedDown)
                {
                    // „Consumăm” evenimentul ca să nu ajungă la logica internă de schimbare a indexului
                    ((HandledMouseEventArgs)e).Handled = true;
                }
            };
        }
    }
}
