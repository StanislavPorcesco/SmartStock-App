using SmartStock.Classes.Utils;
namespace SmartStock.Forms.User_Control
{
    partial class ModifySale
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            base_pnl = new Panel();
            add_instance_pnl = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            remove_from_cart_btn = new Button();
            add_to_cart_btn = new Button();
            qty_tb = new TextBox();
            label7 = new Label();
            product_id_tb = new TextBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            sales_dgv = new DataGridView();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            search_btn = new Button();
            sale_id_tb = new TextBox();
            label4 = new Label();
            logs_lbl = new Label();
            payment_status_cb = new ComboBox();
            payment_method_cb = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            total_amount_tb = new TextBox();
            date_picker = new DateTimePicker();
            label6 = new Label();
            db_lbl = new Label();
            user_id_tb = new TextBox();
            customer_id_tb = new TextBox();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sales_dgv).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Size = new Size(1420, 821);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.Controls.Add(tableLayoutPanel4);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(0, 0);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10, 10, 10, 0);
            add_instance_pnl.Size = new Size(1420, 581);
            add_instance_pnl.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(10, 10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(1400, 571);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 365);
            groupBox3.MinimumSize = new Size(0, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(694, 200);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Cart";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel3.Controls.Add(remove_from_cart_btn, 1, 2);
            tableLayoutPanel3.Controls.Add(add_to_cart_btn, 0, 2);
            tableLayoutPanel3.Controls.Add(qty_tb, 1, 1);
            tableLayoutPanel3.Controls.Add(label7, 0, 0);
            tableLayoutPanel3.Controls.Add(product_id_tb, 1, 0);
            tableLayoutPanel3.Controls.Add(label8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.Size = new Size(674, 160);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // remove_from_cart_btn
            // 
            remove_from_cart_btn.BackColor = Color.FromArgb(54, 54, 54);
            remove_from_cart_btn.Dock = DockStyle.Fill;
            remove_from_cart_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_from_cart_btn.ForeColor = Color.White;
            remove_from_cart_btn.Location = new Point(346, 87);
            remove_from_cart_btn.Margin = new Padding(10, 5, 10, 10);
            remove_from_cart_btn.MaximumSize = new Size(0, 70);
            remove_from_cart_btn.MinimumSize = new Size(0, 70);
            remove_from_cart_btn.Name = "remove_from_cart_btn";
            remove_from_cart_btn.Size = new Size(318, 70);
            remove_from_cart_btn.TabIndex = 23;
            remove_from_cart_btn.Text = "Remove Product";
            remove_from_cart_btn.UseVisualStyleBackColor = false;
            remove_from_cart_btn.Click += remove_from_cart_btn_Click;
            // 
            // add_to_cart_btn
            // 
            add_to_cart_btn.BackColor = Color.FromArgb(54, 54, 54);
            add_to_cart_btn.Dock = DockStyle.Fill;
            add_to_cart_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_to_cart_btn.ForeColor = Color.White;
            add_to_cart_btn.Location = new Point(10, 87);
            add_to_cart_btn.Margin = new Padding(10, 5, 10, 10);
            add_to_cart_btn.MaximumSize = new Size(0, 70);
            add_to_cart_btn.MinimumSize = new Size(0, 70);
            add_to_cart_btn.Name = "add_to_cart_btn";
            add_to_cart_btn.Size = new Size(316, 70);
            add_to_cart_btn.TabIndex = 22;
            add_to_cart_btn.Text = "Add Product";
            add_to_cart_btn.UseVisualStyleBackColor = false;
            add_to_cart_btn.Click += add_to_cart_btn_Click;
            // 
            // qty_tb
            // 
            qty_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qty_tb.BackColor = Color.FromArgb(54, 54, 54);
            qty_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            qty_tb.ForeColor = Color.White;
            qty_tb.Location = new Point(346, 46);
            qty_tb.Margin = new Padding(10, 5, 10, 5);
            qty_tb.Name = "qty_tb";
            qty_tb.Size = new Size(318, 31);
            qty_tb.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 41);
            label7.TabIndex = 8;
            label7.Text = "Product ID";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            product_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_id_tb.ForeColor = Color.White;
            product_id_tb.Location = new Point(346, 5);
            product_id_tb.Margin = new Padding(10, 5, 10, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(318, 31);
            product_id_tb.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(3, 41);
            label8.Name = "label8";
            label8.Size = new Size(80, 41);
            label8.TabIndex = 21;
            label8.Text = "Quantity";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(sales_dgv);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(710, 3);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 20, 10, 20);
            tableLayoutPanel4.SetRowSpan(groupBox4, 2);
            groupBox4.Size = new Size(687, 565);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Product Cart";
            // 
            // sales_dgv
            // 
            sales_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sales_dgv.BackgroundColor = Color.FromArgb(54, 54, 54);
            sales_dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sales_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sales_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales_dgv.Dock = DockStyle.Fill;
            sales_dgv.GridColor = Color.FromArgb(64, 64, 64);
            sales_dgv.Location = new Point(10, 40);
            sales_dgv.Name = "sales_dgv";
            sales_dgv.RowHeadersWidth = 51;
            sales_dgv.Size = new Size(667, 505);
            sales_dgv.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(694, 356);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Sale";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 3);
            tableLayoutPanel2.Controls.Add(payment_status_cb, 1, 4);
            tableLayoutPanel2.Controls.Add(payment_method_cb, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 6);
            tableLayoutPanel2.Controls.Add(label3, 0, 5);
            tableLayoutPanel2.Controls.Add(total_amount_tb, 1, 6);
            tableLayoutPanel2.Controls.Add(date_picker, 1, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(user_id_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(customer_id_tb, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(674, 316);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 45);
            label5.TabIndex = 36;
            label5.Text = "Sale ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel6.Controls.Add(sale_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(339, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(332, 39);
            tableLayoutPanel6.TabIndex = 35;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(54, 54, 54);
            search_btn.Dock = DockStyle.Fill;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(176, 0);
            search_btn.Margin = new Padding(10, 0, 10, 5);
            search_btn.MaximumSize = new Size(0, 34);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(146, 34);
            search_btn.TabIndex = 27;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // sale_id_tb
            // 
            sale_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            sale_id_tb.Dock = DockStyle.Fill;
            sale_id_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sale_id_tb.ForeColor = Color.White;
            sale_id_tb.Location = new Point(10, 0);
            sale_id_tb.Margin = new Padding(10, 0, 0, 5);
            sale_id_tb.Name = "sale_id_tb";
            sale_id_tb.Size = new Size(156, 34);
            sale_id_tb.TabIndex = 26;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 170);
            label4.Name = "label4";
            label4.Size = new Size(135, 43);
            label4.TabIndex = 23;
            label4.Text = "Payment Status";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 127);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(148, 43);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Payment Method";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_status_cb
            // 
            payment_status_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_status_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_status_cb.ForeColor = Color.White;
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.Location = new Point(346, 175);
            payment_status_cb.Margin = new Padding(10, 5, 10, 5);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(318, 33);
            payment_status_cb.TabIndex = 4;
            // 
            // payment_method_cb
            // 
            payment_method_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_method_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_method_cb.ForeColor = Color.White;
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.Location = new Point(346, 132);
            payment_method_cb.Margin = new Padding(10, 5, 10, 5);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(318, 33);
            payment_method_cb.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 250);
            label2.Name = "label2";
            label2.Size = new Size(119, 66);
            label2.TabIndex = 14;
            label2.Text = "Total Amount";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 213);
            label3.Name = "label3";
            label3.Size = new Size(86, 37);
            label3.TabIndex = 21;
            label3.Text = "Sale Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_tb
            // 
            total_amount_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_amount_tb.BackColor = Color.FromArgb(54, 54, 54);
            total_amount_tb.Enabled = false;
            total_amount_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_amount_tb.ForeColor = Color.White;
            total_amount_tb.Location = new Point(346, 267);
            total_amount_tb.Margin = new Padding(10, 5, 10, 5);
            total_amount_tb.Name = "total_amount_tb";
            total_amount_tb.Size = new Size(318, 31);
            total_amount_tb.TabIndex = 5;
            // 
            // date_picker
            // 
            date_picker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_picker.CalendarForeColor = Color.Black;
            date_picker.CalendarMonthBackground = SystemColors.Highlight;
            date_picker.CalendarTitleBackColor = Color.Red;
            date_picker.CalendarTitleForeColor = Color.IndianRed;
            date_picker.CalendarTrailingForeColor = Color.Purple;
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(346, 218);
            date_picker.Margin = new Padding(10, 5, 10, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(318, 27);
            date_picker.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(3, 45);
            label6.Name = "label6";
            label6.Size = new Size(74, 41);
            label6.TabIndex = 37;
            label6.Text = "User ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 86);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(117, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Customer ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            user_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_id_tb.ForeColor = Color.White;
            user_id_tb.Location = new Point(346, 50);
            user_id_tb.Margin = new Padding(10, 5, 10, 5);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(318, 31);
            user_id_tb.TabIndex = 38;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            customer_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_id_tb.ForeColor = Color.White;
            customer_id_tb.Location = new Point(346, 91);
            customer_id_tb.Margin = new Padding(10, 5, 10, 5);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(318, 31);
            customer_id_tb.TabIndex = 1;
            // 
            // ModifySale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(base_pnl);
            Name = "ModifySale";
            Size = new Size(1420, 821);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sales_dgv).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private ComboBox product_caategory_cb;
        private TextBox unit_measure_tb;
        private TextBox safety_stock_tb;
        private TextBox current_stock_tb;
        private Panel add_instance_pnl;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox4;
        private DataGridView sales_dgv;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label db_lbl;
        private TextBox customer_id_tb;
        private Label label3;
        private DateTimePicker date_picker;
        private Label label2;
        private Label label4;
        private Label logs_lbl;
        private TextBox total_amount_tb;
        private ComboBox payment_method_cb;
        private ComboBox payment_status_cb;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button search_btn;
        private TextBox sale_id_tb;
        private Label label6;
        private TextBox user_id_tb;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button add_to_cart_btn;
        private TextBox qty_tb;
        private Label label7;
        private TextBox product_id_tb;
        private Label label8;
        private Button remove_from_cart_btn;
    }
}
