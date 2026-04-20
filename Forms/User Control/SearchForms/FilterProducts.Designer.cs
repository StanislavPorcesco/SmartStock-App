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
            supplier_tb = new TextBox();
            status_lbl = new Label();
            dead_stock_max = new DateTimePicker();
            dead_stock_min = new DateTimePicker();
            product_name_lbl = new Label();
            dead_lbl = new Label();
            safety_lbl = new Label();
            supplier_lbl = new Label();
            category_lbl = new Label();
            under_limit_ck = new CheckBox();
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
            total_sells_range = new Label();
            top_lbl = new Label();
            range_lbl = new Label();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            inactive_rb = new RadioButton();
            product_name_tb = new TextBox();
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
            panel1.Size = new Size(841, 772);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(supplier_tb, 1, 2);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 11);
            tableLayoutPanel1.Controls.Add(dead_stock_max, 1, 5);
            tableLayoutPanel1.Controls.Add(dead_stock_min, 1, 4);
            tableLayoutPanel1.Controls.Add(product_name_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(dead_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(safety_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(category_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(under_limit_ck, 1, 3);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(range_max, 1, 10);
            tableLayoutPanel1.Controls.Add(range_min, 1, 9);
            tableLayoutPanel1.Controls.Add(top_sellers_ck, 1, 8);
            tableLayoutPanel1.Controls.Add(panel3, 1, 7);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(total_sells_range, 0, 9);
            tableLayoutPanel1.Controls.Add(top_lbl, 0, 8);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 11);
            tableLayoutPanel1.Controls.Add(product_name_tb, 1, 0);
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
            tableLayoutPanel1.Size = new Size(841, 762);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // supplier_tb
            // 
            supplier_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_tb.BackColor = SystemColors.Window;
            supplier_tb.Font = new Font("Segoe UI", 10.5F);
            supplier_tb.Location = new Point(426, 114);
            supplier_tb.Margin = new Padding(6, 10, 0, 10);
            supplier_tb.Name = "supplier_tb";
            supplier_tb.Size = new Size(415, 31);
            supplier_tb.TabIndex = 40;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Top;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 568);
            status_lbl.Margin = new Padding(10, 13, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(407, 23);
            status_lbl.TabIndex = 38;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Activity Status";
            // 
            // dead_stock_max
            // 
            dead_stock_max.Dock = DockStyle.Fill;
            dead_stock_max.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_max.Font = new Font("Segoe UI", 11F);
            dead_stock_max.Format = DateTimePickerFormat.Custom;
            dead_stock_max.Location = new Point(426, 261);
            dead_stock_max.Margin = new Padding(6, 10, 0, 10);
            dead_stock_max.Name = "dead_stock_max";
            dead_stock_max.Size = new Size(415, 32);
            dead_stock_max.TabIndex = 36;
            // 
            // dead_stock_min
            // 
            dead_stock_min.Dock = DockStyle.Fill;
            dead_stock_min.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_min.Font = new Font("Segoe UI", 11F);
            dead_stock_min.Format = DateTimePickerFormat.Custom;
            dead_stock_min.Location = new Point(426, 209);
            dead_stock_min.Margin = new Padding(6, 10, 0, 10);
            dead_stock_min.Name = "dead_stock_min";
            dead_stock_min.Size = new Size(415, 32);
            dead_stock_min.TabIndex = 35;
            // 
            // product_name_lbl
            // 
            product_name_lbl.AutoSize = true;
            product_name_lbl.Dock = DockStyle.Fill;
            product_name_lbl.Font = new Font("Segoe UI", 10F);
            product_name_lbl.Location = new Point(10, 0);
            product_name_lbl.Margin = new Padding(10, 0, 3, 0);
            product_name_lbl.Name = "product_name_lbl";
            product_name_lbl.Size = new Size(407, 51);
            product_name_lbl.TabIndex = 31;
            product_name_lbl.Tag = "muted";
            product_name_lbl.Text = "Product Name";
            product_name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dead_lbl
            // 
            dead_lbl.AutoSize = true;
            dead_lbl.Dock = DockStyle.Fill;
            dead_lbl.Font = new Font("Segoe UI", 10F);
            dead_lbl.Location = new Point(10, 199);
            dead_lbl.Margin = new Padding(10, 0, 3, 0);
            dead_lbl.Name = "dead_lbl";
            tableLayoutPanel1.SetRowSpan(dead_lbl, 2);
            dead_lbl.Size = new Size(407, 104);
            dead_lbl.TabIndex = 20;
            dead_lbl.Tag = "muted";
            dead_lbl.Text = "Dead Stock Range";
            dead_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // safety_lbl
            // 
            safety_lbl.AutoSize = true;
            safety_lbl.Dock = DockStyle.Fill;
            safety_lbl.Font = new Font("Segoe UI", 10F);
            safety_lbl.Location = new Point(10, 155);
            safety_lbl.Margin = new Padding(10, 0, 3, 0);
            safety_lbl.Name = "safety_lbl";
            safety_lbl.Size = new Size(407, 44);
            safety_lbl.TabIndex = 18;
            safety_lbl.Tag = "muted";
            safety_lbl.Text = "Under Safety Limit";
            safety_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Fill;
            supplier_lbl.Font = new Font("Segoe UI", 10F);
            supplier_lbl.Location = new Point(10, 104);
            supplier_lbl.Margin = new Padding(10, 0, 3, 20);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(407, 31);
            supplier_lbl.TabIndex = 16;
            supplier_lbl.Tag = "muted";
            supplier_lbl.Text = "Supplier";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_lbl
            // 
            category_lbl.AutoSize = true;
            category_lbl.Dock = DockStyle.Fill;
            category_lbl.Font = new Font("Segoe UI", 10F);
            category_lbl.Location = new Point(10, 51);
            category_lbl.Margin = new Padding(10, 0, 3, 0);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(407, 53);
            category_lbl.TabIndex = 8;
            category_lbl.Tag = "muted";
            category_lbl.Text = "Category";
            category_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // under_limit_ck
            // 
            under_limit_ck.AutoSize = true;
            under_limit_ck.CheckAlign = ContentAlignment.MiddleRight;
            under_limit_ck.Dock = DockStyle.Fill;
            under_limit_ck.ImageAlign = ContentAlignment.MiddleRight;
            under_limit_ck.Location = new Point(426, 165);
            under_limit_ck.Margin = new Padding(6, 10, 0, 10);
            under_limit_ck.Name = "under_limit_ck";
            under_limit_ck.Size = new Size(415, 24);
            under_limit_ck.TabIndex = 19;
            under_limit_ck.Text = "On / Off";
            under_limit_ck.TextImageRelation = TextImageRelation.TextBeforeImage;
            under_limit_ck.UseVisualStyleBackColor = true;
            // 
            // category_cb
            // 
            category_cb.Dock = DockStyle.Fill;
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 11F);
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(426, 61);
            category_cb.Margin = new Padding(6, 10, 0, 10);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(415, 33);
            category_cb.TabIndex = 15;
            // 
            // range_max
            // 
            range_max.Dock = DockStyle.Fill;
            range_max.DropDownAlign = LeftRightAlignment.Right;
            range_max.Font = new Font("Segoe UI", 11F);
            range_max.Format = DateTimePickerFormat.Custom;
            range_max.Location = new Point(426, 513);
            range_max.Margin = new Padding(6, 10, 0, 10);
            range_max.Name = "range_max";
            range_max.Size = new Size(415, 32);
            range_max.TabIndex = 34;
            // 
            // range_min
            // 
            range_min.Dock = DockStyle.Fill;
            range_min.DropDownAlign = LeftRightAlignment.Right;
            range_min.Font = new Font("Segoe UI", 11F);
            range_min.Format = DateTimePickerFormat.Custom;
            range_min.Location = new Point(426, 461);
            range_min.Margin = new Padding(6, 10, 0, 10);
            range_min.Name = "range_min";
            range_min.Size = new Size(415, 32);
            range_min.TabIndex = 33;
            // 
            // top_sellers_ck
            // 
            top_sellers_ck.AutoSize = true;
            top_sellers_ck.CheckAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.Dock = DockStyle.Fill;
            top_sellers_ck.ImageAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.Location = new Point(426, 413);
            top_sellers_ck.Margin = new Padding(6, 10, 0, 10);
            top_sellers_ck.Name = "top_sellers_ck";
            top_sellers_ck.Size = new Size(415, 28);
            top_sellers_ck.TabIndex = 26;
            top_sellers_ck.Text = "On / Off";
            top_sellers_ck.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(426, 363);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 30);
            panel3.TabIndex = 23;
            panel3.Tag = "card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 22;
            label5.Tag = "muted";
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Font = new Font("Segoe UI", 11F);
            max_numeric.Location = new Point(287, 0);
            max_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 32);
            max_numeric.TabIndex = 0;
            max_numeric.Tag = "range_lock";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(426, 313);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 30);
            panel2.TabIndex = 22;
            panel2.Tag = "card";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 23);
            label4.TabIndex = 21;
            label4.Tag = "muted";
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Font = new Font("Segoe UI", 11F);
            min_numeric.Location = new Point(287, 0);
            min_numeric.Margin = new Padding(0, 20, 0, 0);
            min_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 32);
            min_numeric.TabIndex = 0;
            min_numeric.Tag = "range_lock";
            // 
            // total_sells_range
            // 
            total_sells_range.AutoSize = true;
            total_sells_range.Dock = DockStyle.Fill;
            total_sells_range.Font = new Font("Segoe UI", 10F);
            total_sells_range.Location = new Point(10, 451);
            total_sells_range.Margin = new Padding(10, 0, 3, 0);
            total_sells_range.Name = "total_sells_range";
            tableLayoutPanel1.SetRowSpan(total_sells_range, 2);
            total_sells_range.Size = new Size(407, 104);
            total_sells_range.TabIndex = 30;
            total_sells_range.Tag = "muted";
            total_sells_range.Text = "Top Sells Range";
            total_sells_range.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // top_lbl
            // 
            top_lbl.AutoSize = true;
            top_lbl.Dock = DockStyle.Fill;
            top_lbl.Font = new Font("Segoe UI", 10F);
            top_lbl.Location = new Point(10, 423);
            top_lbl.Margin = new Padding(10, 20, 0, 5);
            top_lbl.Name = "top_lbl";
            top_lbl.Size = new Size(410, 23);
            top_lbl.TabIndex = 25;
            top_lbl.Tag = "muted";
            top_lbl.Text = "Top Sellers";
            top_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Fill;
            range_lbl.Font = new Font("Segoe UI", 10F);
            range_lbl.Location = new Point(10, 303);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(407, 100);
            range_lbl.TabIndex = 24;
            range_lbl.Tag = "muted";
            range_lbl.Text = "Price Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Top;
            radio_pnl.Location = new Point(423, 558);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(415, 140);
            radio_pnl.TabIndex = 37;
            radio_pnl.Tag = "card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(active_rb, 0, 1);
            tableLayoutPanel2.Controls.Add(all_rb, 0, 0);
            tableLayoutPanel2.Controls.Add(inactive_rb, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(415, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // active_rb
            // 
            active_rb.AutoSize = true;
            active_rb.CheckAlign = ContentAlignment.MiddleRight;
            active_rb.Dock = DockStyle.Fill;
            active_rb.Font = new Font("Segoe UI", 10F);
            active_rb.Location = new Point(6, 57);
            active_rb.Margin = new Padding(6, 10, 0, 10);
            active_rb.Name = "active_rb";
            active_rb.Size = new Size(409, 27);
            active_rb.TabIndex = 1;
            active_rb.TabStop = true;
            active_rb.Text = "Active Only";
            active_rb.UseVisualStyleBackColor = true;
            // 
            // all_rb
            // 
            all_rb.AutoSize = true;
            all_rb.CheckAlign = ContentAlignment.MiddleRight;
            all_rb.Dock = DockStyle.Fill;
            all_rb.Font = new Font("Segoe UI", 10F);
            all_rb.Location = new Point(6, 10);
            all_rb.Margin = new Padding(6, 10, 0, 10);
            all_rb.Name = "all_rb";
            all_rb.Size = new Size(409, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Tag = "";
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // inactive_rb
            // 
            inactive_rb.AutoSize = true;
            inactive_rb.CheckAlign = ContentAlignment.MiddleRight;
            inactive_rb.Dock = DockStyle.Fill;
            inactive_rb.Font = new Font("Segoe UI", 10F);
            inactive_rb.Location = new Point(6, 104);
            inactive_rb.Margin = new Padding(6, 10, 0, 10);
            inactive_rb.Name = "inactive_rb";
            inactive_rb.Size = new Size(409, 27);
            inactive_rb.TabIndex = 2;
            inactive_rb.TabStop = true;
            inactive_rb.Text = "Inactive Only";
            inactive_rb.UseVisualStyleBackColor = true;
            // 
            // product_name_tb
            // 
            product_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_name_tb.BackColor = SystemColors.Window;
            product_name_tb.Font = new Font("Segoe UI", 10.5F);
            product_name_tb.Location = new Point(426, 10);
            product_name_tb.Margin = new Padding(6, 10, 0, 10);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(415, 31);
            product_name_tb.TabIndex = 39;
            // 
            // FilterProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterProducts";
            Size = new Size(841, 772);
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
        private Label product_name_lbl;
        private Label total_sells_range;
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
        private TextBox product_name_tb;
        private TextBox supplier_tb;
    }
}
