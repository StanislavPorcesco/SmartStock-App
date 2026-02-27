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
    public partial class FilterSales : UserControl
    {
        public FilterSales()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(range_lbl, "Filters sales records between two specific dates to analyze daily, weekly, or monthly performance.");
            ToolTipHelp.AddToolTip(supplier_lbl, "Filters the list to show only transactions associated with a specific vendor or company.");
            ToolTipHelp.AddToolTip(customer_lbl, "Displays all sales transactions associated with a specific client or business entity.");
            ToolTipHelp.AddToolTip(payment_lbl, "Categorizes sales by how they were settled, such as Cash, Credit Card, or Bank Transfer.");
            ToolTipHelp.AddToolTip(total_range_lbl, "Filters transactions based on their total value to identify high-volume sales or small retail orders.");
            ToolTipHelp.AddToolTip(inclusion_lbl, "Finds all sales receipts that contain a specific item, useful for tracking product popularity.");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
