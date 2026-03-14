using SmartStock.Classes.Models;
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            // 1. Validare: Numele categoriei nu poate fi gol
            string categoryName = category_name_tb.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                category_name_tb.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    bool exists = db.Categories.Any(c => c.CategoryName.ToLower() == categoryName.ToLower());

                    if (exists)
                    {
                        MessageBox.Show("This category already exists in the database.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Category newCategory = new Category
                    {
                        CategoryName = categoryName,
                        IsActive = true
                    };

                    db.Categories.Add(newCategory);
                    db.SaveChanges();

                    MessageBox.Show($"Category '{categoryName}' has been added successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    category_name_tb.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
