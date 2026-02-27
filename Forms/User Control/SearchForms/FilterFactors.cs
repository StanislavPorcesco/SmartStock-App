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
    public partial class FilterFactors : UserControl
    {
        public FilterFactors()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(type_lbl, "Categorizes external influences such as public holidays, weather conditions, or economic trends.");
            ToolTipHelp.AddToolTip(range_lbl, "Displays external events that occurred or are scheduled within a specific timeframe.");
            ToolTipHelp.AddToolTip(region_lbl, "Shows factors affecting specific warehouse locations or geographical market areas.");
            ToolTipHelp.AddToolTip(impact_lbl, "Filters factors based on their estimated strength of influence on sales (e.g., Low, Medium, High).");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
