using SmartStock.Classes.Utils;

namespace SmartStock.Forms.AddForms
{
    public partial class AddCategory : UserControl
    {
        public AddCategory()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();           
        }
    }
}
