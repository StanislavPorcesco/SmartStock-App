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
            search_text_tb = new TextBox();
            days_clb = new CheckedListBox();
            months_clb = new CheckedListBox();
            status_lbl = new Label();
            radio_pnl = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inactive_rb = new RadioButton();
            active_rb = new RadioButton();
            all_rb = new RadioButton();
            direction_lbl = new Label();
            value_type_lbl = new Label();
            value_range_lbl = new Label();
            days_lbl = new Label();
            seasonality_lbl = new Label();
            date_range_lbl = new Label();
            region_lbl = new Label();
            factor_lbl = new Label();
            Search_description_lbl = new Label();
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
            panel1.Size = new Size(665, 1056);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(search_text_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(days_clb, 1, 6);
            tableLayoutPanel1.Controls.Add(months_clb, 1, 5);
            tableLayoutPanel1.Controls.Add(status_lbl, 0, 11);
            tableLayoutPanel1.Controls.Add(radio_pnl, 1, 11);
            tableLayoutPanel1.Controls.Add(direction_lbl, 0, 10);
            tableLayoutPanel1.Controls.Add(value_type_lbl, 0, 9);
            tableLayoutPanel1.Controls.Add(value_range_lbl, 0, 7);
            tableLayoutPanel1.Controls.Add(days_lbl, 0, 6);
            tableLayoutPanel1.Controls.Add(seasonality_lbl, 0, 5);
            tableLayoutPanel1.Controls.Add(date_range_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(region_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(factor_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(Search_description_lbl, 0, 0);
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
            tableLayoutPanel1.Size = new Size(665, 1046);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // search_text_tb
            // 
            search_text_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            search_text_tb.BackColor = SystemColors.Window;
            search_text_tb.Font = new Font("Segoe UI", 10.5F);
            search_text_tb.Location = new Point(338, 10);
            search_text_tb.Margin = new Padding(6, 10, 0, 10);
            search_text_tb.Name = "search_text_tb";
            search_text_tb.Size = new Size(327, 31);
            search_text_tb.TabIndex = 63;
            // 
            // days_clb
            // 
            days_clb.BorderStyle = BorderStyle.None;
            days_clb.Dock = DockStyle.Fill;
            days_clb.Font = new Font("Segoe UI", 10F);
            days_clb.FormattingEnabled = true;
            days_clb.Items.AddRange(new object[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" });
            days_clb.Location = new Point(338, 478);
            days_clb.Margin = new Padding(6, 10, 0, 10);
            days_clb.MinimumSize = new Size(0, 110);
            days_clb.Name = "days_clb";
            days_clb.Size = new Size(327, 110);
            days_clb.TabIndex = 62;
            days_clb.UseCompatibleTextRendering = true;
            // 
            // months_clb
            // 
            months_clb.BorderStyle = BorderStyle.None;
            months_clb.Dock = DockStyle.Fill;
            months_clb.Font = new Font("Segoe UI", 10F);
            months_clb.FormattingEnabled = true;
            months_clb.Items.AddRange(new object[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" });
            months_clb.Location = new Point(338, 348);
            months_clb.Margin = new Padding(6, 10, 0, 10);
            months_clb.MinimumSize = new Size(0, 110);
            months_clb.Name = "months_clb";
            months_clb.Size = new Size(327, 110);
            months_clb.TabIndex = 61;
            months_clb.UseCompatibleTextRendering = true;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Top;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(10, 817);
            status_lbl.Margin = new Padding(10, 13, 3, 0);
            status_lbl.MaximumSize = new Size(0, 100);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(319, 23);
            status_lbl.TabIndex = 60;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Activity Status";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radio_pnl
            // 
            radio_pnl.Controls.Add(tableLayoutPanel2);
            radio_pnl.Dock = DockStyle.Fill;
            radio_pnl.Location = new Point(335, 807);
            radio_pnl.MaximumSize = new Size(0, 140);
            radio_pnl.MinimumSize = new Size(0, 140);
            radio_pnl.Name = "radio_pnl";
            radio_pnl.Size = new Size(327, 140);
            radio_pnl.TabIndex = 59;
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
            tableLayoutPanel2.MinimumSize = new Size(0, 140);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(327, 140);
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
            inactive_rb.Size = new Size(321, 27);
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
            active_rb.Size = new Size(321, 27);
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
            all_rb.Size = new Size(321, 27);
            all_rb.TabIndex = 0;
            all_rb.TabStop = true;
            all_rb.Text = "All";
            all_rb.UseVisualStyleBackColor = true;
            // 
            // direction_lbl
            // 
            direction_lbl.AutoSize = true;
            direction_lbl.Dock = DockStyle.Fill;
            direction_lbl.Font = new Font("Segoe UI", 10F);
            direction_lbl.Location = new Point(10, 751);
            direction_lbl.Margin = new Padding(10, 0, 3, 0);
            direction_lbl.Name = "direction_lbl";
            direction_lbl.Size = new Size(319, 53);
            direction_lbl.TabIndex = 57;
            direction_lbl.Tag = "muted";
            direction_lbl.Text = "Impact Direction";
            direction_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_type_lbl
            // 
            value_type_lbl.AutoSize = true;
            value_type_lbl.Dock = DockStyle.Fill;
            value_type_lbl.Font = new Font("Segoe UI", 10F);
            value_type_lbl.Location = new Point(10, 698);
            value_type_lbl.Margin = new Padding(10, 0, 3, 0);
            value_type_lbl.Name = "value_type_lbl";
            value_type_lbl.Size = new Size(319, 53);
            value_type_lbl.TabIndex = 55;
            value_type_lbl.Tag = "muted";
            value_type_lbl.Text = "Value Type";
            value_type_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // value_range_lbl
            // 
            value_range_lbl.AutoSize = true;
            value_range_lbl.Dock = DockStyle.Fill;
            value_range_lbl.Font = new Font("Segoe UI", 10F);
            value_range_lbl.Location = new Point(10, 598);
            value_range_lbl.Margin = new Padding(10, 0, 3, 0);
            value_range_lbl.Name = "value_range_lbl";
            tableLayoutPanel1.SetRowSpan(value_range_lbl, 2);
            value_range_lbl.Size = new Size(319, 100);
            value_range_lbl.TabIndex = 53;
            value_range_lbl.Tag = "muted";
            value_range_lbl.Text = "Impact Value Range";
            value_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // days_lbl
            // 
            days_lbl.AutoSize = true;
            days_lbl.Dock = DockStyle.Fill;
            days_lbl.Font = new Font("Segoe UI", 10F);
            days_lbl.Location = new Point(10, 468);
            days_lbl.Margin = new Padding(10, 0, 3, 0);
            days_lbl.Name = "days_lbl";
            days_lbl.Size = new Size(319, 130);
            days_lbl.TabIndex = 50;
            days_lbl.Tag = "muted";
            days_lbl.Text = "Days of the Week";
            days_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seasonality_lbl
            // 
            seasonality_lbl.AutoSize = true;
            seasonality_lbl.Dock = DockStyle.Fill;
            seasonality_lbl.Font = new Font("Segoe UI", 10F);
            seasonality_lbl.Location = new Point(10, 338);
            seasonality_lbl.Margin = new Padding(10, 0, 3, 0);
            seasonality_lbl.Name = "seasonality_lbl";
            seasonality_lbl.Size = new Size(319, 130);
            seasonality_lbl.TabIndex = 47;
            seasonality_lbl.Tag = "muted";
            seasonality_lbl.Text = "Seasonality (Specific Months)";
            seasonality_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_range_lbl
            // 
            date_range_lbl.AutoSize = true;
            date_range_lbl.Dock = DockStyle.Fill;
            date_range_lbl.Font = new Font("Segoe UI", 10F);
            date_range_lbl.Location = new Point(10, 234);
            date_range_lbl.Margin = new Padding(10, 0, 3, 0);
            date_range_lbl.Name = "date_range_lbl";
            tableLayoutPanel1.SetRowSpan(date_range_lbl, 2);
            date_range_lbl.Size = new Size(319, 104);
            date_range_lbl.TabIndex = 45;
            date_range_lbl.Tag = "muted";
            date_range_lbl.Text = "Date Range";
            date_range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // region_lbl
            // 
            region_lbl.AutoSize = true;
            region_lbl.Dock = DockStyle.Fill;
            region_lbl.Font = new Font("Segoe UI", 10F);
            region_lbl.Location = new Point(10, 181);
            region_lbl.Margin = new Padding(10, 0, 3, 0);
            region_lbl.Name = "region_lbl";
            region_lbl.Size = new Size(319, 53);
            region_lbl.TabIndex = 37;
            region_lbl.Tag = "muted";
            region_lbl.Text = "Region";
            region_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factor_lbl
            // 
            factor_lbl.AutoSize = true;
            factor_lbl.Dock = DockStyle.Fill;
            factor_lbl.Font = new Font("Segoe UI", 10F);
            factor_lbl.Location = new Point(10, 51);
            factor_lbl.Margin = new Padding(10, 0, 3, 0);
            factor_lbl.Name = "factor_lbl";
            factor_lbl.Size = new Size(319, 130);
            factor_lbl.TabIndex = 35;
            factor_lbl.Tag = "muted";
            factor_lbl.Text = "Factor Types";
            factor_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Search_description_lbl
            // 
            Search_description_lbl.AutoSize = true;
            Search_description_lbl.Dock = DockStyle.Fill;
            Search_description_lbl.Font = new Font("Segoe UI", 10F);
            Search_description_lbl.Location = new Point(10, 0);
            Search_description_lbl.Margin = new Padding(10, 0, 3, 0);
            Search_description_lbl.Name = "Search_description_lbl";
            Search_description_lbl.Size = new Size(319, 51);
            Search_description_lbl.TabIndex = 29;
            Search_description_lbl.Tag = "muted";
            Search_description_lbl.Text = "Search by Description/Region";
            Search_description_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factor_types_clb
            // 
            factor_types_clb.BorderStyle = BorderStyle.None;
            factor_types_clb.Dock = DockStyle.Fill;
            factor_types_clb.Font = new Font("Segoe UI", 10F);
            factor_types_clb.FormattingEnabled = true;
            factor_types_clb.Location = new Point(338, 61);
            factor_types_clb.Margin = new Padding(6, 10, 0, 10);
            factor_types_clb.MinimumSize = new Size(0, 110);
            factor_types_clb.Name = "factor_types_clb";
            factor_types_clb.Size = new Size(327, 110);
            factor_types_clb.TabIndex = 34;
            // 
            // region_cb
            // 
            region_cb.Dock = DockStyle.Fill;
            region_cb.FlatStyle = FlatStyle.Flat;
            region_cb.Font = new Font("Segoe UI", 11F);
            region_cb.FormattingEnabled = true;
            region_cb.Location = new Point(338, 191);
            region_cb.Margin = new Padding(6, 10, 0, 10);
            region_cb.Name = "region_cb";
            region_cb.Size = new Size(327, 33);
            region_cb.TabIndex = 36;
            // 
            // date_from_dtp
            // 
            date_from_dtp.Dock = DockStyle.Fill;
            date_from_dtp.DropDownAlign = LeftRightAlignment.Right;
            date_from_dtp.Font = new Font("Segoe UI", 11F);
            date_from_dtp.Format = DateTimePickerFormat.Custom;
            date_from_dtp.Location = new Point(338, 244);
            date_from_dtp.Margin = new Padding(6, 10, 0, 10);
            date_from_dtp.Name = "date_from_dtp";
            date_from_dtp.Size = new Size(327, 32);
            date_from_dtp.TabIndex = 42;
            // 
            // date_to_dtp
            // 
            date_to_dtp.Dock = DockStyle.Fill;
            date_to_dtp.DropDownAlign = LeftRightAlignment.Right;
            date_to_dtp.Font = new Font("Segoe UI", 11F);
            date_to_dtp.Format = DateTimePickerFormat.Custom;
            date_to_dtp.Location = new Point(338, 296);
            date_to_dtp.Margin = new Padding(6, 10, 0, 10);
            date_to_dtp.Name = "date_to_dtp";
            date_to_dtp.Size = new Size(327, 32);
            date_to_dtp.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(impact_min_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(338, 608);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 30);
            panel2.TabIndex = 51;
            panel2.Tag = "card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 23);
            label5.TabIndex = 21;
            label5.Tag = "muted";
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // impact_min_nud
            // 
            impact_min_nud.DecimalPlaces = 4;
            impact_min_nud.Dock = DockStyle.Right;
            impact_min_nud.Font = new Font("Segoe UI", 11F);
            impact_min_nud.Location = new Point(199, 0);
            impact_min_nud.Margin = new Padding(0, 10, 0, 0);
            impact_min_nud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            impact_min_nud.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            impact_min_nud.Name = "impact_min_nud";
            impact_min_nud.Size = new Size(128, 32);
            impact_min_nud.TabIndex = 0;
            impact_min_nud.Tag = "range_lock";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(impact_max_nud);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(338, 658);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.MaximumSize = new Size(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 30);
            panel3.TabIndex = 52;
            panel3.Tag = "card";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 23);
            label8.TabIndex = 22;
            label8.Tag = "muted";
            label8.Text = "Max";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // impact_max_nud
            // 
            impact_max_nud.DecimalPlaces = 4;
            impact_max_nud.Dock = DockStyle.Right;
            impact_max_nud.Font = new Font("Segoe UI", 11F);
            impact_max_nud.Location = new Point(199, 0);
            impact_max_nud.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            impact_max_nud.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            impact_max_nud.Name = "impact_max_nud";
            impact_max_nud.Size = new Size(128, 32);
            impact_max_nud.TabIndex = 0;
            impact_max_nud.Tag = "range_lock";
            // 
            // value_type_cb
            // 
            value_type_cb.Dock = DockStyle.Fill;
            value_type_cb.FlatStyle = FlatStyle.Flat;
            value_type_cb.Font = new Font("Segoe UI", 11F);
            value_type_cb.FormattingEnabled = true;
            value_type_cb.Location = new Point(338, 708);
            value_type_cb.Margin = new Padding(6, 10, 0, 10);
            value_type_cb.Name = "value_type_cb";
            value_type_cb.Size = new Size(327, 33);
            value_type_cb.TabIndex = 54;
            // 
            // direction_cb
            // 
            direction_cb.Dock = DockStyle.Fill;
            direction_cb.FlatStyle = FlatStyle.Flat;
            direction_cb.Font = new Font("Segoe UI", 11F);
            direction_cb.FormattingEnabled = true;
            direction_cb.Location = new Point(338, 761);
            direction_cb.Margin = new Padding(6, 10, 0, 10);
            direction_cb.Name = "direction_cb";
            direction_cb.Size = new Size(327, 33);
            direction_cb.TabIndex = 56;
            // 
            // FilterFactors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FilterFactors";
            Size = new Size(665, 1056);
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
        private Label Search_description_lbl;
        private Label factor_lbl;
        private CheckedListBox factor_types_clb;
        private Label region_lbl;
        private ComboBox region_cb;
        private DateTimePicker date_from_dtp;
        private DateTimePicker date_to_dtp;
        private Label seasonality_lbl;
        private Label date_range_lbl;
        private Label days_lbl;
        private Panel panel2;
        private Label label5;
        private NumericUpDown impact_min_nud;
        private Label value_range_lbl;
        private Panel panel3;
        private Label label8;
        private NumericUpDown impact_max_nud;
        private Label direction_lbl;
        private Label value_type_lbl;
        private ComboBox value_type_cb;
        private ComboBox direction_cb;
        private Panel radio_pnl;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton inactive_rb;
        private RadioButton active_rb;
        private RadioButton all_rb;
        private Label status_lbl;
        private CheckedListBox days_clb;
        private CheckedListBox months_clb;
        private TextBox search_text_tb;
    }
}
