namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterCategories
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
            label6 = new Label();
            name_lbl = new Label();
            category_name_tb = new TextBox();
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
            panel1.Size = new Size(569, 582);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(name_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(category_name_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 3);
            tableLayoutPanel1.Controls.Add(total_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(total_ck, 1, 4);
            tableLayoutPanel1.Controls.Add(panel5, 1, 5);
            tableLayoutPanel1.Controls.Add(panel6, 1, 6);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 7);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(569, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 172);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            tableLayoutPanel1.SetRowSpan(label6, 2);
            label6.Size = new Size(202, 79);
            label6.TabIndex = 38;
            label6.Text = "Total Inventory Range";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Dock = DockStyle.Left;
            name_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            name_lbl.ForeColor = Color.White;
            name_lbl.Location = new Point(10, 0);
            name_lbl.Margin = new Padding(10, 0, 3, 0);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(145, 51);
            name_lbl.TabIndex = 8;
            name_lbl.Text = "Category Name";
            name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_name_tb
            // 
            category_name_tb.BackColor = Color.FromArgb(54, 54, 54);
            category_name_tb.Dock = DockStyle.Fill;
            category_name_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_name_tb.ForeColor = Color.White;
            category_name_tb.Location = new Point(284, 10);
            category_name_tb.Margin = new Padding(0, 10, 10, 10);
            category_name_tb.Name = "category_name_tb";
            category_name_tb.Size = new Size(275, 31);
            category_name_tb.TabIndex = 33;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 51);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(194, 84);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Product Count Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(284, 61);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 27);
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
            min_numeric.Location = new Point(147, 0);
            min_numeric.Margin = new Padding(0, 10, 0, 0);
            min_numeric.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            min_numeric.Name = "min_numeric";
            min_numeric.Size = new Size(128, 27);
            min_numeric.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(max_numeric);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(284, 98);
            panel3.Margin = new Padding(0, 5, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 27);
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
            max_numeric.Location = new Point(147, 0);
            max_numeric.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 27);
            max_numeric.TabIndex = 0;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Dock = DockStyle.Left;
            total_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_lbl.ForeColor = Color.White;
            total_lbl.Location = new Point(10, 135);
            total_lbl.Margin = new Padding(10, 0, 3, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(195, 37);
            total_lbl.TabIndex = 25;
            total_lbl.Text = "Total Inventory Value";
            total_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_ck
            // 
            total_ck.AutoSize = true;
            total_ck.CheckAlign = ContentAlignment.MiddleRight;
            total_ck.Dock = DockStyle.Fill;
            total_ck.ImageAlign = ContentAlignment.MiddleRight;
            total_ck.Location = new Point(284, 145);
            total_ck.Margin = new Padding(0, 10, 10, 10);
            total_ck.Name = "total_ck";
            total_ck.Size = new Size(275, 17);
            total_ck.TabIndex = 26;
            total_ck.TextAlign = ContentAlignment.MiddleRight;
            total_ck.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(value_min);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(284, 177);
            panel5.Margin = new Padding(0, 5, 10, 5);
            panel5.MaximumSize = new Size(0, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 27);
            panel5.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 21;
            label2.Text = "Min";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_min
            // 
            value_min.Dock = DockStyle.Right;
            value_min.Location = new Point(147, 0);
            value_min.Margin = new Padding(0, 10, 0, 0);
            value_min.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            value_min.Name = "value_min";
            value_min.Size = new Size(128, 27);
            value_min.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(value_max);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(284, 214);
            panel6.Margin = new Padding(0, 5, 10, 10);
            panel6.MaximumSize = new Size(0, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 27);
            panel6.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 22;
            label3.Text = "Max";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_max
            // 
            value_max.Dock = DockStyle.Right;
            value_max.Location = new Point(147, 0);
            value_max.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            value_max.Name = "value_max";
            value_max.Size = new Size(128, 27);
            value_max.TabIndex = 0;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(287, 254);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(279, 315);
            radio_pnl.TabIndex = 39;
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
            tableLayoutPanel2.Size = new Size(279, 315);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // inactive_rb
            // 
            inactive_rb.AutoSize = true;
            inactive_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            inactive_rb.ForeColor = Color.White;
            inactive_rb.Location = new Point(3, 73);
            inactive_rb.Name = "inactive_rb";
            inactive_rb.Size = new Size(146, 29);
            inactive_rb.TabIndex = 2;
            inactive_rb.TabStop = true;
            inactive_rb.Text = "Inactive Only";
            inactive_rb.UseVisualStyleBackColor = true;
            // 
            // active_rb
            // 
            active_rb.AutoSize = true;
            active_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            active_rb.ForeColor = Color.White;
            active_rb.Location = new Point(3, 38);
            active_rb.Name = "active_rb";
            active_rb.Size = new Size(132, 29);
            active_rb.TabIndex = 1;
            active_rb.TabStop = true;
            active_rb.Text = "Active Only";
            active_rb.UseVisualStyleBackColor = true;
            // 
            // all_rb
            // 
            all_rb.AutoSize = true;
            all_rb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            all_rb.ForeColor = Color.White;
            all_rb.Location = new Point(3, 3);
            all_rb.Name = "all_rb";
            all_rb.Size = new Size(56, 29);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_lbl.ForeColor = Color.White;
            status_lbl.Location = new Point(10, 251);
            status_lbl.Margin = new Padding(10, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(136, 321);
            status_lbl.TabIndex = 34;
            status_lbl.Text = "Activity Status";
            // 
            // FilterCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterCategories";
            Size = new Size(569, 582);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label name_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private CheckBox total_ck;
        private Label total_lbl;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private TextBox category_name_tb;
        private Label label6;
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
    }
}
