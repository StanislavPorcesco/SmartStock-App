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
            days_clb = new CheckedListBox();
            months_clb = new CheckedListBox();
            label12 = new Label();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            search_text_tb = new TextBox();
            label1 = new Label();
            factor_types_clb = new CheckedListBox();
            region_cb = new ComboBox();
            date_from_dtp = new DateTimePicker();
            date_to_dtp = new DateTimePicker();
            panel2 = new Panel();
            label5 = new Label();
            impact_min_nud = new NumericUpDown();
            panel3 = new Panel();
            label8 = new Label();
            impact_max_nud = new NumericUpDown();
            value_type_cb = new ComboBox();
            direction_cb = new ComboBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            radio_pnl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)impact_min_nud).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)impact_max_nud).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(665, 878);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(days_clb, 1, 6);
            tableLayoutPanel1.Controls.Add(months_clb, 1, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 11);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 11);
            tableLayoutPanel1.Controls.Add(label11, 0, 10);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(label9, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(search_text_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(factor_types_clb, 1, 1);
            tableLayoutPanel1.Controls.Add(region_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(date_from_dtp, 1, 3);
            tableLayoutPanel1.Controls.Add(date_to_dtp, 1, 4);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(panel3, 1, 8);
            tableLayoutPanel1.Controls.Add(value_type_cb, 1, 9);
            tableLayoutPanel1.Controls.Add(direction_cb, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(665, 868);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // days_clb
            // 
            days_clb.BackColor = Color.FromArgb(64, 64, 64);
            days_clb.Dock = DockStyle.Fill;
            days_clb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            days_clb.ForeColor = Color.White;
            days_clb.FormattingEnabled = true;
            days_clb.Items.AddRange(new object[] { "All", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" });
            days_clb.Location = new Point(332, 456);
            days_clb.Margin = new Padding(0, 10, 10, 0);
            days_clb.MinimumSize = new Size(0, 110);
            days_clb.Name = "days_clb";
            days_clb.Size = new Size(323, 110);
            days_clb.TabIndex = 62;
            days_clb.UseCompatibleTextRendering = true;
            // 
            // months_clb
            // 
            months_clb.BackColor = Color.FromArgb(64, 64, 64);
            months_clb.Dock = DockStyle.Fill;
            months_clb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            months_clb.ForeColor = Color.White;
            months_clb.FormattingEnabled = true;
            months_clb.Items.AddRange(new object[] { "All", "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" });
            months_clb.Location = new Point(332, 326);
            months_clb.Margin = new Padding(0, 10, 10, 10);
            months_clb.MinimumSize = new Size(0, 110);
            months_clb.Name = "months_clb";
            months_clb.Size = new Size(323, 110);
            months_clb.TabIndex = 61;
            months_clb.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Left;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(10, 746);
            label12.Margin = new Padding(10, 0, 3, 0);
            label12.MaximumSize = new Size(0, 100);
            label12.Name = "label12";
            label12.Size = new Size(136, 100);
            label12.TabIndex = 60;
            label12.Text = "Activity Status";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(335, 749);
            radio_pnl.MaximumSize = new Size(0, 100);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(327, 100);
            radio_pnl.TabIndex = 59;
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
            tableLayoutPanel2.Size = new Size(327, 100);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(10, 698);
            label11.Margin = new Padding(10, 0, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(154, 48);
            label11.TabIndex = 57;
            label11.Text = "Impact Direction";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Left;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 650);
            label10.Margin = new Padding(10, 0, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 48);
            label10.TabIndex = 55;
            label10.Text = "Value Type";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 566);
            label9.Margin = new Padding(10, 0, 3, 0);
            label9.Name = "label9";
            tableLayoutPanel1.SetRowSpan(label9, 2);
            label9.Size = new Size(182, 84);
            label9.TabIndex = 53;
            label9.Text = "Impact Value Range";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 446);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 120);
            label7.TabIndex = 50;
            label7.Text = "Days of the Week";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 316);
            label6.Margin = new Padding(10, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(264, 130);
            label6.TabIndex = 47;
            label6.Text = "Seasonality (Specific Months)";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 224);
            label4.Margin = new Padding(10, 0, 3, 0);
            label4.Name = "label4";
            tableLayoutPanel1.SetRowSpan(label4, 2);
            label4.Size = new Size(111, 92);
            label4.TabIndex = 45;
            label4.Text = "Date Range";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 176);
            label3.Margin = new Padding(10, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 48);
            label3.TabIndex = 37;
            label3.Text = "Region";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 46);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 130);
            label2.TabIndex = 35;
            label2.Text = "Factor Types";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_text_tb
            // 
            search_text_tb.BackColor = Color.FromArgb(54, 54, 54);
            search_text_tb.Dock = DockStyle.Fill;
            search_text_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            search_text_tb.ForeColor = Color.White;
            search_text_tb.Location = new Point(332, 10);
            search_text_tb.Margin = new Padding(0, 10, 10, 5);
            search_text_tb.Name = "search_text_tb";
            search_text_tb.PlaceholderText = "Search in description or Region...";
            search_text_tb.Size = new Size(323, 31);
            search_text_tb.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 0);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 29;
            label1.Text = "Search by Description/Region";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factor_types_clb
            // 
            factor_types_clb.BackColor = Color.FromArgb(64, 64, 64);
            factor_types_clb.Dock = DockStyle.Fill;
            factor_types_clb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            factor_types_clb.ForeColor = Color.White;
            factor_types_clb.FormattingEnabled = true;
            factor_types_clb.Items.AddRange(new object[] { "Economic", "Weather", "Factor", "factor" });
            factor_types_clb.Location = new Point(332, 56);
            factor_types_clb.Margin = new Padding(0, 10, 10, 10);
            factor_types_clb.MinimumSize = new Size(0, 110);
            factor_types_clb.Name = "factor_types_clb";
            factor_types_clb.Size = new Size(323, 110);
            factor_types_clb.TabIndex = 34;
            // 
            // region_cb
            // 
            region_cb.BackColor = Color.FromArgb(54, 54, 54);
            region_cb.Dock = DockStyle.Fill;
            region_cb.FlatStyle = FlatStyle.Flat;
            region_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            region_cb.ForeColor = Color.White;
            region_cb.FormattingEnabled = true;
            region_cb.Location = new Point(332, 186);
            region_cb.Margin = new Padding(0, 10, 10, 5);
            region_cb.Name = "region_cb";
            region_cb.Size = new Size(323, 33);
            region_cb.TabIndex = 36;
            // 
            // date_from_dtp
            // 
            date_from_dtp.Dock = DockStyle.Fill;
            date_from_dtp.DropDownAlign = LeftRightAlignment.Right;
            date_from_dtp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_from_dtp.Format = DateTimePickerFormat.Custom;
            date_from_dtp.Location = new Point(332, 234);
            date_from_dtp.Margin = new Padding(0, 10, 10, 5);
            date_from_dtp.Name = "date_from_dtp";
            date_from_dtp.Size = new Size(323, 31);
            date_from_dtp.TabIndex = 42;
            // 
            // date_to_dtp
            // 
            date_to_dtp.Dock = DockStyle.Fill;
            date_to_dtp.DropDownAlign = LeftRightAlignment.Right;
            date_to_dtp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_to_dtp.Format = DateTimePickerFormat.Custom;
            date_to_dtp.Location = new Point(332, 280);
            date_to_dtp.Margin = new Padding(0, 10, 10, 5);
            date_to_dtp.Name = "date_to_dtp";
            date_to_dtp.Size = new Size(323, 31);
            date_to_dtp.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(impact_min_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(332, 576);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 27);
            panel2.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 21;
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // impact_min_nud
            // 
            impact_min_nud.DecimalPlaces = 4;
            impact_min_nud.Dock = DockStyle.Right;
            impact_min_nud.Location = new Point(195, 0);
            impact_min_nud.Margin = new Padding(0, 10, 0, 0);
            impact_min_nud.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            impact_min_nud.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            impact_min_nud.Name = "impact_min_nud";
            impact_min_nud.Size = new Size(128, 27);
            impact_min_nud.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(impact_max_nud);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(332, 613);
            panel3.Margin = new Padding(0, 5, 10, 10);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 27);
            panel3.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 22;
            label8.Text = "Max";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // impact_max_nud
            // 
            impact_max_nud.DecimalPlaces = 4;
            impact_max_nud.Dock = DockStyle.Right;
            impact_max_nud.Location = new Point(195, 0);
            impact_max_nud.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            impact_max_nud.Minimum = new decimal(new int[] { 1215752191, 23, 0, int.MinValue });
            impact_max_nud.Name = "impact_max_nud";
            impact_max_nud.Size = new Size(128, 27);
            impact_max_nud.TabIndex = 0;
            // 
            // value_type_cb
            // 
            value_type_cb.BackColor = Color.FromArgb(54, 54, 54);
            value_type_cb.Dock = DockStyle.Fill;
            value_type_cb.FlatStyle = FlatStyle.Flat;
            value_type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            value_type_cb.ForeColor = Color.White;
            value_type_cb.FormattingEnabled = true;
            value_type_cb.Location = new Point(332, 660);
            value_type_cb.Margin = new Padding(0, 10, 10, 5);
            value_type_cb.Name = "value_type_cb";
            value_type_cb.Size = new Size(323, 33);
            value_type_cb.TabIndex = 54;
            // 
            // direction_cb
            // 
            direction_cb.BackColor = Color.FromArgb(54, 54, 54);
            direction_cb.Dock = DockStyle.Fill;
            direction_cb.FlatStyle = FlatStyle.Flat;
            direction_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            direction_cb.ForeColor = Color.White;
            direction_cb.FormattingEnabled = true;
            direction_cb.Location = new Point(332, 708);
            direction_cb.Margin = new Padding(0, 10, 10, 5);
            direction_cb.Name = "direction_cb";
            direction_cb.Size = new Size(323, 33);
            direction_cb.TabIndex = 56;
            // 
            // FilterFactors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Name = "FilterFactors";
            Size = new Size(665, 878);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            radio_pnl.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)impact_min_nud).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)impact_max_nud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox search_text_tb;
        private CheckedListBox factor_types_clb;
        private Label label3;
        private ComboBox region_cb;
        private DateTimePicker date_from_dtp;
        private DateTimePicker date_to_dtp;
        private Label label6;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Label label5;
        private NumericUpDown impact_min_nud;
        private Label label9;
        private Panel panel3;
        private Label label8;
        private NumericUpDown impact_max_nud;
        private Label label11;
        private Label label10;
        private ComboBox value_type_cb;
        private ComboBox direction_cb;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private Label label12;
        private CheckedListBox days_clb;
        private CheckedListBox months_clb;
    }
}
