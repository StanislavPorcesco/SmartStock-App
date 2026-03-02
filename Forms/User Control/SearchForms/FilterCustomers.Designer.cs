namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterCustomers
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
            city_cb = new ComboBox();
            date_picker = new DateTimePicker();
            customer_type_cb = new ComboBox();
            name_or_phone_tb = new TextBox();
            city_lbl = new Label();
            total_lbl = new Label();
            dead_stock_tb = new TextBox();
            dead_lbl = new Label();
            date_lbl = new Label();
            type_lbl = new Label();
            search_lbl = new Label();
            panel2 = new Panel();
            label4 = new Label();
            min_numeric = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            max_numeric = new NumericUpDown();
            panel4 = new Panel();
            reset_btn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
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
            tableLayoutPanel1.Controls.Add(city_cb, 1, 6);
            tableLayoutPanel1.Controls.Add(date_picker, 1, 2);
            tableLayoutPanel1.Controls.Add(customer_type_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(name_or_phone_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(city_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(total_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(dead_stock_tb, 1, 3);
            tableLayoutPanel1.Controls.Add(dead_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(date_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(type_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(search_lbl, 0, 0);
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
            // city_cb
            // 
            city_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            city_cb.BackColor = Color.FromArgb(54, 54, 54);
            city_cb.FlatStyle = FlatStyle.Flat;
            city_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            city_cb.ForeColor = Color.White;
            city_cb.FormattingEnabled = true;
            city_cb.Location = new Point(264, 296);
            city_cb.Margin = new Padding(0, 10, 10, 10);
            city_cb.Name = "city_cb";
            city_cb.Size = new Size(255, 33);
            city_cb.TabIndex = 31;
            // 
            // date_picker
            // 
            date_picker.DropDownAlign = LeftRightAlignment.Right;
            date_picker.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(267, 107);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(250, 31);
            date_picker.TabIndex = 30;
            // 
            // customer_type_cb
            // 
            customer_type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_type_cb.BackColor = Color.FromArgb(54, 54, 54);
            customer_type_cb.FlatStyle = FlatStyle.Flat;
            customer_type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_type_cb.ForeColor = Color.White;
            customer_type_cb.FormattingEnabled = true;
            customer_type_cb.Location = new Point(264, 61);
            customer_type_cb.Margin = new Padding(0, 10, 10, 10);
            customer_type_cb.Name = "customer_type_cb";
            customer_type_cb.Size = new Size(255, 33);
            customer_type_cb.TabIndex = 29;
            // 
            // name_or_phone_tb
            // 
            name_or_phone_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name_or_phone_tb.BackColor = Color.FromArgb(54, 54, 54);
            name_or_phone_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            name_or_phone_tb.ForeColor = Color.White;
            name_or_phone_tb.Location = new Point(264, 10);
            name_or_phone_tb.Margin = new Padding(0, 10, 10, 10);
            name_or_phone_tb.Name = "name_or_phone_tb";
            name_or_phone_tb.Size = new Size(255, 31);
            name_or_phone_tb.TabIndex = 28;
            // 
            // city_lbl
            // 
            city_lbl.AutoSize = true;
            city_lbl.Dock = DockStyle.Left;
            city_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            city_lbl.ForeColor = Color.White;
            city_lbl.Location = new Point(10, 286);
            city_lbl.Margin = new Padding(10, 0, 3, 0);
            city_lbl.Name = "city_lbl";
            city_lbl.Size = new Size(136, 53);
            city_lbl.TabIndex = 25;
            city_lbl.Text = "Location / City";
            city_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Dock = DockStyle.Left;
            total_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_lbl.ForeColor = Color.White;
            total_lbl.Location = new Point(10, 192);
            total_lbl.Margin = new Padding(10, 0, 3, 0);
            total_lbl.Name = "total_lbl";
            tableLayoutPanel1.SetRowSpan(total_lbl, 2);
            total_lbl.Size = new Size(133, 94);
            total_lbl.TabIndex = 24;
            total_lbl.Text = "Total Revenue";
            total_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dead_stock_tb
            // 
            dead_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dead_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            dead_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dead_stock_tb.ForeColor = Color.White;
            dead_stock_tb.Location = new Point(264, 151);
            dead_stock_tb.Margin = new Padding(0, 10, 10, 10);
            dead_stock_tb.Name = "dead_stock_tb";
            dead_stock_tb.Size = new Size(255, 31);
            dead_stock_tb.TabIndex = 21;
            // 
            // dead_lbl
            // 
            dead_lbl.AutoSize = true;
            dead_lbl.Dock = DockStyle.Left;
            dead_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dead_lbl.ForeColor = Color.White;
            dead_lbl.Location = new Point(10, 141);
            dead_lbl.Margin = new Padding(10, 0, 3, 0);
            dead_lbl.Name = "dead_lbl";
            dead_lbl.Size = new Size(108, 51);
            dead_lbl.TabIndex = 20;
            dead_lbl.Text = "Dead Stock";
            dead_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.Dock = DockStyle.Left;
            date_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            date_lbl.ForeColor = Color.White;
            date_lbl.Location = new Point(10, 104);
            date_lbl.Margin = new Padding(10, 0, 3, 0);
            date_lbl.Name = "date_lbl";
            date_lbl.Size = new Size(111, 37);
            date_lbl.TabIndex = 18;
            date_lbl.Text = "Date Range";
            date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Dock = DockStyle.Left;
            type_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            type_lbl.ForeColor = Color.White;
            type_lbl.Location = new Point(10, 51);
            type_lbl.Margin = new Padding(10, 0, 3, 0);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(139, 53);
            type_lbl.TabIndex = 16;
            type_lbl.Text = "Customer Type";
            type_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Dock = DockStyle.Left;
            search_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(10, 0);
            search_lbl.Margin = new Padding(10, 0, 3, 0);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(222, 51);
            search_lbl.TabIndex = 8;
            search_lbl.Text = "Search by Name / Phone";
            search_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 202);
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
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Location = new Point(127, 0);
            min_numeric.Margin = new Padding(0, 10, 0, 0);
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 27);
            min_numeric.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(264, 249);
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
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Location = new Point(127, 0);
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 27);
            max_numeric.TabIndex = 0;
            // 
            // panel4
            // 
            tableLayoutPanel1.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(reset_btn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 499);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 10, 0);
            panel4.Size = new Size(523, 70);
            panel4.TabIndex = 27;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(54, 54, 54);
            reset_btn.Dock = DockStyle.Bottom;
            reset_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_btn.ForeColor = Color.White;
            reset_btn.Location = new Point(10, 0);
            reset_btn.Margin = new Padding(10, 0, 0, 0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(503, 70);
            reset_btn.TabIndex = 17;
            reset_btn.Text = "Reset Filters";
            reset_btn.UseVisualStyleBackColor = false;
            // 
            // FilterCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterCustomers";
            Size = new Size(529, 582);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label total_lbl;
        private TextBox dead_stock_tb;
        private Label dead_lbl;
        private Label date_lbl;
        private Label type_lbl;
        private Label search_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private Label city_lbl;
        private Panel panel4;
        private Button reset_btn;
        private TextBox name_or_phone_tb;
        private ComboBox customer_type_cb;
        private DateTimePicker date_picker;
        private ComboBox city_cb;
    }
}
