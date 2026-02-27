namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            settings_lbl = new Label();
            panel2 = new Panel();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            panel4 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(529, 582);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(panel4, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(529, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.CheckAlign = ContentAlignment.MiddleRight;
            checkBox3.ImageAlign = ContentAlignment.MiddleRight;
            checkBox3.Location = new Point(264, 10);
            checkBox3.Margin = new Padding(0, 10, 10, 10);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(255, 17);
            checkBox3.TabIndex = 28;
            checkBox3.TextAlign = ContentAlignment.MiddleRight;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.ImageAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(264, 141);
            checkBox2.Margin = new Padding(0, 10, 10, 10);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(255, 17);
            checkBox2.TabIndex = 26;
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 131);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(195, 37);
            label7.TabIndex = 25;
            label7.Text = "Total Inventory Value";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 37);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            tableLayoutPanel1.SetRowSpan(label6, 2);
            label6.Size = new Size(194, 94);
            label6.TabIndex = 24;
            label6.Text = "Product Count Range";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings_lbl
            // 
            settings_lbl.AutoSize = true;
            settings_lbl.Dock = DockStyle.Left;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.ForeColor = Color.White;
            settings_lbl.Location = new Point(10, 0);
            settings_lbl.Margin = new Padding(10, 0, 3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(142, 37);
            settings_lbl.TabIndex = 8;
            settings_lbl.Text = "Active/Inactive";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 47);
            panel2.Margin = new Padding(0, 10, 10, 10);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 27);
            panel2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 21;
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Right;
            numericUpDown1.Location = new Point(127, 0);
            numericUpDown1.Margin = new Padding(0, 10, 0, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(128, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(numericUpDown2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(264, 94);
            panel3.Margin = new Padding(0, 10, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 27);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 22;
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Right;
            numericUpDown2.Location = new Point(127, 0);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(128, 27);
            numericUpDown2.TabIndex = 0;
            // 
            // panel4
            // 
            tableLayoutPanel1.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 499);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 10, 0);
            panel4.Size = new Size(523, 70);
            panel4.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 54, 54);
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 0);
            button1.Margin = new Padding(10, 0, 0, 0);
            button1.MaximumSize = new Size(0, 70);
            button1.MinimumSize = new Size(0, 70);
            button1.Name = "button1";
            button1.Size = new Size(503, 70);
            button1.TabIndex = 17;
            button1.Text = "Reset Filters";
            button1.UseVisualStyleBackColor = false;
            // 
            // FilterCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterCategories";
            Size = new Size(529, 582);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label settings_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Panel panel3;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox2;
        private Label label7;
        private Panel panel4;
        private Button button1;
        private CheckBox checkBox3;
    }
}
