namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterCustomers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            name_or_phone_tb = new TextBox();
            status_lbl = new Label();
            dead_stock_end = new DateTimePicker();
            dead_stock_start = new DateTimePicker();
            no_sales_lbl = new Label();
            panel6 = new Panel();
            label3 = new Label();
            spent_max = new NumericUpDown();
            panel5 = new Panel();
            label2 = new Label();
            spent_min = new NumericUpDown();
            total_spent_lbl = new Label();
            registration_start = new DateTimePicker();
            search_lbl = new Label();
            date_lbl = new Label();
            city_lbl = new Label();
            city_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            registration_end = new DateTimePicker();
            sales_count_lbl = new Label();
            panel3 = new Panel();
            label5 = new Label();
            sale_count_max = new NumericUpDown();
            panel2 = new Panel();
            label4 = new Label();
            sale_count_min = new NumericUpDown();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spent_max).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spent_min).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sale_count_max).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sale_count_min).BeginInit();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(872, 817);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 1, 0);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 10);
            tableLayoutPanel1.Controls.Add(dead_stock_end, 1, 5);
            tableLayoutPanel1.Controls.Add(dead_stock_start, 1, 4);
            tableLayoutPanel1.Controls.Add(no_sales_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(panel6, 1, 9);
            tableLayoutPanel1.Controls.Add(panel5, 1, 8);
            tableLayoutPanel1.Controls.Add(total_spent_lbl, 0, 8);
            tableLayoutPanel1.Controls.Add(registration_start, 1, 2);
            tableLayoutPanel1.Controls.Add(search_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(date_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(city_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(city_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(registration_end, 1, 3);
            tableLayoutPanel1.Controls.Add(sales_count_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(panel3, 1, 7);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
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
            tableLayoutPanel1.Size = new Size(872, 807);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // name_or_phone_tb
            // 
            name_or_phone_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name_or_phone_tb.BackColor = SystemColors.Window;
            name_or_phone_tb.Font = new Font("Segoe UI", 10.5F);
            name_or_phone_tb.Location = new Point(0, 0);
            name_or_phone_tb.Margin = new Padding(0);
            name_or_phone_tb.Name = "name_or_phone_tb";
            name_or_phone_tb.Size = new Size(428, 31);
            name_or_phone_tb.TabIndex = 44;
            name_or_phone_tb.Tag = "borderless";
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Top;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 531);
            status_lbl.Margin = new Padding(10, 13, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(423, 23);
            status_lbl.TabIndex = 43;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Activity Status";
            // 
            // dead_stock_end
            // 
            dead_stock_end.Dock = DockStyle.Fill;
            dead_stock_end.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_end.Font = new Font("Segoe UI", 11F);
            dead_stock_end.Format = DateTimePickerFormat.Custom;
            dead_stock_end.Location = new Point(442, 276);
            dead_stock_end.Margin = new Padding(6, 10, 0, 10);
            dead_stock_end.Name = "dead_stock_end";
            dead_stock_end.Size = new Size(430, 32);
            dead_stock_end.TabIndex = 41;
            // 
            // dead_stock_start
            // 
            dead_stock_start.Dock = DockStyle.Fill;
            dead_stock_start.DropDownAlign = LeftRightAlignment.Right;
            dead_stock_start.Font = new Font("Segoe UI", 11F);
            dead_stock_start.Format = DateTimePickerFormat.Custom;
            dead_stock_start.Location = new Point(442, 224);
            dead_stock_start.Margin = new Padding(6, 10, 0, 10);
            dead_stock_start.Name = "dead_stock_start";
            dead_stock_start.Size = new Size(430, 32);
            dead_stock_start.TabIndex = 40;
            // 
            // no_sales_lbl
            // 
            no_sales_lbl.AutoSize = true;
            no_sales_lbl.Dock = DockStyle.Fill;
            no_sales_lbl.Font = new Font("Segoe UI", 10F);
            no_sales_lbl.Location = new Point(10, 214);
            no_sales_lbl.Margin = new Padding(10, 0, 3, 0);
            no_sales_lbl.Name = "no_sales_lbl";
            tableLayoutPanel1.SetRowSpan(no_sales_lbl, 2);
            no_sales_lbl.Size = new Size(423, 104);
            no_sales_lbl.TabIndex = 39;
            no_sales_lbl.Tag = "muted";
            no_sales_lbl.Text = "No Sales Range";
            no_sales_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(spent_max);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(442, 478);
            panel6.Margin = new Padding(6, 10, 0, 10);
            panel6.MaximumSize = new Size(0, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(430, 30);
            panel6.TabIndex = 38;
            panel6.Tag = "card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 0;
            label3.Tag = "muted";
            label3.Text = "Max";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // spent_max
            // 
            spent_max.Dock = DockStyle.Right;
            spent_max.Font = new Font("Segoe UI", 11F);
            spent_max.Location = new Point(302, 0);
            spent_max.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            spent_max.Name = "spent_max";
            spent_max.Size = new Size(128, 32);
            spent_max.TabIndex = 0;
            spent_max.Tag = "range_lock";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(spent_min);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(442, 428);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.MaximumSize = new Size(0, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(430, 30);
            panel5.TabIndex = 36;
            panel5.Tag = "card";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 0;
            label2.Tag = "muted";
            label2.Text = "Min";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // spent_min
            // 
            spent_min.Dock = DockStyle.Right;
            spent_min.Font = new Font("Segoe UI", 11F);
            spent_min.Location = new Point(302, 0);
            spent_min.Margin = new Padding(0, 10, 0, 0);
            spent_min.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            spent_min.Name = "spent_min";
            spent_min.Size = new Size(128, 32);
            spent_min.TabIndex = 0;
            spent_min.Tag = "range_lock";
            // 
            // total_spent_lbl
            // 
            total_spent_lbl.AutoSize = true;
            total_spent_lbl.Dock = DockStyle.Fill;
            total_spent_lbl.Font = new Font("Segoe UI", 10F);
            total_spent_lbl.Location = new Point(10, 418);
            total_spent_lbl.Margin = new Padding(10, 0, 3, 0);
            total_spent_lbl.Name = "total_spent_lbl";
            tableLayoutPanel1.SetRowSpan(total_spent_lbl, 2);
            total_spent_lbl.Size = new Size(423, 100);
            total_spent_lbl.TabIndex = 35;
            total_spent_lbl.Tag = "muted";
            total_spent_lbl.Text = "Total Spent";
            total_spent_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registration_start
            // 
            registration_start.Dock = DockStyle.Fill;
            registration_start.DropDownAlign = LeftRightAlignment.Right;
            registration_start.Font = new Font("Segoe UI", 11F);
            registration_start.Format = DateTimePickerFormat.Custom;
            registration_start.Location = new Point(442, 120);
            registration_start.Margin = new Padding(6, 10, 0, 10);
            registration_start.Name = "registration_start";
            registration_start.Size = new Size(430, 32);
            registration_start.TabIndex = 30;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Dock = DockStyle.Fill;
            search_lbl.Font = new Font("Segoe UI", 10F);
            search_lbl.Location = new Point(10, 0);
            search_lbl.Margin = new Padding(10, 0, 3, 0);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(423, 54);
            search_lbl.TabIndex = 8;
            search_lbl.Tag = "muted";
            search_lbl.Text = "Search by Name / Phone / Email";
            search_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.Dock = DockStyle.Fill;
            date_lbl.Font = new Font("Segoe UI", 10F);
            date_lbl.Location = new Point(10, 110);
            date_lbl.Margin = new Padding(10, 0, 3, 0);
            date_lbl.Name = "date_lbl";
            tableLayoutPanel1.SetRowSpan(date_lbl, 2);
            date_lbl.Size = new Size(423, 104);
            date_lbl.TabIndex = 18;
            date_lbl.Tag = "muted";
            date_lbl.Text = "Registration Date Range";
            date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // city_lbl
            // 
            city_lbl.AutoSize = true;
            city_lbl.Dock = DockStyle.Fill;
            city_lbl.Font = new Font("Segoe UI", 10F);
            city_lbl.Location = new Point(10, 54);
            city_lbl.Margin = new Padding(10, 0, 3, 0);
            city_lbl.Name = "city_lbl";
            city_lbl.Size = new Size(423, 56);
            city_lbl.TabIndex = 25;
            city_lbl.Tag = "muted";
            city_lbl.Text = "Location / City";
            city_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // city_cb
            // 
            city_cb.Dock = DockStyle.Fill;
            city_cb.DrawMode = DrawMode.OwnerDrawFixed;
            city_cb.FlatStyle = FlatStyle.Flat;
            city_cb.Font = new Font("Segoe UI", 11F);
            city_cb.FormattingEnabled = true;
            city_cb.ItemHeight = 30;
            city_cb.Location = new Point(442, 64);
            city_cb.Margin = new Padding(6, 10, 0, 10);
            city_cb.Name = "city_cb";
            city_cb.Size = new Size(430, 36);
            city_cb.TabIndex = 31;
            // 
            // registration_end
            // 
            registration_end.Dock = DockStyle.Fill;
            registration_end.DropDownAlign = LeftRightAlignment.Right;
            registration_end.Font = new Font("Segoe UI", 11F);
            registration_end.Format = DateTimePickerFormat.Custom;
            registration_end.Location = new Point(442, 172);
            registration_end.Margin = new Padding(6, 10, 0, 10);
            registration_end.Name = "registration_end";
            registration_end.Size = new Size(430, 32);
            registration_end.TabIndex = 32;
            // 
            // sales_count_lbl
            // 
            sales_count_lbl.AutoSize = true;
            sales_count_lbl.Dock = DockStyle.Fill;
            sales_count_lbl.Font = new Font("Segoe UI", 10F);
            sales_count_lbl.Location = new Point(10, 318);
            sales_count_lbl.Margin = new Padding(10, 0, 3, 0);
            sales_count_lbl.Name = "sales_count_lbl";
            tableLayoutPanel1.SetRowSpan(sales_count_lbl, 2);
            sales_count_lbl.Size = new Size(423, 100);
            sales_count_lbl.TabIndex = 24;
            sales_count_lbl.Tag = "muted";
            sales_count_lbl.Text = "Sales Count";
            sales_count_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(sale_count_max);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(442, 378);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 30);
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
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_count_max
            // 
            sale_count_max.Dock = DockStyle.Right;
            sale_count_max.Font = new Font("Segoe UI", 11F);
            sale_count_max.Location = new Point(302, 0);
            sale_count_max.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            sale_count_max.Name = "sale_count_max";
            sale_count_max.Size = new Size(128, 32);
            sale_count_max.TabIndex = 0;
            sale_count_max.Tag = "range_lock";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(sale_count_min);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(442, 328);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 30);
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
            label4.TabIndex = 0;
            label4.Tag = "muted";
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_count_min
            // 
            sale_count_min.Dock = DockStyle.Right;
            sale_count_min.Font = new Font("Segoe UI", 11F);
            sale_count_min.Location = new Point(302, 0);
            sale_count_min.Margin = new Padding(0, 10, 0, 0);
            sale_count_min.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            sale_count_min.Name = "sale_count_min";
            sale_count_min.Size = new Size(128, 32);
            sale_count_min.TabIndex = 0;
            sale_count_min.Tag = "range_lock";
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Top;
            radio_pnl.Location = new Point(439, 521);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.MinimumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(430, 140);
            radio_pnl.TabIndex = 42;
            radio_pnl.Tag = "card";
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
            tableLayoutPanel2.Size = new Size(430, 140);
            tableLayoutPanel2.TabIndex = 0;
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
            inactive_rb.Size = new Size(424, 27);
            inactive_rb.TabIndex = 2;
            inactive_rb.TabStop = true;
            inactive_rb.Text = "Inactive Only";
            inactive_rb.UseVisualStyleBackColor = true;
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
            active_rb.Size = new Size(424, 27);
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
            all_rb.Size = new Size(424, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(442, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(430, 34);
            border_theme_pnl.TabIndex = 45;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(428, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(name_or_phone_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(428, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // FilterCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterCustomers";
            Size = new Size(872, 817);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spent_max).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spent_min).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sale_count_max).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sale_count_min).EndInit();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label sales_count_lbl;
        private Label date_lbl;
        private Label search_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown sale_count_min;
        private Panel panel3;
        private Label label5;
        private NumericUpDown sale_count_max;
        private Label city_lbl;
        private DateTimePicker registration_start;
        private SmartStock.Classes.Utils.ThemedComboBox city_cb;
        private DateTimePicker registration_end;
        private Label total_spent_lbl;
        private Panel panel6;
        private Label label3;
        private NumericUpDown spent_max;
        private Panel panel5;
        private Label label2;
        private NumericUpDown spent_min;
        private DateTimePicker dead_stock_end;
        private DateTimePicker dead_stock_start;
        private Label no_sales_lbl;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private Label status_lbl;
        private TextBox name_or_phone_tb;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
