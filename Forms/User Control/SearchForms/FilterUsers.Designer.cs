namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterUsers
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
            status_ck = new CheckBox();
            total_ck = new CheckBox();
            total_lbl = new Label();
            range_lbl = new Label();
            status_lbl = new Label();
            panel2 = new Panel();
            label4 = new Label();
            min_numeric = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            max_numeric = new NumericUpDown();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)min_numeric).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_numeric).BeginInit();
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
            tableLayoutPanel1.Controls.Add(status_ck, 1, 0);
            tableLayoutPanel1.Controls.Add(total_ck, 1, 6);
            tableLayoutPanel1.Controls.Add(total_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
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
            // status_ck
            // 
            status_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            status_ck.AutoSize = true;
            status_ck.CheckAlign = ContentAlignment.MiddleRight;
            status_ck.ImageAlign = ContentAlignment.MiddleRight;
            status_ck.Location = new Point(264, 10);
            status_ck.Margin = new Padding(0, 10, 10, 10);
            status_ck.Name = "status_ck";
            status_ck.Size = new Size(255, 24);
            status_ck.TabIndex = 28;
            status_ck.Text = "On / Off";
            status_ck.UseVisualStyleBackColor = true;
            // 
            // total_ck
            // 
            total_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_ck.AutoSize = true;
            total_ck.CheckAlign = ContentAlignment.MiddleRight;
            total_ck.ImageAlign = ContentAlignment.MiddleRight;
            total_ck.Location = new Point(264, 154);
            total_ck.Margin = new Padding(0, 10, 10, 10);
            total_ck.Name = "total_ck";
            total_ck.Size = new Size(255, 24);
            total_ck.TabIndex = 26;
            total_ck.Text = "On / Off";
            total_ck.UseVisualStyleBackColor = true;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Dock = DockStyle.Fill;
            total_lbl.Font = new Font("Segoe UI", 10F);
            total_lbl.Location = new Point(10, 144);
            total_lbl.Margin = new Padding(10, 0, 3, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(251, 44);
            total_lbl.TabIndex = 25;
            total_lbl.Tag = "muted";
            total_lbl.Text = "Total Inventory Value";
            total_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Fill;
            range_lbl.Font = new Font("Segoe UI", 10F);
            range_lbl.Location = new Point(10, 44);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(251, 100);
            range_lbl.TabIndex = 24;
            range_lbl.Tag = "muted";
            range_lbl.Text = "Product Count Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Fill;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 0);
            status_lbl.Margin = new Padding(10, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(251, 44);
            status_lbl.TabIndex = 8;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Active/Inactive";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 54);
            panel2.Margin = new Padding(0, 10, 10, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 30);
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
            label4.TabIndex = 21;
            label4.Tag = "muted";
            label4.Text = "Min";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // min_numeric
            // 
            min_numeric.Dock = DockStyle.Right;
            min_numeric.Font = new Font("Segoe UI", 11F);
            min_numeric.Location = new Point(127, 0);
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
            panel3.Location = new Point(264, 104);
            panel3.Margin = new Padding(0, 10, 10, 10);
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
            label5.Size = new Size(42, 23);
            label5.TabIndex = 22;
            label5.Tag = "muted";
            label5.Text = "Max";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_numeric
            // 
            max_numeric.Dock = DockStyle.Right;
            max_numeric.Font = new Font("Segoe UI", 11F);
            max_numeric.Location = new Point(127, 0);
            max_numeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 32);
            max_numeric.TabIndex = 0;
            max_numeric.Tag = "range_lock";
            // 
            // FilterUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterUsers";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label range_lbl;
        private Label status_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private CheckBox total_ck;
        private Label total_lbl;
        private CheckBox status_ck;
    }
}
