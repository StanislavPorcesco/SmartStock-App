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
            tableLayoutPanel1.Controls.Add(status_ck, 1, 0);
            tableLayoutPanel1.Controls.Add(total_ck, 1, 6);
            tableLayoutPanel1.Controls.Add(total_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 0);
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
            // status_ck
            // 
            status_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            status_ck.AutoSize = true;
            status_ck.CheckAlign = ContentAlignment.MiddleRight;
            status_ck.ImageAlign = ContentAlignment.MiddleRight;
            status_ck.Location = new Point(264, 10);
            status_ck.Margin = new Padding(0, 10, 10, 10);
            status_ck.Name = "status_ck";
            status_ck.Size = new Size(255, 17);
            status_ck.TabIndex = 28;
            status_ck.TextAlign = ContentAlignment.MiddleRight;
            status_ck.UseVisualStyleBackColor = true;
            // 
            // total_ck
            // 
            total_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            total_ck.AutoSize = true;
            total_ck.CheckAlign = ContentAlignment.MiddleRight;
            total_ck.ImageAlign = ContentAlignment.MiddleRight;
            total_ck.Location = new Point(264, 141);
            total_ck.Margin = new Padding(0, 10, 10, 10);
            total_ck.Name = "total_ck";
            total_ck.Size = new Size(255, 17);
            total_ck.TabIndex = 26;
            total_ck.TextAlign = ContentAlignment.MiddleRight;
            total_ck.UseVisualStyleBackColor = true;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Dock = DockStyle.Left;
            total_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            total_lbl.ForeColor = Color.White;
            total_lbl.Location = new Point(10, 131);
            total_lbl.Margin = new Padding(10, 0, 3, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(195, 37);
            total_lbl.TabIndex = 25;
            total_lbl.Text = "Total Inventory Value";
            total_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 37);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(194, 94);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Product Count Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_lbl.ForeColor = Color.White;
            status_lbl.Location = new Point(10, 0);
            status_lbl.Margin = new Padding(10, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(142, 37);
            status_lbl.TabIndex = 8;
            status_lbl.Text = "Active/Inactive";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 47);
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
            panel3.Location = new Point(264, 94);
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
            reset_btn.Dock = DockStyle.Bottom;
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
            // FilterCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterCategories";
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
        private Label status_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private CheckBox total_ck;
        private Label total_lbl;
        private Panel panel4;
        private Button reset_btn;
        private CheckBox status_ck;
    }
}
