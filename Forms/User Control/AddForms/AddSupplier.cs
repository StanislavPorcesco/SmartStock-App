using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddSupplier : UserControl
    {
        public AddSupplier()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);

            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
