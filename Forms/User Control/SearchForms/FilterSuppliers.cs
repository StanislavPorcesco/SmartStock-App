using SmartStock.Classes.Utils;
using SmartStock.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms.User_Control.SearchForms
{
    public partial class FilterSuppliers : UserControl
    {
        public FilterSuppliers()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(supplier_lbl, "Filters the list to show only products or transactions associated with a specific vendor or company.");
            ToolTipHelp.AddToolTip(contact_lbl, "Displays suppliers based on the primary contact person's name for easier communication.");
            ToolTipHelp.AddToolTip(categories_lbl, "Filters suppliers according to the specific types of products they provide (e.g., Electronics, Perishables).");
            ToolTipHelp.AddToolTip(range_lbl, "Filters vendors based on the total quantity of items they have delivered within the selected period.\"");
            ToolTipHelp.AddToolTip(status_lbl, "Shows partners with whom you have an active contract or ongoing business relationship.");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
