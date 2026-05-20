using FontAwesome.Sharp;
using SmartStock.Classes.Utils;
using System.Text;

namespace SmartStock
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            base_pnl = new Panel();
            content_host = new Panel();
            settings_table = new TableLayoutPanel();
            preferences_pnl = new Panel();
            preferences_body = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel12 = new Panel();
            panel13 = new Panel();
            tableLayoutPanel13 = new TableLayoutPanel();
            currency_symbol_tb = new TextBox();
            theme_lbl = new Label();
            themes_cb = new ThemedComboBox();
            languages_cb = new ThemedComboBox();
            language_lbl = new Label();
            label4 = new Label();
            preferences_divider = new Panel();
            preferences_header = new Panel();
            preferences_title_lbl = new Label();
            preferences_icon = new IconPictureBox();
            reporting_pnl = new Panel();
            reporting_body = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            email_recipient_tb = new TextBox();
            label2 = new Label();
            enable_reports_chk = new CheckBox();
            label1 = new Label();
            time_picker = new ThemedDateTimePicker();
            label3 = new Label();
            label7 = new Label();
            report_row_pnl = new Panel();
            next_report_date_time_lbl = new Label();
            sent_test_btn = new IconButton();
            reporting_divider = new Panel();
            reporting_header = new Panel();
            reporting_title_lbl = new Label();
            reporting_icon = new IconPictureBox();
            paths_pnl = new Panel();
            paths_body = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel11 = new TableLayoutPanel();
            logs_tb = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel10 = new TableLayoutPanel();
            db_tb = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            settings_tb = new TextBox();
            settings_lbl = new Label();
            browse_settings_btn = new IconButton();
            db_lbl = new Label();
            browse_db_btn = new IconButton();
            logs_lbl = new Label();
            browse_logs_btn = new IconButton();
            paths_divider = new Panel();
            paths_header = new Panel();
            paths_title_lbl = new Label();
            paths_icon = new IconPictureBox();
            logging_pnl = new Panel();
            logging_body = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            enable_logging_chk = new CheckBox();
            ai_logs_lbl = new Label();
            ai_logs_ck = new CheckBox();
            label5 = new Label();
            max_size_numeric = new ThemedNumericUpDown();
            log_level_cb = new ThemedComboBox();
            label8 = new Label();
            open_log_btn = new IconButton();
            logging_divider = new Panel();
            logging_header = new Panel();
            logging_title_lbl = new Label();
            logging_icon = new IconPictureBox();
            ai_pnl = new Panel();
            ai_body = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel10 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel12 = new TableLayoutPanel();
            api_tb = new TextBox();
            api_lbl = new Label();
            view_api_btn = new IconButton();
            label9 = new Label();
            provider_cb = new ThemedComboBox();
            label12 = new Label();
            panel1 = new Panel();
            api_status_lbl = new Label();
            status_color_lbl = new Label();
            label16 = new Label();
            temperature_numeric = new ThemedNumericUpDown();
            ai_divider = new Panel();
            ai_header = new Panel();
            ai_title_lbl = new Label();
            ai_icon = new IconPictureBox();
            factors_pnl = new Panel();
            factors_body = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label15 = new Label();
            enable_daily_fetching = new CheckBox();
            label14 = new Label();
            fetching_time = new ThemedDateTimePicker();
            label11 = new Label();
            next_fetch_lbl = new Label();
            commodity_api_lbl = new Label();
            commodity_status_pnl = new Panel();
            commodity_status_lbl = new Label();
            commodity_status_color_lbl = new Label();
            economic_api_lbl = new Label();
            economic_status_pnl = new Panel();
            economic_status_lbl = new Label();
            economic_status_color_lbl = new Label();
            events_api_lbl = new Label();
            events_status_pnl = new Panel();
            events_status_lbl = new Label();
            events_status_color_lbl = new Label();
            weather_api_lbl = new Label();
            weather_status_pnl = new Panel();
            weather_status_lbl = new Label();
            weather_status_color_lbl = new Label();
            manual_fetch_btn = new IconButton();
            factors_divider = new Panel();
            factors_header = new Panel();
            factors_title_lbl = new Label();
            factors_icon = new IconPictureBox();
            hero_pnl = new Panel();
            hero_subtitle_lbl = new Label();
            hero_title_lbl = new Label();
            hero_icon = new IconPictureBox();
            apply_pnl = new Panel();
            apply_btn = new IconButton();
            base_pnl.SuspendLayout();
            content_host.SuspendLayout();
            settings_table.SuspendLayout();
            preferences_pnl.SuspendLayout();
            preferences_body.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            preferences_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)preferences_icon).BeginInit();
            reporting_pnl.SuspendLayout();
            reporting_body.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            report_row_pnl.SuspendLayout();
            reporting_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reporting_icon).BeginInit();
            paths_pnl.SuspendLayout();
            paths_body.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            paths_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paths_icon).BeginInit();
            logging_pnl.SuspendLayout();
            logging_body.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).BeginInit();
            logging_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logging_icon).BeginInit();
            ai_pnl.SuspendLayout();
            ai_body.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)temperature_numeric).BeginInit();
            ai_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ai_icon).BeginInit();
            factors_pnl.SuspendLayout();
            factors_body.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            commodity_status_pnl.SuspendLayout();
            economic_status_pnl.SuspendLayout();
            events_status_pnl.SuspendLayout();
            weather_status_pnl.SuspendLayout();
            factors_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)factors_icon).BeginInit();
            hero_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hero_icon).BeginInit();
            apply_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.Controls.Add(content_host);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(28, 24, 28, 24);
            base_pnl.Size = new Size(1267, 967);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "base";
            // 
            // content_host
            // 
            content_host.Controls.Add(settings_table);
            content_host.Controls.Add(hero_pnl);
            content_host.Dock = DockStyle.Top;
            content_host.Location = new Point(28, 24);
            content_host.Name = "content_host";
            content_host.Size = new Size(1190, 1336);
            content_host.TabIndex = 0;
            content_host.Tag = "base";
            // 
            // settings_table
            // 
            settings_table.ColumnCount = 2;
            settings_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            settings_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            settings_table.Controls.Add(preferences_pnl, 0, 0);
            settings_table.Controls.Add(reporting_pnl, 1, 0);
            settings_table.Controls.Add(paths_pnl, 0, 1);
            settings_table.Controls.Add(logging_pnl, 1, 1);
            settings_table.Controls.Add(ai_pnl, 0, 2);
            settings_table.Controls.Add(factors_pnl, 1, 2);
            settings_table.Dock = DockStyle.Top;
            settings_table.Location = new Point(0, 90);
            settings_table.Margin = new Padding(0);
            settings_table.Name = "settings_table";
            settings_table.RowCount = 3;
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 360F));
            settings_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 360F));
            settings_table.Size = new Size(1190, 1137);
            settings_table.TabIndex = 1;
            // 
            // preferences_pnl
            // 
            preferences_pnl.Controls.Add(preferences_body);
            preferences_pnl.Dock = DockStyle.Fill;
            preferences_pnl.Location = new Point(0, 0);
            preferences_pnl.Margin = new Padding(0, 0, 10, 16);
            preferences_pnl.Name = "preferences_pnl";
            preferences_pnl.Size = new Size(585, 284);
            preferences_pnl.TabIndex = 0;
            preferences_pnl.Tag = "base";
            // 
            // preferences_body
            // 
            preferences_body.Controls.Add(tableLayoutPanel1);
            preferences_body.Controls.Add(preferences_divider);
            preferences_body.Controls.Add(preferences_header);
            preferences_body.Dock = DockStyle.Fill;
            preferences_body.Location = new Point(0, 0);
            preferences_body.Name = "preferences_body";
            preferences_body.Padding = new Padding(22, 0, 22, 18);
            preferences_body.Size = new Size(585, 284);
            preferences_body.TabIndex = 0;
            preferences_body.Tag = "main_card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel12, 1, 2);
            tableLayoutPanel1.Controls.Add(theme_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(languages_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(language_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(22, 57);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 18, 0, 0);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(541, 209);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel13);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(206, 116);
            panel12.Margin = new Padding(6, 10, 0, 10);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(1);
            panel12.Size = new Size(335, 34);
            panel12.TabIndex = 8;
            panel12.Tag = "border_pnl";
            // 
            // panel13
            // 
            panel13.Controls.Add(tableLayoutPanel13);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(1, 1);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(333, 32);
            panel13.TabIndex = 0;
            panel13.Tag = "card";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Controls.Add(currency_symbol_tb, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 0);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(333, 32);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // currency_symbol_tb
            // 
            currency_symbol_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            currency_symbol_tb.Font = new Font("Segoe UI", 11F);
            currency_symbol_tb.Location = new Point(0, 0);
            currency_symbol_tb.Margin = new Padding(0);
            currency_symbol_tb.Name = "currency_symbol_tb";
            currency_symbol_tb.Size = new Size(333, 32);
            currency_symbol_tb.TabIndex = 3;
            currency_symbol_tb.Tag = "borderless";
            // 
            // theme_lbl
            // 
            theme_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            theme_lbl.AutoSize = true;
            theme_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            theme_lbl.Location = new Point(3, 28);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(194, 23);
            theme_lbl.TabIndex = 0;
            theme_lbl.Tag = "muted";
            theme_lbl.Text = "Theme";
            theme_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // themes_cb
            // 
            themes_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            themes_cb.DrawMode = DrawMode.OwnerDrawFixed;
            themes_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            themes_cb.FlatStyle = FlatStyle.Flat;
            themes_cb.Font = new Font("Segoe UI", 10F);
            themes_cb.FormattingEnabled = true;
            themes_cb.ItemHeight = 30;
            themes_cb.Location = new Point(206, 28);
            themes_cb.Margin = new Padding(6, 10, 0, 10);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(335, 36);
            themes_cb.TabIndex = 1;
            // 
            // languages_cb
            // 
            languages_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            languages_cb.DrawMode = DrawMode.OwnerDrawFixed;
            languages_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            languages_cb.FlatStyle = FlatStyle.Flat;
            languages_cb.Font = new Font("Segoe UI", 10F);
            languages_cb.FormattingEnabled = true;
            languages_cb.ItemHeight = 30;
            languages_cb.Location = new Point(206, 72);
            languages_cb.Margin = new Padding(6, 10, 0, 10);
            languages_cb.Name = "languages_cb";
            languages_cb.Size = new Size(335, 36);
            languages_cb.TabIndex = 3;
            // 
            // language_lbl
            // 
            language_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            language_lbl.AutoSize = true;
            language_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            language_lbl.Location = new Point(3, 72);
            language_lbl.Name = "language_lbl";
            language_lbl.Size = new Size(194, 23);
            language_lbl.TabIndex = 2;
            language_lbl.Tag = "muted";
            language_lbl.Text = "Language";
            language_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(194, 23);
            label4.TabIndex = 4;
            label4.Tag = "muted";
            label4.Text = "Currency Symbol";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // preferences_divider
            // 
            preferences_divider.Dock = DockStyle.Top;
            preferences_divider.Location = new Point(22, 56);
            preferences_divider.Name = "preferences_divider";
            preferences_divider.Size = new Size(541, 1);
            preferences_divider.TabIndex = 4;
            preferences_divider.Tag = "divider";
            // 
            // preferences_header
            // 
            preferences_header.Controls.Add(preferences_title_lbl);
            preferences_header.Controls.Add(preferences_icon);
            preferences_header.Dock = DockStyle.Top;
            preferences_header.Location = new Point(22, 0);
            preferences_header.Name = "preferences_header";
            preferences_header.Size = new Size(541, 56);
            preferences_header.TabIndex = 5;
            preferences_header.Tag = "card";
            // 
            // preferences_title_lbl
            // 
            preferences_title_lbl.AutoSize = true;
            preferences_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            preferences_title_lbl.Location = new Point(32, 18);
            preferences_title_lbl.Name = "preferences_title_lbl";
            preferences_title_lbl.Size = new Size(194, 28);
            preferences_title_lbl.TabIndex = 1;
            preferences_title_lbl.Text = "Theme & Preferences";
            // 
            // preferences_icon
            // 
            preferences_icon.BackColor = SystemColors.Control;
            preferences_icon.ForeColor = SystemColors.ControlText;
            preferences_icon.IconChar = IconChar.Palette;
            preferences_icon.IconColor = SystemColors.ControlText;
            preferences_icon.IconFont = IconFont.Auto;
            preferences_icon.IconSize = 30;
            preferences_icon.Location = new Point(0, 17);
            preferences_icon.Name = "preferences_icon";
            preferences_icon.Size = new Size(30, 30);
            preferences_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            preferences_icon.TabIndex = 0;
            preferences_icon.TabStop = false;
            preferences_icon.Tag = "accent-icon";
            // 
            // reporting_pnl
            // 
            reporting_pnl.Controls.Add(reporting_body);
            reporting_pnl.Dock = DockStyle.Fill;
            reporting_pnl.Location = new Point(605, 0);
            reporting_pnl.Margin = new Padding(10, 0, 0, 16);
            reporting_pnl.Name = "reporting_pnl";
            reporting_pnl.Size = new Size(585, 284);
            reporting_pnl.TabIndex = 1;
            reporting_pnl.Tag = "base";
            // 
            // reporting_body
            // 
            reporting_body.Controls.Add(tableLayoutPanel4);
            reporting_body.Controls.Add(reporting_divider);
            reporting_body.Controls.Add(reporting_header);
            reporting_body.Dock = DockStyle.Fill;
            reporting_body.Location = new Point(0, 0);
            reporting_body.Name = "reporting_body";
            reporting_body.Padding = new Padding(22, 0, 22, 18);
            reporting_body.Size = new Size(585, 284);
            reporting_body.TabIndex = 0;
            reporting_body.Tag = "main_card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel2, 1, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(enable_reports_chk, 1, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Controls.Add(time_picker, 1, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(label7, 0, 3);
            tableLayoutPanel4.Controls.Add(report_row_pnl, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(22, 57);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(0, 18, 0, 0);
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(541, 209);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(206, 116);
            panel2.Margin = new Padding(6, 10, 0, 10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(335, 34);
            panel2.TabIndex = 8;
            panel2.Tag = "border_pnl";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1, 1);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 32);
            panel3.TabIndex = 0;
            panel3.Tag = "card";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(email_recipient_tb, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(333, 32);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // email_recipient_tb
            // 
            email_recipient_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_recipient_tb.Font = new Font("Segoe UI", 11F);
            email_recipient_tb.Location = new Point(0, 0);
            email_recipient_tb.Margin = new Padding(0);
            email_recipient_tb.Name = "email_recipient_tb";
            email_recipient_tb.Size = new Size(333, 32);
            email_recipient_tb.TabIndex = 16;
            email_recipient_tb.Tag = "borderless";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 0;
            label2.Tag = "muted";
            label2.Text = "Enable Weekly Reports";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_reports_chk
            // 
            enable_reports_chk.Anchor = AnchorStyles.Left;
            enable_reports_chk.AutoSize = true;
            enable_reports_chk.Location = new Point(206, 31);
            enable_reports_chk.Margin = new Padding(6, 10, 0, 10);
            enable_reports_chk.Name = "enable_reports_chk";
            enable_reports_chk.Size = new Size(18, 17);
            enable_reports_chk.TabIndex = 14;
            enable_reports_chk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 72);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 2;
            label1.Tag = "muted";
            label1.Text = "Schedule Time";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // time_picker
            // 
            time_picker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            time_picker.CustomFormat = "dd MMM yyyy";
            time_picker.Font = new Font("Segoe UI", 10.5F);
            time_picker.Format = DateTimePickerFormat.Custom;
            time_picker.Location = new Point(206, 72);
            time_picker.Margin = new Padding(6, 10, 0, 10);
            time_picker.Name = "time_picker";
            time_picker.Size = new Size(335, 31);
            time_picker.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(194, 23);
            label3.TabIndex = 4;
            label3.Tag = "muted";
            label3.Text = "E-mail Recipient";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(3, 173);
            label7.Name = "label7";
            label7.Size = new Size(194, 23);
            label7.TabIndex = 6;
            label7.Tag = "muted";
            label7.Text = "Next Report Scheduled";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // report_row_pnl
            // 
            report_row_pnl.Controls.Add(next_report_date_time_lbl);
            report_row_pnl.Controls.Add(sent_test_btn);
            report_row_pnl.Dock = DockStyle.Fill;
            report_row_pnl.Location = new Point(206, 166);
            report_row_pnl.Margin = new Padding(6, 6, 0, 6);
            report_row_pnl.Name = "report_row_pnl";
            report_row_pnl.Size = new Size(335, 37);
            report_row_pnl.TabIndex = 7;
            report_row_pnl.Tag = "card";
            // 
            // next_report_date_time_lbl
            // 
            next_report_date_time_lbl.Dock = DockStyle.Fill;
            next_report_date_time_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            next_report_date_time_lbl.Location = new Point(0, 0);
            next_report_date_time_lbl.Name = "next_report_date_time_lbl";
            next_report_date_time_lbl.Padding = new Padding(0, 0, 8, 0);
            next_report_date_time_lbl.Size = new Size(169, 37);
            next_report_date_time_lbl.TabIndex = 7;
            next_report_date_time_lbl.Tag = "accent";
            next_report_date_time_lbl.Text = "—";
            next_report_date_time_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sent_test_btn
            // 
            sent_test_btn.Cursor = Cursors.Hand;
            sent_test_btn.Dock = DockStyle.Right;
            sent_test_btn.FlatAppearance.BorderSize = 0;
            sent_test_btn.FlatStyle = FlatStyle.Flat;
            sent_test_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            sent_test_btn.IconChar = IconChar.PaperPlane;
            sent_test_btn.IconColor = Color.Black;
            sent_test_btn.IconFont = IconFont.Auto;
            sent_test_btn.IconSize = 25;
            sent_test_btn.ImageAlign = ContentAlignment.MiddleLeft;
            sent_test_btn.Location = new Point(169, 0);
            sent_test_btn.Name = "sent_test_btn";
            sent_test_btn.Padding = new Padding(14, 0, 16, 0);
            sent_test_btn.Size = new Size(166, 37);
            sent_test_btn.TabIndex = 17;
            sent_test_btn.Tag = "cta";
            sent_test_btn.Text = "  Send Test";
            sent_test_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            sent_test_btn.UseVisualStyleBackColor = false;
            // 
            // reporting_divider
            // 
            reporting_divider.Dock = DockStyle.Top;
            reporting_divider.Location = new Point(22, 56);
            reporting_divider.Name = "reporting_divider";
            reporting_divider.Size = new Size(541, 1);
            reporting_divider.TabIndex = 4;
            reporting_divider.Tag = "divider";
            // 
            // reporting_header
            // 
            reporting_header.Controls.Add(reporting_title_lbl);
            reporting_header.Controls.Add(reporting_icon);
            reporting_header.Dock = DockStyle.Top;
            reporting_header.Location = new Point(22, 0);
            reporting_header.Name = "reporting_header";
            reporting_header.Size = new Size(541, 56);
            reporting_header.TabIndex = 5;
            reporting_header.Tag = "card";
            // 
            // reporting_title_lbl
            // 
            reporting_title_lbl.AutoSize = true;
            reporting_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            reporting_title_lbl.Location = new Point(32, 18);
            reporting_title_lbl.Name = "reporting_title_lbl";
            reporting_title_lbl.Size = new Size(210, 28);
            reporting_title_lbl.TabIndex = 1;
            reporting_title_lbl.Text = "Automated Reporting";
            // 
            // reporting_icon
            // 
            reporting_icon.BackColor = SystemColors.Control;
            reporting_icon.ForeColor = SystemColors.ControlText;
            reporting_icon.IconChar = IconChar.Envelope;
            reporting_icon.IconColor = SystemColors.ControlText;
            reporting_icon.IconFont = IconFont.Auto;
            reporting_icon.IconSize = 29;
            reporting_icon.Location = new Point(0, 17);
            reporting_icon.Margin = new Padding(0);
            reporting_icon.Name = "reporting_icon";
            reporting_icon.Size = new Size(29, 37);
            reporting_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            reporting_icon.TabIndex = 0;
            reporting_icon.TabStop = false;
            reporting_icon.Tag = "accent-icon";
            // 
            // paths_pnl
            // 
            paths_pnl.Controls.Add(paths_body);
            paths_pnl.Dock = DockStyle.Fill;
            paths_pnl.Location = new Point(0, 300);
            paths_pnl.Margin = new Padding(0, 0, 10, 16);
            paths_pnl.Name = "paths_pnl";
            paths_pnl.Size = new Size(585, 344);
            paths_pnl.TabIndex = 2;
            paths_pnl.Tag = "base";
            // 
            // paths_body
            // 
            paths_body.Controls.Add(tableLayoutPanel2);
            paths_body.Controls.Add(paths_divider);
            paths_body.Controls.Add(paths_header);
            paths_body.Dock = DockStyle.Fill;
            paths_body.Location = new Point(0, 0);
            paths_body.Name = "paths_body";
            paths_body.Padding = new Padding(22, 0, 22, 18);
            paths_body.Size = new Size(585, 344);
            paths_body.TabIndex = 0;
            paths_body.Tag = "main_card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Controls.Add(panel8, 1, 2);
            tableLayoutPanel2.Controls.Add(panel6, 1, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(browse_settings_btn, 2, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(browse_db_btn, 2, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(browse_logs_btn, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(22, 57);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 18, 0, 0);
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(541, 269);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(206, 136);
            panel8.Margin = new Padding(6, 10, 0, 10);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(1);
            panel8.Size = new Size(295, 34);
            panel8.TabIndex = 11;
            panel8.Tag = "border_pnl";
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLayoutPanel11);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(1, 1);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(293, 32);
            panel9.TabIndex = 0;
            panel9.Tag = "card";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Controls.Add(logs_tb, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(293, 32);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // logs_tb
            // 
            logs_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logs_tb.Font = new Font("Segoe UI", 11F);
            logs_tb.Location = new Point(0, 0);
            logs_tb.Margin = new Padding(0);
            logs_tb.Name = "logs_tb";
            logs_tb.Size = new Size(293, 32);
            logs_tb.TabIndex = 8;
            logs_tb.Tag = "borderless";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(206, 82);
            panel6.Margin = new Padding(6, 10, 0, 10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(1);
            panel6.Size = new Size(295, 34);
            panel6.TabIndex = 10;
            panel6.Tag = "border_pnl";
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel10);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1, 1);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(293, 32);
            panel7.TabIndex = 0;
            panel7.Tag = "card";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(db_tb, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(293, 32);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // db_tb
            // 
            db_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            db_tb.Font = new Font("Segoe UI", 11F);
            db_tb.Location = new Point(0, 0);
            db_tb.Margin = new Padding(0);
            db_tb.Name = "db_tb";
            db_tb.Size = new Size(293, 32);
            db_tb.TabIndex = 6;
            db_tb.Tag = "borderless";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(206, 28);
            panel4.Margin = new Padding(6, 10, 0, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1);
            panel4.Size = new Size(295, 34);
            panel4.TabIndex = 9;
            panel4.Tag = "border_pnl";
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1, 1);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 32);
            panel5.TabIndex = 0;
            panel5.Tag = "card";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(settings_tb, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(293, 32);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // settings_tb
            // 
            settings_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            settings_tb.Font = new Font("Segoe UI", 11F);
            settings_tb.Location = new Point(0, 0);
            settings_tb.Margin = new Padding(0);
            settings_tb.Name = "settings_tb";
            settings_tb.Size = new Size(293, 32);
            settings_tb.TabIndex = 4;
            settings_tb.Tag = "borderless";
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 33);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(194, 23);
            settings_lbl.TabIndex = 0;
            settings_lbl.Tag = "muted";
            settings_lbl.Text = "Settings File";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // browse_settings_btn
            // 
            browse_settings_btn.Cursor = Cursors.Hand;
            browse_settings_btn.Dock = DockStyle.Fill;
            browse_settings_btn.FlatStyle = FlatStyle.Flat;
            browse_settings_btn.IconChar = IconChar.Search;
            browse_settings_btn.IconColor = Color.Black;
            browse_settings_btn.IconFont = IconFont.Auto;
            browse_settings_btn.IconSize = 18;
            browse_settings_btn.Location = new Point(507, 28);
            browse_settings_btn.Margin = new Padding(6, 10, 0, 10);
            browse_settings_btn.Name = "browse_settings_btn";
            browse_settings_btn.Size = new Size(34, 34);
            browse_settings_btn.TabIndex = 5;
            browse_settings_btn.Tag = "outlined";
            browse_settings_btn.TextAlign = ContentAlignment.BottomCenter;
            browse_settings_btn.UseVisualStyleBackColor = false;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 87);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(194, 23);
            db_lbl.TabIndex = 3;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Database File";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // browse_db_btn
            // 
            browse_db_btn.Cursor = Cursors.Hand;
            browse_db_btn.Dock = DockStyle.Fill;
            browse_db_btn.FlatStyle = FlatStyle.Flat;
            browse_db_btn.IconChar = IconChar.Search;
            browse_db_btn.IconColor = Color.Black;
            browse_db_btn.IconFont = IconFont.Auto;
            browse_db_btn.IconSize = 18;
            browse_db_btn.Location = new Point(507, 81);
            browse_db_btn.Margin = new Padding(6, 9, 0, 9);
            browse_db_btn.Name = "browse_db_btn";
            browse_db_btn.Size = new Size(34, 36);
            browse_db_btn.TabIndex = 7;
            browse_db_btn.Tag = "outlined";
            browse_db_btn.UseVisualStyleBackColor = false;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 141);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(194, 23);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Log File";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // browse_logs_btn
            // 
            browse_logs_btn.Cursor = Cursors.Hand;
            browse_logs_btn.Dock = DockStyle.Fill;
            browse_logs_btn.FlatStyle = FlatStyle.Flat;
            browse_logs_btn.IconChar = IconChar.Search;
            browse_logs_btn.IconColor = Color.Black;
            browse_logs_btn.IconFont = IconFont.Auto;
            browse_logs_btn.IconSize = 18;
            browse_logs_btn.Location = new Point(507, 135);
            browse_logs_btn.Margin = new Padding(6, 9, 0, 9);
            browse_logs_btn.Name = "browse_logs_btn";
            browse_logs_btn.Size = new Size(34, 36);
            browse_logs_btn.TabIndex = 9;
            browse_logs_btn.Tag = "outlined";
            browse_logs_btn.UseVisualStyleBackColor = false;
            // 
            // paths_divider
            // 
            paths_divider.Dock = DockStyle.Top;
            paths_divider.Location = new Point(22, 56);
            paths_divider.Name = "paths_divider";
            paths_divider.Size = new Size(541, 1);
            paths_divider.TabIndex = 4;
            paths_divider.Tag = "divider";
            // 
            // paths_header
            // 
            paths_header.Controls.Add(paths_title_lbl);
            paths_header.Controls.Add(paths_icon);
            paths_header.Dock = DockStyle.Top;
            paths_header.Location = new Point(22, 0);
            paths_header.Name = "paths_header";
            paths_header.Size = new Size(541, 56);
            paths_header.TabIndex = 5;
            paths_header.Tag = "card";
            // 
            // paths_title_lbl
            // 
            paths_title_lbl.AutoSize = true;
            paths_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            paths_title_lbl.Location = new Point(32, 18);
            paths_title_lbl.Name = "paths_title_lbl";
            paths_title_lbl.Size = new Size(98, 28);
            paths_title_lbl.TabIndex = 1;
            paths_title_lbl.Text = "File Paths";
            // 
            // paths_icon
            // 
            paths_icon.BackColor = SystemColors.Control;
            paths_icon.ForeColor = SystemColors.ControlText;
            paths_icon.IconChar = IconChar.FolderOpen;
            paths_icon.IconColor = SystemColors.ControlText;
            paths_icon.IconFont = IconFont.Auto;
            paths_icon.IconSize = 29;
            paths_icon.Location = new Point(0, 17);
            paths_icon.Name = "paths_icon";
            paths_icon.Size = new Size(29, 37);
            paths_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            paths_icon.TabIndex = 0;
            paths_icon.TabStop = false;
            paths_icon.Tag = "accent-icon";
            // 
            // logging_pnl
            // 
            logging_pnl.Controls.Add(logging_body);
            logging_pnl.Dock = DockStyle.Fill;
            logging_pnl.Location = new Point(605, 300);
            logging_pnl.Margin = new Padding(10, 0, 0, 16);
            logging_pnl.Name = "logging_pnl";
            logging_pnl.Size = new Size(585, 344);
            logging_pnl.TabIndex = 3;
            logging_pnl.Tag = "base";
            // 
            // logging_body
            // 
            logging_body.Controls.Add(tableLayoutPanel5);
            logging_body.Controls.Add(logging_divider);
            logging_body.Controls.Add(logging_header);
            logging_body.Dock = DockStyle.Fill;
            logging_body.Location = new Point(0, 0);
            logging_body.Name = "logging_body";
            logging_body.Padding = new Padding(22, 0, 22, 18);
            logging_body.Size = new Size(585, 344);
            logging_body.TabIndex = 0;
            logging_body.Tag = "main_card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(enable_logging_chk, 1, 0);
            tableLayoutPanel5.Controls.Add(ai_logs_lbl, 0, 1);
            tableLayoutPanel5.Controls.Add(ai_logs_ck, 1, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Controls.Add(max_size_numeric, 1, 2);
            tableLayoutPanel5.Controls.Add(log_level_cb, 1, 3);
            tableLayoutPanel5.Controls.Add(label8, 0, 3);
            tableLayoutPanel5.Controls.Add(open_log_btn, 0, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(22, 57);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(0, 14, 0, 0);
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(541, 269);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(3, 24);
            label6.Name = "label6";
            label6.Size = new Size(194, 23);
            label6.TabIndex = 0;
            label6.Tag = "muted";
            label6.Text = "Enable Logging";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_logging_chk
            // 
            enable_logging_chk.Anchor = AnchorStyles.Left;
            enable_logging_chk.AutoSize = true;
            enable_logging_chk.Location = new Point(206, 27);
            enable_logging_chk.Margin = new Padding(6, 10, 0, 10);
            enable_logging_chk.Name = "enable_logging_chk";
            enable_logging_chk.Size = new Size(18, 17);
            enable_logging_chk.TabIndex = 18;
            enable_logging_chk.UseVisualStyleBackColor = true;
            // 
            // ai_logs_lbl
            // 
            ai_logs_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ai_logs_lbl.AutoSize = true;
            ai_logs_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ai_logs_lbl.Location = new Point(3, 68);
            ai_logs_lbl.Name = "ai_logs_lbl";
            ai_logs_lbl.Size = new Size(194, 23);
            ai_logs_lbl.TabIndex = 2;
            ai_logs_lbl.Tag = "muted";
            ai_logs_lbl.Text = "Detailed Logs for AI";
            ai_logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ai_logs_ck
            // 
            ai_logs_ck.Anchor = AnchorStyles.Left;
            ai_logs_ck.AutoSize = true;
            ai_logs_ck.Location = new Point(206, 71);
            ai_logs_ck.Margin = new Padding(6, 10, 0, 10);
            ai_logs_ck.Name = "ai_logs_ck";
            ai_logs_ck.Size = new Size(18, 17);
            ai_logs_ck.TabIndex = 19;
            ai_logs_ck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(194, 23);
            label5.TabIndex = 4;
            label5.Tag = "muted";
            label5.Text = "Max File Size (MB)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // max_size_numeric
            // 
            max_size_numeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            max_size_numeric.BorderStyle = BorderStyle.None;
            max_size_numeric.Font = new Font("Segoe UI", 11F);
            max_size_numeric.Location = new Point(206, 112);
            max_size_numeric.Margin = new Padding(6, 10, 0, 10);
            max_size_numeric.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            max_size_numeric.Name = "max_size_numeric";
            max_size_numeric.Size = new Size(335, 28);
            max_size_numeric.TabIndex = 5;
            max_size_numeric.Tag = "range_lock";
            // 
            // log_level_cb
            // 
            log_level_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            log_level_cb.DrawMode = DrawMode.OwnerDrawFixed;
            log_level_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            log_level_cb.FlatStyle = FlatStyle.Flat;
            log_level_cb.Font = new Font("Segoe UI", 10F);
            log_level_cb.FormattingEnabled = true;
            log_level_cb.ItemHeight = 30;
            log_level_cb.Location = new Point(206, 156);
            log_level_cb.Margin = new Padding(6, 10, 0, 10);
            log_level_cb.Name = "log_level_cb";
            log_level_cb.Size = new Size(335, 36);
            log_level_cb.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(3, 156);
            label8.Name = "label8";
            label8.Size = new Size(194, 23);
            label8.TabIndex = 6;
            label8.Tag = "muted";
            label8.Text = "Log Level";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // open_log_btn
            // 
            open_log_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.SetColumnSpan(open_log_btn, 2);
            open_log_btn.Cursor = Cursors.Hand;
            open_log_btn.FlatStyle = FlatStyle.Flat;
            open_log_btn.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            open_log_btn.IconChar = IconChar.FileUpload;
            open_log_btn.IconColor = Color.Black;
            open_log_btn.IconFont = IconFont.Auto;
            open_log_btn.IconSize = 18;
            open_log_btn.ImageAlign = ContentAlignment.MiddleLeft;
            open_log_btn.Location = new Point(0, 225);
            open_log_btn.Margin = new Padding(0, 14, 0, 0);
            open_log_btn.Name = "open_log_btn";
            open_log_btn.Padding = new Padding(14, 0, 14, 0);
            open_log_btn.Size = new Size(541, 44);
            open_log_btn.TabIndex = 22;
            open_log_btn.Tag = "outlined";
            open_log_btn.Text = "  Open Log File";
            open_log_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            open_log_btn.UseVisualStyleBackColor = false;
            // 
            // logging_divider
            // 
            logging_divider.Dock = DockStyle.Top;
            logging_divider.Location = new Point(22, 56);
            logging_divider.Name = "logging_divider";
            logging_divider.Size = new Size(541, 1);
            logging_divider.TabIndex = 4;
            logging_divider.Tag = "divider";
            // 
            // logging_header
            // 
            logging_header.Controls.Add(logging_title_lbl);
            logging_header.Controls.Add(logging_icon);
            logging_header.Dock = DockStyle.Top;
            logging_header.Location = new Point(22, 0);
            logging_header.Name = "logging_header";
            logging_header.Size = new Size(541, 56);
            logging_header.TabIndex = 5;
            logging_header.Tag = "card";
            // 
            // logging_title_lbl
            // 
            logging_title_lbl.AutoSize = true;
            logging_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            logging_title_lbl.Location = new Point(32, 18);
            logging_title_lbl.Name = "logging_title_lbl";
            logging_title_lbl.Size = new Size(159, 28);
            logging_title_lbl.TabIndex = 1;
            logging_title_lbl.Text = "Logging System";
            // 
            // logging_icon
            // 
            logging_icon.BackColor = SystemColors.Control;
            logging_icon.ForeColor = SystemColors.ControlText;
            logging_icon.IconChar = IconChar.FileText;
            logging_icon.IconColor = SystemColors.ControlText;
            logging_icon.IconFont = IconFont.Auto;
            logging_icon.IconSize = 29;
            logging_icon.Location = new Point(0, 17);
            logging_icon.Name = "logging_icon";
            logging_icon.Size = new Size(29, 37);
            logging_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            logging_icon.TabIndex = 0;
            logging_icon.TabStop = false;
            logging_icon.Tag = "accent-icon";
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(ai_body);
            ai_pnl.Dock = DockStyle.Fill;
            ai_pnl.Location = new Point(0, 660);
            ai_pnl.Margin = new Padding(0, 0, 10, 0);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Size = new Size(585, 477);
            ai_pnl.TabIndex = 4;
            ai_pnl.Tag = "base";
            // 
            // ai_body
            // 
            ai_body.Controls.Add(tableLayoutPanel3);
            ai_body.Controls.Add(ai_divider);
            ai_body.Controls.Add(ai_header);
            ai_body.Dock = DockStyle.Fill;
            ai_body.Location = new Point(0, 0);
            ai_body.Name = "ai_body";
            ai_body.Padding = new Padding(22, 0, 22, 18);
            ai_body.Size = new Size(585, 477);
            ai_body.TabIndex = 0;
            ai_body.Tag = "main_card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Controls.Add(panel10, 1, 0);
            tableLayoutPanel3.Controls.Add(api_lbl, 0, 0);
            tableLayoutPanel3.Controls.Add(view_api_btn, 2, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 1);
            tableLayoutPanel3.Controls.Add(provider_cb, 1, 1);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(panel1, 1, 2);
            tableLayoutPanel3.Controls.Add(label16, 0, 3);
            tableLayoutPanel3.Controls.Add(temperature_numeric, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(22, 57);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(0, 14, 0, 0);
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(541, 402);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(206, 24);
            panel10.Margin = new Padding(6, 10, 0, 10);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(1);
            panel10.Size = new Size(295, 34);
            panel10.TabIndex = 10;
            panel10.Tag = "border_pnl";
            // 
            // panel11
            // 
            panel11.Controls.Add(tableLayoutPanel12);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(1, 1);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(293, 32);
            panel11.TabIndex = 0;
            panel11.Tag = "card";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Controls.Add(api_tb, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(293, 32);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // api_tb
            // 
            api_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_tb.Font = new Font("Segoe UI", 11F);
            api_tb.Location = new Point(0, 0);
            api_tb.Margin = new Padding(0);
            api_tb.Name = "api_tb";
            api_tb.Size = new Size(293, 32);
            api_tb.TabIndex = 10;
            api_tb.Tag = "borderless";
            // 
            // api_lbl
            // 
            api_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_lbl.AutoSize = true;
            api_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            api_lbl.Location = new Point(3, 29);
            api_lbl.Name = "api_lbl";
            api_lbl.Size = new Size(194, 23);
            api_lbl.TabIndex = 0;
            api_lbl.Tag = "muted";
            api_lbl.Text = "API Key";
            api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // view_api_btn
            // 
            view_api_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            view_api_btn.Cursor = Cursors.Hand;
            view_api_btn.FlatAppearance.BorderSize = 0;
            view_api_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            view_api_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            view_api_btn.FlatStyle = FlatStyle.Flat;
            view_api_btn.IconChar = IconChar.EyeSlash;
            view_api_btn.IconColor = Color.Black;
            view_api_btn.IconFont = IconFont.Auto;
            view_api_btn.IconSize = 22;
            view_api_btn.Location = new Point(507, 28);
            view_api_btn.Margin = new Padding(6, 9, 0, 9);
            view_api_btn.Name = "view_api_btn";
            view_api_btn.Size = new Size(34, 26);
            view_api_btn.TabIndex = 11;
            view_api_btn.Tag = "clean_icon";
            view_api_btn.TextAlign = ContentAlignment.TopCenter;
            view_api_btn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(3, 78);
            label9.Name = "label9";
            label9.Size = new Size(194, 23);
            label9.TabIndex = 3;
            label9.Tag = "muted";
            label9.Text = "AI Provider";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // provider_cb
            // 
            provider_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            provider_cb.DrawMode = DrawMode.OwnerDrawFixed;
            provider_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            provider_cb.FlatStyle = FlatStyle.Flat;
            provider_cb.Font = new Font("Segoe UI", 10F);
            provider_cb.FormattingEnabled = true;
            provider_cb.ItemHeight = 30;
            provider_cb.Location = new Point(206, 78);
            provider_cb.Margin = new Padding(6, 10, 0, 10);
            provider_cb.Name = "provider_cb";
            provider_cb.Size = new Size(295, 36);
            provider_cb.TabIndex = 4;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(3, 122);
            label12.Name = "label12";
            label12.Size = new Size(194, 23);
            label12.TabIndex = 5;
            label12.Tag = "muted";
            label12.Text = "Agent Status";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            tableLayoutPanel3.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(api_status_lbl);
            panel1.Controls.Add(status_color_lbl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(206, 112);
            panel1.Margin = new Padding(6, 0, 0, 0);
            panel1.MaximumSize = new Size(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 44);
            panel1.TabIndex = 6;
            panel1.Tag = "card";
            // 
            // api_status_lbl
            // 
            api_status_lbl.AutoSize = true;
            api_status_lbl.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            api_status_lbl.Location = new Point(35, 0);
            api_status_lbl.Name = "api_status_lbl";
            api_status_lbl.Padding = new Padding(2, 12, 0, 0);
            api_status_lbl.Size = new Size(101, 37);
            api_status_lbl.TabIndex = 1;
            api_status_lbl.Text = "Checking...";
            api_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status_color_lbl
            // 
            status_color_lbl.AutoSize = true;
            status_color_lbl.Dock = DockStyle.Left;
            status_color_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            status_color_lbl.ForeColor = Color.Gray;
            status_color_lbl.Location = new Point(0, 0);
            status_color_lbl.Name = "status_color_lbl";
            status_color_lbl.Padding = new Padding(0, 8, 6, 0);
            status_color_lbl.Size = new Size(35, 40);
            status_color_lbl.TabIndex = 0;
            status_color_lbl.Text = "●";
            status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label16.Location = new Point(3, 166);
            label16.Name = "label16";
            label16.Size = new Size(194, 23);
            label16.TabIndex = 7;
            label16.Tag = "muted";
            label16.Text = "Temperature";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // temperature_numeric
            // 
            temperature_numeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            temperature_numeric.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(temperature_numeric, 2);
            temperature_numeric.Font = new Font("Segoe UI", 10.5F);
            temperature_numeric.Location = new Point(206, 166);
            temperature_numeric.Margin = new Padding(6, 10, 0, 10);
            temperature_numeric.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            temperature_numeric.Name = "temperature_numeric";
            temperature_numeric.Size = new Size(335, 27);
            temperature_numeric.TabIndex = 13;
            temperature_numeric.Tag = "range_lock";
            // 
            // ai_divider
            // 
            ai_divider.Dock = DockStyle.Top;
            ai_divider.Location = new Point(22, 56);
            ai_divider.Name = "ai_divider";
            ai_divider.Size = new Size(541, 1);
            ai_divider.TabIndex = 4;
            ai_divider.Tag = "divider";
            // 
            // ai_header
            // 
            ai_header.Controls.Add(ai_title_lbl);
            ai_header.Controls.Add(ai_icon);
            ai_header.Dock = DockStyle.Top;
            ai_header.Location = new Point(22, 0);
            ai_header.Name = "ai_header";
            ai_header.Size = new Size(541, 56);
            ai_header.TabIndex = 5;
            ai_header.Tag = "card";
            // 
            // ai_title_lbl
            // 
            ai_title_lbl.AutoSize = true;
            ai_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ai_title_lbl.Location = new Point(32, 18);
            ai_title_lbl.Name = "ai_title_lbl";
            ai_title_lbl.Size = new Size(111, 28);
            ai_title_lbl.TabIndex = 1;
            ai_title_lbl.Text = "AI Settings";
            // 
            // ai_icon
            // 
            ai_icon.BackColor = SystemColors.Control;
            ai_icon.ForeColor = SystemColors.ControlText;
            ai_icon.IconChar = IconChar.Robot;
            ai_icon.IconColor = SystemColors.ControlText;
            ai_icon.IconFont = IconFont.Auto;
            ai_icon.IconSize = 29;
            ai_icon.Location = new Point(0, 17);
            ai_icon.Name = "ai_icon";
            ai_icon.Size = new Size(29, 37);
            ai_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            ai_icon.TabIndex = 0;
            ai_icon.TabStop = false;
            ai_icon.Tag = "accent-icon";
            // 
            // factors_pnl
            // 
            factors_pnl.Controls.Add(factors_body);
            factors_pnl.Dock = DockStyle.Fill;
            factors_pnl.Location = new Point(605, 660);
            factors_pnl.Margin = new Padding(10, 0, 0, 0);
            factors_pnl.Name = "factors_pnl";
            factors_pnl.Size = new Size(585, 477);
            factors_pnl.TabIndex = 5;
            factors_pnl.Tag = "base";
            // 
            // factors_body
            // 
            factors_body.Controls.Add(tableLayoutPanel7);
            factors_body.Controls.Add(factors_divider);
            factors_body.Controls.Add(factors_header);
            factors_body.Dock = DockStyle.Fill;
            factors_body.Location = new Point(0, 0);
            factors_body.Name = "factors_body";
            factors_body.Padding = new Padding(22, 0, 22, 18);
            factors_body.Size = new Size(585, 477);
            factors_body.TabIndex = 0;
            factors_body.Tag = "main_card";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label15, 0, 0);
            tableLayoutPanel7.Controls.Add(enable_daily_fetching, 1, 0);
            tableLayoutPanel7.Controls.Add(label14, 0, 1);
            tableLayoutPanel7.Controls.Add(fetching_time, 1, 1);
            tableLayoutPanel7.Controls.Add(label11, 0, 2);
            tableLayoutPanel7.Controls.Add(next_fetch_lbl, 1, 2);
            tableLayoutPanel7.Controls.Add(commodity_api_lbl, 0, 3);
            tableLayoutPanel7.Controls.Add(commodity_status_pnl, 1, 3);
            tableLayoutPanel7.Controls.Add(economic_api_lbl, 0, 4);
            tableLayoutPanel7.Controls.Add(economic_status_pnl, 1, 4);
            tableLayoutPanel7.Controls.Add(events_api_lbl, 0, 5);
            tableLayoutPanel7.Controls.Add(events_status_pnl, 1, 5);
            tableLayoutPanel7.Controls.Add(weather_api_lbl, 0, 6);
            tableLayoutPanel7.Controls.Add(weather_status_pnl, 1, 6);
            tableLayoutPanel7.Controls.Add(manual_fetch_btn, 0, 7);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(22, 57);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(0, 14, 0, 0);
            tableLayoutPanel7.RowCount = 8;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(541, 402);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label15.Location = new Point(3, 24);
            label15.Name = "label15";
            label15.Size = new Size(194, 23);
            label15.TabIndex = 0;
            label15.Tag = "muted";
            label15.Text = "Enable Daily Fetching";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enable_daily_fetching
            // 
            enable_daily_fetching.Anchor = AnchorStyles.Left;
            enable_daily_fetching.AutoSize = true;
            enable_daily_fetching.Location = new Point(206, 27);
            enable_daily_fetching.Margin = new Padding(6, 10, 0, 10);
            enable_daily_fetching.Name = "enable_daily_fetching";
            enable_daily_fetching.Size = new Size(18, 17);
            enable_daily_fetching.TabIndex = 23;
            enable_daily_fetching.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label14.Location = new Point(3, 68);
            label14.Name = "label14";
            label14.Size = new Size(194, 23);
            label14.TabIndex = 2;
            label14.Tag = "muted";
            label14.Text = "Schedule Time";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fetching_time
            // 
            fetching_time.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fetching_time.CustomFormat = "dd MMM yyyy";
            fetching_time.Font = new Font("Segoe UI", 10.5F);
            fetching_time.Format = DateTimePickerFormat.Custom;
            fetching_time.Location = new Point(206, 67);
            fetching_time.Margin = new Padding(6, 9, 0, 9);
            fetching_time.Name = "fetching_time";
            fetching_time.Size = new Size(335, 31);
            fetching_time.TabIndex = 24;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(3, 112);
            label11.Name = "label11";
            label11.Size = new Size(194, 23);
            label11.TabIndex = 4;
            label11.Tag = "muted";
            label11.Text = "Next Fetch Scheduled";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // next_fetch_lbl
            // 
            next_fetch_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            next_fetch_lbl.AutoSize = true;
            next_fetch_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            next_fetch_lbl.Location = new Point(206, 112);
            next_fetch_lbl.Margin = new Padding(6, 0, 0, 0);
            next_fetch_lbl.Name = "next_fetch_lbl";
            next_fetch_lbl.Size = new Size(335, 23);
            next_fetch_lbl.TabIndex = 5;
            next_fetch_lbl.Tag = "accent";
            next_fetch_lbl.Text = "—";
            next_fetch_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // commodity_api_lbl
            // 
            commodity_api_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            commodity_api_lbl.AutoSize = true;
            commodity_api_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            commodity_api_lbl.Location = new Point(3, 156);
            commodity_api_lbl.Name = "commodity_api_lbl";
            commodity_api_lbl.Size = new Size(194, 23);
            commodity_api_lbl.TabIndex = 8;
            commodity_api_lbl.Tag = "muted";
            commodity_api_lbl.Text = "Commodity Prices API";
            commodity_api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // commodity_status_pnl
            // 
            commodity_status_pnl.Controls.Add(commodity_status_lbl);
            commodity_status_pnl.Controls.Add(commodity_status_color_lbl);
            commodity_status_pnl.Dock = DockStyle.Fill;
            commodity_status_pnl.Location = new Point(206, 146);
            commodity_status_pnl.Margin = new Padding(6, 0, 0, 0);
            commodity_status_pnl.MaximumSize = new Size(0, 44);
            commodity_status_pnl.Name = "commodity_status_pnl";
            commodity_status_pnl.Size = new Size(335, 44);
            commodity_status_pnl.TabIndex = 9;
            commodity_status_pnl.Tag = "card";
            // 
            // commodity_status_lbl
            // 
            commodity_status_lbl.AutoSize = true;
            commodity_status_lbl.Dock = DockStyle.Left;
            commodity_status_lbl.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            commodity_status_lbl.Location = new Point(35, 0);
            commodity_status_lbl.Name = "commodity_status_lbl";
            commodity_status_lbl.Padding = new Padding(2, 12, 0, 0);
            commodity_status_lbl.Size = new Size(101, 37);
            commodity_status_lbl.TabIndex = 1;
            commodity_status_lbl.Text = "Checking...";
            commodity_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // commodity_status_color_lbl
            // 
            commodity_status_color_lbl.AutoSize = true;
            commodity_status_color_lbl.Dock = DockStyle.Left;
            commodity_status_color_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            commodity_status_color_lbl.ForeColor = Color.Gray;
            commodity_status_color_lbl.Location = new Point(0, 0);
            commodity_status_color_lbl.Name = "commodity_status_color_lbl";
            commodity_status_color_lbl.Padding = new Padding(0, 8, 6, 0);
            commodity_status_color_lbl.Size = new Size(35, 40);
            commodity_status_color_lbl.TabIndex = 0;
            commodity_status_color_lbl.Text = "●";
            commodity_status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // economic_api_lbl
            // 
            economic_api_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            economic_api_lbl.AutoSize = true;
            economic_api_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            economic_api_lbl.Location = new Point(3, 200);
            economic_api_lbl.Name = "economic_api_lbl";
            economic_api_lbl.Size = new Size(194, 23);
            economic_api_lbl.TabIndex = 10;
            economic_api_lbl.Tag = "muted";
            economic_api_lbl.Text = "Economic Data API";
            economic_api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // economic_status_pnl
            // 
            economic_status_pnl.Controls.Add(economic_status_lbl);
            economic_status_pnl.Controls.Add(economic_status_color_lbl);
            economic_status_pnl.Dock = DockStyle.Fill;
            economic_status_pnl.Location = new Point(206, 190);
            economic_status_pnl.Margin = new Padding(6, 0, 0, 0);
            economic_status_pnl.MaximumSize = new Size(0, 44);
            economic_status_pnl.Name = "economic_status_pnl";
            economic_status_pnl.Size = new Size(335, 44);
            economic_status_pnl.TabIndex = 11;
            economic_status_pnl.Tag = "card";
            // 
            // economic_status_lbl
            // 
            economic_status_lbl.AutoSize = true;
            economic_status_lbl.Dock = DockStyle.Left;
            economic_status_lbl.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            economic_status_lbl.Location = new Point(35, 0);
            economic_status_lbl.Name = "economic_status_lbl";
            economic_status_lbl.Padding = new Padding(2, 12, 0, 0);
            economic_status_lbl.Size = new Size(101, 37);
            economic_status_lbl.TabIndex = 1;
            economic_status_lbl.Text = "Checking...";
            economic_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // economic_status_color_lbl
            // 
            economic_status_color_lbl.AutoSize = true;
            economic_status_color_lbl.Dock = DockStyle.Left;
            economic_status_color_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            economic_status_color_lbl.ForeColor = Color.Gray;
            economic_status_color_lbl.Location = new Point(0, 0);
            economic_status_color_lbl.Name = "economic_status_color_lbl";
            economic_status_color_lbl.Padding = new Padding(0, 8, 6, 0);
            economic_status_color_lbl.Size = new Size(35, 40);
            economic_status_color_lbl.TabIndex = 0;
            economic_status_color_lbl.Text = "●";
            economic_status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // events_api_lbl
            // 
            events_api_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            events_api_lbl.AutoSize = true;
            events_api_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            events_api_lbl.Location = new Point(3, 244);
            events_api_lbl.Name = "events_api_lbl";
            events_api_lbl.Size = new Size(194, 23);
            events_api_lbl.TabIndex = 12;
            events_api_lbl.Tag = "muted";
            events_api_lbl.Text = "Events & Holidays API";
            events_api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // events_status_pnl
            // 
            events_status_pnl.Controls.Add(events_status_lbl);
            events_status_pnl.Controls.Add(events_status_color_lbl);
            events_status_pnl.Dock = DockStyle.Fill;
            events_status_pnl.Location = new Point(206, 234);
            events_status_pnl.Margin = new Padding(6, 0, 0, 0);
            events_status_pnl.MaximumSize = new Size(0, 44);
            events_status_pnl.Name = "events_status_pnl";
            events_status_pnl.Size = new Size(335, 44);
            events_status_pnl.TabIndex = 13;
            events_status_pnl.Tag = "card";
            // 
            // events_status_lbl
            // 
            events_status_lbl.AutoSize = true;
            events_status_lbl.Dock = DockStyle.Left;
            events_status_lbl.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            events_status_lbl.Location = new Point(35, 0);
            events_status_lbl.Name = "events_status_lbl";
            events_status_lbl.Padding = new Padding(2, 12, 0, 0);
            events_status_lbl.Size = new Size(101, 37);
            events_status_lbl.TabIndex = 1;
            events_status_lbl.Text = "Checking...";
            events_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // events_status_color_lbl
            // 
            events_status_color_lbl.AutoSize = true;
            events_status_color_lbl.Dock = DockStyle.Left;
            events_status_color_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            events_status_color_lbl.ForeColor = Color.Gray;
            events_status_color_lbl.Location = new Point(0, 0);
            events_status_color_lbl.Name = "events_status_color_lbl";
            events_status_color_lbl.Padding = new Padding(0, 8, 6, 0);
            events_status_color_lbl.Size = new Size(35, 40);
            events_status_color_lbl.TabIndex = 0;
            events_status_color_lbl.Text = "●";
            events_status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weather_api_lbl
            // 
            weather_api_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            weather_api_lbl.AutoSize = true;
            weather_api_lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            weather_api_lbl.Location = new Point(3, 288);
            weather_api_lbl.Name = "weather_api_lbl";
            weather_api_lbl.Size = new Size(194, 23);
            weather_api_lbl.TabIndex = 14;
            weather_api_lbl.Tag = "muted";
            weather_api_lbl.Text = "Weather API";
            weather_api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weather_status_pnl
            // 
            weather_status_pnl.Controls.Add(weather_status_lbl);
            weather_status_pnl.Controls.Add(weather_status_color_lbl);
            weather_status_pnl.Dock = DockStyle.Fill;
            weather_status_pnl.Location = new Point(206, 278);
            weather_status_pnl.Margin = new Padding(6, 0, 0, 0);
            weather_status_pnl.MaximumSize = new Size(0, 44);
            weather_status_pnl.Name = "weather_status_pnl";
            weather_status_pnl.Size = new Size(335, 44);
            weather_status_pnl.TabIndex = 15;
            weather_status_pnl.Tag = "card";
            // 
            // weather_status_lbl
            // 
            weather_status_lbl.AutoSize = true;
            weather_status_lbl.Dock = DockStyle.Left;
            weather_status_lbl.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            weather_status_lbl.Location = new Point(35, 0);
            weather_status_lbl.Name = "weather_status_lbl";
            weather_status_lbl.Padding = new Padding(2, 12, 0, 0);
            weather_status_lbl.Size = new Size(101, 37);
            weather_status_lbl.TabIndex = 1;
            weather_status_lbl.Text = "Checking...";
            weather_status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weather_status_color_lbl
            // 
            weather_status_color_lbl.AutoSize = true;
            weather_status_color_lbl.Dock = DockStyle.Left;
            weather_status_color_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            weather_status_color_lbl.ForeColor = Color.Gray;
            weather_status_color_lbl.Location = new Point(0, 0);
            weather_status_color_lbl.Name = "weather_status_color_lbl";
            weather_status_color_lbl.Padding = new Padding(0, 8, 6, 0);
            weather_status_color_lbl.Size = new Size(35, 40);
            weather_status_color_lbl.TabIndex = 0;
            weather_status_color_lbl.Text = "●";
            weather_status_color_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // manual_fetch_btn
            // 
            manual_fetch_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.SetColumnSpan(manual_fetch_btn, 2);
            manual_fetch_btn.Cursor = Cursors.Hand;
            manual_fetch_btn.FlatStyle = FlatStyle.Flat;
            manual_fetch_btn.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            manual_fetch_btn.IconChar = IconChar.CloudDownloadAlt;
            manual_fetch_btn.IconColor = Color.Black;
            manual_fetch_btn.IconFont = IconFont.Auto;
            manual_fetch_btn.IconSize = 25;
            manual_fetch_btn.ImageAlign = ContentAlignment.MiddleLeft;
            manual_fetch_btn.Location = new Point(0, 358);
            manual_fetch_btn.Margin = new Padding(0, 14, 0, 0);
            manual_fetch_btn.Name = "manual_fetch_btn";
            manual_fetch_btn.Padding = new Padding(14, 0, 14, 0);
            manual_fetch_btn.Size = new Size(541, 44);
            manual_fetch_btn.TabIndex = 25;
            manual_fetch_btn.Tag = "outlined";
            manual_fetch_btn.Text = "  Fetch Now";
            manual_fetch_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manual_fetch_btn.UseVisualStyleBackColor = false;
            // 
            // factors_divider
            // 
            factors_divider.Dock = DockStyle.Top;
            factors_divider.Location = new Point(22, 56);
            factors_divider.Name = "factors_divider";
            factors_divider.Size = new Size(541, 1);
            factors_divider.TabIndex = 4;
            factors_divider.Tag = "divider";
            // 
            // factors_header
            // 
            factors_header.Controls.Add(factors_title_lbl);
            factors_header.Controls.Add(factors_icon);
            factors_header.Dock = DockStyle.Top;
            factors_header.Location = new Point(22, 0);
            factors_header.Name = "factors_header";
            factors_header.Size = new Size(541, 56);
            factors_header.TabIndex = 5;
            factors_header.Tag = "card";
            // 
            // factors_title_lbl
            // 
            factors_title_lbl.AutoSize = true;
            factors_title_lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            factors_title_lbl.Location = new Point(32, 18);
            factors_title_lbl.Name = "factors_title_lbl";
            factors_title_lbl.Size = new Size(237, 28);
            factors_title_lbl.TabIndex = 1;
            factors_title_lbl.Text = "External Factors Fetching";
            // 
            // factors_icon
            // 
            factors_icon.BackColor = SystemColors.Control;
            factors_icon.ForeColor = SystemColors.ControlText;
            factors_icon.IconChar = IconChar.Thunderstorm;
            factors_icon.IconColor = SystemColors.ControlText;
            factors_icon.IconFont = IconFont.Auto;
            factors_icon.IconSize = 29;
            factors_icon.Location = new Point(0, 17);
            factors_icon.Name = "factors_icon";
            factors_icon.Size = new Size(29, 37);
            factors_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            factors_icon.TabIndex = 0;
            factors_icon.TabStop = false;
            factors_icon.Tag = "accent-icon";
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(hero_subtitle_lbl);
            hero_pnl.Controls.Add(hero_title_lbl);
            hero_pnl.Controls.Add(hero_icon);
            hero_pnl.Dock = DockStyle.Top;
            hero_pnl.Location = new Point(0, 0);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(4, 8, 0, 0);
            hero_pnl.Size = new Size(1190, 90);
            hero_pnl.TabIndex = 2;
            hero_pnl.Tag = "base";
            // 
            // hero_subtitle_lbl
            // 
            hero_subtitle_lbl.AutoSize = true;
            hero_subtitle_lbl.Font = new Font("Segoe UI", 10F);
            hero_subtitle_lbl.Location = new Point(58, 52);
            hero_subtitle_lbl.Name = "hero_subtitle_lbl";
            hero_subtitle_lbl.Size = new Size(506, 23);
            hero_subtitle_lbl.TabIndex = 2;
            hero_subtitle_lbl.Tag = "muted";
            hero_subtitle_lbl.Text = "Manage preferences, paths, logging, AI providers and schedulers.";
            // 
            // hero_title_lbl
            // 
            hero_title_lbl.AutoSize = true;
            hero_title_lbl.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            hero_title_lbl.Location = new Point(56, 8);
            hero_title_lbl.Name = "hero_title_lbl";
            hero_title_lbl.Size = new Size(145, 46);
            hero_title_lbl.TabIndex = 1;
            hero_title_lbl.Text = "Settings";
            // 
            // hero_icon
            // 
            hero_icon.BackColor = SystemColors.Control;
            hero_icon.ForeColor = SystemColors.ControlText;
            hero_icon.IconChar = IconChar.Gears;
            hero_icon.IconColor = SystemColors.ControlText;
            hero_icon.IconFont = IconFont.Auto;
            hero_icon.IconSize = 40;
            hero_icon.Location = new Point(4, 14);
            hero_icon.Name = "hero_icon";
            hero_icon.Size = new Size(40, 40);
            hero_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            hero_icon.TabIndex = 0;
            hero_icon.TabStop = false;
            hero_icon.Tag = "accent-icon";
            // 
            // apply_pnl
            // 
            apply_pnl.Controls.Add(apply_btn);
            apply_pnl.Dock = DockStyle.Bottom;
            apply_pnl.Location = new Point(0, 967);
            apply_pnl.Name = "apply_pnl";
            apply_pnl.Padding = new Padding(28, 16, 28, 20);
            apply_pnl.Size = new Size(1267, 88);
            apply_pnl.TabIndex = 1;
            apply_pnl.Tag = "base";
            // 
            // apply_btn
            // 
            apply_btn.Cursor = Cursors.Hand;
            apply_btn.Dock = DockStyle.Fill;
            apply_btn.FlatAppearance.BorderSize = 0;
            apply_btn.FlatStyle = FlatStyle.Flat;
            apply_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            apply_btn.IconChar = IconChar.Check;
            apply_btn.IconColor = Color.Black;
            apply_btn.IconFont = IconFont.Auto;
            apply_btn.IconSize = 30;
            apply_btn.Location = new Point(28, 16);
            apply_btn.Name = "apply_btn";
            apply_btn.Padding = new Padding(24, 0, 24, 0);
            apply_btn.Size = new Size(1211, 52);
            apply_btn.TabIndex = 0;
            apply_btn.Tag = "cta";
            apply_btn.Text = "  Apply Changes";
            apply_btn.TextAlign = ContentAlignment.MiddleRight;
            apply_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 1055);
            Controls.Add(base_pnl);
            Controls.Add(apply_pnl);
            Name = "SettingsForm";
            Tag = "workplace";
            Text = "Settings";
            base_pnl.ResumeLayout(false);
            content_host.ResumeLayout(false);
            settings_table.ResumeLayout(false);
            preferences_pnl.ResumeLayout(false);
            preferences_body.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            preferences_header.ResumeLayout(false);
            preferences_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)preferences_icon).EndInit();
            reporting_pnl.ResumeLayout(false);
            reporting_body.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            report_row_pnl.ResumeLayout(false);
            reporting_header.ResumeLayout(false);
            reporting_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reporting_icon).EndInit();
            paths_pnl.ResumeLayout(false);
            paths_body.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            paths_header.ResumeLayout(false);
            paths_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paths_icon).EndInit();
            logging_pnl.ResumeLayout(false);
            logging_body.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max_size_numeric).EndInit();
            logging_header.ResumeLayout(false);
            logging_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logging_icon).EndInit();
            ai_pnl.ResumeLayout(false);
            ai_body.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)temperature_numeric).EndInit();
            ai_header.ResumeLayout(false);
            ai_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ai_icon).EndInit();
            factors_pnl.ResumeLayout(false);
            factors_body.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            commodity_status_pnl.ResumeLayout(false);
            commodity_status_pnl.PerformLayout();
            economic_status_pnl.ResumeLayout(false);
            economic_status_pnl.PerformLayout();
            events_status_pnl.ResumeLayout(false);
            events_status_pnl.PerformLayout();
            weather_status_pnl.ResumeLayout(false);
            weather_status_pnl.PerformLayout();
            factors_header.ResumeLayout(false);
            factors_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)factors_icon).EndInit();
            hero_pnl.ResumeLayout(false);
            hero_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hero_icon).EndInit();
            apply_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Root
        private Panel base_pnl;
        private Panel content_host;
        private Panel hero_pnl;
        private IconPictureBox hero_icon;
        private Label hero_title_lbl;
        private Label hero_subtitle_lbl;
        private TableLayoutPanel settings_table;

        // Preferences
        private Panel preferences_pnl;
        private Panel preferences_body;
        private Panel preferences_header;
        private IconPictureBox preferences_icon;
        private Label preferences_title_lbl;
        private Panel preferences_divider;
        private TableLayoutPanel tableLayoutPanel1;
        private Label theme_lbl;
        private ThemedComboBox themes_cb;
        private Label language_lbl;
        private ThemedComboBox languages_cb;
        private Label label4;

        // Reporting
        private Panel reporting_pnl;
        private Panel reporting_body;
        private Panel reporting_header;
        private IconPictureBox reporting_icon;
        private Label reporting_title_lbl;
        private Panel reporting_divider;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private CheckBox enable_reports_chk;
        private Label label1;
        private ThemedDateTimePicker time_picker;
        private Label label3;
        private TextBox email_recipient_tb;
        private Label label7;
        private Label next_report_date_time_lbl;
        private IconButton sent_test_btn;
        private Panel report_row_pnl;

        // Paths
        private Panel paths_pnl;
        private Panel paths_body;
        private Panel paths_header;
        private IconPictureBox paths_icon;
        private Label paths_title_lbl;
        private Panel paths_divider;
        private TableLayoutPanel tableLayoutPanel2;
        private Label settings_lbl;
        private TextBox settings_tb;
        private IconButton browse_settings_btn;
        private Label db_lbl;
        private TextBox db_tb;
        private IconButton browse_db_btn;
        private Label logs_lbl;
        private TextBox logs_tb;
        private IconButton browse_logs_btn;

        // Logging
        private Panel logging_pnl;
        private Panel logging_body;
        private Panel logging_header;
        private IconPictureBox logging_icon;
        private Label logging_title_lbl;
        private Panel logging_divider;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private CheckBox enable_logging_chk;
        private Label ai_logs_lbl;
        private CheckBox ai_logs_ck;
        private Label label5;
        private ThemedNumericUpDown max_size_numeric;
        private Label label8;
        private SmartStock.Classes.Utils.ThemedComboBox log_level_cb;
        private IconButton open_log_btn;

        // AI
        private Panel ai_pnl;
        private Panel ai_body;
        private Panel ai_header;
        private IconPictureBox ai_icon;
        private Label ai_title_lbl;
        private Panel ai_divider;
        private TableLayoutPanel tableLayoutPanel3;
        private Label api_lbl;
        private TextBox api_tb;
        private IconButton view_api_btn;
        private Label label9;
        private SmartStock.Classes.Utils.ThemedComboBox provider_cb;
        private Label label12;
        private Panel panel1;
        private Label status_color_lbl;
        private Label api_status_lbl;
        private Label label16;
        private ThemedNumericUpDown temperature_numeric;

        // Factors
        private Panel factors_pnl;
        private Panel factors_body;
        private Panel factors_header;
        private IconPictureBox factors_icon;
        private Label factors_title_lbl;
        private Panel factors_divider;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label15;
        private CheckBox enable_daily_fetching;
        private Label label14;
        private ThemedDateTimePicker fetching_time;
        private Label label11;
        private Label next_fetch_lbl;
        private IconButton manual_fetch_btn;
        private Label commodity_api_lbl;
        private Panel commodity_status_pnl;
        private Label commodity_status_color_lbl;
        private Label commodity_status_lbl;
        private Label economic_api_lbl;
        private Panel economic_status_pnl;
        private Label economic_status_color_lbl;
        private Label economic_status_lbl;
        private Label events_api_lbl;
        private Panel events_status_pnl;
        private Label events_status_color_lbl;
        private Label events_status_lbl;
        private Label weather_api_lbl;
        private Panel weather_status_pnl;
        private Label weather_status_color_lbl;
        private Label weather_status_lbl;

        // Apply footer
        private Panel apply_pnl;
        private IconButton apply_btn;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel panel8;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel11;
        private Panel panel6;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel10;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel10;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel panel12;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel13;
        private TextBox currency_symbol_tb;
    }
}
