using FontAwesome.Sharp;

namespace SmartStock.Forms
{
    partial class AnalyzeForm
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
            root_shell = new TableLayoutPanel();
            hero_pnl = new Panel();
            selector_inner = new TableLayoutPanel();
            selector_header_pnl = new Panel();
            selector_subtitle_lbl = new Label();
            selector_title_lbl = new Label();
            selector_icon = new IconPictureBox();
            selector_divider = new Panel();
            selector_fields_pnl = new TableLayoutPanel();
            analisys_lbl = new Label();
            analysis_type_cb = new ComboBox();
            label1 = new Label();
            target_subject_cb = new ComboBox();
            label2 = new Label();
            start_date_dtp = new DateTimePicker();
            end_date_lbl = new Label();
            end_date_dtp = new DateTimePicker();
            content_tbl = new TableLayoutPanel();
            params_card = new Panel();
            dynamic_params_pnl = new Panel();
            actions_pnl = new Panel();
            run_btn = new IconButton();
            reset_btn = new IconButton();
            params_divider = new Panel();
            params_header_pnl = new Panel();
            params_title_lbl = new Label();
            params_icon = new IconPictureBox();
            results_card = new Panel();
            groupBox1 = new Panel();
            results_content_tbl = new TableLayoutPanel();
            graph_pnl = new Panel();
            panel1 = new Panel();
            chart_pnl = new Panel();
            quick_stats_pnl = new FlowLayoutPanel();
            reliability_pnl = new Panel();
            reliability_table = new TableLayoutPanel();
            label5 = new Label();
            reliability_lbl = new Label();
            trend_pnl = new Panel();
            sales_rend_table = new TableLayoutPanel();
            label4 = new Label();
            trend_lbl = new Label();
            confidence_pnl = new Panel();
            confidence_table = new TableLayoutPanel();
            label6 = new Label();
            confidence_lbl = new Label();
            ai_pnl = new Panel();
            ai_insights_rtb = new RichTextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            status_lbl = new Label();
            progressBar1 = new ProgressBar();
            results_divider = new Panel();
            results_header_pnl = new Panel();
            results_title_lbl = new Label();
            results_icon = new IconPictureBox();
            query_results_gb = new Panel();
            query_dgv = new DataGridView();
            root_shell.SuspendLayout();
            hero_pnl.SuspendLayout();
            selector_inner.SuspendLayout();
            selector_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).BeginInit();
            selector_fields_pnl.SuspendLayout();
            content_tbl.SuspendLayout();
            params_card.SuspendLayout();
            actions_pnl.SuspendLayout();
            params_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)params_icon).BeginInit();
            results_card.SuspendLayout();
            groupBox1.SuspendLayout();
            results_content_tbl.SuspendLayout();
            graph_pnl.SuspendLayout();
            quick_stats_pnl.SuspendLayout();
            reliability_pnl.SuspendLayout();
            reliability_table.SuspendLayout();
            trend_pnl.SuspendLayout();
            sales_rend_table.SuspendLayout();
            confidence_pnl.SuspendLayout();
            confidence_table.SuspendLayout();
            ai_pnl.SuspendLayout();
            panel3.SuspendLayout();
            results_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)results_icon).BeginInit();
            query_results_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)query_dgv).BeginInit();
            SuspendLayout();
            // 
            // root_shell
            // 
            root_shell.ColumnCount = 1;
            root_shell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            root_shell.Controls.Add(hero_pnl, 0, 0);
            root_shell.Controls.Add(content_tbl, 0, 1);
            root_shell.Dock = DockStyle.Fill;
            root_shell.Location = new Point(30, 30);
            root_shell.Name = "root_shell";
            root_shell.RowCount = 2;
            root_shell.RowStyles.Add(new RowStyle());
            root_shell.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_shell.Size = new Size(1148, 690);
            root_shell.TabIndex = 0;
            root_shell.Tag = "base";
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(selector_inner);
            hero_pnl.Dock = DockStyle.Fill;
            hero_pnl.Location = new Point(0, 0);
            hero_pnl.Margin = new Padding(0, 0, 0, 16);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(24, 20, 24, 22);
            hero_pnl.Size = new Size(1148, 192);
            hero_pnl.TabIndex = 0;
            hero_pnl.Tag = "main_card";
            // 
            // selector_inner
            // 
            selector_inner.ColumnCount = 1;
            selector_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selector_inner.Controls.Add(selector_header_pnl, 0, 0);
            selector_inner.Controls.Add(selector_divider, 0, 1);
            selector_inner.Controls.Add(selector_fields_pnl, 0, 2);
            selector_inner.Dock = DockStyle.Fill;
            selector_inner.Location = new Point(24, 20);
            selector_inner.Name = "selector_inner";
            selector_inner.RowCount = 3;
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.Size = new Size(1100, 150);
            selector_inner.TabIndex = 0;
            // 
            // selector_header_pnl
            // 
            selector_header_pnl.Controls.Add(selector_subtitle_lbl);
            selector_header_pnl.Controls.Add(selector_title_lbl);
            selector_header_pnl.Controls.Add(selector_icon);
            selector_header_pnl.Dock = DockStyle.Fill;
            selector_header_pnl.Location = new Point(0, 0);
            selector_header_pnl.Margin = new Padding(0, 0, 0, 10);
            selector_header_pnl.Name = "selector_header_pnl";
            selector_header_pnl.Size = new Size(1100, 57);
            selector_header_pnl.TabIndex = 0;
            selector_header_pnl.Tag = "card";
            // 
            // selector_subtitle_lbl
            // 
            selector_subtitle_lbl.AutoSize = true;
            selector_subtitle_lbl.Font = new Font("Segoe UI", 9.5F);
            selector_subtitle_lbl.Location = new Point(48, 33);
            selector_subtitle_lbl.Name = "selector_subtitle_lbl";
            selector_subtitle_lbl.Size = new Size(587, 21);
            selector_subtitle_lbl.TabIndex = 2;
            selector_subtitle_lbl.Tag = "muted";
            selector_subtitle_lbl.Text = "Run AI-powered forecasts, correlations, anomaly detection, and stock optimizations.";
            // 
            // selector_title_lbl
            // 
            selector_title_lbl.AutoSize = true;
            selector_title_lbl.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            selector_title_lbl.Location = new Point(46, -5);
            selector_title_lbl.Name = "selector_title_lbl";
            selector_title_lbl.Size = new Size(117, 37);
            selector_title_lbl.TabIndex = 1;
            selector_title_lbl.Text = "Analysis";
            // 
            // selector_icon
            // 
            selector_icon.BackColor = SystemColors.Control;
            selector_icon.ForeColor = Color.FromArgb(245, 181, 71);
            selector_icon.IconChar = IconChar.ChartLine;
            selector_icon.IconColor = Color.FromArgb(245, 181, 71);
            selector_icon.IconFont = IconFont.Auto;
            selector_icon.IconSize = 34;
            selector_icon.Location = new Point(0, 0);
            selector_icon.Name = "selector_icon";
            selector_icon.Size = new Size(34, 34);
            selector_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            selector_icon.TabIndex = 0;
            selector_icon.TabStop = false;
            selector_icon.Tag = "accent-icon";
            // 
            // selector_divider
            // 
            selector_divider.Dock = DockStyle.Fill;
            selector_divider.Location = new Point(0, 67);
            selector_divider.Margin = new Padding(0, 0, 0, 12);
            selector_divider.Name = "selector_divider";
            selector_divider.Size = new Size(1100, 1);
            selector_divider.TabIndex = 1;
            selector_divider.Tag = "divider";
            // 
            // selector_fields_pnl
            // 
            selector_fields_pnl.ColumnCount = 4;
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            selector_fields_pnl.Controls.Add(analisys_lbl, 0, 0);
            selector_fields_pnl.Controls.Add(analysis_type_cb, 0, 1);
            selector_fields_pnl.Controls.Add(label1, 1, 0);
            selector_fields_pnl.Controls.Add(target_subject_cb, 1, 1);
            selector_fields_pnl.Controls.Add(label2, 2, 0);
            selector_fields_pnl.Controls.Add(start_date_dtp, 2, 1);
            selector_fields_pnl.Controls.Add(end_date_lbl, 3, 0);
            selector_fields_pnl.Controls.Add(end_date_dtp, 3, 1);
            selector_fields_pnl.Dock = DockStyle.Fill;
            selector_fields_pnl.Location = new Point(3, 83);
            selector_fields_pnl.Name = "selector_fields_pnl";
            selector_fields_pnl.RowCount = 2;
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            selector_fields_pnl.Size = new Size(1094, 64);
            selector_fields_pnl.TabIndex = 2;
            selector_fields_pnl.Tag = "card";
            // 
            // analisys_lbl
            // 
            analisys_lbl.AutoSize = true;
            analisys_lbl.Dock = DockStyle.Bottom;
            analisys_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            analisys_lbl.Location = new Point(3, 2);
            analisys_lbl.Margin = new Padding(3, 0, 3, 6);
            analisys_lbl.Name = "analisys_lbl";
            analisys_lbl.Size = new Size(267, 20);
            analisys_lbl.TabIndex = 0;
            analisys_lbl.Tag = "muted";
            analisys_lbl.Text = "ANALYSIS TYPE";
            // 
            // analysis_type_cb
            // 
            analysis_type_cb.Dock = DockStyle.Fill;
            analysis_type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            analysis_type_cb.FlatStyle = FlatStyle.Flat;
            analysis_type_cb.Font = new Font("Segoe UI", 11F);
            analysis_type_cb.FormattingEnabled = true;
            analysis_type_cb.Location = new Point(0, 28);
            analysis_type_cb.Margin = new Padding(0, 0, 8, 0);
            analysis_type_cb.Name = "analysis_type_cb";
            analysis_type_cb.Size = new Size(265, 33);
            analysis_type_cb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(276, 2);
            label1.Margin = new Padding(3, 0, 3, 6);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 0;
            label1.Tag = "muted";
            label1.Text = "TARGET SUBJECT";
            // 
            // target_subject_cb
            // 
            target_subject_cb.Dock = DockStyle.Fill;
            target_subject_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            target_subject_cb.FlatStyle = FlatStyle.Flat;
            target_subject_cb.Font = new Font("Segoe UI", 11F);
            target_subject_cb.FormattingEnabled = true;
            target_subject_cb.Location = new Point(273, 28);
            target_subject_cb.Margin = new Padding(0, 0, 8, 0);
            target_subject_cb.Name = "target_subject_cb";
            target_subject_cb.Size = new Size(265, 33);
            target_subject_cb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(549, 2);
            label2.Margin = new Padding(3, 0, 3, 6);
            label2.Name = "label2";
            label2.Size = new Size(267, 20);
            label2.TabIndex = 0;
            label2.Tag = "muted";
            label2.Text = "START DATE";
            // 
            // start_date_dtp
            // 
            start_date_dtp.Dock = DockStyle.Fill;
            start_date_dtp.DropDownAlign = LeftRightAlignment.Right;
            start_date_dtp.Font = new Font("Segoe UI", 11F);
            start_date_dtp.Format = DateTimePickerFormat.Custom;
            start_date_dtp.Location = new Point(546, 28);
            start_date_dtp.Margin = new Padding(0, 0, 8, 0);
            start_date_dtp.Name = "start_date_dtp";
            start_date_dtp.Size = new Size(265, 32);
            start_date_dtp.TabIndex = 3;
            // 
            // end_date_lbl
            // 
            end_date_lbl.AutoSize = true;
            end_date_lbl.Dock = DockStyle.Bottom;
            end_date_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            end_date_lbl.Location = new Point(822, 2);
            end_date_lbl.Margin = new Padding(3, 0, 3, 6);
            end_date_lbl.Name = "end_date_lbl";
            end_date_lbl.Size = new Size(269, 20);
            end_date_lbl.TabIndex = 0;
            end_date_lbl.Tag = "muted";
            end_date_lbl.Text = "END DATE";
            // 
            // end_date_dtp
            // 
            end_date_dtp.Dock = DockStyle.Fill;
            end_date_dtp.DropDownAlign = LeftRightAlignment.Right;
            end_date_dtp.Font = new Font("Segoe UI", 11F);
            end_date_dtp.Format = DateTimePickerFormat.Custom;
            end_date_dtp.Location = new Point(819, 28);
            end_date_dtp.Margin = new Padding(0);
            end_date_dtp.Name = "end_date_dtp";
            end_date_dtp.Size = new Size(275, 32);
            end_date_dtp.TabIndex = 4;
            // 
            // content_tbl
            // 
            content_tbl.ColumnCount = 2;
            content_tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            content_tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            content_tbl.Controls.Add(params_card, 0, 0);
            content_tbl.Controls.Add(results_card, 1, 0);
            content_tbl.Dock = DockStyle.Fill;
            content_tbl.Location = new Point(3, 211);
            content_tbl.Name = "content_tbl";
            content_tbl.RowCount = 1;
            content_tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            content_tbl.Size = new Size(1142, 476);
            content_tbl.TabIndex = 1;
            // 
            // params_card
            // 
            params_card.Controls.Add(dynamic_params_pnl);
            params_card.Controls.Add(actions_pnl);
            params_card.Controls.Add(params_divider);
            params_card.Controls.Add(params_header_pnl);
            params_card.Dock = DockStyle.Fill;
            params_card.Location = new Point(0, 0);
            params_card.Margin = new Padding(0, 0, 16, 0);
            params_card.Name = "params_card";
            params_card.Padding = new Padding(24, 10, 24, 20);
            params_card.Size = new Size(364, 476);
            params_card.TabIndex = 0;
            params_card.Tag = "main_card";
            // 
            // dynamic_params_pnl
            // 
            dynamic_params_pnl.Dock = DockStyle.Fill;
            dynamic_params_pnl.Location = new Point(24, 51);
            dynamic_params_pnl.Name = "dynamic_params_pnl";
            dynamic_params_pnl.Size = new Size(316, 267);
            dynamic_params_pnl.TabIndex = 2;
            dynamic_params_pnl.Tag = "card";
            // 
            // actions_pnl
            // 
            actions_pnl.Controls.Add(run_btn);
            actions_pnl.Controls.Add(reset_btn);
            actions_pnl.Dock = DockStyle.Bottom;
            actions_pnl.Location = new Point(24, 318);
            actions_pnl.MaximumSize = new Size(0, 138);
            actions_pnl.MinimumSize = new Size(0, 138);
            actions_pnl.Name = "actions_pnl";
            actions_pnl.Padding = new Padding(0, 10, 0, 0);
            actions_pnl.Size = new Size(316, 138);
            actions_pnl.TabIndex = 3;
            actions_pnl.Tag = "card";
            // 
            // run_btn
            // 
            run_btn.Dock = DockStyle.Top;
            run_btn.FlatAppearance.BorderSize = 0;
            run_btn.FlatStyle = FlatStyle.Flat;
            run_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            run_btn.IconChar = IconChar.Play;
            run_btn.IconColor = Color.Black;
            run_btn.IconFont = IconFont.Auto;
            run_btn.IconSize = 22;
            run_btn.Location = new Point(0, 10);
            run_btn.Margin = new Padding(0);
            run_btn.MaximumSize = new Size(0, 60);
            run_btn.MinimumSize = new Size(0, 60);
            run_btn.Name = "run_btn";
            run_btn.Size = new Size(316, 60);
            run_btn.TabIndex = 0;
            run_btn.Tag = "cta";
            run_btn.Text = "  Run Analysis";
            run_btn.TextAlign = ContentAlignment.MiddleRight;
            run_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            run_btn.UseVisualStyleBackColor = true;
            run_btn.Click += run_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.Dock = DockStyle.Bottom;
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            reset_btn.IconChar = IconChar.RotateBack;
            reset_btn.IconColor = Color.Black;
            reset_btn.IconFont = IconFont.Auto;
            reset_btn.IconSize = 22;
            reset_btn.Location = new Point(0, 78);
            reset_btn.Margin = new Padding(0);
            reset_btn.MaximumSize = new Size(0, 60);
            reset_btn.MinimumSize = new Size(0, 60);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(316, 60);
            reset_btn.TabIndex = 1;
            reset_btn.Tag = "outlined";
            reset_btn.Text = "  Reset Parameters";
            reset_btn.TextAlign = ContentAlignment.MiddleRight;
            reset_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // params_divider
            // 
            params_divider.Dock = DockStyle.Top;
            params_divider.Location = new Point(24, 50);
            params_divider.Name = "params_divider";
            params_divider.Size = new Size(316, 1);
            params_divider.TabIndex = 1;
            params_divider.Tag = "divider";
            // 
            // params_header_pnl
            // 
            params_header_pnl.Controls.Add(params_title_lbl);
            params_header_pnl.Controls.Add(params_icon);
            params_header_pnl.Dock = DockStyle.Top;
            params_header_pnl.Location = new Point(24, 10);
            params_header_pnl.Name = "params_header_pnl";
            params_header_pnl.Size = new Size(316, 40);
            params_header_pnl.TabIndex = 0;
            params_header_pnl.Tag = "card";
            // 
            // params_title_lbl
            // 
            params_title_lbl.Dock = DockStyle.Fill;
            params_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            params_title_lbl.Location = new Point(30, 0);
            params_title_lbl.Name = "params_title_lbl";
            params_title_lbl.Size = new Size(286, 40);
            params_title_lbl.TabIndex = 1;
            params_title_lbl.Text = "Analysis Parameters";
            params_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // params_icon
            // 
            params_icon.BackColor = SystemColors.Control;
            params_icon.Dock = DockStyle.Left;
            params_icon.ForeColor = SystemColors.ControlText;
            params_icon.IconChar = IconChar.Sliders;
            params_icon.IconColor = SystemColors.ControlText;
            params_icon.IconFont = IconFont.Auto;
            params_icon.IconSize = 30;
            params_icon.Location = new Point(0, 0);
            params_icon.Name = "params_icon";
            params_icon.Size = new Size(30, 40);
            params_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            params_icon.TabIndex = 0;
            params_icon.TabStop = false;
            params_icon.Tag = "accent-icon";
            // 
            // results_card
            // 
            results_card.Controls.Add(groupBox1);
            results_card.Controls.Add(panel3);
            results_card.Controls.Add(results_divider);
            results_card.Controls.Add(results_header_pnl);
            results_card.Controls.Add(query_results_gb);
            results_card.Dock = DockStyle.Fill;
            results_card.Location = new Point(380, 0);
            results_card.Margin = new Padding(0);
            results_card.Name = "results_card";
            results_card.Padding = new Padding(24, 10, 24, 20);
            results_card.Size = new Size(762, 476);
            results_card.TabIndex = 1;
            results_card.Tag = "main_card";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(results_content_tbl);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(24, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 377);
            groupBox1.TabIndex = 3;
            groupBox1.Tag = "card";
            // 
            // results_content_tbl
            // 
            results_content_tbl.ColumnCount = 1;
            results_content_tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            results_content_tbl.Controls.Add(graph_pnl, 0, 0);
            results_content_tbl.Controls.Add(quick_stats_pnl, 0, 1);
            results_content_tbl.Controls.Add(ai_pnl, 0, 2);
            results_content_tbl.Dock = DockStyle.Fill;
            results_content_tbl.Location = new Point(0, 0);
            results_content_tbl.Name = "results_content_tbl";
            results_content_tbl.RowCount = 3;
            results_content_tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            results_content_tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            results_content_tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            results_content_tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            results_content_tbl.Size = new Size(714, 377);
            results_content_tbl.TabIndex = 0;
            // 
            // graph_pnl
            // 
            graph_pnl.Controls.Add(panel1);
            graph_pnl.Controls.Add(chart_pnl);
            graph_pnl.Dock = DockStyle.Fill;
            graph_pnl.Location = new Point(0, 0);
            graph_pnl.Margin = new Padding(0);
            graph_pnl.Name = "graph_pnl";
            graph_pnl.Size = new Size(714, 175);
            graph_pnl.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 1);
            panel1.TabIndex = 2;
            panel1.Tag = "divider";
            // 
            // chart_pnl
            // 
            chart_pnl.Dock = DockStyle.Fill;
            chart_pnl.Location = new Point(0, 0);
            chart_pnl.Name = "chart_pnl";
            chart_pnl.Padding = new Padding(0, 8, 0, 0);
            chart_pnl.Size = new Size(714, 175);
            chart_pnl.TabIndex = 0;
            chart_pnl.Tag = "card";
            // 
            // quick_stats_pnl
            // 
            quick_stats_pnl.Controls.Add(reliability_pnl);
            quick_stats_pnl.Controls.Add(trend_pnl);
            quick_stats_pnl.Controls.Add(confidence_pnl);
            quick_stats_pnl.Dock = DockStyle.Fill;
            quick_stats_pnl.Location = new Point(3, 178);
            quick_stats_pnl.Name = "quick_stats_pnl";
            quick_stats_pnl.Padding = new Padding(18, 2, 18, 0);
            quick_stats_pnl.Size = new Size(708, 66);
            quick_stats_pnl.TabIndex = 1;
            quick_stats_pnl.Tag = "card";
            // 
            // reliability_pnl
            // 
            reliability_pnl.Controls.Add(reliability_table);
            reliability_pnl.Location = new Point(21, 4);
            reliability_pnl.Margin = new Padding(3, 2, 3, 2);
            reliability_pnl.Name = "reliability_pnl";
            reliability_pnl.Size = new Size(114, 71);
            reliability_pnl.TabIndex = 0;
            reliability_pnl.Tag = "card";
            // 
            // reliability_table
            // 
            reliability_table.ColumnCount = 1;
            reliability_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            reliability_table.Controls.Add(label5, 0, 0);
            reliability_table.Controls.Add(reliability_lbl, 0, 1);
            reliability_table.Dock = DockStyle.Fill;
            reliability_table.Location = new Point(0, 0);
            reliability_table.Name = "reliability_table";
            reliability_table.RowCount = 2;
            reliability_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            reliability_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            reliability_table.Size = new Size(114, 71);
            reliability_table.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 18);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "Reliability (R²)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reliability_lbl
            // 
            reliability_lbl.AutoSize = true;
            reliability_lbl.Dock = DockStyle.Fill;
            reliability_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            reliability_lbl.Location = new Point(3, 18);
            reliability_lbl.Name = "reliability_lbl";
            reliability_lbl.Size = new Size(108, 53);
            reliability_lbl.TabIndex = 1;
            reliability_lbl.Text = "0";
            reliability_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trend_pnl
            // 
            trend_pnl.Controls.Add(sales_rend_table);
            trend_pnl.Location = new Point(141, 4);
            trend_pnl.Margin = new Padding(3, 2, 3, 2);
            trend_pnl.Name = "trend_pnl";
            trend_pnl.Size = new Size(114, 71);
            trend_pnl.TabIndex = 1;
            trend_pnl.Tag = "card";
            // 
            // sales_rend_table
            // 
            sales_rend_table.ColumnCount = 1;
            sales_rend_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sales_rend_table.Controls.Add(label4, 0, 0);
            sales_rend_table.Controls.Add(trend_lbl, 0, 1);
            sales_rend_table.Dock = DockStyle.Fill;
            sales_rend_table.Location = new Point(0, 0);
            sales_rend_table.Name = "sales_rend_table";
            sales_rend_table.RowCount = 2;
            sales_rend_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            sales_rend_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            sales_rend_table.Size = new Size(114, 71);
            sales_rend_table.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 0;
            label4.Tag = "muted";
            label4.Text = "Sales Trend (%)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trend_lbl
            // 
            trend_lbl.AutoSize = true;
            trend_lbl.Dock = DockStyle.Fill;
            trend_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            trend_lbl.Location = new Point(3, 18);
            trend_lbl.Name = "trend_lbl";
            trend_lbl.Size = new Size(108, 53);
            trend_lbl.TabIndex = 1;
            trend_lbl.Text = "0%";
            trend_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confidence_pnl
            // 
            confidence_pnl.Controls.Add(confidence_table);
            confidence_pnl.Location = new Point(261, 4);
            confidence_pnl.Margin = new Padding(3, 2, 3, 2);
            confidence_pnl.Name = "confidence_pnl";
            confidence_pnl.Size = new Size(114, 71);
            confidence_pnl.TabIndex = 2;
            confidence_pnl.Tag = "card";
            // 
            // confidence_table
            // 
            confidence_table.ColumnCount = 1;
            confidence_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            confidence_table.Controls.Add(label6, 0, 0);
            confidence_table.Controls.Add(confidence_lbl, 0, 1);
            confidence_table.Dock = DockStyle.Fill;
            confidence_table.Location = new Point(0, 0);
            confidence_table.Name = "confidence_table";
            confidence_table.RowCount = 2;
            confidence_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            confidence_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            confidence_table.Size = new Size(114, 71);
            confidence_table.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 18);
            label6.TabIndex = 0;
            label6.Tag = "muted";
            label6.Text = "AI Confidence";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confidence_lbl
            // 
            confidence_lbl.AutoSize = true;
            confidence_lbl.Dock = DockStyle.Fill;
            confidence_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            confidence_lbl.Location = new Point(3, 18);
            confidence_lbl.Name = "confidence_lbl";
            confidence_lbl.Size = new Size(108, 53);
            confidence_lbl.TabIndex = 1;
            confidence_lbl.Text = "0";
            confidence_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(ai_insights_rtb);
            ai_pnl.Controls.Add(panel4);
            ai_pnl.Controls.Add(panel2);
            ai_pnl.Dock = DockStyle.Fill;
            ai_pnl.Location = new Point(3, 250);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Size = new Size(708, 124);
            ai_pnl.TabIndex = 2;
            ai_pnl.Tag = "card";
            // 
            // ai_insights_rtb
            // 
            ai_insights_rtb.BorderStyle = BorderStyle.None;
            ai_insights_rtb.Dock = DockStyle.Fill;
            ai_insights_rtb.Font = new Font("Segoe UI", 10F);
            ai_insights_rtb.Location = new Point(0, 11);
            ai_insights_rtb.Margin = new Padding(0);
            ai_insights_rtb.Name = "ai_insights_rtb";
            ai_insights_rtb.ReadOnly = true;
            ai_insights_rtb.ScrollBars = RichTextBoxScrollBars.Vertical;
            ai_insights_rtb.Size = new Size(708, 113);
            ai_insights_rtb.TabIndex = 0;
            ai_insights_rtb.Tag = "insights";
            ai_insights_rtb.Text = "";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(708, 10);
            panel4.TabIndex = 3;
            panel4.Tag = "card";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0, 0, 0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 1);
            panel2.TabIndex = 2;
            panel2.Tag = "divider";
            // 
            // panel3
            // 
            panel3.Controls.Add(status_lbl);
            panel3.Controls.Add(progressBar1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(24, 428);
            panel3.MaximumSize = new Size(0, 28);
            panel3.MinimumSize = new Size(0, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 28);
            panel3.TabIndex = 2;
            panel3.Tag = "card";
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(0, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(38, 23);
            status_lbl.TabIndex = 0;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Idle";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Right;
            progressBar1.Location = new Point(153, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(561, 28);
            progressBar1.TabIndex = 1;
            // 
            // results_divider
            // 
            results_divider.Dock = DockStyle.Top;
            results_divider.Location = new Point(24, 50);
            results_divider.Name = "results_divider";
            results_divider.Size = new Size(714, 1);
            results_divider.TabIndex = 1;
            results_divider.Tag = "divider";
            // 
            // results_header_pnl
            // 
            results_header_pnl.Controls.Add(results_title_lbl);
            results_header_pnl.Controls.Add(results_icon);
            results_header_pnl.Dock = DockStyle.Top;
            results_header_pnl.Location = new Point(24, 10);
            results_header_pnl.Name = "results_header_pnl";
            results_header_pnl.Size = new Size(714, 40);
            results_header_pnl.TabIndex = 0;
            results_header_pnl.Tag = "card";
            // 
            // results_title_lbl
            // 
            results_title_lbl.Dock = DockStyle.Fill;
            results_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            results_title_lbl.Location = new Point(30, 0);
            results_title_lbl.Name = "results_title_lbl";
            results_title_lbl.Size = new Size(684, 40);
            results_title_lbl.TabIndex = 1;
            results_title_lbl.Text = "Results";
            results_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // results_icon
            // 
            results_icon.BackColor = SystemColors.Control;
            results_icon.Dock = DockStyle.Left;
            results_icon.ForeColor = SystemColors.ControlText;
            results_icon.IconChar = IconChar.BarChart;
            results_icon.IconColor = SystemColors.ControlText;
            results_icon.IconFont = IconFont.Auto;
            results_icon.IconSize = 30;
            results_icon.Location = new Point(0, 0);
            results_icon.Name = "results_icon";
            results_icon.Size = new Size(30, 40);
            results_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            results_icon.TabIndex = 0;
            results_icon.TabStop = false;
            results_icon.Tag = "accent-icon";
            // 
            // query_results_gb
            // 
            query_results_gb.Controls.Add(query_dgv);
            query_results_gb.Location = new Point(24, 51);
            query_results_gb.Name = "query_results_gb";
            query_results_gb.Size = new Size(714, 387);
            query_results_gb.TabIndex = 4;
            query_results_gb.Tag = "card";
            query_results_gb.Visible = false;
            // 
            // query_dgv
            // 
            query_dgv.AllowUserToAddRows = false;
            query_dgv.AllowUserToDeleteRows = false;
            query_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query_dgv.BorderStyle = BorderStyle.None;
            query_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            query_dgv.Dock = DockStyle.Top;
            query_dgv.EnableHeadersVisualStyles = false;
            query_dgv.Location = new Point(0, 0);
            query_dgv.Name = "query_dgv";
            query_dgv.ReadOnly = true;
            query_dgv.RowHeadersVisible = false;
            query_dgv.RowHeadersWidth = 51;
            query_dgv.Size = new Size(714, 387);
            query_dgv.TabIndex = 0;
            // 
            // AnalyzeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 750);
            Controls.Add(root_shell);
            Name = "AnalyzeForm";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "AnalyzeForm";
            root_shell.ResumeLayout(false);
            hero_pnl.ResumeLayout(false);
            selector_inner.ResumeLayout(false);
            selector_header_pnl.ResumeLayout(false);
            selector_header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).EndInit();
            selector_fields_pnl.ResumeLayout(false);
            selector_fields_pnl.PerformLayout();
            content_tbl.ResumeLayout(false);
            params_card.ResumeLayout(false);
            actions_pnl.ResumeLayout(false);
            params_header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)params_icon).EndInit();
            results_card.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            results_content_tbl.ResumeLayout(false);
            graph_pnl.ResumeLayout(false);
            quick_stats_pnl.ResumeLayout(false);
            reliability_pnl.ResumeLayout(false);
            reliability_table.ResumeLayout(false);
            reliability_table.PerformLayout();
            trend_pnl.ResumeLayout(false);
            sales_rend_table.ResumeLayout(false);
            sales_rend_table.PerformLayout();
            confidence_pnl.ResumeLayout(false);
            confidence_table.ResumeLayout(false);
            confidence_table.PerformLayout();
            ai_pnl.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            results_header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)results_icon).EndInit();
            query_results_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)query_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel root_shell;
        private Panel hero_pnl;
        private TableLayoutPanel selector_inner;
        private Panel selector_header_pnl;
        private IconPictureBox selector_icon;
        private Label selector_title_lbl;
        private Label selector_subtitle_lbl;
        private Panel selector_divider;
        private TableLayoutPanel selector_fields_pnl;
        private Label analisys_lbl;
        private ComboBox analysis_type_cb;
        private Label label1;
        private ComboBox target_subject_cb;
        private Label label2;
        private DateTimePicker start_date_dtp;
        private Label end_date_lbl;
        private DateTimePicker end_date_dtp;
        private TableLayoutPanel content_tbl;
        private Panel params_card;
        private Panel params_header_pnl;
        private IconPictureBox params_icon;
        private Label params_title_lbl;
        private Panel params_divider;
        private Panel dynamic_params_pnl;
        private Panel actions_pnl;
        private IconButton run_btn;
        private IconButton reset_btn;
        private Panel results_card;
        private Panel results_header_pnl;
        private IconPictureBox results_icon;
        private Label results_title_lbl;
        private Panel results_divider;
        private Panel panel3;
        private Label status_lbl;
        private ProgressBar progressBar1;
        private Panel groupBox1;
        private TableLayoutPanel results_content_tbl;
        private Panel chart_pnl;
        private FlowLayoutPanel quick_stats_pnl;
        private Panel reliability_pnl;
        private TableLayoutPanel reliability_table;
        private Label label5;
        private Label reliability_lbl;
        private Panel trend_pnl;
        private TableLayoutPanel sales_rend_table;
        private Label label4;
        private Label trend_lbl;
        private Panel confidence_pnl;
        private TableLayoutPanel confidence_table;
        private Label label6;
        private Label confidence_lbl;
        private Panel ai_pnl;
        private RichTextBox ai_insights_rtb;
        private Panel query_results_gb;
        private DataGridView query_dgv;
        private Panel graph_pnl;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
    }
}
