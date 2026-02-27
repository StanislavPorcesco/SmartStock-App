using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control.SearchForms;
using System.ComponentModel;
using System.Xml.Linq;

namespace SmartStock
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.setRightIndex(selector_cb);
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void selector_cb_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string selectedOption = selector_cb.SelectedItem as string;
            if (selectedOption == null) return;
            filters_pnl.SuspendLayout();
            filters_pnl.Controls.Clear();
            UserControl controlToOpen = selectedOption switch
            {
                "Product" => new FilterProducts(),
                "Category" => new FilterCategories(),
                "Supplier" => new FilterSuppliers(),
                "Transaction" => new FilterTransactions(),
                "Customer" => new FilterCustomers(),
                "Sale" => new FilterSales(),
                "ExternalFactor" => new FilterFactors()
            };
            if (controlToOpen != null)
            {
                controlToOpen.Dock = DockStyle.Fill;
                filters_pnl.Controls.Add(controlToOpen);
                ThemeManager.Apply(controlToOpen);
            }

            filters_pnl.ResumeLayout(true);
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
