namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterSales
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            category_cb = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            inclusion_lbl = new Label();
            total_range_lbl = new Label();
            payment_lbl = new Label();
            customer_lbl = new Label();
            textBox2 = new TextBox();
            supplier_lbl = new Label();
            range_lbl = new Label();
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
            tableLayoutPanel1.Controls.Add(textBox1, 1, 6);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(inclusion_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(total_range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(payment_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(customer_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 0);
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(54, 54, 54);
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(264, 298);
            textBox1.Margin = new Padding(0, 10, 10, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 31);
            textBox1.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(54, 54, 54);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(264, 151);
            comboBox1.Margin = new Padding(0, 10, 10, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 33);
            comboBox1.TabIndex = 31;
            // 
            // category_cb
            // 
            category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_cb.BackColor = Color.FromArgb(54, 54, 54);
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_cb.ForeColor = Color.White;
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(264, 98);
            category_cb.Margin = new Padding(0, 10, 10, 10);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(255, 33);
            category_cb.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(267, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 31);
            dateTimePicker1.TabIndex = 29;
            // 
            // inclusion_lbl
            // 
            inclusion_lbl.AutoSize = true;
            inclusion_lbl.Dock = DockStyle.Left;
            inclusion_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            inclusion_lbl.ForeColor = Color.White;
            inclusion_lbl.Location = new Point(10, 288);
            inclusion_lbl.Margin = new Padding(10, 0, 3, 0);
            inclusion_lbl.Name = "inclusion_lbl";
            inclusion_lbl.Size = new Size(161, 51);
            inclusion_lbl.TabIndex = 25;
            inclusion_lbl.Text = "Product Inclusion";
            inclusion_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_range_lbl
            // 
            total_range_lbl.AutoSize = true;
            total_range_lbl.Dock = DockStyle.Left;
            total_range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_range_lbl.ForeColor = Color.White;
            total_range_lbl.Location = new Point(10, 194);
            total_range_lbl.Margin = new Padding(10, 0, 3, 0);
            total_range_lbl.Name = "total_range_lbl";
            tableLayoutPanel1.SetRowSpan(total_range_lbl, 2);
            total_range_lbl.Size = new Size(187, 94);
            total_range_lbl.TabIndex = 24;
            total_range_lbl.Text = "Total Amount Range";
            total_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_lbl
            // 
            payment_lbl.AutoSize = true;
            payment_lbl.Dock = DockStyle.Left;
            payment_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_lbl.ForeColor = Color.White;
            payment_lbl.Location = new Point(10, 141);
            payment_lbl.Margin = new Padding(10, 0, 3, 0);
            payment_lbl.Name = "payment_lbl";
            payment_lbl.Size = new Size(220, 53);
            payment_lbl.TabIndex = 20;
            payment_lbl.Text = "Payment Status/Method";
            payment_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_lbl
            // 
            customer_lbl.AutoSize = true;
            customer_lbl.Dock = DockStyle.Left;
            customer_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_lbl.ForeColor = Color.White;
            customer_lbl.Location = new Point(10, 88);
            customer_lbl.Margin = new Padding(10, 0, 3, 0);
            customer_lbl.Name = "customer_lbl";
            customer_lbl.Size = new Size(155, 53);
            customer_lbl.TabIndex = 18;
            customer_lbl.Text = "Customer Search";
            customer_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(54, 54, 54);
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(264, 47);
            textBox2.Margin = new Padding(0, 10, 10, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 31);
            textBox2.TabIndex = 17;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Left;
            supplier_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_lbl.ForeColor = Color.White;
            supplier_lbl.Location = new Point(10, 37);
            supplier_lbl.Margin = new Padding(10, 0, 3, 0);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(82, 51);
            supplier_lbl.TabIndex = 16;
            supplier_lbl.Text = "Supplier";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 0);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(111, 37);
            range_lbl.TabIndex = 8;
            range_lbl.Text = "Date Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 204);
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
            panel3.Location = new Point(264, 251);
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
            // FilterSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterSales";
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
        private Label total_range_lbl;
        private Label payment_lbl;
        private Label customer_lbl;
        private TextBox textBox2;
        private Label supplier_lbl;
        private Label range_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Panel panel3;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private Label inclusion_lbl;
        private Panel panel4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox category_cb;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}
