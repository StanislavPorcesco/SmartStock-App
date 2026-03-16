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
            label9 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            items_count_min = new NumericUpDown();
            contains_cat_tb = new TextBox();
            sale_date_start = new DateTimePicker();
            payment_method_cb = new ComboBox();
            payment_status_cb = new ComboBox();
            user_id_tb = new TextBox();
            customer_id_tb = new TextBox();
            name_or_supplier_tb = new TextBox();
            label1 = new Label();
            total_range_lbl = new Label();
            payment_lbl = new Label();
            customer_lbl = new Label();
            supplier_lbl = new Label();
            range_lbl = new Label();
            inclusion_lbl = new Label();
            sale_date_end = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            total_amount_min = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            total_amount_max = new NumericUpDown();
            contains_prod_tb = new TextBox();
            panel6 = new Panel();
            label8 = new Label();
            items_count_max = new NumericUpDown();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panel1.Size = new Size(587, 753);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label9, 0, 13);
            tableLayoutPanel1.Controls.Add(panel5, 1, 11);
            tableLayoutPanel1.Controls.Add(contains_cat_tb, 1, 10);
            tableLayoutPanel1.Controls.Add(sale_date_start, 1, 5);
            tableLayoutPanel1.Controls.Add(payment_method_cb, 1, 4);
            tableLayoutPanel1.Controls.Add(payment_status_cb, 1, 3);
            tableLayoutPanel1.Controls.Add(user_id_tb, 1, 2);
            tableLayoutPanel1.Controls.Add(customer_id_tb, 1, 1);
            tableLayoutPanel1.Controls.Add(name_or_supplier_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(total_range_lbl, 0, 5);
            tableLayoutPanel1.Controls.Add(payment_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(customer_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(inclusion_lbl, 0, 7);
            tableLayoutPanel1.Controls.Add(sale_date_end, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 11);
            tableLayoutPanel1.Controls.Add(label3, 0, 10);
            tableLayoutPanel1.Controls.Add(label2, 0, 9);
            tableLayoutPanel1.Controls.Add(panel3, 1, 8);
            tableLayoutPanel1.Controls.Add(contains_prod_tb, 1, 9);
            tableLayoutPanel1.Controls.Add(panel6, 1, 12);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(587, 713);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 585);
            label9.Margin = new Padding(10, 0, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 105);
            label9.TabIndex = 50;
            label9.Text = "Activity Status";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(items_count_min);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(293, 511);
            panel5.Margin = new Padding(0, 10, 10, 5);
            panel5.MaximumSize = new Size(0, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 27);
            panel5.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 21;
            label7.Text = "Min";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // items_count_min
            // 
            items_count_min.Dock = DockStyle.Right;
            items_count_min.Location = new Point(156, 0);
            items_count_min.Margin = new Padding(0, 10, 0, 0);
            items_count_min.Name = "items_count_min";
            items_count_min.Size = new Size(128, 27);
            items_count_min.TabIndex = 0;
            // 
            // contains_cat_tb
            // 
            contains_cat_tb.BackColor = Color.FromArgb(54, 54, 54);
            contains_cat_tb.Dock = DockStyle.Fill;
            contains_cat_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            contains_cat_tb.ForeColor = Color.White;
            contains_cat_tb.Location = new Point(293, 460);
            contains_cat_tb.Margin = new Padding(0, 5, 10, 10);
            contains_cat_tb.Name = "contains_cat_tb";
            contains_cat_tb.Size = new Size(284, 31);
            contains_cat_tb.TabIndex = 46;
            // 
            // sale_date_start
            // 
            sale_date_start.Dock = DockStyle.Fill;
            sale_date_start.DropDownAlign = LeftRightAlignment.Right;
            sale_date_start.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sale_date_start.Format = DateTimePickerFormat.Custom;
            sale_date_start.Location = new Point(293, 243);
            sale_date_start.Margin = new Padding(0, 10, 10, 5);
            sale_date_start.Name = "sale_date_start";
            sale_date_start.Size = new Size(284, 31);
            sale_date_start.TabIndex = 41;
            // 
            // payment_method_cb
            // 
            payment_method_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_method_cb.Dock = DockStyle.Fill;
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_method_cb.ForeColor = Color.White;
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.Location = new Point(293, 190);
            payment_method_cb.Margin = new Padding(0, 5, 10, 10);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(284, 33);
            payment_method_cb.TabIndex = 36;
            // 
            // payment_status_cb
            // 
            payment_status_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_status_cb.Dock = DockStyle.Fill;
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_status_cb.ForeColor = Color.White;
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.Location = new Point(293, 147);
            payment_status_cb.Margin = new Padding(0, 10, 10, 5);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(284, 33);
            payment_status_cb.TabIndex = 35;
            // 
            // user_id_tb
            // 
            user_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            user_id_tb.Dock = DockStyle.Fill;
            user_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_id_tb.ForeColor = Color.White;
            user_id_tb.Location = new Point(293, 96);
            user_id_tb.Margin = new Padding(0, 5, 10, 10);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(284, 31);
            user_id_tb.TabIndex = 34;
            // 
            // customer_id_tb
            // 
            customer_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            customer_id_tb.Dock = DockStyle.Fill;
            customer_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_id_tb.ForeColor = Color.White;
            customer_id_tb.Location = new Point(293, 55);
            customer_id_tb.Margin = new Padding(0, 5, 10, 5);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(284, 31);
            customer_id_tb.TabIndex = 33;
            // 
            // name_or_supplier_tb
            // 
            name_or_supplier_tb.BackColor = Color.FromArgb(54, 54, 54);
            name_or_supplier_tb.Dock = DockStyle.Fill;
            name_or_supplier_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            name_or_supplier_tb.ForeColor = Color.White;
            name_or_supplier_tb.Location = new Point(293, 10);
            name_or_supplier_tb.Margin = new Padding(0, 10, 10, 5);
            name_or_supplier_tb.Name = "name_or_supplier_tb";
            name_or_supplier_tb.Size = new Size(284, 31);
            name_or_supplier_tb.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 0);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 50);
            label1.TabIndex = 28;
            label1.Text = "Search by Client Name /  Supplier";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_range_lbl
            // 
            total_range_lbl.AutoSize = true;
            total_range_lbl.Dock = DockStyle.Left;
            total_range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_range_lbl.ForeColor = Color.White;
            total_range_lbl.Location = new Point(10, 233);
            total_range_lbl.Margin = new Padding(10, 0, 3, 0);
            total_range_lbl.Name = "total_range_lbl";
            tableLayoutPanel1.SetRowSpan(total_range_lbl, 2);
            total_range_lbl.Size = new Size(151, 92);
            total_range_lbl.TabIndex = 24;
            total_range_lbl.Text = "Sale Date Range";
            total_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_lbl
            // 
            payment_lbl.AutoSize = true;
            payment_lbl.Dock = DockStyle.Left;
            payment_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_lbl.ForeColor = Color.White;
            payment_lbl.Location = new Point(10, 185);
            payment_lbl.Margin = new Padding(10, 0, 3, 0);
            payment_lbl.Name = "payment_lbl";
            payment_lbl.Size = new Size(159, 48);
            payment_lbl.TabIndex = 20;
            payment_lbl.Text = "Payment Method";
            payment_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_lbl
            // 
            customer_lbl.AutoSize = true;
            customer_lbl.Dock = DockStyle.Left;
            customer_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_lbl.ForeColor = Color.White;
            customer_lbl.Location = new Point(10, 137);
            customer_lbl.Margin = new Padding(10, 0, 3, 0);
            customer_lbl.Name = "customer_lbl";
            customer_lbl.Size = new Size(145, 48);
            customer_lbl.TabIndex = 18;
            customer_lbl.Text = "Payment Status";
            customer_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Left;
            supplier_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_lbl.ForeColor = Color.White;
            supplier_lbl.Location = new Point(10, 91);
            supplier_lbl.Margin = new Padding(10, 0, 3, 0);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(74, 46);
            supplier_lbl.TabIndex = 16;
            supplier_lbl.Text = "User ID";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 50);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(117, 41);
            range_lbl.TabIndex = 8;
            range_lbl.Text = "Customer ID";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inclusion_lbl
            // 
            inclusion_lbl.AutoSize = true;
            inclusion_lbl.Dock = DockStyle.Left;
            inclusion_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            inclusion_lbl.ForeColor = Color.White;
            inclusion_lbl.Location = new Point(10, 325);
            inclusion_lbl.Margin = new Padding(10, 0, 3, 0);
            inclusion_lbl.Name = "inclusion_lbl";
            tableLayoutPanel1.SetRowSpan(inclusion_lbl, 2);
            inclusion_lbl.Size = new Size(128, 84);
            inclusion_lbl.TabIndex = 25;
            inclusion_lbl.Text = "Total Amount";
            inclusion_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_date_end
            // 
            sale_date_end.Dock = DockStyle.Fill;
            sale_date_end.DropDownAlign = LeftRightAlignment.Right;
            sale_date_end.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sale_date_end.Format = DateTimePickerFormat.Custom;
            sale_date_end.Location = new Point(293, 284);
            sale_date_end.Margin = new Padding(0, 5, 10, 10);
            sale_date_end.Name = "sale_date_end";
            sale_date_end.Size = new Size(284, 31);
            sale_date_end.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(total_amount_min);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(293, 335);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 27);
            panel2.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 21;
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_min
            // 
            total_amount_min.Dock = DockStyle.Right;
            total_amount_min.Location = new Point(156, 0);
            total_amount_min.Margin = new Padding(0, 10, 0, 0);
            total_amount_min.Name = "total_amount_min";
            total_amount_min.Size = new Size(128, 27);
            total_amount_min.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 501);
            label4.Margin = new Padding(10, 0, 3, 0);
            label4.Name = "label4";
            tableLayoutPanel1.SetRowSpan(label4, 2);
            label4.Size = new Size(115, 84);
            label4.TabIndex = 31;
            label4.Text = "Items Count";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 455);
            label3.Margin = new Padding(10, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 46);
            label3.TabIndex = 30;
            label3.Text = "Contains Category ID";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 409);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 46);
            label2.TabIndex = 29;
            label2.Text = "Contains Product ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(total_amount_max);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(293, 372);
            panel3.Margin = new Padding(0, 5, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 27);
            panel3.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 22;
            label6.Text = "Max";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_max
            // 
            total_amount_max.Dock = DockStyle.Right;
            total_amount_max.Location = new Point(156, 0);
            total_amount_max.Name = "total_amount_max";
            total_amount_max.Size = new Size(128, 27);
            total_amount_max.TabIndex = 0;
            // 
            // contains_prod_tb
            // 
            contains_prod_tb.BackColor = Color.FromArgb(54, 54, 54);
            contains_prod_tb.Dock = DockStyle.Fill;
            contains_prod_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            contains_prod_tb.ForeColor = Color.White;
            contains_prod_tb.Location = new Point(293, 419);
            contains_prod_tb.Margin = new Padding(0, 10, 10, 5);
            contains_prod_tb.Name = "contains_prod_tb";
            contains_prod_tb.Size = new Size(284, 31);
            contains_prod_tb.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Controls.Add(items_count_max);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(293, 548);
            panel6.Margin = new Padding(0, 5, 10, 10);
            panel6.MaximumSize = new Size(0, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 27);
            panel6.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 22;
            label8.Text = "Max";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // items_count_max
            // 
            items_count_max.Dock = DockStyle.Right;
            items_count_max.Location = new Point(156, 0);
            items_count_max.Name = "items_count_max";
            items_count_max.Size = new Size(128, 27);
            items_count_max.TabIndex = 0;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(296, 588);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(288, 99);
            radio_pnl.TabIndex = 49;
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
            tableLayoutPanel2.Size = new Size(288, 99);
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
            // FilterSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "FilterSales";
            Size = new Size(587, 753);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label total_range_lbl;
        private Label payment_lbl;
        private Label customer_lbl;
        private Label supplier_lbl;
        private Label range_lbl;
        private Label inclusion_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox user_id_tb;
        private TextBox customer_id_tb;
        private TextBox name_or_supplier_tb;
        private ComboBox payment_method_cb;
        private ComboBox payment_status_cb;
        private DateTimePicker sale_date_start;
        private DateTimePicker sale_date_end;
        private Panel panel2;
        private Label label5;
        private NumericUpDown total_amount_min;
        private TextBox contains_cat_tb;
        private Panel panel3;
        private Label label6;
        private NumericUpDown total_amount_max;
        private TextBox contains_prod_tb;
        private Panel panel5;
        private Label label7;
        private NumericUpDown items_count_min;
        private Panel panel6;
        private Label label8;
        private NumericUpDown items_count_max;
        private Label label9;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
    }
}
