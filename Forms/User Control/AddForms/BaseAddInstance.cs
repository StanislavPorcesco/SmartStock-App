using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;

namespace SmartStock
{
    public partial class BaseAddInstance : Form
    {
        public BaseAddInstance()
        {
            InitializeComponent();
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
