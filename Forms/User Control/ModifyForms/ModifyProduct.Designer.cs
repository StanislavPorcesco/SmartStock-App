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
            settings_lbl = new Label();
            search_row = new Panel();
            product_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            product_name_tb = new TextBox();
            logs_lbl = new Label();
            product_category_cb = new ComboBox();
            label6 = new Label();
            supplier_id_tb = new TextBox();
            label2 = new Label();
            unit_price_tb = new TextBox();
            label3 = new Label();
            current_stock_tb = new TextBox();
            label4 = new Label();
            safety_stock_tb = new TextBox();
            label5 = new Label();
            unit_measure_tb = new TextBox();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            search_row.SuspendLayout();
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
            fields_table.Controls.Add(settings_lbl, 0, 0);
            fields_table.Controls.Add(search_row, 1, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(product_name_tb, 1, 1);
            fields_table.Controls.Add(logs_lbl, 0, 2);
            fields_table.Controls.Add(product_category_cb, 1, 2);
            fields_table.Controls.Add(label6, 0, 3);
            fields_table.Controls.Add(supplier_id_tb, 1, 3);
            fields_table.Controls.Add(label2, 0, 4);
            fields_table.Controls.Add(unit_price_tb, 1, 4);
            fields_table.Controls.Add(label3, 0, 5);
            fields_table.Controls.Add(current_stock_tb, 1, 5);
            fields_table.Controls.Add(label4, 0, 6);
            fields_table.Controls.Add(safety_stock_tb, 1, 6);
            fields_table.Controls.Add(label5, 0, 7);
            fields_table.Controls.Add(unit_measure_tb, 1, 7);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 8;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.Size = new Size(851, 416);
            fields_table.TabIndex = 0;
            // 
            // settings_lbl
            // 
            settings_lbl.Dock = DockStyle.Fill;
            settings_lbl.Font = new Font("Segoe UI", 10F);
            settings_lbl.Location = new Point(0, 0);
            settings_lbl.Margin = new Padding(0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(170, 52);
            settings_lbl.TabIndex = 0;
            settings_lbl.Tag = "muted";
            settings_lbl.Text = "Product ID";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_row
            // 
            search_row.Controls.Add(product_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(173, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(675, 46);
            search_row.TabIndex = 1;
            search_row.Tag = "card";
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(0, 8);
            product_id_tb.Margin = new Padding(0);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(523, 32);
            product_id_tb.TabIndex = 0;
            product_id_tb.Tag = "";
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
            search_btn.Location = new Point(535, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(140, 38);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // db_lbl
            // 
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 52);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(170, 52);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Product Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_name_tb
            // 
            product_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_name_tb.Font = new Font("Segoe UI", 11F);
            product_name_tb.Location = new Point(173, 62);
            product_name_tb.Margin = new Padding(3, 5, 3, 5);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(675, 32);
            product_name_tb.TabIndex = 3;
            product_name_tb.Tag = "";
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 104);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(170, 52);
            logs_lbl.TabIndex = 4;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Category";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_category_cb
            // 
            product_category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_category_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            product_category_cb.FlatStyle = FlatStyle.Flat;
            product_category_cb.Font = new Font("Segoe UI", 11F);
            product_category_cb.FormattingEnabled = true;
            product_category_cb.Location = new Point(173, 113);
            product_category_cb.Margin = new Padding(3, 5, 3, 5);
            product_category_cb.Name = "product_category_cb";
            product_category_cb.Size = new Size(675, 33);
            product_category_cb.TabIndex = 5;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 156);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(170, 52);
            label6.TabIndex = 6;
            label6.Tag = "muted";
            label6.Text = "Supplier ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_id_tb
            // 
            supplier_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_id_tb.Font = new Font("Segoe UI", 11F);
            supplier_id_tb.Location = new Point(173, 166);
            supplier_id_tb.Margin = new Padding(3, 5, 3, 5);
            supplier_id_tb.Name = "supplier_id_tb";
            supplier_id_tb.Size = new Size(675, 32);
            supplier_id_tb.TabIndex = 7;
            supplier_id_tb.Tag = "";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 208);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(170, 52);
            label2.TabIndex = 8;
            label2.Tag = "muted";
            label2.Text = "Unit Price";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_price_tb
            // 
            unit_price_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_price_tb.Font = new Font("Segoe UI", 11F);
            unit_price_tb.Location = new Point(173, 218);
            unit_price_tb.Margin = new Padding(3, 5, 3, 5);
            unit_price_tb.Name = "unit_price_tb";
            unit_price_tb.Size = new Size(675, 32);
            unit_price_tb.TabIndex = 9;
            unit_price_tb.Tag = "";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 260);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(170, 52);
            label3.TabIndex = 10;
            label3.Tag = "muted";
            label3.Text = "Current Stock";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // current_stock_tb
            // 
            current_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            current_stock_tb.Font = new Font("Segoe UI", 11F);
            current_stock_tb.Location = new Point(173, 270);
            current_stock_tb.Margin = new Padding(3, 5, 3, 5);
            current_stock_tb.Name = "current_stock_tb";
            current_stock_tb.Size = new Size(675, 32);
            current_stock_tb.TabIndex = 11;
            current_stock_tb.Tag = "";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 312);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(170, 52);
            label4.TabIndex = 12;
            label4.Tag = "muted";
            label4.Text = "Safety Stock";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // safety_stock_tb
            // 
            safety_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            safety_stock_tb.Font = new Font("Segoe UI", 11F);
            safety_stock_tb.Location = new Point(173, 322);
            safety_stock_tb.Margin = new Padding(3, 5, 3, 5);
            safety_stock_tb.Name = "safety_stock_tb";
            safety_stock_tb.Size = new Size(675, 32);
            safety_stock_tb.TabIndex = 13;
            safety_stock_tb.Tag = "";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 364);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(170, 52);
            label5.TabIndex = 14;
            label5.Tag = "muted";
            label5.Text = "Unit of Measure";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_measure_tb
            // 
            unit_measure_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_measure_tb.Font = new Font("Segoe UI", 11F);
            unit_measure_tb.Location = new Point(173, 374);
            unit_measure_tb.Margin = new Padding(3, 5, 3, 5);
            unit_measure_tb.Name = "unit_measure_tb";
            unit_measure_tb.Size = new Size(675, 32);
            unit_measure_tb.TabIndex = 15;
            unit_measure_tb.Tag = "";
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
            fields_table.PerformLayout();
            search_row.ResumeLayout(false);
            search_row.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label settings_lbl;
        private Panel search_row;
        private TextBox product_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox product_name_tb;
        private Label logs_lbl;
        private ComboBox product_category_cb;
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
    }
}
