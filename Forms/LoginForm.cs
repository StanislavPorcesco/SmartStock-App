using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
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
