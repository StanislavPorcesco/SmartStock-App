namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterProducts
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
            top_sellers_ck = new CheckBox();
            top_lbl = new Label();
            range_lbl = new Label();
            dead_stock_tb = new TextBox();
            dead_lbl = new Label();
            safety_lbl = new Label();
            supplier_tb = new TextBox();
            supplier_lbl = new Label();
            category_cb = new ComboBox();
            category_lbl = new Label();
            under_limit_ck = new CheckBox();
            panel2 = new Panel();
            label4 = new Label();
            min_numeric = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            max_numeric = new NumericUpDown();
            panel4 = new Panel();
            reset_btn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(529, 582);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(top_sellers_ck, 1, 6);
            tableLayoutPanel1.Controls.Add(top_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(dead_stock_tb, 1, 3);
            tableLayoutPanel1.Controls.Add(dead_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(safety_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(supplier_tb, 1, 1);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(category_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(under_limit_ck, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(panel4, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(529, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // top_sellers_ck
            // 
            top_sellers_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            top_sellers_ck.AutoSize = true;
            top_sellers_ck.CheckAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.ImageAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.Location = new Point(264, 296);
            top_sellers_ck.Margin = new Padding(0, 10, 10, 10);
            top_sellers_ck.Name = "top_sellers_ck";
            top_sellers_ck.Size = new Size(255, 17);
            top_sellers_ck.TabIndex = 26;
            top_sellers_ck.TextAlign = ContentAlignment.MiddleRight;
            top_sellers_ck.UseVisualStyleBackColor = true;
            // 
            // top_lbl
            // 
            top_lbl.AutoSize = true;
            top_lbl.Dock = DockStyle.Left;
            top_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            top_lbl.ForeColor = Color.White;
            top_lbl.Location = new Point(10, 286);
            top_lbl.Margin = new Padding(10, 0, 3, 0);
            top_lbl.Name = "top_lbl";
            top_lbl.Size = new Size(103, 37);
            top_lbl.TabIndex = 25;
            top_lbl.Text = "Top Sellers";
            top_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 192);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(113, 94);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Price Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dead_stock_tb
            // 
            dead_stock_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dead_stock_tb.BackColor = Color.FromArgb(54, 54, 54);
            dead_stock_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dead_stock_tb.ForeColor = Color.White;
            dead_stock_tb.Location = new Point(264, 151);
            dead_stock_tb.Margin = new Padding(0, 10, 10, 10);
            dead_stock_tb.Name = "dead_stock_tb";
            dead_stock_tb.Size = new Size(255, 31);
            dead_stock_tb.TabIndex = 21;
            // 
            // dead_lbl
            // 
            dead_lbl.AutoSize = true;
            dead_lbl.Dock = DockStyle.Left;
            dead_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dead_lbl.ForeColor = Color.White;
            dead_lbl.Location = new Point(10, 141);
            dead_lbl.Margin = new Padding(10, 0, 3, 0);
            dead_lbl.Name = "dead_lbl";
            dead_lbl.Size = new Size(108, 51);
            dead_lbl.TabIndex = 20;
            dead_lbl.Text = "Dead Stock";
            dead_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // safety_lbl
            // 
            safety_lbl.AutoSize = true;
            safety_lbl.Dock = DockStyle.Left;
            safety_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            safety_lbl.ForeColor = Color.White;
            safety_lbl.Location = new Point(10, 104);
            safety_lbl.Margin = new Padding(10, 0, 3, 0);
            safety_lbl.Name = "safety_lbl";
            safety_lbl.Size = new Size(170, 37);
            safety_lbl.TabIndex = 18;
            safety_lbl.Text = "Under Safety Limit";
            safety_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_tb
            // 
            supplier_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_tb.ForeColor = Color.White;
            supplier_tb.Location = new Point(264, 63);
            supplier_tb.Margin = new Padding(0, 10, 10, 10);
            supplier_tb.Name = "supplier_tb";
            supplier_tb.Size = new Size(255, 31);
            supplier_tb.TabIndex = 17;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Left;
            supplier_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_lbl.ForeColor = Color.White;
            supplier_lbl.Location = new Point(10, 53);
            supplier_lbl.Margin = new Padding(10, 0, 3, 0);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(82, 51);
            supplier_lbl.TabIndex = 16;
            supplier_lbl.Text = "Supplier";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_cb
            // 
            category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_cb.BackColor = Color.FromArgb(54, 54, 54);
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_cb.ForeColor = Color.White;
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(264, 10);
            category_cb.Margin = new Padding(0, 10, 10, 10);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(255, 33);
            category_cb.TabIndex = 15;
            // 
            // category_lbl
            // 
            category_lbl.AutoSize = true;
            category_lbl.Dock = DockStyle.Left;
            category_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_lbl.ForeColor = Color.White;
            category_lbl.Location = new Point(10, 0);
            category_lbl.Margin = new Padding(10, 0, 3, 0);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(90, 53);
            category_lbl.TabIndex = 8;
            category_lbl.Text = "Category";
            category_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // under_limit_ck
            // 
            under_limit_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            under_limit_ck.AutoSize = true;
            under_limit_ck.CheckAlign = ContentAlignment.MiddleRight;
            under_limit_ck.ImageAlign = ContentAlignment.MiddleRight;
            under_limit_ck.Location = new Point(264, 114);
            under_limit_ck.Margin = new Padding(0, 10, 10, 10);
            under_limit_ck.Name = "under_limit_ck";
            under_limit_ck.Size = new Size(255, 17);
            under_limit_ck.TabIndex = 19;
            under_limit_ck.TextAlign = ContentAlignment.MiddleRight;
            under_limit_ck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 202);
            panel2.Margin = new Padding(0, 10, 10, 10);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 27);
            panel2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 21;
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Location = new Point(127, 0);
            min_numeric.Margin = new Padding(0, 10, 0, 0);
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 27);
            min_numeric.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(264, 249);
            panel3.Margin = new Padding(0, 10, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 27);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 22;
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Location = new Point(127, 0);
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 27);
            max_numeric.TabIndex = 0;
            // 
            // panel4
            // 
            tableLayoutPanel1.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(reset_btn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 499);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 10, 0);
            panel4.Size = new Size(523, 70);
            panel4.TabIndex = 27;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(54, 54, 54);
            reset_btn.Dock = DockStyle.Fill;
            reset_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_btn.ForeColor = Color.White;
            reset_btn.Location = new Point(10, 0);
            reset_btn.Margin = new Padding(10, 0, 0, 0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(503, 70);
            reset_btn.TabIndex = 17;
            reset_btn.Text = "Reset Filters";
            reset_btn.UseVisualStyleBackColor = false;
            // 
            // FilterProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterProducts";
            Size = new Size(529, 582);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label range_lbl;
        private TextBox dead_stock_tb;
        private Label dead_lbl;
        private Label safety_lbl;
        private TextBox supplier_tb;
        private Label supplier_lbl;
        private ComboBox category_cb;
        private Label category_lbl;
        private CheckBox under_limit_ck;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private CheckBox top_sellers_ck;
        private Label top_lbl;
        private Panel panel4;
        private Button reset_btn;
    }
}
