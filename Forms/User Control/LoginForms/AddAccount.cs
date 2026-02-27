using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms.AddForms
{
    public partial class AddAccount : UserControl
    {
        public AddAccount()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Login());
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string code = EmailService.SendVerificationCode(email_tb.Text);
            DataLayer.OpenUserControl(this.FindForm(), new MailConfirmation());
        }
    }
}
