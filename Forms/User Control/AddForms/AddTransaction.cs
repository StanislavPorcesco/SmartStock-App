using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddTransaction : UserControl
    {
        public AddTransaction()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            // Wire up the ComboBox event handler here (not in Designer)
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
