using SmartStock.Classes.Utils;
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
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
