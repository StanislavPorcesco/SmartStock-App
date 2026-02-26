using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;

namespace SmartStock
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //ThemeManager.OnThemeChanged += HandleThemeUpdate;
            this.Load += (s, e) => {
                this.SuspendLayout();
                this.PerformLayout();
                this.ResumeLayout();
            };
        }


        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
