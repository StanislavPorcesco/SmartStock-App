using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddSale : UserControl
    {
        public AddSale()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
