using SmartStock.Classes.Utils;

namespace SmartStock.Forms.AddForms
{
    public partial class ModifyCategory : UserControl
    {
        public ModifyCategory()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
