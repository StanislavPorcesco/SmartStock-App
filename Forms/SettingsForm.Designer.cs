namespace SmartStock
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            apply_btn = new Button();
            themes_cb = new ComboBox();
            base_pnl = new Panel();
            settings_table = new TableLayoutPanel();
            factors_pnl = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            next_fetch_lbl = new Label();
            label11 = new Label();
            enable_daily_fetching = new CheckBox();
            label14 = new Label();
            label15 = new Label();
            fetching_time = new DateTimePicker();
            manual_fetch_btn = new Button();
            ai_pnl = new Panel();
            ai_settings_gb = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            temperature_numeric = new NumericUpDown();
            label16 = new Label();
            provider_cb = new ComboBox();
            label9 = new Label();
            api_tb = new TextBox();
            api_lbl = new Label();
            panel1 = new Panel();
            status_color_lbl = new Label();
            api_status_lbl = new Label();
            label12 = new Label();
            view_api_btn = new FontAwesome.Sharp.IconButton();
            reporting_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            next_report_date_time_lbl = new Label();
            label7 = new Label();
            email_recipient_tb = new TextBox();
            label3 = new Label();
            enable_reports_chk = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            time_picker = new DateTimePicker();
            sent_test_btn = new Button();
            preferences_pnl = new Panel();
            preferences_gb = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            languages_cb = new ComboBox();
            language_lbl = new Label();
            theme_lbl = new Label();
            logging_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            enable_logging_chk = new CheckBox();
            ai_logs_lbl = new Label();
            ai_logs_ck = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            max_size_numeric = new NumericUpDown();
            log_level_cb = new ComboBox();
            open_log_btn = new Button();
            label8 = new Label();
            paths_pnl = new Panel();
            paths_gb = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            settings_lbl = new Label();
            settings_tb = new TextBox();
            browse_settings_btn = new Button();
            db_lbl = new Label();
            db_tb = new TextBox();
            browse_db_btn = new Button();
            logs_lbl = new Label();
            logs_tb = new TextBox();
            browse_logs_btn = new Button();
            apply_pnl = new Panel();
            currency_tb = new TextBox();
            base_pnl.SuspendLayout();
            settings_table.SuspendLayout();
            factors_pnl.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ai_pnl.SuspendLayout();
            ai_settings_gb.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)temperature_numeric).BeginInit();
            panel1.SuspendLayout();
            reporting_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            preferences_pnl.SuspendLayout();
            preferences_gb.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            logging_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).BeginInit();
            paths_pnl.SuspendLayout();
            paths_gb.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            apply_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // apply_btn
            // 
            apply_btn.BackColor = Color.FromArgb(54, 54, 54);
            apply_btn.Dock = DockStyle.Fill;
            apply_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.ForeColor = Color.White;
            apply_btn.Location = new Point(20, 20);
            apply_btn.Margin = new Padding(0);
            apply_btn.MaximumSize = new Size(0, 70);
            apply_btn.MinimumSize = new Size(0, 70);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(1276, 70);
            apply_btn.TabIndex = 0;
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // themes_cb
            // 
            themes_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            themes_cb.BackColor = Color.FromArgb(54, 54, 54);
            themes_cb.FlatStyle = FlatStyle.Flat;
            themes_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            themes_cb.ForeColor = Color.White;
            themes_cb.FormattingEnabled = true;
            themes_cb.Location = new Point(257, 7);
            themes_cb.Margin = new Padding(10, 7, 10, 7);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(352, 33);
            themes_cb.TabIndex = 1;
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(settings_table);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(10);
            base_pnl.Size = new Size(1337, 885);
            base_pnl.TabIndex = 2;
            base_pnl.Tag = "base";
            // 
            // settings_table
            // 
            settings_table.ColumnCount = 2;
            settings_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            settings_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            settings_table.Controls.Add(factors_pnl, 1, 2);
            settings_table.Controls.Add(ai_pnl, 0, 2);
            settings_table.Controls.Add(reporting_pnl, 1, 0);
            settings_table.Controls.Add(preferences_pnl, 1, 1);
            settings_table.Controls.Add(logging_pnl, 0, 0);
            settings_table.Controls.Add(paths_pnl, 0, 1);
            settings_table.Dock = DockStyle.Top;
            settings_table.Location = new Point(10, 10);
            settings_table.Margin = new Padding(3, 3, 3, 30);
            settings_table.Name = "settings_table";
            settings_table.RowCount = 3;
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 329F));
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 216F));
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            settings_table.Size = new Size(1317, 840);
            settings_table.TabIndex = 12;
            // 
            // factors_pnl
            // 
            factors_pnl.Controls.Add(groupBox3);
            factors_pnl.Dock = DockStyle.Fill;
            factors_pnl.Location = new Point(658, 545);
            factors_pnl.Margin = new Padding(0);
            factors_pnl.Name = "factors_pnl";
            factors_pnl.Padding = new Padding(10);
            factors_pnl.Size = new Size(659, 295);
            factors_pnl.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel7);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(10, 10);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 20, 10, 10);
            groupBox3.Size = new Size(639, 275);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "External Factors Fetching";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Controls.Add(next_fetch_lbl, 1, 2);
            tableLayoutPanel7.Controls.Add(label11, 0, 2);
            tableLayoutPanel7.Controls.Add(enable_daily_fetching, 1, 0);
            tableLayoutPanel7.Controls.Add(label14, 0, 1);
            tableLayoutPanel7.Controls.Add(label15, 0, 0);
            tableLayoutPanel7.Controls.Add(fetching_time, 1, 1);
            tableLayoutPanel7.Controls.Add(manual_fetch_btn, 0, 3);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(10, 40);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(619, 225);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // next_fetch_lbl
            // 
            next_fetch_lbl.AutoSize = true;
            next_fetch_lbl.Dock = DockStyle.Fill;
            next_fetch_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            next_fetch_lbl.Location = new Point(257, 99);
            next_fetch_lbl.Margin = new Padding(10, 15, 10, 15);
            next_fetch_lbl.Name = "next_fetch_lbl";
            next_fetch_lbl.Size = new Size(352, 25);
            next_fetch_lbl.TabIndex = 22;
            next_fetch_lbl.Text = "15.01.2026 12:45";
            next_fetch_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(10, 84);
            label11.Margin = new Padding(10, 0, 0, 0);
            label11.Name = "label11";
            label11.Size = new Size(188, 55);
            label11.TabIndex = 21;
            label11.Text = "Next Fetch Sheduled";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_daily_fetching
            // 
            enable_daily_fetching.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            enable_daily_fetching.AutoSize = true;
            enable_daily_fetching.ForeColor = Color.FromArgb(64, 64, 64);
            enable_daily_fetching.Location = new Point(591, 10);
            enable_daily_fetching.Margin = new Padding(0, 10, 10, 10);
            enable_daily_fetching.Name = "enable_daily_fetching";
            enable_daily_fetching.Size = new Size(18, 17);
            enable_daily_fetching.TabIndex = 16;
            enable_daily_fetching.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Left;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label14.Location = new Point(10, 37);
            label14.Margin = new Padding(10, 0, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(136, 47);
            label14.TabIndex = 3;
            label14.Text = "Schedule Time";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Left;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label15.Location = new Point(10, 0);
            label15.Margin = new Padding(10, 0, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(195, 37);
            label15.TabIndex = 2;
            label15.Text = "Enable Daily Fetching";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fetching_time
            // 
            fetching_time.Dock = DockStyle.Fill;
            fetching_time.Location = new Point(247, 47);
            fetching_time.Margin = new Padding(0, 10, 10, 10);
            fetching_time.Name = "fetching_time";
            fetching_time.Size = new Size(362, 27);
            fetching_time.TabIndex = 17;
            // 
            // manual_fetch_btn
            // 
            manual_fetch_btn.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel7.SetColumnSpan(manual_fetch_btn, 2);
            manual_fetch_btn.Dock = DockStyle.Fill;
            manual_fetch_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manual_fetch_btn.ForeColor = Color.White;
            manual_fetch_btn.Location = new Point(10, 149);
            manual_fetch_btn.Margin = new Padding(10);
            manual_fetch_btn.MaximumSize = new Size(0, 70);
            manual_fetch_btn.MinimumSize = new Size(0, 70);
            manual_fetch_btn.Name = "manual_fetch_btn";
            manual_fetch_btn.Size = new Size(599, 70);
            manual_fetch_btn.TabIndex = 20;
            manual_fetch_btn.Text = "Manual Fetch";
            manual_fetch_btn.UseVisualStyleBackColor = false;
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(ai_settings_gb);
            ai_pnl.Dock = DockStyle.Fill;
            ai_pnl.Location = new Point(0, 545);
            ai_pnl.Margin = new Padding(0);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Padding = new Padding(10);
            ai_pnl.Size = new Size(658, 295);
            ai_pnl.TabIndex = 5;
            // 
            // ai_settings_gb
            // 
            ai_settings_gb.Controls.Add(tableLayoutPanel3);
            ai_settings_gb.Dock = DockStyle.Fill;
            ai_settings_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ai_settings_gb.ForeColor = Color.White;
            ai_settings_gb.Location = new Point(10, 10);
            ai_settings_gb.Margin = new Padding(0);
            ai_settings_gb.Name = "ai_settings_gb";
            ai_settings_gb.Padding = new Padding(10, 20, 10, 10);
            ai_settings_gb.Size = new Size(638, 275);
            ai_settings_gb.TabIndex = 4;
            ai_settings_gb.TabStop = false;
            ai_settings_gb.Text = "AI Settings";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(temperature_numeric, 1, 3);
            tableLayoutPanel3.Controls.Add(label16, 0, 3);
            tableLayoutPanel3.Controls.Add(provider_cb, 1, 1);
            tableLayoutPanel3.Controls.Add(label9, 0, 1);
            tableLayoutPanel3.Controls.Add(api_tb, 1, 0);
            tableLayoutPanel3.Controls.Add(api_lbl, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 1, 2);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(view_api_btn, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(618, 225);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // temperature_numeric
            // 
            tableLayoutPanel3.SetColumnSpan(temperature_numeric, 2);
            temperature_numeric.Dock = DockStyle.Fill;
            temperature_numeric.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            temperature_numeric.Location = new Point(257, 178);
            temperature_numeric.Margin = new Padding(10, 20, 10, 10);
            temperature_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            temperature_numeric.Name = "temperature_numeric";
            temperature_numeric.Size = new Size(351, 31);
            temperature_numeric.TabIndex = 29;
            temperature_numeric.Tag = "range_lock";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Left;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label16.Location = new Point(10, 158);
            label16.Margin = new Padding(10, 0, 0, 0);
            label16.Name = "label16";
            label16.Size = new Size(120, 67);
            label16.TabIndex = 22;
            label16.Text = "Temperature";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // provider_cb
            // 
            provider_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            provider_cb.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel3.SetColumnSpan(provider_cb, 2);
            provider_cb.FlatStyle = FlatStyle.Flat;
            provider_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            provider_cb.ForeColor = Color.White;
            provider_cb.FormattingEnabled = true;
            provider_cb.Location = new Point(257, 61);
            provider_cb.Margin = new Padding(10);
            provider_cb.Name = "provider_cb";
            provider_cb.Size = new Size(351, 33);
            provider_cb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(10, 51);
            label9.Margin = new Padding(10, 0, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 53);
            label9.TabIndex = 20;
            label9.Text = "AI Provider";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // api_tb
            // 
            api_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_tb.BackColor = Color.FromArgb(54, 54, 54);
            api_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_tb.ForeColor = Color.White;
            api_tb.Location = new Point(257, 10);
            api_tb.Margin = new Padding(10);
            api_tb.Name = "api_tb";
            api_tb.Size = new Size(289, 31);
            api_tb.TabIndex = 14;
            // 
            // api_lbl
            // 
            api_lbl.AutoSize = true;
            api_lbl.Dock = DockStyle.Left;
            api_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_lbl.Location = new Point(10, 0);
            api_lbl.Margin = new Padding(10, 0, 0, 0);
            api_lbl.Name = "api_lbl";
            api_lbl.Size = new Size(79, 51);
            api_lbl.TabIndex = 2;
            api_lbl.Text = "API Key";
            api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            tableLayoutPanel3.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(status_color_lbl);
            panel1.Controls.Add(api_status_lbl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 107);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(365, 48);
            panel1.TabIndex = 18;
            // 
            // status_color_lbl
            // 
            status_color_lbl.AutoSize = true;
            status_color_lbl.Dock = DockStyle.Right;
            status_color_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_color_lbl.ForeColor = Color.Red;
            status_color_lbl.Location = new Point(262, 10);
            status_color_lbl.Margin = new Padding(10);
            status_color_lbl.Name = "status_color_lbl";
            status_color_lbl.Size = new Size(23, 25);
            status_color_lbl.TabIndex = 16;
            status_color_lbl.Text = "●";
            status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // api_status_lbl
            // 
            api_status_lbl.AutoSize = true;
            api_status_lbl.Dock = DockStyle.Right;
            api_status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_status_lbl.ForeColor = Color.White;
            api_status_lbl.Location = new Point(285, 10);
            api_status_lbl.Margin = new Padding(10);
            api_status_lbl.Name = "api_status_lbl";
            api_status_lbl.Size = new Size(80, 25);
            api_status_lbl.TabIndex = 17;
            api_status_lbl.Text = "Inactive";
            api_status_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Left;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label12.Location = new Point(10, 104);
            label12.Margin = new Padding(10, 0, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 54);
            label12.TabIndex = 19;
            label12.Text = "Agent Status";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // view_api_btn
            // 
            view_api_btn.BackColor = Color.Transparent;
            view_api_btn.FlatAppearance.BorderSize = 0;
            view_api_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            view_api_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            view_api_btn.FlatStyle = FlatStyle.Flat;
            view_api_btn.ForeColor = Color.White;
            view_api_btn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            view_api_btn.IconColor = Color.White;
            view_api_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            view_api_btn.IconSize = 40;
            view_api_btn.Location = new Point(566, 10);
            view_api_btn.Margin = new Padding(10);
            view_api_btn.Name = "view_api_btn";
            view_api_btn.Size = new Size(40, 31);
            view_api_btn.TabIndex = 8;
            view_api_btn.Tag = "clean_icon";
            view_api_btn.UseVisualStyleBackColor = false;
            // 
            // reporting_pnl
            // 
            reporting_pnl.Controls.Add(groupBox1);
            reporting_pnl.Dock = DockStyle.Fill;
            reporting_pnl.Location = new Point(658, 0);
            reporting_pnl.Margin = new Padding(0);
            reporting_pnl.Name = "reporting_pnl";
            reporting_pnl.Padding = new Padding(10);
            reporting_pnl.Size = new Size(659, 329);
            reporting_pnl.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 20, 10, 10);
            groupBox1.Size = new Size(639, 309);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Automated Reporting";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Controls.Add(next_report_date_time_lbl, 1, 3);
            tableLayoutPanel4.Controls.Add(label7, 0, 3);
            tableLayoutPanel4.Controls.Add(email_recipient_tb, 1, 2);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(enable_reports_chk, 1, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(time_picker, 1, 1);
            tableLayoutPanel4.Controls.Add(sent_test_btn, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(10, 40);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(619, 259);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // next_report_date_time_lbl
            // 
            next_report_date_time_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            next_report_date_time_lbl.AutoSize = true;
            next_report_date_time_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            next_report_date_time_lbl.Location = new Point(457, 135);
            next_report_date_time_lbl.Margin = new Padding(10, 15, 10, 18);
            next_report_date_time_lbl.Name = "next_report_date_time_lbl";
            next_report_date_time_lbl.RightToLeft = RightToLeft.No;
            next_report_date_time_lbl.Size = new Size(152, 25);
            next_report_date_time_lbl.TabIndex = 22;
            next_report_date_time_lbl.Text = "15.01.2026 12:45";
            next_report_date_time_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(10, 120);
            label7.Margin = new Padding(10, 0, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(201, 58);
            label7.TabIndex = 21;
            label7.Text = "Next Report Sheduled";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_recipient_tb
            // 
            email_recipient_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_recipient_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_recipient_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_recipient_tb.ForeColor = Color.White;
            email_recipient_tb.Location = new Point(257, 79);
            email_recipient_tb.Margin = new Padding(10, 5, 10, 10);
            email_recipient_tb.MinimumSize = new Size(0, 31);
            email_recipient_tb.Name = "email_recipient_tb";
            email_recipient_tb.Size = new Size(352, 31);
            email_recipient_tb.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(10, 74);
            label3.Margin = new Padding(10, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 46);
            label3.TabIndex = 18;
            label3.Text = "E-mail Recipient";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_reports_chk
            // 
            enable_reports_chk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            enable_reports_chk.AutoSize = true;
            enable_reports_chk.ForeColor = Color.FromArgb(64, 64, 64);
            enable_reports_chk.Location = new Point(591, 10);
            enable_reports_chk.Margin = new Padding(0, 10, 10, 10);
            enable_reports_chk.Name = "enable_reports_chk";
            enable_reports_chk.Size = new Size(18, 17);
            enable_reports_chk.TabIndex = 16;
            enable_reports_chk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 37);
            label1.Margin = new Padding(10, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 3;
            label1.Text = "Schedule Time";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(10, 0);
            label2.Margin = new Padding(10, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 2;
            label2.Text = "Enable Weekly Reports";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // time_picker
            // 
            time_picker.Dock = DockStyle.Fill;
            time_picker.Location = new Point(257, 42);
            time_picker.Margin = new Padding(10, 5, 10, 5);
            time_picker.Name = "time_picker";
            time_picker.Size = new Size(352, 27);
            time_picker.TabIndex = 17;
            // 
            // sent_test_btn
            // 
            sent_test_btn.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel4.SetColumnSpan(sent_test_btn, 2);
            sent_test_btn.Dock = DockStyle.Fill;
            sent_test_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sent_test_btn.ForeColor = Color.White;
            sent_test_btn.Location = new Point(10, 188);
            sent_test_btn.Margin = new Padding(10);
            sent_test_btn.MaximumSize = new Size(0, 70);
            sent_test_btn.MinimumSize = new Size(0, 70);
            sent_test_btn.Name = "sent_test_btn";
            sent_test_btn.Size = new Size(599, 70);
            sent_test_btn.TabIndex = 20;
            sent_test_btn.Text = "Send Test Report";
            sent_test_btn.UseVisualStyleBackColor = false;
            // 
            // preferences_pnl
            // 
            preferences_pnl.Controls.Add(preferences_gb);
            preferences_pnl.Dock = DockStyle.Fill;
            preferences_pnl.Location = new Point(658, 329);
            preferences_pnl.Margin = new Padding(0);
            preferences_pnl.Name = "preferences_pnl";
            preferences_pnl.Padding = new Padding(10);
            preferences_pnl.Size = new Size(659, 216);
            preferences_pnl.TabIndex = 7;
            // 
            // preferences_gb
            // 
            preferences_gb.Controls.Add(tableLayoutPanel1);
            preferences_gb.Dock = DockStyle.Fill;
            preferences_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            preferences_gb.ForeColor = Color.White;
            preferences_gb.Location = new Point(10, 10);
            preferences_gb.Margin = new Padding(0);
            preferences_gb.Name = "preferences_gb";
            preferences_gb.Padding = new Padding(10, 20, 10, 10);
            preferences_gb.Size = new Size(639, 196);
            preferences_gb.TabIndex = 3;
            preferences_gb.TabStop = false;
            preferences_gb.Text = "Theme and Preferences";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(currency_tb, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(languages_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(language_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(theme_lbl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(619, 146);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 94);
            label4.Margin = new Padding(10, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 52);
            label4.TabIndex = 6;
            label4.Text = "Currency Symbol";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // languages_cb
            // 
            languages_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            languages_cb.BackColor = Color.FromArgb(54, 54, 54);
            languages_cb.FlatStyle = FlatStyle.Flat;
            languages_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            languages_cb.ForeColor = Color.White;
            languages_cb.FormattingEnabled = true;
            languages_cb.Location = new Point(257, 54);
            languages_cb.Margin = new Padding(10, 7, 10, 7);
            languages_cb.Name = "languages_cb";
            languages_cb.Size = new Size(352, 33);
            languages_cb.TabIndex = 5;
            // 
            // language_lbl
            // 
            language_lbl.AutoSize = true;
            language_lbl.Dock = DockStyle.Left;
            language_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            language_lbl.Location = new Point(10, 47);
            language_lbl.Margin = new Padding(10, 0, 0, 0);
            language_lbl.Name = "language_lbl";
            language_lbl.Size = new Size(95, 47);
            language_lbl.TabIndex = 3;
            language_lbl.Text = "Language";
            language_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // theme_lbl
            // 
            theme_lbl.AutoSize = true;
            theme_lbl.Dock = DockStyle.Left;
            theme_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            theme_lbl.Location = new Point(10, 0);
            theme_lbl.Margin = new Padding(10, 0, 0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(70, 47);
            theme_lbl.TabIndex = 2;
            theme_lbl.Text = "Theme";
            theme_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logging_pnl
            // 
            logging_pnl.Controls.Add(groupBox2);
            logging_pnl.Dock = DockStyle.Fill;
            logging_pnl.Location = new Point(0, 0);
            logging_pnl.Margin = new Padding(0);
            logging_pnl.Name = "logging_pnl";
            logging_pnl.Padding = new Padding(10);
            logging_pnl.Size = new Size(658, 329);
            logging_pnl.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 10);
            groupBox2.Size = new Size(638, 309);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logging System";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(enable_logging_chk, 1, 0);
            tableLayoutPanel5.Controls.Add(ai_logs_lbl, 0, 1);
            tableLayoutPanel5.Controls.Add(ai_logs_ck, 1, 1);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Controls.Add(max_size_numeric, 1, 2);
            tableLayoutPanel5.Controls.Add(log_level_cb, 1, 3);
            tableLayoutPanel5.Controls.Add(open_log_btn, 1, 4);
            tableLayoutPanel5.Controls.Add(label8, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(10, 40);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(618, 259);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // enable_logging_chk
            // 
            enable_logging_chk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            enable_logging_chk.AutoSize = true;
            enable_logging_chk.ForeColor = Color.FromArgb(64, 64, 64);
            enable_logging_chk.Location = new Point(590, 10);
            enable_logging_chk.Margin = new Padding(0, 10, 10, 10);
            enable_logging_chk.Name = "enable_logging_chk";
            enable_logging_chk.Size = new Size(18, 17);
            enable_logging_chk.TabIndex = 16;
            enable_logging_chk.UseVisualStyleBackColor = true;
            // 
            // ai_logs_lbl
            // 
            ai_logs_lbl.AutoSize = true;
            ai_logs_lbl.Dock = DockStyle.Left;
            ai_logs_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ai_logs_lbl.Location = new Point(10, 37);
            ai_logs_lbl.Margin = new Padding(10, 0, 0, 0);
            ai_logs_lbl.Name = "ai_logs_lbl";
            ai_logs_lbl.Size = new Size(181, 37);
            ai_logs_lbl.TabIndex = 3;
            ai_logs_lbl.Text = "Detailed Logs for AI";
            ai_logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ai_logs_ck
            // 
            ai_logs_ck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ai_logs_ck.AutoSize = true;
            ai_logs_ck.ForeColor = Color.FromArgb(64, 64, 64);
            ai_logs_ck.Location = new Point(590, 47);
            ai_logs_ck.Margin = new Padding(10);
            ai_logs_ck.Name = "ai_logs_ck";
            ai_logs_ck.Size = new Size(18, 17);
            ai_logs_ck.TabIndex = 15;
            ai_logs_ck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(10, 0);
            label6.Margin = new Padding(10, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 37);
            label6.TabIndex = 2;
            label6.Text = "Enable Logging";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(10, 74);
            label5.Margin = new Padding(10, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 51);
            label5.TabIndex = 26;
            label5.Text = "Max File Size (MB)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_size_numeric
            // 
            max_size_numeric.Dock = DockStyle.Fill;
            max_size_numeric.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            max_size_numeric.Location = new Point(257, 84);
            max_size_numeric.Margin = new Padding(10);
            max_size_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            max_size_numeric.Name = "max_size_numeric";
            max_size_numeric.Size = new Size(351, 31);
            max_size_numeric.TabIndex = 28;
            // 
            // log_level_cb
            // 
            log_level_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            log_level_cb.BackColor = Color.FromArgb(54, 54, 54);
            log_level_cb.FlatStyle = FlatStyle.Flat;
            log_level_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            log_level_cb.ForeColor = Color.White;
            log_level_cb.FormattingEnabled = true;
            log_level_cb.Location = new Point(257, 135);
            log_level_cb.Margin = new Padding(10);
            log_level_cb.Name = "log_level_cb";
            log_level_cb.Size = new Size(351, 33);
            log_level_cb.TabIndex = 29;
            // 
            // open_log_btn
            // 
            open_log_btn.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel5.SetColumnSpan(open_log_btn, 2);
            open_log_btn.Dock = DockStyle.Fill;
            open_log_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            open_log_btn.ForeColor = Color.White;
            open_log_btn.Location = new Point(10, 188);
            open_log_btn.Margin = new Padding(10);
            open_log_btn.MaximumSize = new Size(0, 70);
            open_log_btn.MinimumSize = new Size(0, 70);
            open_log_btn.Name = "open_log_btn";
            open_log_btn.Size = new Size(598, 70);
            open_log_btn.TabIndex = 25;
            open_log_btn.Text = "Open Log File";
            open_log_btn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(10, 125);
            label8.Margin = new Padding(10, 0, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 53);
            label8.TabIndex = 27;
            label8.Text = "Log Level";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paths_pnl
            // 
            paths_pnl.Controls.Add(paths_gb);
            paths_pnl.Dock = DockStyle.Fill;
            paths_pnl.Location = new Point(0, 329);
            paths_pnl.Margin = new Padding(0);
            paths_pnl.Name = "paths_pnl";
            paths_pnl.Padding = new Padding(10);
            paths_pnl.Size = new Size(658, 216);
            paths_pnl.TabIndex = 6;
            // 
            // paths_gb
            // 
            paths_gb.Controls.Add(tableLayoutPanel2);
            paths_gb.Dock = DockStyle.Fill;
            paths_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            paths_gb.ForeColor = Color.White;
            paths_gb.Location = new Point(10, 10);
            paths_gb.Margin = new Padding(0);
            paths_gb.Name = "paths_gb";
            paths_gb.Padding = new Padding(10, 20, 10, 10);
            paths_gb.Size = new Size(638, 196);
            paths_gb.TabIndex = 4;
            paths_gb.TabStop = false;
            paths_gb.Text = "File paths";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(settings_tb, 1, 0);
            tableLayoutPanel2.Controls.Add(browse_settings_btn, 2, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(db_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(browse_db_btn, 2, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(logs_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(browse_logs_btn, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(618, 146);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // settings_lbl
            // 
            settings_lbl.AutoSize = true;
            settings_lbl.Dock = DockStyle.Left;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(10, 0);
            settings_lbl.Margin = new Padding(10, 0, 0, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(159, 51);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Settings File Path";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings_tb
            // 
            settings_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            settings_tb.BackColor = Color.FromArgb(54, 54, 54);
            settings_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_tb.ForeColor = Color.White;
            settings_tb.Location = new Point(257, 10);
            settings_tb.Margin = new Padding(10);
            settings_tb.Name = "settings_tb";
            settings_tb.Size = new Size(289, 31);
            settings_tb.TabIndex = 11;
            // 
            // browse_settings_btn
            // 
            browse_settings_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_settings_btn.Dock = DockStyle.Fill;
            browse_settings_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_settings_btn.ForeColor = Color.White;
            browse_settings_btn.Location = new Point(560, 10);
            browse_settings_btn.Margin = new Padding(4, 10, 10, 10);
            browse_settings_btn.Name = "browse_settings_btn";
            browse_settings_btn.Size = new Size(48, 31);
            browse_settings_btn.TabIndex = 23;
            browse_settings_btn.Text = "...";
            browse_settings_btn.UseVisualStyleBackColor = false;
            // 
            // db_lbl
            // 
            db_lbl.AutoSize = true;
            db_lbl.Dock = DockStyle.Left;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(10, 51);
            db_lbl.Margin = new Padding(10, 0, 0, 0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(136, 51);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "DataBase Path";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_tb
            // 
            db_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            db_tb.BackColor = Color.FromArgb(54, 54, 54);
            db_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_tb.ForeColor = Color.White;
            db_tb.Location = new Point(257, 61);
            db_tb.Margin = new Padding(10);
            db_tb.Name = "db_tb";
            db_tb.Size = new Size(289, 31);
            db_tb.TabIndex = 12;
            // 
            // browse_db_btn
            // 
            browse_db_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_db_btn.Dock = DockStyle.Fill;
            browse_db_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_db_btn.ForeColor = Color.White;
            browse_db_btn.Location = new Point(560, 61);
            browse_db_btn.Margin = new Padding(4, 10, 10, 10);
            browse_db_btn.Name = "browse_db_btn";
            browse_db_btn.Size = new Size(48, 31);
            browse_db_btn.TabIndex = 24;
            browse_db_btn.Text = "...";
            browse_db_btn.UseVisualStyleBackColor = false;
            // 
            // logs_lbl
            // 
            logs_lbl.AutoSize = true;
            logs_lbl.Dock = DockStyle.Left;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(10, 102);
            logs_lbl.Margin = new Padding(10, 0, 0, 0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(114, 51);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Log File Path";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_tb
            // 
            logs_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logs_tb.BackColor = Color.FromArgb(54, 54, 54);
            logs_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            logs_tb.ForeColor = Color.White;
            logs_tb.Location = new Point(257, 112);
            logs_tb.Margin = new Padding(10);
            logs_tb.Name = "logs_tb";
            logs_tb.Size = new Size(289, 31);
            logs_tb.TabIndex = 13;
            // 
            // browse_logs_btn
            // 
            browse_logs_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_logs_btn.Dock = DockStyle.Fill;
            browse_logs_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_logs_btn.ForeColor = Color.White;
            browse_logs_btn.Location = new Point(560, 112);
            browse_logs_btn.Margin = new Padding(4, 10, 10, 10);
            browse_logs_btn.Name = "browse_logs_btn";
            browse_logs_btn.Size = new Size(48, 31);
            browse_logs_btn.TabIndex = 25;
            browse_logs_btn.Text = "...";
            browse_logs_btn.UseVisualStyleBackColor = false;
            // 
            // apply_pnl
            // 
            apply_pnl.BackColor = Color.FromArgb(64, 64, 64);
            apply_pnl.Controls.Add(apply_btn);
            apply_pnl.Dock = DockStyle.Bottom;
            apply_pnl.Location = new Point(30, 915);
            apply_pnl.Margin = new Padding(3, 20, 3, 3);
            apply_pnl.Name = "apply_pnl";
            apply_pnl.Padding = new Padding(20, 20, 41, 0);
            apply_pnl.Size = new Size(1337, 110);
            apply_pnl.TabIndex = 9;
            // 
            // currency_tb
            // 
            currency_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            currency_tb.BackColor = Color.FromArgb(54, 54, 54);
            currency_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            currency_tb.ForeColor = Color.White;
            currency_tb.Location = new Point(257, 102);
            currency_tb.Margin = new Padding(10, 5, 10, 10);
            currency_tb.MinimumSize = new Size(0, 31);
            currency_tb.Name = "currency_tb";
            currency_tb.Size = new Size(352, 31);
            currency_tb.TabIndex = 20;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(1397, 1055);
            Controls.Add(base_pnl);
            Controls.Add(apply_pnl);
            Name = "SettingsForm";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "Form1";
            base_pnl.ResumeLayout(false);
            settings_table.ResumeLayout(false);
            factors_pnl.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ai_pnl.ResumeLayout(false);
            ai_settings_gb.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)temperature_numeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            reporting_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            preferences_pnl.ResumeLayout(false);
            preferences_gb.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            logging_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).EndInit();
            paths_pnl.ResumeLayout(false);
            paths_gb.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            apply_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button apply_btn;
        private ComboBox themes_cb;
        private Panel base_pnl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label theme_lbl;
        private ComboBox languages_cb;
        private Label language_lbl;
        private GroupBox preferences_gb;
        private GroupBox paths_gb;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox settings_tb;
        private Label settings_lbl;
        private GroupBox ai_settings_gb;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox api_tb;
        private Label ai_logs_lbl;
        private Label api_lbl;
        private CheckBox ai_logs_ck;
        private Label db_lbl;
        private TextBox db_tb;
        private Label logs_lbl;
        private TextBox logs_tb;
        private Panel preferences_pnl;
        private Panel paths_pnl;
        private Panel ai_pnl;
        private Panel apply_pnl;
        private Panel logging_pnl;
        private Panel reporting_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox enable_reports_chk;
        private Label label1;
        private Label label2;
        private DateTimePicker time_picker;
        private TextBox email_recipient_tb;
        private Label label3;
        private Button sent_test_btn;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox enable_logging_chk;
        private Label label6;
        private Label next_report_date_time_lbl;
        private Label label7;
        private Button browse_settings_btn;
        private Button browse_db_btn;
        private Button browse_logs_btn;
        private Label label5;
        private Button open_log_btn;
        private Label label8;
        private NumericUpDown max_size_numeric;
        private ComboBox log_level_cb;
        private Label status_color_lbl;
        private ComboBox provider_cb;
        private Label label9;
        private Panel panel1;
        private Label api_status_lbl;
        private Label label12;
        private FontAwesome.Sharp.IconButton view_api_btn;
        private TableLayoutPanel settings_table;
        private Label label4;
        private Panel factors_pnl;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel7;
        private Label next_fetch_lbl;
        private Label label11;
        private CheckBox enable_daily_fetching;
        private Label label14;
        private Label label15;
        private DateTimePicker fetching_time;
        private Button manual_fetch_btn;
        private Label label16;
        private NumericUpDown temperature_numeric;
        private TextBox currency_tb;
    }
}
