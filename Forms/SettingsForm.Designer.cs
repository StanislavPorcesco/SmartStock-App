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
            section_b_pnl = new Panel();
            panel3 = new Panel();
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
            label4 = new Label();
            panel4 = new Panel();
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
            section_a_pnl = new Panel();
            theme_pnl = new Panel();
            ai_settings_gb = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label10 = new Label();
            label9 = new Label();
            api_tb = new TextBox();
            api_lbl = new Label();
            path_pnl = new Panel();
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
            ai_pnl = new Panel();
            preferences_gb = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            languages_cb = new ComboBox();
            language_lbl = new Label();
            theme_lbl = new Label();
            apply_pnl = new Panel();
            base_pnl.SuspendLayout();
            section_b_pnl.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            section_a_pnl.SuspendLayout();
            theme_pnl.SuspendLayout();
            ai_settings_gb.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            path_pnl.SuspendLayout();
            paths_gb.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ai_pnl.SuspendLayout();
            preferences_gb.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            apply_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // apply_btn
            // 
            apply_btn.BackColor = Color.FromArgb(54, 54, 54);
            apply_btn.Dock = DockStyle.Fill;
            apply_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.ForeColor = Color.White;
            apply_btn.Location = new Point(10, 0);
            apply_btn.Margin = new Padding(0);
            apply_btn.MaximumSize = new Size(0, 70);
            apply_btn.MinimumSize = new Size(0, 70);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(1211, 70);
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
            themes_cb.Location = new Point(298, 10);
            themes_cb.Margin = new Padding(10);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(268, 33);
            themes_cb.TabIndex = 1;
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(section_b_pnl);
            base_pnl.Controls.Add(section_a_pnl);
            base_pnl.Controls.Add(apply_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1271, 793);
            base_pnl.TabIndex = 2;
            base_pnl.Tag = "base";
            // 
            // section_b_pnl
            // 
            section_b_pnl.Controls.Add(panel3);
            section_b_pnl.Controls.Add(panel4);
            section_b_pnl.Dock = DockStyle.Fill;
            section_b_pnl.Location = new Point(636, 20);
            section_b_pnl.Name = "section_b_pnl";
            section_b_pnl.Size = new Size(615, 683);
            section_b_pnl.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 337);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(615, 321);
            panel3.TabIndex = 6;
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
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(595, 301);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logging System";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(enable_logging_chk, 1, 0);
            tableLayoutPanel5.Controls.Add(ai_logs_lbl, 0, 1);
            tableLayoutPanel5.Controls.Add(ai_logs_ck, 1, 1);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Controls.Add(max_size_numeric, 1, 2);
            tableLayoutPanel5.Controls.Add(log_level_cb, 1, 3);
            tableLayoutPanel5.Controls.Add(open_log_btn, 1, 4);
            tableLayoutPanel5.Controls.Add(label8, 0, 3);
            tableLayoutPanel5.Controls.Add(label4, 0, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(10, 40);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(575, 241);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // enable_logging_chk
            // 
            enable_logging_chk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            enable_logging_chk.AutoSize = true;
            enable_logging_chk.ForeColor = Color.FromArgb(64, 64, 64);
            enable_logging_chk.Location = new Point(547, 10);
            enable_logging_chk.Margin = new Padding(0, 10, 10, 10);
            enable_logging_chk.Name = "enable_logging_chk";
            enable_logging_chk.Size = new Size(18, 17);
            enable_logging_chk.TabIndex = 16;
            enable_logging_chk.UseVisualStyleBackColor = true;
            // 
            // ai_logs_lbl
            // 
            ai_logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ai_logs_lbl.AutoSize = true;
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
            ai_logs_ck.Location = new Point(547, 47);
            ai_logs_ck.Margin = new Padding(10);
            ai_logs_ck.Name = "ai_logs_ck";
            ai_logs_ck.Size = new Size(18, 17);
            ai_logs_ck.TabIndex = 15;
            ai_logs_ck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
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
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(10, 74);
            label5.Margin = new Padding(10, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 47);
            label5.TabIndex = 26;
            label5.Text = "Max File Size (MB)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_size_numeric
            // 
            max_size_numeric.Dock = DockStyle.Fill;
            max_size_numeric.Location = new Point(297, 84);
            max_size_numeric.Margin = new Padding(10);
            max_size_numeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            max_size_numeric.Name = "max_size_numeric";
            max_size_numeric.Size = new Size(268, 27);
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
            log_level_cb.Location = new Point(297, 131);
            log_level_cb.Margin = new Padding(10);
            log_level_cb.Name = "log_level_cb";
            log_level_cb.Size = new Size(268, 33);
            log_level_cb.TabIndex = 29;
            // 
            // open_log_btn
            // 
            open_log_btn.BackColor = Color.FromArgb(54, 54, 54);
            open_log_btn.Dock = DockStyle.Fill;
            open_log_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            open_log_btn.ForeColor = Color.White;
            open_log_btn.Location = new Point(297, 184);
            open_log_btn.Margin = new Padding(10);
            open_log_btn.Name = "open_log_btn";
            open_log_btn.Size = new Size(268, 47);
            open_log_btn.TabIndex = 25;
            open_log_btn.Text = "Open File";
            open_log_btn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(10, 121);
            label8.Margin = new Padding(10, 0, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 53);
            label8.TabIndex = 27;
            label8.Text = "Log Level";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 174);
            label4.Margin = new Padding(10, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 67);
            label4.TabIndex = 17;
            label4.Text = "Open Log File";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(615, 337);
            panel4.TabIndex = 7;
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
            groupBox1.Padding = new Padding(10, 20, 10, 20);
            groupBox1.Size = new Size(595, 317);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Automated Reporting";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(575, 257);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // next_report_date_time_lbl
            // 
            next_report_date_time_lbl.AutoSize = true;
            next_report_date_time_lbl.Dock = DockStyle.Fill;
            next_report_date_time_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            next_report_date_time_lbl.Location = new Point(297, 135);
            next_report_date_time_lbl.Margin = new Padding(10, 0, 0, 0);
            next_report_date_time_lbl.Name = "next_report_date_time_lbl";
            next_report_date_time_lbl.Size = new Size(278, 30);
            next_report_date_time_lbl.TabIndex = 22;
            next_report_date_time_lbl.Text = "15.01.2026 12:45";
            next_report_date_time_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(10, 135);
            label7.Margin = new Padding(10, 0, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(199, 30);
            label7.TabIndex = 21;
            label7.Text = "Next Report sheduled";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_recipient_tb
            // 
            email_recipient_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_recipient_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_recipient_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_recipient_tb.ForeColor = Color.White;
            email_recipient_tb.Location = new Point(287, 94);
            email_recipient_tb.Margin = new Padding(0, 10, 10, 10);
            email_recipient_tb.Name = "email_recipient_tb";
            email_recipient_tb.Size = new Size(278, 31);
            email_recipient_tb.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(10, 84);
            label3.Margin = new Padding(10, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 51);
            label3.TabIndex = 18;
            label3.Text = "E-mail Recipient";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_reports_chk
            // 
            enable_reports_chk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            enable_reports_chk.AutoSize = true;
            enable_reports_chk.ForeColor = Color.FromArgb(64, 64, 64);
            enable_reports_chk.Location = new Point(547, 10);
            enable_reports_chk.Margin = new Padding(0, 10, 10, 10);
            enable_reports_chk.Name = "enable_reports_chk";
            enable_reports_chk.Size = new Size(18, 17);
            enable_reports_chk.TabIndex = 16;
            enable_reports_chk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 37);
            label1.Margin = new Padding(10, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 47);
            label1.TabIndex = 3;
            label1.Text = "Shedule Time";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(10, 0);
            label2.Margin = new Padding(10, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(260, 37);
            label2.TabIndex = 2;
            label2.Text = "Enable Daily/Weekly Reports";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // time_picker
            // 
            time_picker.Dock = DockStyle.Fill;
            time_picker.Location = new Point(287, 47);
            time_picker.Margin = new Padding(0, 10, 10, 10);
            time_picker.Name = "time_picker";
            time_picker.Size = new Size(278, 27);
            time_picker.TabIndex = 17;
            // 
            // sent_test_btn
            // 
            sent_test_btn.BackColor = Color.FromArgb(54, 54, 54);
            tableLayoutPanel4.SetColumnSpan(sent_test_btn, 2);
            sent_test_btn.Dock = DockStyle.Fill;
            sent_test_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sent_test_btn.ForeColor = Color.White;
            sent_test_btn.Location = new Point(10, 185);
            sent_test_btn.Margin = new Padding(10, 20, 10, 10);
            sent_test_btn.MaximumSize = new Size(0, 70);
            sent_test_btn.MinimumSize = new Size(0, 70);
            sent_test_btn.Name = "sent_test_btn";
            sent_test_btn.Size = new Size(555, 70);
            sent_test_btn.TabIndex = 20;
            sent_test_btn.Text = "Send Test Report";
            sent_test_btn.UseVisualStyleBackColor = false;
            // 
            // section_a_pnl
            // 
            section_a_pnl.Controls.Add(theme_pnl);
            section_a_pnl.Controls.Add(path_pnl);
            section_a_pnl.Controls.Add(ai_pnl);
            section_a_pnl.Dock = DockStyle.Left;
            section_a_pnl.Location = new Point(20, 20);
            section_a_pnl.Name = "section_a_pnl";
            section_a_pnl.Size = new Size(616, 683);
            section_a_pnl.TabIndex = 10;
            // 
            // theme_pnl
            // 
            theme_pnl.Controls.Add(ai_settings_gb);
            theme_pnl.Dock = DockStyle.Top;
            theme_pnl.Location = new Point(0, 413);
            theme_pnl.Margin = new Padding(0);
            theme_pnl.Name = "theme_pnl";
            theme_pnl.Padding = new Padding(10);
            theme_pnl.Size = new Size(616, 245);
            theme_pnl.TabIndex = 5;
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
            ai_settings_gb.Padding = new Padding(10, 20, 10, 20);
            ai_settings_gb.Size = new Size(596, 225);
            ai_settings_gb.TabIndex = 4;
            ai_settings_gb.TabStop = false;
            ai_settings_gb.Text = "AI Settings";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.74464F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2553635F));
            tableLayoutPanel3.Controls.Add(label10, 1, 1);
            tableLayoutPanel3.Controls.Add(label9, 0, 1);
            tableLayoutPanel3.Controls.Add(api_tb, 1, 0);
            tableLayoutPanel3.Controls.Add(api_lbl, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(576, 165);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Right;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(486, 60);
            label10.Margin = new Padding(10);
            label10.Name = "label10";
            label10.Size = new Size(80, 95);
            label10.TabIndex = 16;
            label10.Text = "Inactive";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(10, 50);
            label9.Margin = new Padding(10, 0, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 115);
            label9.TabIndex = 15;
            label9.Text = "Agent Status";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // api_tb
            // 
            api_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_tb.BackColor = Color.FromArgb(54, 54, 54);
            api_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_tb.ForeColor = Color.White;
            api_tb.Location = new Point(296, 10);
            api_tb.Margin = new Padding(10);
            api_tb.Name = "api_tb";
            api_tb.Size = new Size(270, 31);
            api_tb.TabIndex = 14;
            // 
            // api_lbl
            // 
            api_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            api_lbl.AutoSize = true;
            api_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_lbl.Location = new Point(10, 0);
            api_lbl.Margin = new Padding(10, 0, 0, 0);
            api_lbl.Name = "api_lbl";
            api_lbl.Size = new Size(79, 50);
            api_lbl.TabIndex = 2;
            api_lbl.Text = "API Key";
            api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // path_pnl
            // 
            path_pnl.Controls.Add(paths_gb);
            path_pnl.Dock = DockStyle.Top;
            path_pnl.Location = new Point(0, 185);
            path_pnl.Margin = new Padding(0);
            path_pnl.Name = "path_pnl";
            path_pnl.Padding = new Padding(10);
            path_pnl.Size = new Size(616, 228);
            path_pnl.TabIndex = 6;
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
            paths_gb.Padding = new Padding(10, 20, 10, 20);
            paths_gb.Size = new Size(596, 208);
            paths_gb.TabIndex = 4;
            paths_gb.TabStop = false;
            paths_gb.Text = "File paths";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
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
            tableLayoutPanel2.Size = new Size(576, 148);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
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
            settings_tb.Location = new Point(224, 10);
            settings_tb.Margin = new Padding(10);
            settings_tb.Name = "settings_tb";
            settings_tb.Size = new Size(251, 31);
            settings_tb.TabIndex = 11;
            // 
            // browse_settings_btn
            // 
            browse_settings_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_settings_btn.Dock = DockStyle.Fill;
            browse_settings_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_settings_btn.ForeColor = Color.White;
            browse_settings_btn.Location = new Point(489, 10);
            browse_settings_btn.Margin = new Padding(4, 10, 10, 10);
            browse_settings_btn.Name = "browse_settings_btn";
            browse_settings_btn.Size = new Size(77, 31);
            browse_settings_btn.TabIndex = 23;
            browse_settings_btn.Text = "Browse...";
            browse_settings_btn.UseVisualStyleBackColor = false;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
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
            db_tb.Location = new Point(224, 61);
            db_tb.Margin = new Padding(10);
            db_tb.Name = "db_tb";
            db_tb.Size = new Size(251, 31);
            db_tb.TabIndex = 12;
            // 
            // browse_db_btn
            // 
            browse_db_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_db_btn.Dock = DockStyle.Fill;
            browse_db_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_db_btn.ForeColor = Color.White;
            browse_db_btn.Location = new Point(489, 61);
            browse_db_btn.Margin = new Padding(4, 10, 10, 10);
            browse_db_btn.Name = "browse_db_btn";
            browse_db_btn.Size = new Size(77, 31);
            browse_db_btn.TabIndex = 24;
            browse_db_btn.Text = "Browse...";
            browse_db_btn.UseVisualStyleBackColor = false;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
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
            logs_tb.Location = new Point(224, 112);
            logs_tb.Margin = new Padding(10);
            logs_tb.Name = "logs_tb";
            logs_tb.Size = new Size(251, 31);
            logs_tb.TabIndex = 13;
            // 
            // browse_logs_btn
            // 
            browse_logs_btn.BackColor = Color.FromArgb(54, 54, 54);
            browse_logs_btn.Dock = DockStyle.Fill;
            browse_logs_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_logs_btn.ForeColor = Color.White;
            browse_logs_btn.Location = new Point(489, 112);
            browse_logs_btn.Margin = new Padding(4, 10, 10, 10);
            browse_logs_btn.Name = "browse_logs_btn";
            browse_logs_btn.Size = new Size(77, 31);
            browse_logs_btn.TabIndex = 25;
            browse_logs_btn.Text = "Browse...";
            browse_logs_btn.UseVisualStyleBackColor = false;
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(preferences_gb);
            ai_pnl.Dock = DockStyle.Top;
            ai_pnl.Location = new Point(0, 0);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Padding = new Padding(10);
            ai_pnl.Size = new Size(616, 185);
            ai_pnl.TabIndex = 7;
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
            preferences_gb.Padding = new Padding(10, 20, 10, 20);
            preferences_gb.Size = new Size(596, 165);
            preferences_gb.TabIndex = 3;
            preferences_gb.TabStop = false;
            preferences_gb.Text = "Theme and Preferences";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(languages_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(language_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(theme_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(576, 105);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // languages_cb
            // 
            languages_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            languages_cb.BackColor = Color.FromArgb(54, 54, 54);
            languages_cb.FlatStyle = FlatStyle.Flat;
            languages_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            languages_cb.ForeColor = Color.White;
            languages_cb.FormattingEnabled = true;
            languages_cb.Location = new Point(298, 63);
            languages_cb.Margin = new Padding(10);
            languages_cb.Name = "languages_cb";
            languages_cb.Size = new Size(268, 33);
            languages_cb.TabIndex = 5;
            // 
            // language_lbl
            // 
            language_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            language_lbl.AutoSize = true;
            language_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            language_lbl.Location = new Point(10, 53);
            language_lbl.Margin = new Padding(10, 0, 0, 0);
            language_lbl.Name = "language_lbl";
            language_lbl.Size = new Size(95, 53);
            language_lbl.TabIndex = 3;
            language_lbl.Text = "Language";
            language_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // theme_lbl
            // 
            theme_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            theme_lbl.AutoSize = true;
            theme_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            theme_lbl.Location = new Point(10, 0);
            theme_lbl.Margin = new Padding(10, 0, 0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(70, 53);
            theme_lbl.TabIndex = 2;
            theme_lbl.Text = "Theme";
            theme_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apply_pnl
            // 
            apply_pnl.Controls.Add(apply_btn);
            apply_pnl.Dock = DockStyle.Bottom;
            apply_pnl.Location = new Point(20, 703);
            apply_pnl.Name = "apply_pnl";
            apply_pnl.Padding = new Padding(10, 0, 10, 0);
            apply_pnl.Size = new Size(1231, 70);
            apply_pnl.TabIndex = 9;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(1331, 853);
            Controls.Add(base_pnl);
            Name = "SettingsForm";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "Form1";
            base_pnl.ResumeLayout(false);
            section_b_pnl.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            section_a_pnl.ResumeLayout(false);
            theme_pnl.ResumeLayout(false);
            ai_settings_gb.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            path_pnl.ResumeLayout(false);
            paths_gb.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ai_pnl.ResumeLayout(false);
            preferences_gb.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Panel ai_pnl;
        private Panel path_pnl;
        private Panel theme_pnl;
        private Panel apply_pnl;
        private Panel section_b_pnl;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox enable_reports_chk;
        private Label label1;
        private Label label2;
        private Panel section_a_pnl;
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
        private Label label4;
        private Label label8;
        private NumericUpDown max_size_numeric;
        private ComboBox log_level_cb;
        private Label label10;
        private Label label9;
    }
}
