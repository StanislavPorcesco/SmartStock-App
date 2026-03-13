using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock.Forms
{
    public partial class DetailsPopupForm : Form
    {
        public DetailsPopupForm(object dataSource, string title)
        {
            InitializeComponent();
            this.Text = $"Details: {title}";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 600;
            this.Height = 400;

            LoadData(dataSource);
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
        }
        private void LoadData(object dataSource)
        {
            details_dgv.DataSource = dataSource;
            details_dgv.ReadOnly = true;
            details_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            details_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            details_dgv.AllowUserToAddRows = false;

            // Ascundem automat coloanele de navigare (obiectele complexe)
            foreach (DataGridViewColumn col in details_dgv.Columns)
            {
                // Daca tipul proprietatii este o clasa custom sau o colectie, o ascundem
                if (col.ValueType.IsClass && col.ValueType != typeof(string))
                {
                    col.Visible = false;
                }
            }

            // Aplicam tema aplicatiei
            ThemeManager.Apply(this);
        }
        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }
    }
}
