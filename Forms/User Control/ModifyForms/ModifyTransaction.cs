using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyTransaction : UserControl
    {
        public ModifyTransaction()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            // Wire up the ComboBox event handler here (not in Designer)
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
