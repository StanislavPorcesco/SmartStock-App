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
            /*DataLayer.PopulateSelector(selector_cb);
            selector_cb.Text = "Select an option";*/
        }

        /*void SelectorIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = selector_cb.SelectedItem as string;
            if (selectedOption == null) return;
            base_pnl.Controls.Clear();

            UserControl controlToOpen = selectedOption switch
            {
                "Product" => new AddProduct(),
                "Category" => new AddCategory(),
                "Supplier" => new AddSupplier(),
                "Transaction" => new AddTransaction(),
                "Customer" => new AddCustomer(),
                "Sale" => new AddSale(),
                "ExternalFactor" => new AddExternalFactor()
            };

            if (controlToOpen != null)
            {
                controlToOpen.Dock = DockStyle.Fill;
                base_pnl.Controls.Add(controlToOpen);
                ThemeManager.Apply(controlToOpen);
            }
        }*/

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
