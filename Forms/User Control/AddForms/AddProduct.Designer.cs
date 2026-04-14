using SmartStock.Classes.Utils;
namespace SmartStock.Forms.User_Control
{
    partial class AddProduct
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
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            supplier_cb = new ComboBox();
            label6 = new Label();
            category_selector_cb = new ComboBox();
            db_lbl = new Label();
            product_name_tb = new TextBox();
            logs_lbl = new Label();
            label5 = new Label();
            unit_measure_tb = new TextBox();
            label4 = new Label();
            safety_stock_tb = new TextBox();
            label3 = new Label();
            current_stock_tb = new TextBox();
            label2 = new Label();
            unit_price_tb = new TextBox();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1299, 717);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 20);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1259, 370);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(1239, 350);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Product";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(supplier_cb, 1, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(category_selector_cb, 1, 1);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(product_name_tb, 1, 0);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 6);
            tableLayoutPanel2.Controls.Add(unit_measure_tb, 1, 6);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(safety_stock_tb, 1, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(current_stock_tb, 1, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(unit_price_tb, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1219, 290);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // supplier_cb
            // 
            supplier_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_cb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_cb.FlatStyle = FlatStyle.Flat;
            supplier_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_cb.ForeColor = Color.White;
            supplier_cb.FormattingEnabled = true;
            supplier_cb.Location = new Point(608, 89);
            supplier_cb.Margin = new Padding(0, 5, 0, 5);
            supplier_cb.Name = "supplier_cb";
            supplier_cb.Size = new Size(611, 33);
            supplier_cb.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(3, 84);
            label6.Name = "label6";
            label6.Size = new Size(78, 43);
            label6.TabIndex = 23;
            label6.Text = "Supplier";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_selector_cb
            // 
            category_selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            category_selector_cb.FlatStyle = FlatStyle.Flat;
            category_selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_selector_cb.ForeColor = Color.White;
            category_selector_cb.FormattingEnabled = true;
            category_selector_cb.Location = new Point(608, 46);
            category_selector_cb.Margin = new Padding(0, 5, 0, 5);
            category_selector_cb.Name = "category_selector_cb";
            category_selector_cb.Size = new Size(611, 33);
            category_selector_cb.TabIndex = 2;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 0);
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
            product_name_tb.Location = new Point(608, 5);
            product_name_tb.Margin = new Padding(0, 5, 0, 5);
            product_name_tb.Name = "product_name_tb";
            product_name_tb.Size = new Size(611, 31);
            product_name_tb.TabIndex = 1;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 41);
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
            label5.Location = new Point(3, 250);
            label5.Name = "label5";
            label5.Size = new Size(141, 41);
            label5.TabIndex = 20;
            label5.Text = "Unit Of Measure";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_measure_tb
            // 
            unit_measure_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_measure_tb.BackColor = Color.FromArgb(54, 54, 54);
            unit_measure_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            unit_measure_tb.ForeColor = Color.White;
            unit_measure_tb.Location = new Point(608, 255);
            unit_measure_tb.Margin = new Padding(0, 5, 0, 5);
            unit_measure_tb.Name = "unit_measure_tb";
            unit_measure_tb.Size = new Size(611, 31);
            unit_measure_tb.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 209);
            label4.Name = "label4";
            label4.Size = new Size(111, 41);
            label4.TabIndex = 18;
            label4.Text = "Safety Stock";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // safety_stock_tb
            // 
            safety_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            safety_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            safety_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            safety_stock_tb.ForeColor = Color.White;
            safety_stock_tb.Location = new Point(608, 214);
            safety_stock_tb.Margin = new Padding(0, 5, 0, 5);
            safety_stock_tb.Name = "safety_stock_tb";
            safety_stock_tb.Size = new Size(611, 31);
            safety_stock_tb.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 168);
            label3.Name = "label3";
            label3.Size = new Size(121, 41);
            label3.TabIndex = 16;
            label3.Text = "Current Stock";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // current_stock_tb
            // 
            current_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            current_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            current_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            current_stock_tb.ForeColor = Color.White;
            current_stock_tb.Location = new Point(608, 173);
            current_stock_tb.Margin = new Padding(0, 5, 0, 5);
            current_stock_tb.Name = "current_stock_tb";
            current_stock_tb.Size = new Size(611, 31);
            current_stock_tb.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 127);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 14;
            label2.Text = "Unit Price";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_price_tb
            // 
            unit_price_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            unit_price_tb.BackColor = Color.FromArgb(54, 54, 54);
            unit_price_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            unit_price_tb.ForeColor = Color.White;
            unit_price_tb.Location = new Point(608, 132);
            unit_price_tb.Margin = new Padding(0, 5, 0, 5);
            unit_price_tb.Name = "unit_price_tb";
            unit_price_tb.Size = new Size(611, 31);
            unit_price_tb.TabIndex = 4;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "AddProduct";
            Size = new Size(1299, 717);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox category_selector_cb;
        private TextBox unit_measure_tb;
        private Label label5;
        private TextBox safety_stock_tb;
        private Label label4;
        private TextBox current_stock_tb;
        private Label label3;
        private TextBox unit_price_tb;
        private Label label2;
        private Label db_lbl;
        private TextBox product_name_tb;
        private Label logs_lbl;
        private Label label6;
        private ComboBox supplier_cb;
    }
}
