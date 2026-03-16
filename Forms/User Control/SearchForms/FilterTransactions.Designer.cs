namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterTransactions
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
            date_lbl = new Label();
            date_start = new DateTimePicker();
            user_cb = new ComboBox();
            type_cb = new ComboBox();
            user_lbl = new Label();
            type_lbl = new Label();
            date_end = new DateTimePicker();
            range_lbl = new Label();
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
            panel1.Size = new Size(719, 667);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(date_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(date_start, 1, 0);
            tableLayoutPanel1.Controls.Add(user_cb, 1, 3);
            tableLayoutPanel1.Controls.Add(type_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(user_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(type_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(date_end, 1, 1);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
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
            tableLayoutPanel1.Size = new Size(719, 657);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.Dock = DockStyle.Left;
            date_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            date_lbl.ForeColor = Color.White;
            date_lbl.Location = new Point(10, 0);
            date_lbl.Margin = new Padding(10, 0, 3, 0);
            date_lbl.Name = "date_lbl";
            tableLayoutPanel1.SetRowSpan(date_lbl, 2);
            date_lbl.Size = new Size(111, 92);
            date_lbl.TabIndex = 8;
            date_lbl.Text = "Date Range";
            date_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_start
            // 
            date_start.Dock = DockStyle.Fill;
            date_start.DropDownAlign = LeftRightAlignment.Right;
            date_start.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_start.Format = DateTimePickerFormat.Custom;
            date_start.Location = new Point(359, 10);
            date_start.Margin = new Padding(0, 10, 10, 5);
            date_start.Name = "date_start";
            date_start.Size = new Size(350, 31);
            date_start.TabIndex = 28;
            // 
            // user_cb
            // 
            user_cb.BackColor = Color.FromArgb(54, 54, 54);
            user_cb.Dock = DockStyle.Fill;
            user_cb.FlatStyle = FlatStyle.Flat;
            user_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_cb.ForeColor = Color.White;
            user_cb.FormattingEnabled = true;
            user_cb.Location = new Point(359, 155);
            user_cb.Margin = new Padding(0, 10, 10, 10);
            user_cb.Name = "user_cb";
            user_cb.Size = new Size(350, 33);
            user_cb.TabIndex = 30;
            // 
            // type_cb
            // 
            type_cb.BackColor = Color.FromArgb(54, 54, 54);
            type_cb.Dock = DockStyle.Fill;
            type_cb.FlatStyle = FlatStyle.Flat;
            type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            type_cb.ForeColor = Color.White;
            type_cb.FormattingEnabled = true;
            type_cb.Location = new Point(359, 102);
            type_cb.Margin = new Padding(0, 10, 10, 10);
            type_cb.Name = "type_cb";
            type_cb.Size = new Size(350, 33);
            type_cb.TabIndex = 29;
            // 
            // user_lbl
            // 
            user_lbl.AutoSize = true;
            user_lbl.Dock = DockStyle.Left;
            user_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_lbl.ForeColor = Color.White;
            user_lbl.Location = new Point(10, 145);
            user_lbl.Margin = new Padding(10, 0, 3, 0);
            user_lbl.Name = "user_lbl";
            user_lbl.Size = new Size(151, 53);
            user_lbl.TabIndex = 18;
            user_lbl.Text = "User / Employee";
            user_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Dock = DockStyle.Left;
            type_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            type_lbl.ForeColor = Color.White;
            type_lbl.Location = new Point(10, 92);
            type_lbl.Margin = new Padding(10, 0, 3, 0);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(157, 53);
            type_lbl.TabIndex = 16;
            type_lbl.Text = "Transaction Type";
            type_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_end
            // 
            date_end.Dock = DockStyle.Fill;
            date_end.DropDownAlign = LeftRightAlignment.Right;
            date_end.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_end.Format = DateTimePickerFormat.Custom;
            date_end.Location = new Point(359, 51);
            date_end.Margin = new Padding(0, 5, 10, 10);
            date_end.Name = "date_end";
            date_end.Size = new Size(350, 31);
            date_end.TabIndex = 31;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 198);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            tableLayoutPanel1.SetRowSpan(range_lbl, 2);
            range_lbl.Size = new Size(146, 84);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Quantity Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(359, 208);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 27);
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
            min_numeric.Location = new Point(222, 0);
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
            panel3.Location = new Point(359, 245);
            panel3.Margin = new Padding(0, 5, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 27);
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
            max_numeric.Location = new Point(222, 0);
            max_numeric.Name = "max_numeric";
            max_numeric.Size = new Size(128, 27);
            max_numeric.TabIndex = 0;
            // 
            // FilterTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterTransactions";
            Size = new Size(719, 667);
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
        private Label user_lbl;
        private Label type_lbl;
        private Label date_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private DateTimePicker date_start;
        private ComboBox type_cb;
        private ComboBox user_cb;
        private DateTimePicker date_end;
    }
}
