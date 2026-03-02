using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifySupplier : UserControl
    {
        public ModifySupplier()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);

            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
