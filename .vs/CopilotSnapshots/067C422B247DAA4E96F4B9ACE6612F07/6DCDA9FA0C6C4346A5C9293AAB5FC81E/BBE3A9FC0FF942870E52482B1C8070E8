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
    public partial class FilterCustomers : UserControl
    {
        public FilterCustomers()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(search_lbl, "Searches for specific clients or companies by their registered name or phone number.");
            ToolTipHelp.AddToolTip(type_lbl, "Categorizes clients into groups such as Retail, Wholesale, or VIP for targeted analysis.");
            ToolTipHelp.AddToolTip(date_lbl, "Filters customers by their registration or first purchase date.");
            ToolTipHelp.AddToolTip(dead_lbl, "Identifies products with zero sales or movement during the last X days.");
            ToolTipHelp.AddToolTip(total_lbl, "Filters customers based on their lifetime purchase value to identify high-revenue accounts.");
            ToolTipHelp.AddToolTip(city_lbl, "Segments the customer base by geographical location to analyze regional market demand.");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
