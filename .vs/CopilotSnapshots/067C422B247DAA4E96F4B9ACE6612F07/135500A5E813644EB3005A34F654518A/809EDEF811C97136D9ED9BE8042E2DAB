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
    public partial class FilterUsers : UserControl
    {
        public FilterUsers()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Refresh();
            ToolTipHelp.AddToolTip(status_lbl, "Filters to show only categories that currently contain active, in-stock items.");
            ToolTipHelp.AddToolTip(range_lbl, "Filters categories based on the number of individual products they contain.");
            ToolTipHelp.AddToolTip(total_lbl, "Displays categories whose total stock value falls within the specified monetary range.");
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
