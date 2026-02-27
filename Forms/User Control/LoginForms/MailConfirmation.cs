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
    public partial class MailConfirmation : UserControl
    {
        public MailConfirmation()
        {
            InitializeComponent();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new AddAccount());
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Settings());
        }
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTb = sender as TextBox;

            // Verificăm dacă s-a introdus un caracter
            if (currentTb != null && currentTb.Text.Length > 0)
            {
                // Selectăm automat următorul control în ordinea TabIndex
                //this.SelectNextControl(currentTb, true, true, false, false);
                SendKeys.Send("{TAB}");
            }
        }
        private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTb = sender as TextBox;

            // 1. Logica pentru BackSpace (Salt înapoi)
            if (e.KeyCode == Keys.Back && currentTb.Text.Length == 0)
            {
                SendKeys.Send("+{TAB}");
                e.Handled = true;
            }

            // 2. Logica pentru PASTE (Ctrl + V)
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Dezactivăm acțiunea default de paste a Windows-ului
                e.SuppressKeyPress = true;

                string clipboardText = Clipboard.GetText().Trim();
                // Păstrăm doar cifrele folosind Regex
                string digitsOnly = System.Text.RegularExpressions.Regex.Replace(clipboardText, @"[^\d]", "");

                if (digitsOnly.Length >= 6)
                {
                    // IMPORTANT: Asigură-te că numele acestor controale coincid cu cele din Designer-ul tău
                    TextBox[] boxes = { textBox0, textBox1, textBox2, textBox3, textBox4, textBox5 };

                    for (int i = 0; i < 6; i++)
                    {
                        boxes[i].Text = digitsOnly[i].ToString();
                    }

                    // Mutăm focusul pe ultima căsuță pentru a finaliza experiența UX
                    boxes[5].Focus();

                    // Opțional: Poți apela aici automat funcția de confirmare
                    // btnConfirm_Click(null, null);
                }
            }
        }
    }
}
