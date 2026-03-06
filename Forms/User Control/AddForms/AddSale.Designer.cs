using SmartStock.Classes.Utils;
namespace SmartStock.Forms.User_Control
{
    partial class AddSale
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
            add_btn = new Button();
            margin_pnl = new Panel();
            add_instance_pnl = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            sales_dgv = new DataGridView();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            add_to_cart_btn = new Button();
            qty_tb = new TextBox();
            label7 = new Label();
            product_id_tb = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            db_lbl = new Label();
            customer_id_tb = new TextBox();
            label3 = new Label();
            date_picker = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            logs_lbl = new Label();
            total_amount_tb = new TextBox();
            payment_method_cb = new ComboBox();
            payment_status_cb = new ComboBox();
            selector_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            selector_cb = new ComboBox();
            label1 = new Label();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sales_dgv).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            selector_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(add_btn);
            base_pnl.Controls.Add(margin_pnl);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1267, 940);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(54, 54, 54);
            add_btn.Dock = DockStyle.Bottom;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(20, 850);
            add_btn.Margin = new Padding(0);
            add_btn.MaximumSize = new Size(0, 70);
            add_btn.MinimumSize = new Size(0, 70);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(1227, 70);
            add_btn.TabIndex = 9;
            add_btn.Text = "Add Instance";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // margin_pnl
            // 
            margin_pnl.BackColor = Color.Transparent;
            margin_pnl.Dock = DockStyle.Top;
            margin_pnl.Location = new Point(20, 744);
            margin_pnl.MaximumSize = new Size(0, 20);
            margin_pnl.MinimumSize = new Size(0, 20);
            margin_pnl.Name = "margin_pnl";
            margin_pnl.Size = new Size(1227, 20);
            margin_pnl.TabIndex = 9;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(tableLayoutPanel4);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 150);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1227, 594);
            add_instance_pnl.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(10, 10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3554F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6446F));
            tableLayoutPanel4.Size = new Size(1207, 574);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(sales_dgv);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(613, 3);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 20, 10, 20);
            tableLayoutPanel4.SetRowSpan(groupBox4, 2);
            groupBox4.Size = new Size(591, 568);
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
            sales_dgv.Size = new Size(571, 508);
            sales_dgv.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 346);
            groupBox3.MaximumSize = new Size(0, 225);
            groupBox3.MinimumSize = new Size(0, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 20, 10, 20);
            groupBox3.Size = new Size(597, 225);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Cart";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel3.Controls.Add(add_to_cart_btn, 0, 4);
            tableLayoutPanel3.Controls.Add(qty_tb, 1, 1);
            tableLayoutPanel3.Controls.Add(label7, 0, 0);
            tableLayoutPanel3.Controls.Add(product_id_tb, 1, 0);
            tableLayoutPanel3.Controls.Add(label8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(577, 165);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // add_to_cart_btn
            // 
            add_to_cart_btn.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel3.SetColumnSpan(add_to_cart_btn, 2);
            add_to_cart_btn.Dock = DockStyle.Bottom;
            add_to_cart_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_to_cart_btn.ForeColor = Color.White;
            add_to_cart_btn.Location = new Point(0, 95);
            add_to_cart_btn.Margin = new Padding(0);
            add_to_cart_btn.MaximumSize = new Size(0, 70);
            add_to_cart_btn.MinimumSize = new Size(0, 70);
            add_to_cart_btn.Name = "add_to_cart_btn";
            add_to_cart_btn.Size = new Size(577, 70);
            add_to_cart_btn.TabIndex = 8;
            add_to_cart_btn.Text = "Add Product to Cart";
            add_to_cart_btn.UseVisualStyleBackColor = false;
            add_to_cart_btn.Click += add_to_cart_btn_Click;
            // 
            // qty_tb
            // 
            qty_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qty_tb.BackColor = Color.FromArgb(54, 54, 54);
            qty_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            qty_tb.ForeColor = Color.White;
            qty_tb.Location = new Point(288, 46);
            qty_tb.Margin = new Padding(0, 5, 0, 5);
            qty_tb.Name = "qty_tb";
            qty_tb.Size = new Size(289, 31);
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
            product_id_tb.Location = new Point(288, 5);
            product_id_tb.Margin = new Padding(0, 5, 0, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(289, 31);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 3);
            groupBox2.MaximumSize = new Size(0, 265);
            groupBox2.MinimumSize = new Size(0, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(597, 265);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Sale";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(customer_id_tb, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(date_picker, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(total_amount_tb, 1, 4);
            tableLayoutPanel2.Controls.Add(payment_method_cb, 1, 2);
            tableLayoutPanel2.Controls.Add(payment_status_cb, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(577, 205);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(117, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Customer ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            customer_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            customer_id_tb.ForeColor = Color.White;
            customer_id_tb.Location = new Point(288, 5);
            customer_id_tb.Margin = new Padding(0, 5, 0, 5);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(289, 31);
            customer_id_tb.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(86, 33);
            label3.TabIndex = 21;
            label3.Text = "Sale Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            date_picker.Location = new Point(291, 44);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(283, 27);
            date_picker.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 160);
            label2.Name = "label2";
            label2.Size = new Size(119, 45);
            label2.TabIndex = 14;
            label2.Text = "Total Amount";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 117);
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
            logs_lbl.Location = new Point(3, 74);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(148, 43);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Payment Method";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_tb
            // 
            total_amount_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_amount_tb.BackColor = Color.FromArgb(54, 54, 54);
            total_amount_tb.Enabled = false;
            total_amount_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_amount_tb.ForeColor = Color.White;
            total_amount_tb.Location = new Point(288, 167);
            total_amount_tb.Margin = new Padding(0, 5, 0, 5);
            total_amount_tb.Name = "total_amount_tb";
            total_amount_tb.Size = new Size(289, 31);
            total_amount_tb.TabIndex = 5;
            // 
            // payment_method_cb
            // 
            payment_method_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_method_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_method_cb.ForeColor = Color.White;
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.Location = new Point(288, 79);
            payment_method_cb.Margin = new Padding(0, 5, 0, 5);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(289, 33);
            payment_method_cb.TabIndex = 3;
            // 
            // payment_status_cb
            // 
            payment_status_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_status_cb.BackColor = Color.FromArgb(54, 54, 54);
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            payment_status_cb.ForeColor = Color.White;
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.Location = new Point(288, 122);
            payment_status_cb.Margin = new Padding(0, 5, 0, 5);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(289, 33);
            payment_status_cb.TabIndex = 4;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(groupBox1);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(1227, 130);
            selector_pnl.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 20, 10, 20);
            groupBox1.Size = new Size(1207, 110);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instance selector";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(selector_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1187, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // selector_cb
            // 
            selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            selector_cb.ForeColor = Color.White;
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(593, 8);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(594, 33);
            selector_cb.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(587, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the desired instance";
            // 
            // AddSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(base_pnl);
            Name = "AddSale";
            Size = new Size(1267, 940);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sales_dgv).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            selector_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Button add_btn;
        private Panel margin_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox product_caategory_cb;
        private TextBox unit_measure_tb;
        private TextBox safety_stock_tb;
        private TextBox current_stock_tb;
        private TextBox total_amount_tb;
        private Label label2;
        private Label db_lbl;
        private TextBox customer_id_tb;
        private Label logs_lbl;
        private Panel selector_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selector_cb;
        private Label label1;
        private Label label3;
        private DateTimePicker date_picker;
        private Label label4;
        private ComboBox payment_method_cb;
        private ComboBox payment_status_cb;
        private Button add_to_cart_btn;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox qty_tb;
        private Label label7;
        private TextBox product_id_tb;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView sales_dgv;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
