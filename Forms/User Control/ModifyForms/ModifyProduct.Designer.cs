using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class ModifyProduct
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
            fields_table = new TableLayoutPanel();
            panel11 = new Panel();
            panel12 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            unit_measure_tb = new TextBox();
            panel9 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            safety_stock_tb = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            current_stock_tb = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            unit_price_tb = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            supplier_id_tb = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            product_name_tb = new TextBox();
            settings_lbl = new Label();
            db_lbl = new Label();
            logs_lbl = new Label();
            product_category_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            product_id_tb = new TextBox();
            search_btn = new IconButton();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(fields_table);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(28, 24, 28, 24);
            base_pnl.Size = new Size(907, 572);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            // 
            // fields_table
            // 
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(panel11, 1, 7);
            fields_table.Controls.Add(panel9, 1, 6);
            fields_table.Controls.Add(panel7, 1, 5);
            fields_table.Controls.Add(panel5, 1, 4);
            fields_table.Controls.Add(panel3, 1, 3);
            fields_table.Controls.Add(panel1, 1, 1);
            fields_table.Controls.Add(settings_lbl, 0, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(logs_lbl, 0, 2);
            fields_table.Controls.Add(product_category_cb, 1, 2);
            fields_table.Controls.Add(label6, 0, 3);
            fields_table.Controls.Add(label2, 0, 4);
            fields_table.Controls.Add(label3, 0, 5);
            fields_table.Controls.Add(label4, 0, 6);
            fields_table.Controls.Add(label5, 0, 7);
            fields_table.Controls.Add(tableLayoutPanel8, 1, 0);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 8;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fields_table.Size = new Size(851, 433);
            fields_table.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(176, 388);
            panel11.Margin = new Padding(6, 10, 0, 10);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(1);
            panel11.Size = new Size(675, 35);
            panel11.TabIndex = 21;
            panel11.Tag = "border_pnl";
            // 
            // panel12
            // 
            panel12.Controls.Add(tableLayoutPanel7);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(1, 1);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(673, 33);
            panel12.TabIndex = 0;
            panel12.Tag = "card";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(unit_measure_tb, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(673, 33);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // unit_measure_tb
            // 
            unit_measure_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_measure_tb.Font = new Font("Segoe UI", 11F);
            unit_measure_tb.Location = new Point(0, 0);
            unit_measure_tb.Margin = new Padding(0);
            unit_measure_tb.Name = "unit_measure_tb";
            unit_measure_tb.Size = new Size(673, 32);
            unit_measure_tb.TabIndex = 15;
            unit_measure_tb.Tag = "borderless";
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(176, 334);
            panel9.Margin = new Padding(6, 10, 0, 10);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(1);
            panel9.Size = new Size(675, 34);
            panel9.TabIndex = 20;
            panel9.Tag = "border_pnl";
            // 
            // panel10
            // 
            panel10.Controls.Add(tableLayoutPanel5);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1, 1);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(673, 32);
            panel10.TabIndex = 0;
            panel10.Tag = "card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(safety_stock_tb, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(673, 32);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // safety_stock_tb
            // 
            safety_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            safety_stock_tb.Font = new Font("Segoe UI", 11F);
            safety_stock_tb.Location = new Point(0, 0);
            safety_stock_tb.Margin = new Padding(0);
            safety_stock_tb.Name = "safety_stock_tb";
            safety_stock_tb.Size = new Size(673, 32);
            safety_stock_tb.TabIndex = 13;
            safety_stock_tb.Tag = "borderless";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(176, 280);
            panel7.Margin = new Padding(6, 10, 0, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(675, 34);
            panel7.TabIndex = 19;
            panel7.Tag = "border_pnl";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(673, 32);
            panel8.TabIndex = 0;
            panel8.Tag = "card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(current_stock_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(673, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // current_stock_tb
            // 
            current_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            current_stock_tb.Font = new Font("Segoe UI", 11F);
            current_stock_tb.Location = new Point(0, 0);
            current_stock_tb.Margin = new Padding(0);
            current_stock_tb.Name = "current_stock_tb";
            current_stock_tb.Size = new Size(673, 32);
            current_stock_tb.TabIndex = 11;
            current_stock_tb.Tag = "borderless";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(176, 226);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(675, 34);
            panel5.TabIndex = 18;
            panel5.Tag = "border_pnl";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(673, 32);
            panel6.TabIndex = 0;
            panel6.Tag = "card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(unit_price_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(673, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // unit_price_tb
            // 
            unit_price_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_price_tb.Font = new Font("Segoe UI", 11F);
            unit_price_tb.Location = new Point(0, 0);
            unit_price_tb.Margin = new Padding(0);
            unit_price_tb.Name = "unit_price_tb";
            unit_price_tb.Size = new Size(673, 32);
            unit_price_tb.TabIndex = 9;
            unit_price_tb.Tag = "borderless";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 172);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(675, 34);
            panel3.TabIndex = 17;
            panel3.Tag = "border_pnl";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(673, 32);
            panel4.TabIndex = 0;
            panel4.Tag = "card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(supplier_id_tb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(673, 32);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // supplier_id_tb
            // 
            supplier_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_id_tb.Font = new Font("Segoe UI", 11F);
            supplier_id_tb.Location = new Point(0, 0);
            supplier_id_tb.Margin = new Padding(0);
            supplier_id_tb.Name = "supplier_id_tb";
            supplier_id_tb.Size = new Size(673, 32);
            supplier_id_tb.TabIndex = 7;
            supplier_id_tb.Tag = "borderless";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(176, 64);
            panel1.Margin = new Padding(6, 10, 0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(675, 34);
            panel1.TabIndex = 16;
            panel1.Tag = "border_pnl";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 32);
            panel2.TabIndex = 0;
            panel2.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(product_name_tb, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(673, 32);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // product_name_tb
            // 
            product_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_name_tb.Font = new Font("Segoe UI", 11F);
            product_name_tb.Location = new Point(0, 0);
            product_name_tb.Margin = new Padding(0);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(673, 32);
            product_name_tb.TabIndex = 3;
            product_name_tb.Tag = "borderless";
            // 
            // settings_lbl
            // 
            settings_lbl.Dock = DockStyle.Fill;
            settings_lbl.Font = new Font("Segoe UI", 10F);
            settings_lbl.Location = new Point(0, 0);
            settings_lbl.Margin = new Padding(0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(170, 54);
            settings_lbl.TabIndex = 0;
            settings_lbl.Tag = "muted";
            settings_lbl.Text = "Product ID";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 54);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(170, 54);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Product Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 108);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(170, 54);
            logs_lbl.TabIndex = 4;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Category";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_category_cb
            // 
            product_category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_category_cb.DrawMode = DrawMode.OwnerDrawFixed;
            product_category_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            product_category_cb.FlatStyle = FlatStyle.Flat;
            product_category_cb.Font = new Font("Segoe UI", 11F);
            product_category_cb.FormattingEnabled = true;
            product_category_cb.ItemHeight = 30;
            product_category_cb.Location = new Point(173, 117);
            product_category_cb.Margin = new Padding(3, 5, 3, 5);
            product_category_cb.Name = "product_category_cb";
            product_category_cb.Size = new Size(675, 36);
            product_category_cb.TabIndex = 5;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 162);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(170, 54);
            label6.TabIndex = 6;
            label6.Tag = "muted";
            label6.Text = "Supplier ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 216);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(170, 54);
            label2.TabIndex = 8;
            label2.Tag = "muted";
            label2.Text = "Unit Price";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 270);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(170, 54);
            label3.TabIndex = 10;
            label3.Tag = "muted";
            label3.Text = "Current Stock";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 324);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(170, 54);
            label4.TabIndex = 12;
            label4.Tag = "muted";
            label4.Text = "Safety Stock";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 378);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(170, 55);
            label5.TabIndex = 14;
            label5.Tag = "muted";
            label5.Text = "Unit of Measure";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel8.Controls.Add(border_theme_pnl, 0, 0);
            tableLayoutPanel8.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(170, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(681, 54);
            tableLayoutPanel8.TabIndex = 22;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Location = new Point(6, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(565, 34);
            border_theme_pnl.TabIndex = 6;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(563, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(product_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(563, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(0, 0);
            product_id_tb.Margin = new Padding(0);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(563, 32);
            product_id_tb.TabIndex = 0;
            product_id_tb.Tag = "borderless";
            // 
            // search_btn
            // 
            search_btn.Dock = DockStyle.Fill;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.Search;
            search_btn.IconColor = Color.Black;
            search_btn.IconFont = IconFont.Auto;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(577, 10);
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
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyProduct";
            Size = new Size(907, 572);
            base_pnl.ResumeLayout(false);
            fields_table.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label settings_lbl;
        private TextBox product_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox product_name_tb;
        private Label logs_lbl;
        private SmartStock.Classes.Utils.ThemedComboBox product_category_cb;
        private Label label6;
        private TextBox supplier_id_tb;
        private Label label2;
        private TextBox unit_price_tb;
        private Label label3;
        private TextBox current_stock_tb;
        private Label label4;
        private TextBox safety_stock_tb;
        private Label label5;
        private TextBox unit_measure_tb;
        private Panel panel11;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel9;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
    }
}
