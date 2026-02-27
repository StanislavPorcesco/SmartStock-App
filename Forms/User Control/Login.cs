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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new AddAccount());
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Settings());
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            MenuForm mainForm = new MenuForm();
            mainForm.ShowDialog();
            this.FindForm().Close();
        }
    }
}
