namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterProducts
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
            status_lbl = new Label();
            dead_stock_max = new DateTimePicker();
            dead_stock_min = new DateTimePicker();
            product_name_tb = new TextBox();
            name_lbl = new Label();
            dead_lbl = new Label();
            safety_lbl = new Label();
            supplier_lbl = new Label();
            category_lbl = new Label();
            under_limit_ck = new CheckBox();
            supplier_tb = new TextBox();
            category_cb = new ComboBox();
            range_max = new DateTimePicker();
            range_min = new DateTimePicker();
            top_sellers_ck = new CheckBox();
            panel3 = new Panel();
            label5 = new Label();
            max_numeric = new NumericUpDown();
            panel2 = new Panel();
            label4 = new Label();
            min_numeric = new NumericUpDown();
            label3 = new Label();
            top_lbl = new Label();
            range_lbl = new Label();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(1099, 687);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 11);
            tableLayoutPanel1.Controls.Add(dead_stock_max, 1, 5);
            tableLayoutPanel1.Controls.Add(dead_stock_min, 1, 4);
            tableLayoutPanel1.Controls.Add(product_name_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(name_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(dead_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(safety_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(category_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(under_limit_ck, 1, 3);
            tableLayoutPanel1.Controls.Add(supplier_tb, 1, 2);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(range_max, 1, 10);
            tableLayoutPanel1.Controls.Add(range_min, 1, 9);
            tableLayoutPanel1.Controls.Add(top_sellers_ck, 1, 8);
            tableLayoutPanel1.Controls.Add(panel3, 1, 7);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 9);
            tableLayoutPanel1.Controls.Add(top_lbl, 0, 8);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1099, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_lbl.ForeColor = Color.White;
            status_lbl.Location = new Point(10, 545);
            status_lbl.Margin = new Padding(10, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(136, 140);
            status_lbl.TabIndex = 38;
            status_lbl.Text = "Activity Status";
            // 
            // dead_stock_max
            // 
            dead_stock_max.Dock = DockStyle.Fill;
            dead_stock_max.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_max.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dead_stock_max.Format = DateTimePickerFormat.Custom;
            dead_stock_max.Location = new Point(549, 243);
            dead_stock_max.Margin = new Padding(0, 5, 10, 20);
            dead_stock_max.Name = "dead_stock_max";
            dead_stock_max.Size = new Size(540, 31);
            dead_stock_max.TabIndex = 36;
            // 
            // dead_stock_min
            // 
            dead_stock_min.Dock = DockStyle.Fill;
            dead_stock_min.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_min.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dead_stock_min.Format = DateTimePickerFormat.Custom;
            dead_stock_min.Location = new Point(549, 202);
            dead_stock_min.Margin = new Padding(0, 20, 10, 5);
            dead_stock_min.Name = "dead_stock_min";
            dead_stock_min.Size = new Size(540, 31);
            dead_stock_min.TabIndex = 35;
            // 
            // product_name_tb
            // 
            product_name_tb.BackColor = Color.FromArgb(54, 54, 54);
            product_name_tb.Dock = DockStyle.Fill;
            product_name_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_name_tb.ForeColor = Color.White;
            product_name_tb.Location = new Point(549, 10);
            product_name_tb.Margin = new Padding(0, 10, 10, 5);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(540, 31);
            product_name_tb.TabIndex = 32;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Dock = DockStyle.Left;
            name_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            name_lbl.ForeColor = Color.White;
            name_lbl.Location = new Point(10, 0);
            name_lbl.Margin = new Padding(10, 0, 3, 0);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(134, 46);
            name_lbl.TabIndex = 31;
            name_lbl.Text = "Product Name";
            name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dead_lbl
            // 
            dead_lbl.AutoSize = true;
            dead_lbl.Dock = DockStyle.Left;
            dead_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dead_lbl.ForeColor = Color.White;
            dead_lbl.Location = new Point(10, 182);
            dead_lbl.Margin = new Padding(10, 0, 3, 0);
            dead_lbl.Name = "dead_lbl";
            tableLayoutPanel1.SetRowSpan(dead_lbl, 2);
            dead_lbl.Size = new Size(167, 112);
            dead_lbl.TabIndex = 20;
            dead_lbl.Text = "Dead Stock Range";
            dead_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // safety_lbl
            // 
            safety_lbl.AutoSize = true;
            safety_lbl.Dock = DockStyle.Left;
            safety_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            safety_lbl.ForeColor = Color.White;
            safety_lbl.Location = new Point(10, 145);
            safety_lbl.Margin = new Padding(10, 0, 3, 0);
            safety_lbl.Name = "safety_lbl";
            safety_lbl.Size = new Size(170, 37);
            safety_lbl.TabIndex = 18;
            safety_lbl.Text = "Under Safety Limit";
            safety_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Left;
            supplier_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_lbl.ForeColor = Color.White;
            supplier_lbl.Location = new Point(10, 89);
            supplier_lbl.Margin = new Padding(10, 0, 3, 20);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(82, 36);
            supplier_lbl.TabIndex = 16;
            supplier_lbl.Text = "Supplier";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_lbl
            // 
            category_lbl.AutoSize = true;
            category_lbl.Dock = DockStyle.Left;
            category_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_lbl.ForeColor = Color.White;
            category_lbl.Location = new Point(10, 46);
            category_lbl.Margin = new Padding(10, 0, 3, 0);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(90, 43);
            category_lbl.TabIndex = 8;
            category_lbl.Text = "Category";
            category_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // under_limit_ck
            // 
            under_limit_ck.AutoSize = true;
            under_limit_ck.CheckAlign = ContentAlignment.MiddleRight;
            under_limit_ck.Dock = DockStyle.Fill;
            under_limit_ck.ImageAlign = ContentAlignment.MiddleRight;
            under_limit_ck.Location = new Point(549, 155);
            under_limit_ck.Margin = new Padding(0, 10, 10, 10);
            under_limit_ck.Name = "under_limit_ck";
            under_limit_ck.Size = new Size(540, 17);
            under_limit_ck.TabIndex = 19;
            under_limit_ck.TextAlign = ContentAlignment.MiddleRight;
            under_limit_ck.UseVisualStyleBackColor = true;
            // 
            // supplier_tb
            // 
            supplier_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_tb.Dock = DockStyle.Fill;
            supplier_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_tb.ForeColor = Color.White;
            supplier_tb.Location = new Point(549, 94);
            supplier_tb.Margin = new Padding(0, 5, 10, 20);
            supplier_tb.Name = "supplier_tb";
            supplier_tb.Size = new Size(540, 31);
            supplier_tb.TabIndex = 17;
            // 
            // category_cb
            // 
            category_cb.BackColor = Color.FromArgb(54, 54, 54);
            category_cb.Dock = DockStyle.Fill;
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_cb.ForeColor = Color.White;
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(549, 51);
            category_cb.Margin = new Padding(0, 5, 10, 5);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(540, 33);
            category_cb.TabIndex = 15;
            // 
            // range_max
            // 
            range_max.Dock = DockStyle.Fill;
            range_max.DropDownAlign = LeftRightAlignment.Right;
            range_max.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            range_max.Format = DateTimePickerFormat.Custom;
            range_max.Location = new Point(549, 494);
            range_max.Margin = new Padding(0, 5, 10, 20);
            range_max.Name = "range_max";
            range_max.Size = new Size(540, 31);
            range_max.TabIndex = 34;
            // 
            // range_min
            // 
            range_min.Dock = DockStyle.Fill;
            range_min.DropDownAlign = LeftRightAlignment.Right;
            range_min.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            range_min.Format = DateTimePickerFormat.Custom;
            range_min.Location = new Point(549, 453);
            range_min.Margin = new Padding(0, 5, 10, 5);
            range_min.Name = "range_min";
            range_min.Size = new Size(540, 31);
            range_min.TabIndex = 33;
            // 
            // top_sellers_ck
            // 
            top_sellers_ck.AutoSize = true;
            top_sellers_ck.CheckAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.Dock = DockStyle.Fill;
            top_sellers_ck.ImageAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.Location = new Point(549, 418);
            top_sellers_ck.Margin = new Padding(0, 20, 10, 5);
            top_sellers_ck.Name = "top_sellers_ck";
            top_sellers_ck.Size = new Size(540, 25);
            top_sellers_ck.TabIndex = 26;
            top_sellers_ck.TextAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(549, 351);
            panel3.Margin = new Padding(0, 5, 10, 20);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 27);
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
            max_numeric.Location = new Point(412, 0);
            max_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 27);
            max_numeric.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(549, 314);
            panel2.Margin = new Padding(0, 20, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 27);
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
            min_numeric.Location = new Point(412, 0);
            min_numeric.Margin = new Padding(0, 20, 0, 0);
            min_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 27);
            min_numeric.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 448);
            label3.Margin = new Padding(10, 0, 3, 0);
            label3.Name = "label3";
            tableLayoutPanel1.SetRowSpan(label3, 2);
            label3.Size = new Size(162, 97);
            label3.TabIndex = 30;
            label3.Text = "Top Sellers Range";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // top_lbl
            // 
            top_lbl.AutoSize = true;
            top_lbl.Dock = DockStyle.Left;
            top_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            top_lbl.ForeColor = Color.White;
            top_lbl.Location = new Point(10, 418);
            top_lbl.Margin = new Padding(10, 20, 0, 5);
            top_lbl.Name = "top_lbl";
            top_lbl.Size = new Size(103, 25);
            top_lbl.TabIndex = 25;
            top_lbl.Text = "Top Sellers";
            top_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 294);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(113, 104);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Price Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(552, 548);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(544, 134);
            radio_pnl.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(inactive_rb, 0, 2);
            tableLayoutPanel2.Controls.Add(active_rb, 0, 1);
            tableLayoutPanel2.Controls.Add(all_rb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(544, 134);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // inactive_rb
            // 
            inactive_rb.AutoSize = true;
            inactive_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            inactive_rb.ForeColor = Color.White;
            inactive_rb.Location = new Point(3, 73);
            inactive_rb.Name = "inactive_rb";
            inactive_rb.Size = new Size(146, 29);
            inactive_rb.TabIndex = 2;
            inactive_rb.TabStop = true;
            inactive_rb.Text = "Inactive Only";
            inactive_rb.UseVisualStyleBackColor = true;
            // 
            // active_rb
            // 
            active_rb.AutoSize = true;
            active_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            active_rb.ForeColor = Color.White;
            active_rb.Location = new Point(3, 38);
            active_rb.Name = "active_rb";
            active_rb.Size = new Size(132, 29);
            active_rb.TabIndex = 1;
            active_rb.TabStop = true;
            active_rb.Text = "Active Only";
            active_rb.UseVisualStyleBackColor = true;
            // 
            // all_rb
            // 
            all_rb.AutoSize = true;
            all_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            all_rb.ForeColor = Color.White;
            all_rb.Location = new Point(3, 3);
            all_rb.Name = "all_rb";
            all_rb.Size = new Size(56, 29);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // FilterProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterProducts";
            Size = new Size(1099, 687);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).EndInit();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label range_lbl;
        private Label dead_lbl;
        private Label safety_lbl;
        private TextBox supplier_tb;
        private Label supplier_lbl;
        private ComboBox category_cb;
        private Label category_lbl;
        private CheckBox under_limit_ck;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private CheckBox top_sellers_ck;
        private Label top_lbl;
        private TextBox product_name_tb;
        private Label name_lbl;
        private Label label3;
        private DateTimePicker range_max;
        private DateTimePicker range_min;
        private DateTimePicker dead_stock_max;
        private DateTimePicker dead_stock_min;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private Label status_lbl;
    }
}
