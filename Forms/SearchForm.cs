using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms;
using SmartStock.Forms.User_Control.SearchForms;


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
            ThemeManager.Apply(this);
            string selectedOption = selector_cb.SelectedItem as string;
            if (selectedOption == null) return;

            if (selectedOption == "User" && (SessionManager.CurrentUser == null || SessionManager.CurrentUser.Role != "Admin"))
            {
                MessageBox.Show("Unauthorized access! Only administrators can manage user accounts.",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            filters_pnl.SuspendLayout();
            filters_pnl.Controls.Clear();

            UserControl controlToOpen = null;

            try
            {
                using (var db = new SmartStockContext())
                {
                    // Resetăm sursa de date a Grid-ului înainte de noua încărcare
                    main_dgv.DataSource = null;

                    switch (selectedOption)
                    {
                        case "Product":
                            controlToOpen = new FilterProducts();
                            //main_dgv.DataSource = db.Products.AsNoTracking().ToList();
                            main_dgv.DataSource = db.Products.Include(p => p.Category)
                                                             .Include(p => p.Supplier)
                                                             .AsNoTracking()
                                                             .ToList();
                            break;
                        case "Category":
                            controlToOpen = new FilterCategories();
                            main_dgv.DataSource = Category.GetAllCategories();
                            break;
                        case "Supplier":
                            controlToOpen = new FilterSuppliers();
                            main_dgv.DataSource = db.Suppliers.AsNoTracking().ToList();
                            break;
                        case "Transaction":
                            controlToOpen = new FilterTransactions();
                            main_dgv.DataSource = db.Transactions.AsNoTracking().ToList();
                            break;
                        case "Customer":
                            controlToOpen = new FilterCustomers();
                            main_dgv.DataSource = db.Customers.AsNoTracking().ToList();
                            break;
                        case "Sale":
                            controlToOpen = new FilterSales();
                            main_dgv.DataSource = db.Sales.AsNoTracking().ToList();
                            break;
                        case "ExternalFactor":
                            controlToOpen = new FilterFactors();
                            main_dgv.DataSource = db.ExternalFactors.AsNoTracking().ToList();
                            break;
                        case "User":
                            controlToOpen = new FilterUsers();
                            main_dgv.DataSource = db.Users.AsNoTracking().ToList();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (controlToOpen != null)
            {
                controlToOpen.Dock = DockStyle.Fill;
                filters_pnl.Controls.Add(controlToOpen);
                ThemeManager.Apply(controlToOpen);
            }

            filters_pnl.ResumeLayout(true);
        }
        private void main_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Siguranță: Validăm rândul și obiectul de date
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var dgv = (DataGridView)sender;
            var boundItem = dgv.Rows[e.RowIndex].DataBoundItem;
            if (boundItem == null) return;

            // 2. Identificăm proprietatea din clasa Model
            var column = dgv.Columns[e.ColumnIndex];
            string dataPropName = column.DataPropertyName;
            if (string.IsNullOrEmpty(dataPropName)) return;

            var propInfo = boundItem.GetType().GetProperty(dataPropName);
            if (propInfo == null) return;

            Type propType = propInfo.PropertyType;

            // --- CAZUL 1: RELAȚIE 1:M (Colecții - Ex: Category.Products) ---
            if (typeof(System.Collections.IEnumerable).IsAssignableFrom(propType) && propType != typeof(string))
            {
                e.Value = "See more";
                e.FormattingApplied = true;

                // Stilizare Link
                e.CellStyle.ForeColor = ThemeManager.GetCurrentPalette().Text;
                e.CellStyle.Font = new Font(dgv.Font, FontStyle.Underline);

                // Redenumim Header-ul dacă este cazul
                if (column.HeaderText == dataPropName) column.HeaderText = "Linked " + dataPropName;
                ThemeManager.Apply(dgv);
            }
            // --- CAZUL 2: RELAȚIE M:1 / 1:1 (Obiecte - Ex: Product.Category) ---
            else if (propType.IsClass && propType != typeof(string))
            {
                // Preluăm obiectul de navigare (ex: instanța de Category sau Supplier)
                var relatedObj = propInfo.GetValue(boundItem);

                if (relatedObj != null)
                {
                    // Căutăm automat o proprietate care conține "Name" sau "Username" [cite: 1, 11, 15]
                    var nameProp = relatedObj.GetType().GetProperties()
                        .FirstOrDefault(p => p.Name.Contains("Name") || p.Name.Contains("Username"));

                    if (nameProp != null)
                    {
                        e.Value = nameProp.GetValue(relatedObj);
                        e.FormattingApplied = true;

                        // Actualizăm Header-ul pentru a fi mai explicit (ex: "Category Name")
                        if (column.HeaderText == dataPropName)
                        {
                            column.HeaderText = dataPropName + "Name";
                            ThemeManager.Apply(dgv);
                        }
                    }
                }
                else
                {
                    // Dacă obiectul este null, înseamnă că lipsește .Include() în interogare
                    e.Value = "Not Loaded";
                }
            }
            ThemeManager.Apply(dgv);
        }
        private void main_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string selectedType = selector_cb.SelectedItem?.ToString();
            string columnName = main_dgv.Columns[e.ColumnIndex].Name;
            var boundItem = main_dgv.Rows[e.RowIndex].DataBoundItem;

            if (boundItem == null) return;

            object detailsList = null;
            string popupTitle = "";
            switch (selectedType)
            {
                case "Category" when columnName == "Products":
                    var cat = (Category)boundItem;
                    detailsList = cat.GetRelatedProducts();
                    popupTitle = $"Products in {cat.CategoryName}";
                    break;

                case "Supplier" when columnName == "Products":
                    var sup = (Supplier)boundItem;
                    detailsList = sup.GetRelatedProducts();
                    popupTitle = $"Products supplied by {sup.SupplierName}";
                    break;
                case "Sale" when columnName == "SaleDetails":
                    var sale = (Sale)boundItem;
                    detailsList = sale.GetRelatedDetails();
                    popupTitle = $"Items in Sale #{sale.SaleId}";
                    break;
                case "Customer" when columnName == "Sales":
                    var cust = (Customer)boundItem;
                    detailsList = cust.GetCustomerSales();
                    popupTitle = $"Transactions for {cust.FullName}";
                    break;
            }

            if (detailsList != null)
            {
                OpenDetailsPopup(detailsList, popupTitle);
            }
        }
        private void OpenDetailsPopup(object data, string title)
        {
            var list = (System.Collections.IList)data;
            if (list.Count > 0)
            {
                using (var detailsForm = new DetailsPopupForm(data, title))
                {
                    detailsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No records found for this selection.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
