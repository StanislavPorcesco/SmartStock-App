using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifySale : UserControl
    {
        public ModifySale()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
