namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterCategories
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            category_name_tb = new TextBox();
            total_range_lbl = new Label();
            category_name_lbl = new Label();
            range_lbl = new Label();
            panel2 = new Panel();
            label4 = new Label();
            min_numeric = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            max_numeric = new NumericUpDown();
            total_lbl = new Label();
            total_ck = new CheckBox();
            panel5 = new Panel();
            label2 = new Label();
            value_min = new NumericUpDown();
            panel6 = new Panel();
            label3 = new Label();
            value_max = new NumericUpDown();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            status_lbl = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)value_min).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)value_max).BeginInit();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(569, 633);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 1, 0);
            tableLayoutPanel1.Controls.Add(total_range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(category_name_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 2);
            tableLayoutPanel1.Controls.Add(total_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(total_ck, 1, 3);
            tableLayoutPanel1.Controls.Add(panel5, 1, 4);
            tableLayoutPanel1.Controls.Add(panel6, 1, 5);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 6);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
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
            tableLayoutPanel1.Size = new Size(569, 623);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(290, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(279, 34);
            border_theme_pnl.TabIndex = 41;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(277, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(category_name_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(277, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // category_name_tb
            // 
            category_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_name_tb.BackColor = SystemColors.Window;
            category_name_tb.Font = new Font("Segoe UI", 10.5F);
            category_name_tb.Location = new Point(0, 0);
            category_name_tb.Margin = new Padding(0);
            category_name_tb.Name = "category_name_tb";
            category_name_tb.Size = new Size(277, 31);
            category_name_tb.TabIndex = 40;
            category_name_tb.Tag = "borderless";
            // 
            // total_range_lbl
            // 
            total_range_lbl.AutoSize = true;
            total_range_lbl.Dock = DockStyle.Fill;
            total_range_lbl.Font = new Font("Segoe UI", 10F);
            total_range_lbl.Location = new Point(10, 198);
            total_range_lbl.Margin = new Padding(10, 0, 3, 0);
            total_range_lbl.Name = "total_range_lbl";
            tableLayoutPanel1.SetRowSpan(total_range_lbl, 2);
            total_range_lbl.Size = new Size(271, 100);
            total_range_lbl.TabIndex = 38;
            total_range_lbl.Tag = "muted";
            total_range_lbl.Text = "Total Inventory Range";
            total_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_name_lbl
            // 
            category_name_lbl.AutoSize = true;
            category_name_lbl.Dock = DockStyle.Fill;
            category_name_lbl.Font = new Font("Segoe UI", 10F);
            category_name_lbl.Location = new Point(10, 0);
            category_name_lbl.Margin = new Padding(10, 0, 3, 0);
            category_name_lbl.Name = "category_name_lbl";
            category_name_lbl.Size = new Size(271, 54);
            category_name_lbl.TabIndex = 8;
            category_name_lbl.Tag = "muted";
            category_name_lbl.Text = "Category Name";
            category_name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Fill;
            range_lbl.Font = new Font("Segoe UI", 10F);
            range_lbl.Location = new Point(10, 54);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(271, 100);
            range_lbl.TabIndex = 24;
            range_lbl.Tag = "muted";
            range_lbl.Text = "Product Count Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(290, 64);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 30);
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
            label4.Size = new Size(39, 23);
            label4.TabIndex = 0;
            label4.Tag = "muted";
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Font = new Font("Segoe UI", 11F);
            min_numeric.Location = new Point(151, 0);
            min_numeric.Margin = new Padding(0, 10, 0, 0);
            min_numeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 32);
            min_numeric.TabIndex = 0;
            min_numeric.Tag = "range_lock";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 114);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 30);
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
            label5.Size = new Size(42, 23);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Font = new Font("Segoe UI", 11F);
            max_numeric.Location = new Point(151, 0);
            max_numeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 32);
            max_numeric.TabIndex = 0;
            max_numeric.Tag = "range_lock";
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Dock = DockStyle.Fill;
            total_lbl.Font = new Font("Segoe UI", 10F);
            total_lbl.Location = new Point(10, 154);
            total_lbl.Margin = new Padding(10, 0, 3, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(271, 44);
            total_lbl.TabIndex = 25;
            total_lbl.Tag = "muted";
            total_lbl.Text = "Total Inventory Value";
            total_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_ck
            // 
            total_ck.AutoSize = true;
            total_ck.CheckAlign = ContentAlignment.MiddleRight;
            total_ck.Dock = DockStyle.Fill;
            total_ck.ImageAlign = ContentAlignment.MiddleRight;
            total_ck.Location = new Point(290, 164);
            total_ck.Margin = new Padding(6, 10, 0, 10);
            total_ck.Name = "total_ck";
            total_ck.Size = new Size(279, 24);
            total_ck.TabIndex = 26;
            total_ck.Text = "On / Off";
            total_ck.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(value_min);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(290, 208);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.MaximumSize = new Size(0, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 30);
            panel5.TabIndex = 36;
            panel5.Tag = "card";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 0;
            label2.Tag = "muted";
            label2.Text = "Min";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_min
            // 
            value_min.Dock = DockStyle.Right;
            value_min.Font = new Font("Segoe UI", 11F);
            value_min.Location = new Point(151, 0);
            value_min.Margin = new Padding(0, 10, 0, 0);
            value_min.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            value_min.Name = "value_min";
            value_min.Size = new Size(128, 32);
            value_min.TabIndex = 0;
            value_min.Tag = "range_lock";
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(value_max);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(290, 258);
            panel6.Margin = new Padding(6, 10, 0, 10);
            panel6.MaximumSize = new Size(0, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 30);
            panel6.TabIndex = 37;
            panel6.Tag = "card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 0;
            label3.Tag = "muted";
            label3.Text = "Max";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_max
            // 
            value_max.Dock = DockStyle.Right;
            value_max.Font = new Font("Segoe UI", 11F);
            value_max.Location = new Point(151, 0);
            value_max.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            value_max.Name = "value_max";
            value_max.Size = new Size(128, 32);
            value_max.TabIndex = 0;
            value_max.Tag = "range_lock";
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(287, 301);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(279, 140);
            radio_pnl.TabIndex = 39;
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
            tableLayoutPanel2.MaximumSize = new Size(0, 140);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(279, 140);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Tag = "card";
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
            inactive_rb.Size = new Size(273, 27);
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
            active_rb.Size = new Size(273, 27);
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
            all_rb.Size = new Size(273, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Fill;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 311);
            status_lbl.Margin = new Padding(10, 13, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(271, 312);
            status_lbl.TabIndex = 34;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Activity Status";
            // 
            // FilterCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterCategories";
            Size = new Size(569, 633);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)value_min).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)value_max).EndInit();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label range_lbl;
        private Label category_name_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private CheckBox total_ck;
        private Label total_lbl;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private Label total_range_lbl;
        private Panel panel5;
        private Label label2;
        private NumericUpDown value_min;
        private Panel panel6;
        private Label label3;
        private NumericUpDown value_max;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private Label status_lbl;
        private TextBox category_name_tb;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
