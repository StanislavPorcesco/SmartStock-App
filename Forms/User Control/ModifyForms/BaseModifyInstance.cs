using SmartStock.Classes.Utils;

namespace SmartStock
{
    public partial class BaseModifyInstance : Form
    {
        public BaseModifyInstance()
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
