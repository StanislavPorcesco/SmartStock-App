using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            // Apply the current theme to this form
            ThemeManager.Apply(this);
            // Subscribe to theme changes to update this form when the theme changes
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
