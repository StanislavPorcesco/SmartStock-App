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
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
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
            tableLayoutPanel1.Controls.Add(textBox1, 1, 6);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 288);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(161, 51);
            label7.TabIndex = 25;
            label7.Text = "Product Inclusion";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 194);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            tableLayoutPanel1.SetRowSpan(label6, 2);
            label6.Size = new Size(187, 94);
            label6.TabIndex = 24;
            label6.Text = "Total Amount Range";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 141);
            label3.Margin = new Padding(10, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 53);
            label3.TabIndex = 20;
            label3.Text = "Payment Status/Method";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 88);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 53);
            label2.TabIndex = 18;
            label2.Text = "Customer Search";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 37);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 51);
            label1.TabIndex = 16;
            label1.Text = "Supplier";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            settings_lbl.Size = new Size(111, 37);
            settings_lbl.TabIndex = 8;
            settings_lbl.Text = "Date Range";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
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
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Label settings_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Panel panel3;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private Panel panel4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox category_cb;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}
