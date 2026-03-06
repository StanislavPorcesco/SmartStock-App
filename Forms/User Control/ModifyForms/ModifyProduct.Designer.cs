using SmartStock.Classes.Utils;
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
            panel1 = new Panel();
            add_btn = new Button();
            delete_btn = new Button();
            margin_pnl = new Panel();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            search_btn = new Button();
            product_id_tb = new TextBox();
            product_category_cb = new ComboBox();
            settings_lbl = new Label();
            db_lbl = new Label();
            product_name_tb = new TextBox();
            logs_lbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            unit_measure_tb = new TextBox();
            safety_stock_tb = new TextBox();
            current_stock_tb = new TextBox();
            unit_price_tb = new TextBox();
            supplier_id_tb = new TextBox();
            selector_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            selector_cb = new ComboBox();
            label1 = new Label();
            base_pnl.SuspendLayout();
            panel1.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            selector_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(panel1);
            base_pnl.Controls.Add(margin_pnl);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1085, 779);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // panel1
            // 
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(delete_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 604);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 155);
            panel1.TabIndex = 12;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(54, 54, 54);
            add_btn.Dock = DockStyle.Bottom;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(0, 86);
            add_btn.Margin = new Padding(0);
            add_btn.MaximumSize = new Size(0, 69);
            add_btn.MinimumSize = new Size(0, 69);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(1045, 69);
            add_btn.TabIndex = 0;
            add_btn.Text = "Apply Changes";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(54, 54, 54);
            delete_btn.Dock = DockStyle.Top;
            delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(0, 0);
            delete_btn.Margin = new Padding(0);
            delete_btn.MaximumSize = new Size(0, 69);
            delete_btn.MinimumSize = new Size(0, 69);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(1045, 69);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "Delete Instance";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // margin_pnl
            // 
            margin_pnl.BackColor = Color.Transparent;
            margin_pnl.Dock = DockStyle.Top;
            margin_pnl.Location = new Point(20, 582);
            margin_pnl.MaximumSize = new Size(0, 20);
            margin_pnl.MinimumSize = new Size(0, 20);
            margin_pnl.Name = "margin_pnl";
            margin_pnl.Size = new Size(1045, 20);
            margin_pnl.TabIndex = 9;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 150);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1045, 432);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(1025, 412);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Product";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(product_category_cb, 1, 2);
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(product_name_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 7);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(label3, 0, 5);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(unit_measure_tb, 1, 7);
            tableLayoutPanel2.Controls.Add(safety_stock_tb, 1, 6);
            tableLayoutPanel2.Controls.Add(current_stock_tb, 1, 5);
            tableLayoutPanel2.Controls.Add(unit_price_tb, 1, 4);
            tableLayoutPanel2.Controls.Add(supplier_id_tb, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1005, 341);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7438F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2562F));
            tableLayoutPanel3.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel3.Controls.Add(product_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(504, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(498, 39);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(54, 54, 54);
            search_btn.Dock = DockStyle.Fill;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(262, 4);
            search_btn.Margin = new Padding(10, 4, 0, 0);
            search_btn.MaximumSize = new Size(0, 34);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(236, 34);
            search_btn.TabIndex = 27;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // product_id_tb
            // 
            product_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            product_id_tb.Dock = DockStyle.Fill;
            product_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_id_tb.ForeColor = Color.White;
            product_id_tb.Location = new Point(0, 5);
            product_id_tb.Margin = new Padding(0, 5, 10, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(242, 31);
            product_id_tb.TabIndex = 26;
            // 
            // product_category_cb
            // 
            product_category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_category_cb.BackColor = Color.FromArgb(54, 54, 54);
            product_category_cb.FlatStyle = FlatStyle.Flat;
            product_category_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_category_cb.ForeColor = Color.White;
            product_category_cb.FormattingEnabled = true;
            product_category_cb.Location = new Point(501, 91);
            product_category_cb.Margin = new Padding(0, 5, 0, 5);
            product_category_cb.Name = "product_category_cb";
            product_category_cb.Size = new Size(504, 33);
            product_category_cb.TabIndex = 22;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(103, 45);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Product ID";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 45);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(134, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Product Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_name_tb
            // 
            product_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_name_tb.BackColor = Color.FromArgb(54, 54, 54);
            product_name_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_name_tb.ForeColor = Color.White;
            product_name_tb.Location = new Point(501, 50);
            product_name_tb.Margin = new Padding(0, 5, 0, 5);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(504, 31);
            product_name_tb.TabIndex = 12;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 86);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(152, 43);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Product Category";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(3, 293);
            label5.Name = "label5";
            label5.Size = new Size(141, 48);
            label5.TabIndex = 20;
            label5.Text = "Unit Of Measure";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 252);
            label4.Name = "label4";
            label4.Size = new Size(111, 41);
            label4.TabIndex = 18;
            label4.Text = "Safety Stock";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 211);
            label3.Name = "label3";
            label3.Size = new Size(121, 41);
            label3.TabIndex = 16;
            label3.Text = "Current Stock";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 170);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 14;
            label2.Text = "Unit Price";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(3, 129);
            label6.Name = "label6";
            label6.Size = new Size(101, 41);
            label6.TabIndex = 34;
            label6.Text = "Supplier ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_measure_tb
            // 
            unit_measure_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_measure_tb.BackColor = Color.FromArgb(54, 54, 54);
            unit_measure_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            unit_measure_tb.ForeColor = Color.White;
            unit_measure_tb.Location = new Point(501, 301);
            unit_measure_tb.Margin = new Padding(0, 5, 0, 5);
            unit_measure_tb.Name = "unit_measure_tb";
            unit_measure_tb.Size = new Size(504, 31);
            unit_measure_tb.TabIndex = 21;
            // 
            // safety_stock_tb
            // 
            safety_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            safety_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            safety_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            safety_stock_tb.ForeColor = Color.White;
            safety_stock_tb.Location = new Point(501, 257);
            safety_stock_tb.Margin = new Padding(0, 5, 0, 5);
            safety_stock_tb.Name = "safety_stock_tb";
            safety_stock_tb.Size = new Size(504, 31);
            safety_stock_tb.TabIndex = 19;
            // 
            // current_stock_tb
            // 
            current_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            current_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            current_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            current_stock_tb.ForeColor = Color.White;
            current_stock_tb.Location = new Point(501, 216);
            current_stock_tb.Margin = new Padding(0, 5, 0, 5);
            current_stock_tb.Name = "current_stock_tb";
            current_stock_tb.Size = new Size(504, 31);
            current_stock_tb.TabIndex = 17;
            // 
            // unit_price_tb
            // 
            unit_price_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_price_tb.BackColor = Color.FromArgb(54, 54, 54);
            unit_price_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            unit_price_tb.ForeColor = Color.White;
            unit_price_tb.Location = new Point(501, 175);
            unit_price_tb.Margin = new Padding(0, 5, 0, 5);
            unit_price_tb.Name = "unit_price_tb";
            unit_price_tb.Size = new Size(504, 31);
            unit_price_tb.TabIndex = 15;
            // 
            // supplier_id_tb
            // 
            supplier_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_id_tb.ForeColor = Color.White;
            supplier_id_tb.Location = new Point(501, 134);
            supplier_id_tb.Margin = new Padding(0, 5, 0, 5);
            supplier_id_tb.Name = "supplier_id_tb";
            supplier_id_tb.Size = new Size(504, 31);
            supplier_id_tb.TabIndex = 35;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(groupBox1);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(1045, 130);
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
            groupBox1.Size = new Size(1025, 110);
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
            tableLayoutPanel1.Size = new Size(1005, 50);
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
            selector_cb.Location = new Point(502, 8);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(503, 33);
            selector_cb.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(496, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the desired instance";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyProduct";
            Size = new Size(1085, 779);
            base_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            selector_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel margin_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox product_category_cb;
        private TextBox unit_measure_tb;
        private Label label5;
        private TextBox safety_stock_tb;
        private Label label4;
        private TextBox current_stock_tb;
        private Label label3;
        private TextBox unit_price_tb;
        private Label label2;
        private Label settings_lbl;
        private Label db_lbl;
        private TextBox product_name_tb;
        private Label logs_lbl;
        private Panel selector_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selector_cb;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button search_btn;
        private TextBox product_id_tb;
        private Label label6;
        private TextBox supplier_id_tb;
        private Panel panel1;
        private Button add_btn;
        private Button delete_btn;
    }
}
