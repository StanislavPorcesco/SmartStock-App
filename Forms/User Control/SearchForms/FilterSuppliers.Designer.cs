namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterSuppliers
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
            panel4 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            contact_name_tb = new TextBox();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            supplier_name_tb = new TextBox();
            category_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            status_lbl = new Label();
            categories_lbl = new Label();
            contact_lbl = new Label();
            supplier_lbl = new Label();
            panel2 = new Panel();
            label4 = new Label();
            max_numeric = new NumericUpDown();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            panel3 = new Panel();
            label5 = new Label();
            min_numeric = new NumericUpDown();
            range_lbl = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
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
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 1, 0);
            tableLayoutPanel1.Controls.Add(category_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(categories_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(contact_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(supplier_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 6);
            tableLayoutPanel1.Controls.Add(panel3, 1, 3);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(529, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(270, 64);
            panel4.Margin = new Padding(6, 10, 0, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1);
            panel4.Size = new Size(259, 34);
            panel4.TabIndex = 43;
            panel4.Tag = "border_pnl";
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1, 1);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 32);
            panel5.TabIndex = 0;
            panel5.Tag = "card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(contact_name_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(257, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // contact_name_tb
            // 
            contact_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            contact_name_tb.BackColor = SystemColors.Window;
            contact_name_tb.Font = new Font("Segoe UI", 10.5F);
            contact_name_tb.Location = new Point(0, 0);
            contact_name_tb.Margin = new Padding(0);
            contact_name_tb.Name = "contact_name_tb";
            contact_name_tb.Size = new Size(257, 31);
            contact_name_tb.TabIndex = 41;
            contact_name_tb.Tag = "borderless";
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(270, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(259, 34);
            border_theme_pnl.TabIndex = 42;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(257, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(supplier_name_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(257, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // supplier_name_tb
            // 
            supplier_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_name_tb.BackColor = SystemColors.Window;
            supplier_name_tb.Font = new Font("Segoe UI", 10.5F);
            supplier_name_tb.Location = new Point(0, 0);
            supplier_name_tb.Margin = new Padding(0);
            supplier_name_tb.Name = "supplier_name_tb";
            supplier_name_tb.Size = new Size(257, 31);
            supplier_name_tb.TabIndex = 40;
            supplier_name_tb.Tag = "borderless";
            // 
            // category_cb
            // 
            category_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_cb.DrawMode = DrawMode.OwnerDrawFixed;
            category_cb.FlatStyle = FlatStyle.Flat;
            category_cb.Font = new Font("Segoe UI", 11F);
            category_cb.FormattingEnabled = true;
            category_cb.ItemHeight = 30;
            category_cb.Location = new Point(270, 118);
            category_cb.Margin = new Padding(6, 10, 0, 10);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(259, 36);
            category_cb.TabIndex = 29;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Top;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 277);
            status_lbl.Margin = new Padding(10, 13, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(251, 23);
            status_lbl.TabIndex = 25;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Active Status";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // categories_lbl
            // 
            categories_lbl.AutoSize = true;
            categories_lbl.Dock = DockStyle.Fill;
            categories_lbl.Font = new Font("Segoe UI", 10F);
            categories_lbl.Location = new Point(10, 108);
            categories_lbl.Margin = new Padding(10, 0, 3, 0);
            categories_lbl.Name = "categories_lbl";
            categories_lbl.Size = new Size(251, 56);
            categories_lbl.TabIndex = 18;
            categories_lbl.Tag = "muted";
            categories_lbl.Text = "Categories Supplied";
            categories_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contact_lbl
            // 
            contact_lbl.AutoSize = true;
            contact_lbl.Dock = DockStyle.Fill;
            contact_lbl.Font = new Font("Segoe UI", 10F);
            contact_lbl.Location = new Point(10, 54);
            contact_lbl.Margin = new Padding(10, 0, 3, 0);
            contact_lbl.Name = "contact_lbl";
            contact_lbl.Size = new Size(251, 54);
            contact_lbl.TabIndex = 16;
            contact_lbl.Tag = "muted";
            contact_lbl.Text = "Contact Person";
            contact_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_lbl
            // 
            supplier_lbl.AutoSize = true;
            supplier_lbl.Dock = DockStyle.Fill;
            supplier_lbl.Font = new Font("Segoe UI", 10F);
            supplier_lbl.Location = new Point(10, 0);
            supplier_lbl.Margin = new Padding(10, 0, 3, 0);
            supplier_lbl.Name = "supplier_lbl";
            supplier_lbl.Size = new Size(251, 54);
            supplier_lbl.TabIndex = 8;
            supplier_lbl.Tag = "muted";
            supplier_lbl.Text = "Supplier Name (Company)";
            supplier_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(max_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(270, 224);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 30);
            panel2.TabIndex = 22;
            panel2.Tag = "card";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 21;
            label4.Tag = "muted";
            label4.Text = "Max";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Font = new Font("Segoe UI", 11F);
            max_numeric.Location = new Point(131, 0);
            max_numeric.Margin = new Padding(0, 10, 0, 0);
            max_numeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 32);
            max_numeric.TabIndex = 0;
            max_numeric.Tag = "range_lock";
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(267, 267);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.MinimumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(259, 140);
            radio_pnl.TabIndex = 36;
            radio_pnl.Tag = "card";
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
            tableLayoutPanel2.Size = new Size(259, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // inactive_rb
            // 
            inactive_rb.AutoSize = true;
            inactive_rb.CheckAlign = ContentAlignment.MiddleRight;
            inactive_rb.Dock = DockStyle.Fill;
            inactive_rb.Font = new Font("Segoe UI", 10F);
            inactive_rb.Location = new Point(6, 104);
            inactive_rb.Margin = new Padding(6, 10, 0, 10);
            inactive_rb.Name = "inactive_rb";
            inactive_rb.Size = new Size(253, 27);
            inactive_rb.TabIndex = 2;
            inactive_rb.TabStop = true;
            inactive_rb.Text = "Inactive Only";
            inactive_rb.UseVisualStyleBackColor = true;
            // 
            // active_rb
            // 
            active_rb.AutoSize = true;
            active_rb.CheckAlign = ContentAlignment.MiddleRight;
            active_rb.Dock = DockStyle.Fill;
            active_rb.Font = new Font("Segoe UI", 10F);
            active_rb.Location = new Point(6, 57);
            active_rb.Margin = new Padding(6, 10, 0, 10);
            active_rb.Name = "active_rb";
            active_rb.Size = new Size(253, 27);
            active_rb.TabIndex = 1;
            active_rb.TabStop = true;
            active_rb.Text = "Active Only";
            active_rb.UseVisualStyleBackColor = true;
            // 
            // all_rb
            // 
            all_rb.AutoSize = true;
            all_rb.CheckAlign = ContentAlignment.MiddleRight;
            all_rb.Dock = DockStyle.Fill;
            all_rb.Font = new Font("Segoe UI", 10F);
            all_rb.Location = new Point(6, 10);
            all_rb.Margin = new Padding(6, 10, 0, 10);
            all_rb.Name = "all_rb";
            all_rb.Size = new Size(253, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(min_numeric);
            panel3.Location = new Point(270, 174);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 30);
            panel3.TabIndex = 23;
            panel3.Tag = "card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 23);
            label5.TabIndex = 22;
            label5.Tag = "muted";
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Font = new Font("Segoe UI", 11F);
            min_numeric.Location = new Point(127, 0);
            min_numeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 32);
            min_numeric.TabIndex = 0;
            min_numeric.Tag = "range_lock";
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Fill;
            range_lbl.Font = new Font("Segoe UI", 10F);
            range_lbl.Location = new Point(10, 164);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(251, 100);
            range_lbl.TabIndex = 24;
            range_lbl.Tag = "muted";
            range_lbl.Text = "Supply Volume";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FilterSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterSuppliers";
            Size = new Size(529, 582);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).EndInit();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label range_lbl;
        private Label categories_lbl;
        private Label contact_lbl;
        private Label supplier_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown max_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown min_numeric;
        private Label status_lbl;
        private SmartStock.Classes.Utils.ThemedComboBox category_cb;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private TextBox contact_name_tb;
        private TextBox supplier_name_tb;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
