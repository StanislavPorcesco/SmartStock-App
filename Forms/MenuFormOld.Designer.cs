using SmartStock.Classes.Utils;
namespace SmartStock.Forms
{
    partial class MenuFormOld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu_pnl = new Panel();
            logo_pnl = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menu_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // menu_pnl
            // 
            menu_pnl.BackColor = Color.FromArgb(54, 54, 54);
            menu_pnl.Controls.Add(iconButton1);
            menu_pnl.Controls.Add(logo_pnl);
            menu_pnl.Dock = DockStyle.Left;
            menu_pnl.Location = new Point(0, 0);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(525, 770);
            menu_pnl.TabIndex = 0;
            // 
            // logo_pnl
            // 
            logo_pnl.Dock = DockStyle.Top;
            logo_pnl.Location = new Point(0, 0);
            logo_pnl.Name = "logo_pnl";
            logo_pnl.Size = new Size(525, 105);
            logo_pnl.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(56, 164);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(336, 86);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 770);
            Controls.Add(menu_pnl);
            Name = "MenuForm";
            Text = "MenuForm";
            menu_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel menu_pnl;
        private Panel logo_pnl;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}