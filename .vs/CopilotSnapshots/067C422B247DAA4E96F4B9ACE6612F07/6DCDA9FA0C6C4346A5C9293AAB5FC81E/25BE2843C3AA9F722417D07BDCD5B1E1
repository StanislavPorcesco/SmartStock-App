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
    public partial class FilterTransactions : UserControl
    {
        public FilterTransactions()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(date_lbl, "Filters the movement history between two specific dates to track past stock activity.");
            ToolTipHelp.AddToolTip(type_lbl, "Categorizes movements into Stock In (Restocking), Stock Out (Sales), or Adjustments (Corrections).");
            ToolTipHelp.AddToolTip(user_lbl, "Filters records to show which staff member authorized or processed the transaction.");
            ToolTipHelp.AddToolTip(dead_lbl, "Identifies products with zero sales or movement during the last X days.");
            ToolTipHelp.AddToolTip(range_lbl, "Filters transactions by volume to identify large bulk movements or minor stock changes.");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
