namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterSuppliers
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
            category_cb = new ComboBox();
            textBox3 = new TextBox();
            checkBox2 = new CheckBox();
            status_lbl = new Label();
            range_lbl = new Label();
            categories_lbl = new Label();
            textBox2 = new TextBox();
            contact_lbl = new Label();
            supplier_lbl = new Label();
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
            tableLayoutPanel1.Controls.Add(category_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(categories_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(contact_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 0);
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
            // category_cb
            // 
            category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_cb.BackColor = Color.FromArgb(54, 54, 54);
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_cb.ForeColor = Color.White;
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(264, 112);
            category_cb.Margin = new Padding(0, 10, 10, 10);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(255, 33);
            category_cb.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(54, 54, 54);
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(264, 10);
            textBox3.Margin = new Padding(0, 10, 10, 10);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 31);
            textBox3.TabIndex = 28;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.ImageAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(264, 259);
            checkBox2.Margin = new Padding(0, 10, 10, 10);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(255, 17);
            checkBox2.TabIndex = 26;
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_lbl.ForeColor = Color.White;
            status_lbl.Location = new Point(10, 249);
            status_lbl.Margin = new Padding(10, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(124, 37);
            status_lbl.TabIndex = 25;
            status_lbl.Text = "Active Status";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 155);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(236, 94);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Supply Volume (Min/Max)";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // categories_lbl
            // 
            categories_lbl.AutoSize = true;
            categories_lbl.Dock = DockStyle.Left;
            categories_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            categories_lbl.ForeColor = Color.White;
            categories_lbl.Location = new Point(10, 102);
            categories_lbl.Margin = new Padding(10, 0, 3, 0);
            categories_lbl.Name = "categories_lbl";
            categories_lbl.Size = new Size(179, 53);
            categories_lbl.TabIndex = 18;
            categories_lbl.Text = "Product Categories Supplied";
            categories_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(54, 54, 54);
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(264, 61);
            textBox2.Margin = new Padding(0, 10, 10, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 31);
            textBox2.TabIndex = 17;
            // 
            // contact_lbl
            // 
            contact_lbl.AutoSize = true;
            contact_lbl.Dock = DockStyle.Left;
            contact_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            contact_lbl.ForeColor = Color.White;
            contact_lbl.Location = new Point(10, 51);
            contact_lbl.Margin = new Padding(10, 0, 3, 0);
            contact_lbl.Name = "contact_lbl";
            contact_lbl.Size = new Size(140, 51);
            contact_lbl.TabIndex = 16;
            contact_lbl.Text = "Contact Person";
            contact_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Left;
            supplier_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_lbl.ForeColor = Color.White;
            supplier_lbl.Location = new Point(10, 0);
            supplier_lbl.Margin = new Padding(10, 0, 3, 0);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(235, 51);
            supplier_lbl.TabIndex = 8;
            supplier_lbl.Text = "Supplier Name / Company";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 165);
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
            panel3.Location = new Point(264, 212);
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
            // FilterSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterSuppliers";
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
        private Label range_lbl;
        private Label categories_lbl;
        private Label contact_lbl;
        private Label supplier_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Panel panel3;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox2;
        private Label status_lbl;
        private Panel panel4;
        private Button button1;
        private TextBox textBox3;
        private ComboBox category_cb;
        private TextBox textBox2;
    }
}
