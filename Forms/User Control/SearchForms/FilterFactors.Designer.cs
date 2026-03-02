namespace SmartStock.Forms.User_Control.SearchForms
{
    partial class FilterFactors
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
            date_picker = new DateTimePicker();
            impact_lbl = new Label();
            location_tb = new TextBox();
            region_lbl = new Label();
            range_lbl = new Label();
            factor_type_cb = new ComboBox();
            type_lbl = new Label();
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
            tableLayoutPanel1.Controls.Add(date_picker, 1, 1);
            tableLayoutPanel1.Controls.Add(impact_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(location_tb, 1, 3);
            tableLayoutPanel1.Controls.Add(region_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(factor_type_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(type_lbl, 0, 0);
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
            // date_picker
            // 
            date_picker.DropDownAlign = LeftRightAlignment.Right;
            date_picker.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(267, 56);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(250, 31);
            date_picker.TabIndex = 29;
            // 
            // impact_lbl
            // 
            impact_lbl.AutoSize = true;
            impact_lbl.Dock = DockStyle.Left;
            impact_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            impact_lbl.ForeColor = Color.White;
            impact_lbl.Location = new Point(10, 141);
            impact_lbl.Margin = new Padding(10, 0, 3, 0);
            impact_lbl.Name = "impact_lbl";
            tableLayoutPanel1.SetRowSpan(impact_lbl, 2);
            impact_lbl.Size = new Size(120, 94);
            impact_lbl.TabIndex = 24;
            impact_lbl.Text = "Impact Level";
            impact_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // location_tb
            // 
            location_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            location_tb.BackColor = Color.FromArgb(54, 54, 54);
            location_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            location_tb.ForeColor = Color.White;
            location_tb.Location = new Point(264, 100);
            location_tb.Margin = new Padding(0, 10, 10, 10);
            location_tb.Name = "location_tb";
            location_tb.Size = new Size(255, 31);
            location_tb.TabIndex = 21;
            // 
            // region_lbl
            // 
            region_lbl.AutoSize = true;
            region_lbl.Dock = DockStyle.Left;
            region_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            region_lbl.ForeColor = Color.White;
            region_lbl.Location = new Point(10, 90);
            region_lbl.Margin = new Padding(10, 0, 3, 0);
            region_lbl.Name = "region_lbl";
            region_lbl.Size = new Size(153, 51);
            region_lbl.TabIndex = 20;
            region_lbl.Text = "Region/Location";
            region_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Left;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 53);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(111, 37);
            range_lbl.TabIndex = 16;
            range_lbl.Text = "Date Range";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factor_type_cb
            // 
            factor_type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            factor_type_cb.BackColor = Color.FromArgb(54, 54, 54);
            factor_type_cb.FlatStyle = FlatStyle.Flat;
            factor_type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            factor_type_cb.ForeColor = Color.White;
            factor_type_cb.FormattingEnabled = true;
            factor_type_cb.Location = new Point(264, 10);
            factor_type_cb.Margin = new Padding(0, 10, 10, 10);
            factor_type_cb.Name = "factor_type_cb";
            factor_type_cb.Size = new Size(255, 33);
            factor_type_cb.TabIndex = 15;
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Dock = DockStyle.Left;
            type_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            type_lbl.ForeColor = Color.White;
            type_lbl.Location = new Point(10, 0);
            type_lbl.Margin = new Padding(10, 0, 3, 0);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(110, 53);
            type_lbl.TabIndex = 8;
            type_lbl.Text = "Factor Type";
            type_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(min_numeric);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 151);
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
            panel3.Location = new Point(264, 198);
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
            // FilterFactors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterFactors";
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
        private Label impact_lbl;
        private TextBox location_tb;
        private Label region_lbl;
        private Label range_lbl;
        private ComboBox factor_type_cb;
        private Label type_lbl;
        private Panel panel2;
        private Label label4;
        private NumericUpDown min_numeric;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
        private Panel panel4;
        private Button reset_btn;
        private DateTimePicker date_picker;
    }
}
