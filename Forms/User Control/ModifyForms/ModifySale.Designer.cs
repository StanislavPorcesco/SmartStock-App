using FontAwesome.Sharp;

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
            base_pnl = new Panel();
            left_pnl = new Panel();
            cart_section = new Panel();
            cart_fields = new TableLayoutPanel();
            label7 = new Label();
            product_id_tb = new TextBox();
            label8 = new Label();
            qty_tb = new TextBox();
            cart_buttons = new TableLayoutPanel();
            add_to_cart_btn = new IconButton();
            remove_from_cart_btn = new IconButton();
            cart_divider = new Panel();
            cart_title_lbl = new Label();
            sale_fields = new TableLayoutPanel();
            label5 = new Label();
            search_row = new Panel();
            sale_id_tb = new TextBox();
            search_btn = new IconButton();
            label6 = new Label();
            user_id_tb = new TextBox();
            db_lbl = new Label();
            customer_id_tb = new TextBox();
            logs_lbl = new Label();
            payment_method_cb = new ComboBox();
            label4 = new Label();
            payment_status_cb = new ComboBox();
            label3 = new Label();
            date_picker = new DateTimePicker();
            label2 = new Label();
            total_amount_tb = new TextBox();
            base_pnl.SuspendLayout();
            left_pnl.SuspendLayout();
            cart_section.SuspendLayout();
            cart_fields.SuspendLayout();
            cart_buttons.SuspendLayout();
            sale_fields.SuspendLayout();
            search_row.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.Controls.Add(left_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20, 16, 20, 16);
            base_pnl.Size = new Size(1420, 717);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            //
            // left_pnl
            //
            left_pnl.Controls.Add(cart_section);
            left_pnl.Controls.Add(sale_fields);
            left_pnl.Dock = DockStyle.Top;
            left_pnl.Location = new Point(0, 0);
            left_pnl.Margin = new Padding(0);
            left_pnl.Name = "left_pnl";
            left_pnl.Size = new Size(654, 549);
            left_pnl.TabIndex = 0;
            left_pnl.Tag = "card";
            // 
            // cart_section
            // 
            cart_section.Controls.Add(cart_fields);
            cart_section.Controls.Add(cart_buttons);
            cart_section.Controls.Add(cart_divider);
            cart_section.Controls.Add(cart_title_lbl);
            cart_section.Dock = DockStyle.Top;
            cart_section.Location = new Point(0, 350);
            cart_section.Name = "cart_section";
            cart_section.Padding = new Padding(0, 8, 0, 0);
            cart_section.Size = new Size(654, 199);
            cart_section.TabIndex = 1;
            cart_section.Tag = "card";
            // 
            // cart_fields
            // 
            cart_fields.ColumnCount = 2;
            cart_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            cart_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cart_fields.Controls.Add(label7, 0, 0);
            cart_fields.Controls.Add(product_id_tb, 1, 0);
            cart_fields.Controls.Add(label8, 0, 1);
            cart_fields.Controls.Add(qty_tb, 1, 1);
            cart_fields.Dock = DockStyle.Top;
            cart_fields.Location = new Point(0, 41);
            cart_fields.Name = "cart_fields";
            cart_fields.RowCount = 2;
            cart_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            cart_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            cart_fields.Size = new Size(654, 100);
            cart_fields.TabIndex = 2;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(155, 50);
            label7.TabIndex = 0;
            label7.Tag = "muted";
            label7.Text = "Product ID";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(158, 9);
            product_id_tb.Margin = new Padding(3, 5, 3, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(493, 32);
            product_id_tb.TabIndex = 1;
            product_id_tb.Tag = "";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 50);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(155, 50);
            label8.TabIndex = 2;
            label8.Tag = "muted";
            label8.Text = "Quantity";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // qty_tb
            // 
            qty_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qty_tb.Font = new Font("Segoe UI", 11F);
            qty_tb.Location = new Point(158, 59);
            qty_tb.Margin = new Padding(3, 5, 3, 5);
            qty_tb.Name = "qty_tb";
            qty_tb.Size = new Size(493, 32);
            qty_tb.TabIndex = 3;
            qty_tb.Tag = "";
            // 
            // cart_buttons
            // 
            cart_buttons.ColumnCount = 2;
            cart_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cart_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cart_buttons.Controls.Add(add_to_cart_btn, 0, 0);
            cart_buttons.Controls.Add(remove_from_cart_btn, 1, 0);
            cart_buttons.Dock = DockStyle.Bottom;
            cart_buttons.Location = new Point(0, 147);
            cart_buttons.Name = "cart_buttons";
            cart_buttons.RowCount = 1;
            cart_buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            cart_buttons.Size = new Size(654, 52);
            cart_buttons.TabIndex = 3;
            // 
            // add_to_cart_btn
            // 
            add_to_cart_btn.Dock = DockStyle.Fill;
            add_to_cart_btn.FlatAppearance.BorderSize = 0;
            add_to_cart_btn.FlatStyle = FlatStyle.Flat;
            add_to_cart_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            add_to_cart_btn.IconChar = IconChar.CartPlus;
            add_to_cart_btn.IconColor = Color.Black;
            add_to_cart_btn.IconFont = IconFont.Auto;
            add_to_cart_btn.IconSize = 20;
            add_to_cart_btn.Location = new Point(3, 3);
            add_to_cart_btn.Margin = new Padding(3, 3, 6, 3);
            add_to_cart_btn.Name = "add_to_cart_btn";
            add_to_cart_btn.Size = new Size(318, 46);
            add_to_cart_btn.TabIndex = 0;
            add_to_cart_btn.Tag = "cta";
            add_to_cart_btn.Text = "  Add Product";
            add_to_cart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_to_cart_btn.UseVisualStyleBackColor = true;
            add_to_cart_btn.Click += add_to_cart_btn_Click;
            // 
            // remove_from_cart_btn
            // 
            remove_from_cart_btn.Dock = DockStyle.Fill;
            remove_from_cart_btn.FlatStyle = FlatStyle.Flat;
            remove_from_cart_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            remove_from_cart_btn.IconChar = IconChar.TrashCan;
            remove_from_cart_btn.IconColor = Color.Black;
            remove_from_cart_btn.IconFont = IconFont.Auto;
            remove_from_cart_btn.IconSize = 20;
            remove_from_cart_btn.Location = new Point(333, 3);
            remove_from_cart_btn.Margin = new Padding(6, 3, 3, 3);
            remove_from_cart_btn.Name = "remove_from_cart_btn";
            remove_from_cart_btn.Size = new Size(318, 46);
            remove_from_cart_btn.TabIndex = 1;
            remove_from_cart_btn.Tag = "outlined";
            remove_from_cart_btn.Text = "  Remove Product";
            remove_from_cart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            remove_from_cart_btn.UseVisualStyleBackColor = true;
            remove_from_cart_btn.Click += remove_from_cart_btn_Click;
            // 
            // cart_divider
            // 
            cart_divider.Dock = DockStyle.Top;
            cart_divider.Location = new Point(0, 40);
            cart_divider.Name = "cart_divider";
            cart_divider.Size = new Size(654, 1);
            cart_divider.TabIndex = 1;
            cart_divider.Tag = "divider";
            // 
            // cart_title_lbl
            // 
            cart_title_lbl.Dock = DockStyle.Top;
            cart_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cart_title_lbl.Location = new Point(0, 8);
            cart_title_lbl.Name = "cart_title_lbl";
            cart_title_lbl.Size = new Size(654, 32);
            cart_title_lbl.TabIndex = 0;
            cart_title_lbl.Tag = "";
            cart_title_lbl.Text = "Product Cart";
            cart_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sale_fields
            // 
            sale_fields.ColumnCount = 2;
            sale_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            sale_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sale_fields.Controls.Add(label5, 0, 0);
            sale_fields.Controls.Add(search_row, 1, 0);
            sale_fields.Controls.Add(label6, 0, 1);
            sale_fields.Controls.Add(user_id_tb, 1, 1);
            sale_fields.Controls.Add(db_lbl, 0, 2);
            sale_fields.Controls.Add(customer_id_tb, 1, 2);
            sale_fields.Controls.Add(logs_lbl, 0, 3);
            sale_fields.Controls.Add(payment_method_cb, 1, 3);
            sale_fields.Controls.Add(label4, 0, 4);
            sale_fields.Controls.Add(payment_status_cb, 1, 4);
            sale_fields.Controls.Add(label3, 0, 5);
            sale_fields.Controls.Add(date_picker, 1, 5);
            sale_fields.Controls.Add(label2, 0, 6);
            sale_fields.Controls.Add(total_amount_tb, 1, 6);
            sale_fields.Dock = DockStyle.Top;
            sale_fields.Location = new Point(0, 0);
            sale_fields.Name = "sale_fields";
            sale_fields.RowCount = 7;
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            sale_fields.Size = new Size(654, 350);
            sale_fields.TabIndex = 0;
            sale_fields.Tag = "card";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(155, 50);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "Sale ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_row
            // 
            search_row.Controls.Add(sale_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(158, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(493, 44);
            search_row.TabIndex = 1;
            search_row.Tag = "card";
            // 
            // sale_id_tb
            // 
            sale_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sale_id_tb.Font = new Font("Segoe UI", 11F);
            sale_id_tb.Location = new Point(0, 7);
            sale_id_tb.Margin = new Padding(0);
            sale_id_tb.Name = "sale_id_tb";
            sale_id_tb.Size = new Size(341, 32);
            sale_id_tb.TabIndex = 0;
            sale_id_tb.Tag = "";
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.Search;
            search_btn.IconColor = Color.Black;
            search_btn.IconFont = IconFont.Auto;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(353, 3);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(140, 38);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 50);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(155, 50);
            label6.TabIndex = 2;
            label6.Tag = "muted";
            label6.Text = "User ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Enabled = false;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(158, 59);
            user_id_tb.Margin = new Padding(3, 5, 3, 5);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(493, 32);
            user_id_tb.TabIndex = 3;
            user_id_tb.Tag = "";
            // 
            // db_lbl
            // 
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 100);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(155, 50);
            db_lbl.TabIndex = 4;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Customer ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.Font = new Font("Segoe UI", 11F);
            customer_id_tb.Location = new Point(158, 109);
            customer_id_tb.Margin = new Padding(3, 5, 3, 5);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(493, 32);
            customer_id_tb.TabIndex = 5;
            customer_id_tb.Tag = "";
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 150);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(155, 50);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Payment Method";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_method_cb
            // 
            payment_method_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_method_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 11F);
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.Location = new Point(158, 158);
            payment_method_cb.Margin = new Padding(3, 5, 3, 5);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(493, 33);
            payment_method_cb.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 200);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(155, 50);
            label4.TabIndex = 8;
            label4.Tag = "muted";
            label4.Text = "Payment Status";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_status_cb
            // 
            payment_status_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_status_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 11F);
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.Location = new Point(158, 208);
            payment_status_cb.Margin = new Padding(3, 5, 3, 5);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(493, 33);
            payment_status_cb.TabIndex = 9;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 250);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(155, 50);
            label3.TabIndex = 10;
            label3.Tag = "muted";
            label3.Text = "Sale Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_picker
            // 
            date_picker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_picker.Font = new Font("Segoe UI", 11F);
            date_picker.Format = DateTimePickerFormat.Short;
            date_picker.Location = new Point(158, 259);
            date_picker.Margin = new Padding(3, 5, 3, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(493, 32);
            date_picker.TabIndex = 11;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 300);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(155, 50);
            label2.TabIndex = 12;
            label2.Tag = "muted";
            label2.Text = "Total Amount";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_amount_tb
            // 
            total_amount_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_amount_tb.Enabled = false;
            total_amount_tb.Font = new Font("Segoe UI", 11F);
            total_amount_tb.Location = new Point(158, 309);
            total_amount_tb.Margin = new Padding(3, 5, 3, 5);
            total_amount_tb.Name = "total_amount_tb";
            total_amount_tb.Size = new Size(493, 32);
            total_amount_tb.TabIndex = 13;
            total_amount_tb.Tag = "";
            //
            // ModifySale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifySale";
            Size = new Size(1420, 717);
            base_pnl.ResumeLayout(false);
            left_pnl.ResumeLayout(false);
            cart_section.ResumeLayout(false);
            cart_fields.ResumeLayout(false);
            cart_fields.PerformLayout();
            cart_buttons.ResumeLayout(false);
            sale_fields.ResumeLayout(false);
            sale_fields.PerformLayout();
            search_row.ResumeLayout(false);
            search_row.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel left_pnl;
        private TableLayoutPanel sale_fields;
        private Label label5;
        private Panel search_row;
        private TextBox sale_id_tb;
        private IconButton search_btn;
        private Label label6;
        private TextBox user_id_tb;
        private Label db_lbl;
        private TextBox customer_id_tb;
        private Label logs_lbl;
        private ComboBox payment_method_cb;
        private Label label4;
        private ComboBox payment_status_cb;
        private Label label3;
        private DateTimePicker date_picker;
        private Label label2;
        private TextBox total_amount_tb;
        private Panel cart_section;
        private Label cart_title_lbl;
        private Panel cart_divider;
        private TableLayoutPanel cart_fields;
        private Label label7;
        private TextBox product_id_tb;
        private Label label8;
        private TextBox qty_tb;
        private TableLayoutPanel cart_buttons;
        private IconButton add_to_cart_btn;
        private IconButton remove_from_cart_btn;
    }
}
