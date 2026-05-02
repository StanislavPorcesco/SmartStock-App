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
            panel9 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            qty_tb = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            product_id_tb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cart_buttons = new TableLayoutPanel();
            add_to_cart_btn = new IconButton();
            remove_from_cart_btn = new IconButton();
            cart_divider = new Panel();
            cart_title_lbl = new Label();
            sale_fields = new TableLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            total_amount_tb = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            customer_id_tb = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            user_id_tb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            db_lbl = new Label();
            logs_lbl = new Label();
            payment_method_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label4 = new Label();
            payment_status_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label3 = new Label();
            date_picker = new DateTimePicker();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            sale_id_tb = new TextBox();
            search_btn = new IconButton();
            base_pnl.SuspendLayout();
            left_pnl.SuspendLayout();
            cart_section.SuspendLayout();
            cart_fields.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            cart_buttons.SuspendLayout();
            sale_fields.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            base_pnl.Size = new Size(903, 829);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            // 
            // left_pnl
            // 
            left_pnl.Controls.Add(cart_section);
            left_pnl.Controls.Add(sale_fields);
            left_pnl.Dock = DockStyle.Top;
            left_pnl.Location = new Point(20, 16);
            left_pnl.Margin = new Padding(0);
            left_pnl.Name = "left_pnl";
            left_pnl.Size = new Size(863, 640);
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
            cart_section.Location = new Point(0, 380);
            cart_section.Name = "cart_section";
            cart_section.Padding = new Padding(0, 8, 0, 0);
            cart_section.Size = new Size(863, 238);
            cart_section.TabIndex = 1;
            cart_section.Tag = "card";
            // 
            // cart_fields
            // 
            cart_fields.ColumnCount = 2;
            cart_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            cart_fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cart_fields.Controls.Add(panel9, 1, 2);
            cart_fields.Controls.Add(panel7, 1, 1);
            cart_fields.Controls.Add(label7, 0, 1);
            cart_fields.Controls.Add(label8, 0, 2);
            cart_fields.Dock = DockStyle.Top;
            cart_fields.Location = new Point(0, 59);
            cart_fields.Name = "cart_fields";
            cart_fields.RowCount = 3;
            cart_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            cart_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            cart_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            cart_fields.Size = new Size(863, 110);
            cart_fields.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(161, 69);
            panel9.Margin = new Padding(6, 10, 0, 10);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(1);
            panel9.Size = new Size(702, 34);
            panel9.TabIndex = 8;
            panel9.Tag = "border_pnl";
            // 
            // panel10
            // 
            panel10.Controls.Add(tableLayoutPanel7);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1, 1);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(700, 32);
            panel10.TabIndex = 0;
            panel10.Tag = "card";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(qty_tb, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(700, 32);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // qty_tb
            // 
            qty_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            qty_tb.Font = new Font("Segoe UI", 11F);
            qty_tb.Location = new Point(0, 0);
            qty_tb.Margin = new Padding(0);
            qty_tb.Name = "qty_tb";
            qty_tb.Size = new Size(700, 32);
            qty_tb.TabIndex = 3;
            qty_tb.Tag = "borderless";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(161, 15);
            panel7.Margin = new Padding(6, 10, 0, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(702, 34);
            panel7.TabIndex = 7;
            panel7.Tag = "border_pnl";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(700, 32);
            panel8.TabIndex = 0;
            panel8.Tag = "card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(product_id_tb, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(700, 32);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(0, 0);
            product_id_tb.Margin = new Padding(0);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(700, 32);
            product_id_tb.TabIndex = 1;
            product_id_tb.Tag = "borderless";
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 5);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(155, 54);
            label7.TabIndex = 0;
            label7.Tag = "muted";
            label7.Text = "Product ID";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 59);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(155, 54);
            label8.TabIndex = 2;
            label8.Tag = "muted";
            label8.Text = "Quantity";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cart_buttons
            // 
            cart_buttons.ColumnCount = 2;
            cart_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cart_buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cart_buttons.Controls.Add(add_to_cart_btn, 1, 0);
            cart_buttons.Controls.Add(remove_from_cart_btn, 0, 0);
            cart_buttons.Dock = DockStyle.Bottom;
            cart_buttons.Location = new Point(0, 186);
            cart_buttons.Margin = new Padding(0);
            cart_buttons.Name = "cart_buttons";
            cart_buttons.RowCount = 1;
            cart_buttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            cart_buttons.Size = new Size(863, 52);
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
            add_to_cart_btn.Location = new Point(437, 0);
            add_to_cart_btn.Margin = new Padding(6, 0, 0, 0);
            add_to_cart_btn.Name = "add_to_cart_btn";
            add_to_cart_btn.Size = new Size(426, 52);
            add_to_cart_btn.TabIndex = 0;
            add_to_cart_btn.Tag = "cta";
            add_to_cart_btn.Text = "  Add Product";
            add_to_cart_btn.TextAlign = ContentAlignment.MiddleRight;
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
            remove_from_cart_btn.Location = new Point(0, 0);
            remove_from_cart_btn.Margin = new Padding(0);
            remove_from_cart_btn.Name = "remove_from_cart_btn";
            remove_from_cart_btn.Size = new Size(431, 52);
            remove_from_cart_btn.TabIndex = 1;
            remove_from_cart_btn.Tag = "outlined";
            remove_from_cart_btn.Text = "  Remove Product";
            remove_from_cart_btn.TextAlign = ContentAlignment.MiddleRight;
            remove_from_cart_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            remove_from_cart_btn.UseVisualStyleBackColor = true;
            remove_from_cart_btn.Click += remove_from_cart_btn_Click;
            // 
            // cart_divider
            // 
            cart_divider.Dock = DockStyle.Top;
            cart_divider.Location = new Point(0, 58);
            cart_divider.Name = "cart_divider";
            cart_divider.Size = new Size(863, 1);
            cart_divider.TabIndex = 1;
            cart_divider.Tag = "divider";
            // 
            // cart_title_lbl
            // 
            cart_title_lbl.Dock = DockStyle.Top;
            cart_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cart_title_lbl.Location = new Point(0, 8);
            cart_title_lbl.Name = "cart_title_lbl";
            cart_title_lbl.Size = new Size(863, 50);
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
            sale_fields.Controls.Add(panel5, 1, 6);
            sale_fields.Controls.Add(panel3, 1, 2);
            sale_fields.Controls.Add(panel1, 1, 1);
            sale_fields.Controls.Add(label5, 0, 0);
            sale_fields.Controls.Add(label6, 0, 1);
            sale_fields.Controls.Add(db_lbl, 0, 2);
            sale_fields.Controls.Add(logs_lbl, 0, 3);
            sale_fields.Controls.Add(payment_method_cb, 1, 3);
            sale_fields.Controls.Add(label4, 0, 4);
            sale_fields.Controls.Add(payment_status_cb, 1, 4);
            sale_fields.Controls.Add(label3, 0, 5);
            sale_fields.Controls.Add(date_picker, 1, 5);
            sale_fields.Controls.Add(label2, 0, 6);
            sale_fields.Controls.Add(tableLayoutPanel1, 1, 0);
            sale_fields.Dock = DockStyle.Top;
            sale_fields.Location = new Point(0, 0);
            sale_fields.Name = "sale_fields";
            sale_fields.RowCount = 7;
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            sale_fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sale_fields.Size = new Size(863, 380);
            sale_fields.TabIndex = 0;
            sale_fields.Tag = "card";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(161, 334);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(702, 36);
            panel5.TabIndex = 17;
            panel5.Tag = "border_pnl";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(700, 34);
            panel6.TabIndex = 0;
            panel6.Tag = "card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(total_amount_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(700, 34);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // total_amount_tb
            // 
            total_amount_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_amount_tb.Enabled = false;
            total_amount_tb.Font = new Font("Segoe UI", 11F);
            total_amount_tb.Location = new Point(0, 1);
            total_amount_tb.Margin = new Padding(0);
            total_amount_tb.Name = "total_amount_tb";
            total_amount_tb.Size = new Size(700, 32);
            total_amount_tb.TabIndex = 13;
            total_amount_tb.Tag = "borderless";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(161, 118);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(702, 34);
            panel3.TabIndex = 16;
            panel3.Tag = "border_pnl";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(700, 32);
            panel4.TabIndex = 0;
            panel4.Tag = "card";
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
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(700, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.Font = new Font("Segoe UI", 11F);
            customer_id_tb.Location = new Point(0, 0);
            customer_id_tb.Margin = new Padding(0);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(700, 32);
            customer_id_tb.TabIndex = 5;
            customer_id_tb.Tag = "borderless";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(161, 64);
            panel1.Margin = new Padding(6, 10, 0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(702, 34);
            panel1.TabIndex = 15;
            panel1.Tag = "border_pnl";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 32);
            panel2.TabIndex = 0;
            panel2.Tag = "card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(user_id_tb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(700, 32);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Enabled = false;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(0, 0);
            user_id_tb.Margin = new Padding(0);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(700, 32);
            user_id_tb.TabIndex = 3;
            user_id_tb.Tag = "borderless";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(155, 54);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "Sale ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 54);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(155, 54);
            label6.TabIndex = 2;
            label6.Tag = "muted";
            label6.Text = "User ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 108);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(155, 54);
            db_lbl.TabIndex = 4;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Customer ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 162);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(155, 54);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Payment Method";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_method_cb
            // 
            payment_method_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_method_cb.DrawMode = DrawMode.OwnerDrawFixed;
            payment_method_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_method_cb.FlatStyle = FlatStyle.Flat;
            payment_method_cb.Font = new Font("Segoe UI", 11F);
            payment_method_cb.FormattingEnabled = true;
            payment_method_cb.ItemHeight = 30;
            payment_method_cb.Location = new Point(158, 171);
            payment_method_cb.Margin = new Padding(3, 5, 3, 5);
            payment_method_cb.Name = "payment_method_cb";
            payment_method_cb.Size = new Size(702, 36);
            payment_method_cb.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 216);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(155, 54);
            label4.TabIndex = 8;
            label4.Tag = "muted";
            label4.Text = "Payment Status";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payment_status_cb
            // 
            payment_status_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payment_status_cb.DrawMode = DrawMode.OwnerDrawFixed;
            payment_status_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            payment_status_cb.FlatStyle = FlatStyle.Flat;
            payment_status_cb.Font = new Font("Segoe UI", 11F);
            payment_status_cb.FormattingEnabled = true;
            payment_status_cb.ItemHeight = 30;
            payment_status_cb.Location = new Point(158, 225);
            payment_status_cb.Margin = new Padding(3, 5, 3, 5);
            payment_status_cb.Name = "payment_status_cb";
            payment_status_cb.Size = new Size(702, 36);
            payment_status_cb.TabIndex = 9;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 270);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(155, 54);
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
            date_picker.Location = new Point(158, 281);
            date_picker.Margin = new Padding(3, 5, 3, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(702, 32);
            date_picker.TabIndex = 11;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 324);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(155, 56);
            label2.TabIndex = 12;
            label2.Tag = "muted";
            label2.Text = "Total Amount";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 0, 0);
            tableLayoutPanel1.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(155, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(708, 54);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(6, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(592, 34);
            border_theme_pnl.TabIndex = 7;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(590, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(sale_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(590, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // sale_id_tb
            // 
            sale_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sale_id_tb.Font = new Font("Segoe UI", 11F);
            sale_id_tb.Location = new Point(0, 0);
            sale_id_tb.Margin = new Padding(0);
            sale_id_tb.Name = "sale_id_tb";
            sale_id_tb.Size = new Size(590, 32);
            sale_id_tb.TabIndex = 0;
            sale_id_tb.Tag = "borderless";
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
            search_btn.Location = new Point(604, 10);
            search_btn.Margin = new Padding(6, 10, 0, 10);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(104, 34);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // ModifySale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifySale";
            Size = new Size(903, 829);
            base_pnl.ResumeLayout(false);
            left_pnl.ResumeLayout(false);
            cart_section.ResumeLayout(false);
            cart_fields.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            cart_buttons.ResumeLayout(false);
            sale_fields.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel left_pnl;
        private TableLayoutPanel sale_fields;
        private Label label5;
        private TextBox sale_id_tb;
        private IconButton search_btn;
        private Label label6;
        private TextBox user_id_tb;
        private Label db_lbl;
        private TextBox customer_id_tb;
        private Label logs_lbl;
        private SmartStock.Classes.Utils.ThemedComboBox payment_method_cb;
        private Label label4;
        private SmartStock.Classes.Utils.ThemedComboBox payment_status_cb;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel9;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
