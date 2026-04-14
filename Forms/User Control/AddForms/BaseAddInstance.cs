using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;
using SmartStock.Forms.User_Control.SearchForms;

namespace SmartStock
{
    public partial class BaseAddInstance : Form
    {
        UserControl controlToOpen = null;
        public BaseAddInstance()
        {
            InitializeComponent();
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            DataLayer.PopulateSelector(selector_cb);
            action_cb.Items.AddRange(new object[] { "Add Instance", "Modify Instance" });
            action_cb.SelectedIndex = 0;
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void selector_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = selector_cb.SelectedItem as string;
            usercontrol_pnl.SuspendLayout();
            usercontrol_pnl.Controls.Clear();
           
            try
            {
                switch (selectedOption)
                {
                    case "Product":
                        controlToOpen = new ModifyProduct();
                        break;

                    case "Category":
                        controlToOpen = new ModifyCategory();
                        break;

                    case "Supplier":
                        controlToOpen = new ModifySupplier();
                        break;

                    case "Transaction":
                        controlToOpen = new ModifyTransaction();
                        break;

                    case "Customer":
                        controlToOpen = new ModifyCustomer();
                        break;

                    case "Sale":
                        controlToOpen = new ModifySale();
                        break;

                    case "ExternalFactor":
                        controlToOpen = new ModifyExternalFactor();
                        break;

                    case "User":
                        controlToOpen = new ModifyUser();
                        break;
                }
                if (controlToOpen != null)
                {
                    controlToOpen.Dock = DockStyle.Fill;
                    usercontrol_pnl.Controls.Add(controlToOpen);

                    ThemeManager.Apply(controlToOpen);
                    SyncActionState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                usercontrol_pnl.ResumeLayout(true);
            }
        }

        private async void archive_btn_Click(object sender, EventArgs e)
        {
            // 1. Verificăm dacă suntem în modul "Modify" (nu poți arhiva un produs care nu există încă)
            bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";
            if (isAddMode) return;

            if (controlToOpen is ISaveableControl saveable)
            {
                // 2. Obținem ID-ul de la controlul copil
                int idToArchive = saveable.GetCurrentId();

                if (idToArchive <= 0)
                {
                    MessageBox.Show("Please select a valid record first (use Search).", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to archive this record?",
                                             "Confirm Archive",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    archive_btn.Enabled = false; // Prevenim dublu-click

                    bool success = await saveable.PerformArchive(idToArchive);

                    // Notă: MessageBox-ul de succes e deja în controlul tău copil, 
                    // deci aici doar reactivăm butonul.

                    archive_btn.Enabled = true;
                }
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (controlToOpen is ISaveableControl saveable)
            {
                bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";

                // Dezactivăm butonul temporar pentru a evita click-uri multiple
                save_btn.Enabled = false;

                bool success = await saveable.PerformSave(isAddMode);

                if (success)
                {
                    MessageBox.Show("Instance added successfully to inventory!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveable.ClearControls();
                }
                else
                {
                    MessageBox.Show("Failed to add instance.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                save_btn.Enabled = true;
            }
        }

        private void action_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncActionState();
        }

        private void SyncActionState()
        {
            if (controlToOpen is ISaveableControl control)
            {
                bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";
                control.UpdateUIState(isAddMode);
                archive_btn.Enabled = !isAddMode;
                ThemeManager.Apply(controlToOpen);
            }
        }
    }
}
