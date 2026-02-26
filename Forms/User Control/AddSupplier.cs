using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms.User_Control
{
    public partial class AddSupplier : UserControl
    {
        public AddSupplier()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
            selector_cb.Text = "Select an option";
        }
        void SelectorIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = selector_cb.SelectedItem as string;
            if (selectedOption == null) return;

            // Curățăm panoul de controlul anterior pentru a elibera memoria
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
        }
    }
}
