using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.AddForms
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată CategoryService.
    /// </summary>
    public partial class ModifyCategory : UserControl, ISaveableControl
    {
        private CategoryService _categoryService;
        private int _currentCategoryId;

        public ModifyCategory()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Category>(new SmartStockContext());
            _categoryService = new CategoryService(repository);
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!FormValidator.RequireId(category_id_tb.Text, "Category ID", out int catId)) return;

            SearchAndLoadCategory(catId);
        }

        /// <summary>
        /// Caută și încarcă categoria.
        /// </summary>
        private async void SearchAndLoadCategory(int categoryId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var category = await _categoryService.GetByIdAsync(categoryId);

                if (category != null)
                {
                    _currentCategoryId = category.CategoryId;
                    DisplayCategoryData(category);
                }
                else
                {
                    category_id_tb.BackColor = Color.DarkRed;
                    category_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Category not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Afișează datele categoriei în controale.
        /// </summary>
        private void DisplayCategoryData(Category category)
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
                MessageBox.Show("This category is currently inactive (Soft Deleted).", "Information", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Colectează datele din controale.
        /// </summary>
        private bool TryCollectCategoryData(out Category category)
        {
            category = null;

            if (!FormValidator.RequireText(category_name_tb.Text, "Category Name")) return false;

            category = new Category
            {
                CategoryName = category_name_tb.Text.Trim(),
                IsActive = true
            };

            return true;
        }

        /// <summary>
        /// Actualizează categoria în baza de date.
        /// </summary>
        public async Task<SaveOutcome> PerformSave(bool isAddMode)
        {
            if (!TryCollectCategoryData(out var category)) return SaveOutcome.Handled;

            try
            {
                bool ok = isAddMode
                    ? await _categoryService.AddCategoryAsync(category)
                    : await _categoryService.UpdateCategoryAsync(category);

                return ok ? SaveOutcome.Success : SaveOutcome.Failed;
            }
            catch (Exception ex)
            {
                FormValidator.ShowDbError(ex);
                return SaveOutcome.Handled;
            }
        }

        public async Task<bool> PerformArchive(int id)
        {
            bool success = false;
            string message = string.Empty;
            try
            {
                Cursor = Cursors.WaitCursor;

                (success, message) = await _categoryService.DeactivateCategoryAsync(id);

                if (success)
                {
                    MessageBox.Show(message, "Category Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControls();
                    return success;
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return success;
        }
        public void UpdateUIState(bool isAddMode)
        {
            var searchButton = this.Controls.Find("search_btn", true).FirstOrDefault();
            var idTextBox = this.Controls.Find("category_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox != null) idTextBox.Enabled = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            if (int.TryParse(category_id_tb.Text, out int id))
            {
                return id;
            }
            return -1;
        }

        public void ClearControls()
        {
            category_id_tb.Clear();
            category_name_tb.Clear();
            ThemeManager.Apply(this);
        }

        public void LoadById(int id)
        {
            category_id_tb.Text = id.ToString();
            SearchAndLoadCategory(id);
        }
    }
}