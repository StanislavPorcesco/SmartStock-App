using SmartStock.Classes.Utils;

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
