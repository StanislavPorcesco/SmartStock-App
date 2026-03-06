using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(category_id_tb.Text, out int catId))
            {
                MessageBox.Show("Please enter a valid Category ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var category = db.Categories.AsNoTracking().FirstOrDefault(c => c.CategoryId == catId);
                    if (category != null)
                    {
                        category_name_tb.Text = category.CategoryName;
                        if (category.IsActive)
                        {
                            category_id_tb.BackColor = Color.DarkGreen;
                            category_id_tb.ForeColor = Color.White;
                        }
                        else
                        {
                            category_id_tb.BackColor = Color.DarkOrange;
                            category_id_tb.ForeColor = Color.White;
                            MessageBox.Show("This category is currently inactive (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        category_id_tb.BackColor = Color.DarkRed;
                        category_id_tb.ForeColor = Color.White;
                        MessageBox.Show("Category ID not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        category_id_tb.Clear();
                        ThemeManager.Apply(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(category_id_tb.Text, out int catId)) return;
            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this category? Historical data will be preserved.",
                                                 "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var category = db.Categories.FirstOrDefault(c => c.CategoryId == catId);

                        if (category != null)
                        {
                            category.IsActive = false;
                            db.SaveChanges();
                            MessageBox.Show("Category has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            category_id_tb.Clear();
                            category_name_tb.Clear();
                            ThemeManager.Apply(this);
                        }
                        else
                        {
                            MessageBox.Show("Category not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            category_id_tb.Clear();
                            category_name_tb.Clear();
                            ThemeManager.Apply(this);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(category_id_tb.Text, out int catId) || string.IsNullOrWhiteSpace(category_name_tb.Text))
            {
                MessageBox.Show("Please select a category and enter a new name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var category = db.Categories.FirstOrDefault(c => c.CategoryId == catId);
                    if (category != null)
                    {
                        category.CategoryName = category_name_tb.Text.Trim();
                        db.SaveChanges();
                        category_id_tb.Clear();
                        category_name_tb.Clear();
                        ThemeManager.Apply(this);
                        MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Category not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
