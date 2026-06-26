using SmartStock.Classes.Utils;

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
            panel12 = new Panel();
            panel13 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            contains_cat_tb = new TextBox();
            panel10 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            contains_prod_tb = new TextBox();
            panel8 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            user_id_tb = new TextBox();
            panel4 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            customer_id_tb = new TextBox();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            name_or_supplier_tb = new TextBox();
            activity_status_lbl = new Label();
            panel5 = new Panel();
            label7 = new Label();
            items_count_min = new ThemedNumericUpDown();
            sale_date_start = new ThemedDateTimePicker();
            payment_method_cb = new ThemedComboBox();
            payment_status_cb = new ThemedComboBox();
            search_by_name_lbl = new Label();
            sale_date_range_lbl = new Label();
            payment_method_lbl = new Label();
            payment_status_lbl = new Label();
            user_id_lbl = new Label();
            customer_id_lbl = new Label();
            total_amount_lbl = new Label();
            sale_date_end = new ThemedDateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            total_amount_min = new ThemedNumericUpDown();
            itemss_count_lbl = new Label();
            category_id_lbl = new Label();
            product_id_lbl = new Label();
            panel3 = new Panel();
            label6 = new Label();
            total_amount_max = new ThemedNumericUpDown();
            panel6 = new Panel();
            label8 = new Label();
            items_count_max = new ThemedNumericUpDown();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)items_count_min).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)total_amount_min).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)total_amount_max).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)items_count_max).BeginInit();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 30);
            panel1.Size = new Size(718, 936);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel12, 1, 10);
            tableLayoutPanel1.Controls.Add(panel10, 1, 9);
            tableLayoutPanel1.Controls.Add(panel8, 1, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 1, 0);
            tableLayoutPanel1.Controls.Add(activity_status_lbl, 0, 13);
            tableLayoutPanel1.Controls.Add(panel5, 1, 11);
            tableLayoutPanel1.Controls.Add(sale_date_start, 1, 5);
            tableLayoutPanel1.Controls.Add(payment_method_cb, 1, 4);
            tableLayoutPanel1.Controls.Add(payment_status_cb, 1, 3);
            tableLayoutPanel1.Controls.Add(search_by_name_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(sale_date_range_lbl, 0, 5);
            tableLayoutPanel1.Controls.Add(payment_method_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(payment_status_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(user_id_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(customer_id_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(total_amount_lbl, 0, 7);
            tableLayoutPanel1.Controls.Add(sale_date_end, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(itemss_count_lbl, 0, 11);
            tableLayoutPanel1.Controls.Add(category_id_lbl, 0, 10);
            tableLayoutPanel1.Controls.Add(product_id_lbl, 0, 9);
            tableLayoutPanel1.Controls.Add(panel3, 1, 8);
            tableLayoutPanel1.Controls.Add(panel6, 1, 12);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(718, 896);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel13);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(365, 542);
            panel12.Margin = new Padding(6, 10, 0, 10);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(1);
            panel12.Size = new Size(353, 34);
            panel12.TabIndex = 60;
            panel12.Tag = "border_pnl";
            // 
            // panel13
            // 
            panel13.Controls.Add(tableLayoutPanel7);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(1, 1);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(351, 32);
            panel13.TabIndex = 0;
            panel13.Tag = "card";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(contains_cat_tb, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(351, 32);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // contains_cat_tb
            // 
            contains_cat_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            contains_cat_tb.BackColor = SystemColors.Window;
            contains_cat_tb.Font = new Font("Segoe UI", 10.5F);
            contains_cat_tb.Location = new Point(15, 0);
            contains_cat_tb.Margin = new Padding(0);
            contains_cat_tb.Name = "contains_cat_tb";
            contains_cat_tb.Size = new Size(321, 31);
            contains_cat_tb.TabIndex = 55;
            contains_cat_tb.Tag = "borderless";
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(365, 488);
            panel10.Margin = new Padding(6, 10, 0, 10);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(1);
            panel10.Size = new Size(353, 34);
            panel10.TabIndex = 59;
            panel10.Tag = "border_pnl";
            // 
            // panel11
            // 
            panel11.Controls.Add(tableLayoutPanel5);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(1, 1);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(351, 32);
            panel11.TabIndex = 0;
            panel11.Tag = "card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(contains_prod_tb, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(351, 32);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // contains_prod_tb
            // 
            contains_prod_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            contains_prod_tb.BackColor = SystemColors.Window;
            contains_prod_tb.Font = new Font("Segoe UI", 10.5F);
            contains_prod_tb.Location = new Point(15, 0);
            contains_prod_tb.Margin = new Padding(0);
            contains_prod_tb.Name = "contains_prod_tb";
            contains_prod_tb.Size = new Size(321, 31);
            contains_prod_tb.TabIndex = 54;
            contains_prod_tb.Tag = "borderless";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(365, 118);
            panel8.Margin = new Padding(6, 10, 0, 10);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(1);
            panel8.Size = new Size(353, 34);
            panel8.TabIndex = 58;
            panel8.Tag = "border_pnl";
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLayoutPanel4);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(1, 1);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(351, 32);
            panel9.TabIndex = 0;
            panel9.Tag = "card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(user_id_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(351, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.BackColor = SystemColors.Window;
            user_id_tb.Font = new Font("Segoe UI", 10.5F);
            user_id_tb.Location = new Point(15, 0);
            user_id_tb.Margin = new Padding(0);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(321, 31);
            user_id_tb.TabIndex = 53;
            user_id_tb.Tag = "borderless";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(365, 64);
            panel4.Margin = new Padding(6, 10, 0, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1);
            panel4.Size = new Size(353, 34);
            panel4.TabIndex = 57;
            panel4.Tag = "border_pnl";
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel3);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1, 1);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(351, 32);
            panel7.TabIndex = 0;
            panel7.Tag = "card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(customer_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(351, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.BackColor = SystemColors.Window;
            customer_id_tb.Font = new Font("Segoe UI", 10.5F);
            customer_id_tb.Location = new Point(15, 0);
            customer_id_tb.Margin = new Padding(0);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(321, 31);
            customer_id_tb.TabIndex = 52;
            customer_id_tb.Tag = "borderless";
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(365, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(353, 34);
            border_theme_pnl.TabIndex = 56;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(351, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(name_or_supplier_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(351, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // name_or_supplier_tb
            // 
            name_or_supplier_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name_or_supplier_tb.BackColor = SystemColors.Window;
            name_or_supplier_tb.Font = new Font("Segoe UI", 10.5F);
            name_or_supplier_tb.Location = new Point(15, 0);
            name_or_supplier_tb.Margin = new Padding(0);
            name_or_supplier_tb.Name = "name_or_supplier_tb";
            name_or_supplier_tb.Size = new Size(321, 31);
            name_or_supplier_tb.TabIndex = 51;
            name_or_supplier_tb.Tag = "borderless";
            // 
            // activity_status_lbl
            // 
            activity_status_lbl.AutoSize = true;
            activity_status_lbl.Dock = DockStyle.Top;
            activity_status_lbl.Font = new Font("Segoe UI", 10F);
            activity_status_lbl.Location = new Point(10, 699);
            activity_status_lbl.Margin = new Padding(10, 13, 3, 0);
            activity_status_lbl.Name = "activity_status_lbl";
            activity_status_lbl.Size = new Size(346, 23);
            activity_status_lbl.TabIndex = 50;
            activity_status_lbl.Tag = "muted";
            activity_status_lbl.Text = "Activity Status";
            activity_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(items_count_min);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(365, 596);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.MaximumSize = new Size(0, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(353, 30);
            panel5.TabIndex = 47;
            panel5.Tag = "card";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(9, 0, 0, 0);
            label7.Size = new Size(48, 23);
            label7.TabIndex = 21;
            label7.Tag = "muted";
            label7.Text = "Min";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // items_count_min
            // 
            items_count_min.BorderStyle = BorderStyle.None;
            items_count_min.Dock = DockStyle.Right;
            items_count_min.Font = new Font("Segoe UI", 11F);
            items_count_min.Location = new Point(225, 0);
            items_count_min.Margin = new Padding(0, 10, 0, 0);
            items_count_min.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            items_count_min.Name = "items_count_min";
            items_count_min.Size = new Size(128, 28);
            items_count_min.TabIndex = 0;
            items_count_min.Tag = "range_lock";
            // 
            // sale_date_start
            // 
            sale_date_start.CustomFormat = "dd MMM yyyy";
            sale_date_start.Dock = DockStyle.Fill;
            sale_date_start.DropDownAlign = LeftRightAlignment.Right;
            sale_date_start.Font = new Font("Segoe UI", 11F);
            sale_date_start.Format = DateTimePickerFormat.Custom;
            sale_date_start.Location = new Point(365, 284);
            sale_date_start.Margin = new Padding(6, 10, 0, 10);
            sale_date_start.Name = "sale_date_start";
            sale_date_start.Size = new Size(353, 32);
            sale_date_start.TabIndex = 41;
            // 
            // payment_method_cb
            // 
            payment_method_cb.Dock = DockStyle.Fill;
            payment_method_cb.DrawMode = DrawMode.OwnerDrawFixed;
            payment_method_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 11F);
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.ItemHeight = 30;
            payment_method_cb.Location = new Point(365, 228);
            payment_method_cb.Margin = new Padding(6, 10, 0, 10);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(353, 36);
            payment_method_cb.TabIndex = 36;
            // 
            // payment_status_cb
            // 
            payment_status_cb.Dock = DockStyle.Fill;
            payment_status_cb.DrawMode = DrawMode.OwnerDrawFixed;
            payment_status_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 11F);
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.ItemHeight = 30;
            payment_status_cb.Location = new Point(365, 172);
            payment_status_cb.Margin = new Padding(6, 10, 0, 10);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(353, 36);
            payment_status_cb.TabIndex = 35;
            // 
            // search_by_name_lbl
            // 
            search_by_name_lbl.AutoSize = true;
            search_by_name_lbl.Dock = DockStyle.Fill;
            search_by_name_lbl.Font = new Font("Segoe UI", 10F);
            search_by_name_lbl.Location = new Point(10, 0);
            search_by_name_lbl.Margin = new Padding(10, 0, 3, 0);
            search_by_name_lbl.Name = "search_by_name_lbl";
            search_by_name_lbl.Size = new Size(346, 54);
            search_by_name_lbl.TabIndex = 28;
            search_by_name_lbl.Tag = "muted";
            search_by_name_lbl.Text = "Search by Client Name /  Supplier";
            search_by_name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_date_range_lbl
            // 
            sale_date_range_lbl.AutoSize = true;
            sale_date_range_lbl.Dock = DockStyle.Fill;
            sale_date_range_lbl.Font = new Font("Segoe UI", 10F);
            sale_date_range_lbl.Location = new Point(10, 274);
            sale_date_range_lbl.Margin = new Padding(10, 0, 3, 0);
            sale_date_range_lbl.Name = "sale_date_range_lbl";
            tableLayoutPanel1.SetRowSpan(sale_date_range_lbl, 2);
            sale_date_range_lbl.Size = new Size(346, 104);
            sale_date_range_lbl.TabIndex = 24;
            sale_date_range_lbl.Tag = "muted";
            sale_date_range_lbl.Text = "Sale Date Range";
            sale_date_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_method_lbl
            // 
            payment_method_lbl.AutoSize = true;
            payment_method_lbl.Dock = DockStyle.Fill;
            payment_method_lbl.Font = new Font("Segoe UI", 10F);
            payment_method_lbl.Location = new Point(10, 218);
            payment_method_lbl.Margin = new Padding(10, 0, 3, 0);
            payment_method_lbl.Name = "payment_method_lbl";
            payment_method_lbl.Size = new Size(346, 56);
            payment_method_lbl.TabIndex = 20;
            payment_method_lbl.Tag = "muted";
            payment_method_lbl.Text = "Payment Method";
            payment_method_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_status_lbl
            // 
            payment_status_lbl.AutoSize = true;
            payment_status_lbl.Dock = DockStyle.Fill;
            payment_status_lbl.Font = new Font("Segoe UI", 10F);
            payment_status_lbl.Location = new Point(10, 162);
            payment_status_lbl.Margin = new Padding(10, 0, 3, 0);
            payment_status_lbl.Name = "payment_status_lbl";
            payment_status_lbl.Size = new Size(346, 56);
            payment_status_lbl.TabIndex = 18;
            payment_status_lbl.Tag = "muted";
            payment_status_lbl.Text = "Payment Status";
            payment_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_lbl
            // 
            user_id_lbl.AutoSize = true;
            user_id_lbl.Dock = DockStyle.Fill;
            user_id_lbl.Font = new Font("Segoe UI", 10F);
            user_id_lbl.Location = new Point(10, 108);
            user_id_lbl.Margin = new Padding(10, 0, 3, 0);
            user_id_lbl.Name = "user_id_lbl";
            user_id_lbl.Size = new Size(346, 54);
            user_id_lbl.TabIndex = 16;
            user_id_lbl.Tag = "muted";
            user_id_lbl.Text = "User ID";
            user_id_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_id_lbl
            // 
            customer_id_lbl.AutoSize = true;
            customer_id_lbl.Dock = DockStyle.Fill;
            customer_id_lbl.Font = new Font("Segoe UI", 10F);
            customer_id_lbl.Location = new Point(10, 54);
            customer_id_lbl.Margin = new Padding(10, 0, 3, 0);
            customer_id_lbl.Name = "customer_id_lbl";
            customer_id_lbl.Size = new Size(346, 54);
            customer_id_lbl.TabIndex = 8;
            customer_id_lbl.Tag = "muted";
            customer_id_lbl.Text = "Customer ID";
            customer_id_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_lbl
            // 
            total_amount_lbl.AutoSize = true;
            total_amount_lbl.Dock = DockStyle.Fill;
            total_amount_lbl.Font = new Font("Segoe UI", 10F);
            total_amount_lbl.Location = new Point(10, 378);
            total_amount_lbl.Margin = new Padding(10, 0, 3, 0);
            total_amount_lbl.Name = "total_amount_lbl";
            tableLayoutPanel1.SetRowSpan(total_amount_lbl, 2);
            total_amount_lbl.Size = new Size(346, 100);
            total_amount_lbl.TabIndex = 25;
            total_amount_lbl.Tag = "muted";
            total_amount_lbl.Text = "Total Amount";
            total_amount_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_date_end
            // 
            sale_date_end.CustomFormat = "dd MMM yyyy";
            sale_date_end.Dock = DockStyle.Fill;
            sale_date_end.DropDownAlign = LeftRightAlignment.Right;
            sale_date_end.Font = new Font("Segoe UI", 11F);
            sale_date_end.Format = DateTimePickerFormat.Custom;
            sale_date_end.Location = new Point(365, 336);
            sale_date_end.Margin = new Padding(6, 10, 0, 10);
            sale_date_end.Name = "sale_date_end";
            sale_date_end.Size = new Size(353, 32);
            sale_date_end.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(total_amount_min);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(365, 388);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 30);
            panel2.TabIndex = 43;
            panel2.Tag = "card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(9, 0, 0, 0);
            label5.Size = new Size(48, 23);
            label5.TabIndex = 21;
            label5.Tag = "muted";
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_min
            // 
            total_amount_min.BorderStyle = BorderStyle.None;
            total_amount_min.DecimalPlaces = 2;
            total_amount_min.Dock = DockStyle.Right;
            total_amount_min.Font = new Font("Segoe UI", 11F);
            total_amount_min.Location = new Point(225, 0);
            total_amount_min.Margin = new Padding(0, 10, 0, 0);
            total_amount_min.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            total_amount_min.Name = "total_amount_min";
            total_amount_min.Size = new Size(128, 28);
            total_amount_min.TabIndex = 0;
            total_amount_min.Tag = "range_lock";
            // 
            // itemss_count_lbl
            // 
            itemss_count_lbl.AutoSize = true;
            itemss_count_lbl.Dock = DockStyle.Fill;
            itemss_count_lbl.Font = new Font("Segoe UI", 10F);
            itemss_count_lbl.Location = new Point(10, 586);
            itemss_count_lbl.Margin = new Padding(10, 0, 3, 0);
            itemss_count_lbl.Name = "itemss_count_lbl";
            tableLayoutPanel1.SetRowSpan(itemss_count_lbl, 2);
            itemss_count_lbl.Size = new Size(346, 100);
            itemss_count_lbl.TabIndex = 31;
            itemss_count_lbl.Tag = "muted";
            itemss_count_lbl.Text = "Items Count";
            itemss_count_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_id_lbl
            // 
            category_id_lbl.AutoSize = true;
            category_id_lbl.Dock = DockStyle.Fill;
            category_id_lbl.Font = new Font("Segoe UI", 10F);
            category_id_lbl.Location = new Point(10, 532);
            category_id_lbl.Margin = new Padding(10, 0, 3, 0);
            category_id_lbl.Name = "category_id_lbl";
            category_id_lbl.Size = new Size(346, 54);
            category_id_lbl.TabIndex = 30;
            category_id_lbl.Tag = "muted";
            category_id_lbl.Text = "Contains Category ID";
            category_id_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_id_lbl
            // 
            product_id_lbl.AutoSize = true;
            product_id_lbl.Dock = DockStyle.Fill;
            product_id_lbl.Font = new Font("Segoe UI", 10F);
            product_id_lbl.Location = new Point(10, 478);
            product_id_lbl.Margin = new Padding(10, 0, 3, 0);
            product_id_lbl.Name = "product_id_lbl";
            product_id_lbl.Size = new Size(346, 54);
            product_id_lbl.TabIndex = 29;
            product_id_lbl.Tag = "muted";
            product_id_lbl.Text = "Contains Product ID";
            product_id_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(total_amount_max);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(365, 438);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 30);
            panel3.TabIndex = 44;
            panel3.Tag = "card";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(9, 0, 0, 0);
            label6.Size = new Size(51, 23);
            label6.TabIndex = 22;
            label6.Tag = "muted";
            label6.Text = "Max";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_max
            // 
            total_amount_max.BorderStyle = BorderStyle.None;
            total_amount_max.DecimalPlaces = 2;
            total_amount_max.Dock = DockStyle.Right;
            total_amount_max.Font = new Font("Segoe UI", 11F);
            total_amount_max.Location = new Point(225, 0);
            total_amount_max.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            total_amount_max.Name = "total_amount_max";
            total_amount_max.Size = new Size(128, 28);
            total_amount_max.TabIndex = 0;
            total_amount_max.Tag = "range_lock";
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Controls.Add(items_count_max);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(365, 646);
            panel6.Margin = new Padding(6, 10, 0, 10);
            panel6.MaximumSize = new Size(0, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(353, 30);
            panel6.TabIndex = 48;
            panel6.Tag = "card";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(9, 0, 0, 0);
            label8.Size = new Size(51, 23);
            label8.TabIndex = 22;
            label8.Tag = "muted";
            label8.Text = "Max";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // items_count_max
            // 
            items_count_max.BorderStyle = BorderStyle.None;
            items_count_max.Dock = DockStyle.Right;
            items_count_max.Font = new Font("Segoe UI", 11F);
            items_count_max.Location = new Point(225, 0);
            items_count_max.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            items_count_max.Name = "items_count_max";
            items_count_max.Size = new Size(128, 28);
            items_count_max.TabIndex = 0;
            items_count_max.Tag = "range_lock";
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(362, 689);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.MinimumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(353, 140);
            radio_pnl.TabIndex = 49;
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
            tableLayoutPanel2.MaximumSize = new Size(0, 140);
            tableLayoutPanel2.MinimumSize = new Size(0, 140);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(353, 140);
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
            inactive_rb.Padding = new Padding(5, 0, 0, 0);
            inactive_rb.Size = new Size(347, 27);
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
            active_rb.Padding = new Padding(5, 0, 0, 0);
            active_rb.Size = new Size(347, 27);
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
            all_rb.Padding = new Padding(5, 0, 0, 0);
            all_rb.Size = new Size(347, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // FilterSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "FilterSales";
            Size = new Size(718, 936);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)items_count_min).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)total_amount_min).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)total_amount_max).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)items_count_max).EndInit();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label sale_date_range_lbl;
        private Label payment_method_lbl;
        private Label payment_status_lbl;
        private Label user_id_lbl;
        private Label customer_id_lbl;
        private Label total_amount_lbl;
        private Label search_by_name_lbl;
        private Label product_id_lbl;
        private Label category_id_lbl;
        private Label itemss_count_lbl;
        private ThemedComboBox payment_method_cb;
        private ThemedComboBox payment_status_cb;
        private ThemedDateTimePicker sale_date_start;
        private ThemedDateTimePicker sale_date_end;
        private Panel panel2;
        private Label label5;
        private ThemedNumericUpDown total_amount_min;
        private Panel panel3;
        private Label label6;
        private ThemedNumericUpDown total_amount_max;
        private Panel panel5;
        private Label label7;
        private ThemedNumericUpDown items_count_min;
        private Panel panel6;
        private Label label8;
        private ThemedNumericUpDown items_count_max;
        private Label activity_status_lbl;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private TextBox name_or_supplier_tb;
        private TextBox user_id_tb;
        private TextBox customer_id_tb;
        private TextBox contains_cat_tb;
        private TextBox contains_prod_tb;
        private Panel panel12;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel10;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel8;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
