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
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            DataLayer.OpenUserControl(this, new Login());
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
