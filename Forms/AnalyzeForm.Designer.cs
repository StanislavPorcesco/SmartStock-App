using FontAwesome.Sharp;

namespace SmartStock.Forms
{
    partial class AnalyzeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            base_pnl = new Panel();
            main_split = new SplitContainer();
            params_card = new Panel();
            dynamic_params_pnl = new Panel();
            panel2 = new Panel();
            run_btn = new IconButton();
            reset_btn = new IconButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            analisys_lbl = new Label();
            analysis_type_cb = new ComboBox();
            target_subject_cb = new ComboBox();
            start_date_dtp = new DateTimePicker();
            end_date_dtp = new DateTimePicker();
            params_divider = new Panel();
            params_title_lbl = new Label();
            groupBox1 = new Panel();
            result_split = new SplitContainer();
            chart_pnl = new Panel();
            quick_stats_pnl = new FlowLayoutPanel();
            reliability_pnl = new Panel();
            reliability_table = new TableLayoutPanel();
            reliability_lbl = new Label();
            label5 = new Label();
            trend_pnl = new Panel();
            sales_rend_table = new TableLayoutPanel();
            label4 = new Label();
            trend_lbl = new Label();
            confidence_pnl = new Panel();
            confidence_table = new TableLayoutPanel();
            label6 = new Label();
            confidence_lbl = new Label();
            ai_insights_rtb = new RichTextBox();
            panel3 = new Panel();
            status_lbl = new Label();
            progressBar1 = new ProgressBar();
            results_divider = new Panel();
            results_title_lbl = new Label();
            query_results_gb = new Panel();
            query_dgv = new DataGridView();
            query_divider = new Panel();
            query_title_lbl = new Label();
            base_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)main_split).BeginInit();
            main_split.Panel1.SuspendLayout();
            main_split.Panel2.SuspendLayout();
            main_split.SuspendLayout();
            params_card.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)result_split).BeginInit();
            result_split.Panel1.SuspendLayout();
            result_split.Panel2.SuspendLayout();
            result_split.SuspendLayout();
            quick_stats_pnl.SuspendLayout();
            reliability_pnl.SuspendLayout();
            reliability_table.SuspendLayout();
            trend_pnl.SuspendLayout();
            sales_rend_table.SuspendLayout();
            confidence_pnl.SuspendLayout();
            confidence_table.SuspendLayout();
            panel3.SuspendLayout();
            query_results_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)query_dgv).BeginInit();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.Controls.Add(main_split);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1320, 739);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // main_split
            // 
            main_split.Dock = DockStyle.Fill;
            main_split.Location = new Point(20, 20);
            main_split.Name = "main_split";
            // 
            // main_split.Panel1
            // 
            main_split.Panel1.Controls.Add(params_card);
            // 
            // main_split.Panel2
            // 
            main_split.Panel2.Controls.Add(groupBox1);
            main_split.Panel2.Controls.Add(query_results_gb);
            main_split.Size = new Size(1280, 699);
            main_split.SplitterDistance = 471;
            main_split.TabIndex = 0;
            // 
            // params_card
            // 
            params_card.Controls.Add(dynamic_params_pnl);
            params_card.Controls.Add(panel2);
            params_card.Controls.Add(panel1);
            params_card.Controls.Add(params_divider);
            params_card.Controls.Add(params_title_lbl);
            params_card.Dock = DockStyle.Fill;
            params_card.Location = new Point(0, 0);
            params_card.Margin = new Padding(0);
            params_card.Name = "params_card";
            params_card.Padding = new Padding(10, 10, 10, 20);
            params_card.Size = new Size(471, 699);
            params_card.TabIndex = 5;
            params_card.Tag = "card";
            // 
            // dynamic_params_pnl
            // 
            dynamic_params_pnl.Dock = DockStyle.Fill;
            dynamic_params_pnl.Location = new Point(10, 212);
            dynamic_params_pnl.Name = "dynamic_params_pnl";
            dynamic_params_pnl.Size = new Size(451, 297);
            dynamic_params_pnl.TabIndex = 1;
            dynamic_params_pnl.Tag = "base";
            // 
            // panel2
            // 
            panel2.Controls.Add(run_btn);
            panel2.Controls.Add(reset_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 509);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(451, 170);
            panel2.TabIndex = 2;
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
            run_btn.Location = new Point(10, 10);
            run_btn.Margin = new Padding(10, 0, 0, 0);
            run_btn.MaximumSize = new Size(0, 70);
            run_btn.MinimumSize = new Size(0, 70);
            run_btn.Name = "run_btn";
            run_btn.Size = new Size(431, 70);
            run_btn.TabIndex = 19;
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
            reset_btn.Location = new Point(10, 90);
            reset_btn.Margin = new Padding(10, 0, 0, 0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(431, 70);
            reset_btn.TabIndex = 18;
            reset_btn.Tag = "outlined";
            reset_btn.Text = "  Reset Parameters";
            reset_btn.TextAlign = ContentAlignment.MiddleRight;
            reset_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 47);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(451, 165);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(analisys_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(analysis_type_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(target_subject_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(start_date_dtp, 1, 2);
            tableLayoutPanel1.Controls.Add(end_date_dtp, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(431, 165);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 81);
            label2.Margin = new Padding(0, 0, 3, 0);
            label2.Name = "label2";
            tableLayoutPanel1.SetRowSpan(label2, 2);
            label2.Size = new Size(133, 84);
            label2.TabIndex = 44;
            label2.Tag = "muted";
            label2.Text = "Historical Range";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 48);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 16;
            label1.Tag = "muted";
            label1.Text = "Target Subject";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // analisys_lbl
            // 
            analisys_lbl.AutoSize = true;
            analisys_lbl.Dock = DockStyle.Left;
            analisys_lbl.Font = new Font("Segoe UI", 10F);
            analisys_lbl.Location = new Point(0, 0);
            analisys_lbl.Margin = new Padding(0, 0, 3, 0);
            analisys_lbl.Name = "analisys_lbl";
            analisys_lbl.Size = new Size(144, 48);
            analisys_lbl.TabIndex = 7;
            analisys_lbl.Tag = "muted";
            analisys_lbl.Text = "Analysis Selection";
            analisys_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // analysis_type_cb
            // 
            analysis_type_cb.Dock = DockStyle.Fill;
            analysis_type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            analysis_type_cb.FlatStyle = FlatStyle.Flat;
            analysis_type_cb.Font = new Font("Segoe UI", 11F);
            analysis_type_cb.FormattingEnabled = true;
            analysis_type_cb.Location = new Point(215, 5);
            analysis_type_cb.Margin = new Padding(0, 5, 10, 10);
            analysis_type_cb.Name = "analysis_type_cb";
            analysis_type_cb.Size = new Size(206, 33);
            analysis_type_cb.TabIndex = 14;
            // 
            // target_subject_cb
            // 
            target_subject_cb.Dock = DockStyle.Fill;
            target_subject_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            target_subject_cb.FlatStyle = FlatStyle.Flat;
            target_subject_cb.Font = new Font("Segoe UI", 11F);
            target_subject_cb.FormattingEnabled = true;
            target_subject_cb.Location = new Point(215, 48);
            target_subject_cb.Margin = new Padding(0, 0, 10, 0);
            target_subject_cb.Name = "target_subject_cb";
            target_subject_cb.Size = new Size(206, 33);
            target_subject_cb.TabIndex = 15;
            // 
            // start_date_dtp
            // 
            start_date_dtp.Dock = DockStyle.Fill;
            start_date_dtp.DropDownAlign = LeftRightAlignment.Right;
            start_date_dtp.Font = new Font("Segoe UI", 11F);
            start_date_dtp.Format = DateTimePickerFormat.Custom;
            start_date_dtp.Location = new Point(215, 86);
            start_date_dtp.Margin = new Padding(0, 5, 10, 5);
            start_date_dtp.Name = "start_date_dtp";
            start_date_dtp.Size = new Size(206, 32);
            start_date_dtp.TabIndex = 42;
            // 
            // end_date_dtp
            // 
            end_date_dtp.Dock = DockStyle.Fill;
            end_date_dtp.DropDownAlign = LeftRightAlignment.Right;
            end_date_dtp.Font = new Font("Segoe UI", 11F);
            end_date_dtp.Format = DateTimePickerFormat.Custom;
            end_date_dtp.Location = new Point(215, 128);
            end_date_dtp.Margin = new Padding(0, 5, 10, 0);
            end_date_dtp.Name = "end_date_dtp";
            end_date_dtp.Size = new Size(206, 32);
            end_date_dtp.TabIndex = 43;
            // 
            // params_divider
            // 
            params_divider.Dock = DockStyle.Top;
            params_divider.Location = new Point(10, 46);
            params_divider.Name = "params_divider";
            params_divider.Size = new Size(451, 1);
            params_divider.TabIndex = 11;
            params_divider.Tag = "divider";
            // 
            // params_title_lbl
            // 
            params_title_lbl.Dock = DockStyle.Top;
            params_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            params_title_lbl.Location = new Point(10, 10);
            params_title_lbl.Name = "params_title_lbl";
            params_title_lbl.Padding = new Padding(5, 5, 0, 5);
            params_title_lbl.Size = new Size(451, 36);
            params_title_lbl.TabIndex = 10;
            params_title_lbl.Text = "Analysis Parameters";
            params_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(result_split);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(results_divider);
            groupBox1.Controls.Add(results_title_lbl);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(805, 699);
            groupBox1.TabIndex = 10;
            groupBox1.Tag = "card";
            // 
            // result_split
            // 
            result_split.Dock = DockStyle.Fill;
            result_split.Location = new Point(10, 47);
            result_split.Name = "result_split";
            result_split.Orientation = Orientation.Horizontal;
            // 
            // result_split.Panel1
            // 
            result_split.Panel1.Controls.Add(chart_pnl);
            result_split.Panel1.Controls.Add(quick_stats_pnl);
            // 
            // result_split.Panel2
            // 
            result_split.Panel2.Controls.Add(ai_insights_rtb);
            result_split.Panel2.Padding = new Padding(20);
            result_split.Size = new Size(785, 607);
            result_split.SplitterDistance = 320;
            result_split.TabIndex = 11;
            // 
            // chart_pnl
            // 
            chart_pnl.Dock = DockStyle.Fill;
            chart_pnl.Location = new Point(0, 0);
            chart_pnl.Name = "chart_pnl";
            chart_pnl.Padding = new Padding(20, 0, 20, 0);
            chart_pnl.Size = new Size(785, 220);
            chart_pnl.TabIndex = 2;
            // 
            // quick_stats_pnl
            // 
            quick_stats_pnl.Controls.Add(reliability_pnl);
            quick_stats_pnl.Controls.Add(trend_pnl);
            quick_stats_pnl.Controls.Add(confidence_pnl);
            quick_stats_pnl.Dock = DockStyle.Bottom;
            quick_stats_pnl.Location = new Point(0, 220);
            quick_stats_pnl.Name = "quick_stats_pnl";
            quick_stats_pnl.Padding = new Padding(20, 0, 20, 0);
            quick_stats_pnl.Size = new Size(785, 100);
            quick_stats_pnl.TabIndex = 1;
            // 
            // reliability_pnl
            // 
            reliability_pnl.Controls.Add(reliability_table);
            reliability_pnl.Location = new Point(23, 3);
            reliability_pnl.Name = "reliability_pnl";
            reliability_pnl.Size = new Size(130, 100);
            reliability_pnl.TabIndex = 1;
            reliability_pnl.Tag = "hero";
            // 
            // reliability_table
            // 
            reliability_table.ColumnCount = 1;
            reliability_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            reliability_table.Controls.Add(reliability_lbl, 0, 1);
            reliability_table.Controls.Add(label5, 0, 0);
            reliability_table.Dock = DockStyle.Fill;
            reliability_table.Location = new Point(0, 0);
            reliability_table.Name = "reliability_table";
            reliability_table.RowCount = 2;
            reliability_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            reliability_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            reliability_table.Size = new Size(130, 100);
            reliability_table.TabIndex = 2;
            // 
            // reliability_lbl
            // 
            reliability_lbl.AutoSize = true;
            reliability_lbl.Dock = DockStyle.Fill;
            reliability_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            reliability_lbl.Location = new Point(3, 26);
            reliability_lbl.Name = "reliability_lbl";
            reliability_lbl.Size = new Size(124, 74);
            reliability_lbl.TabIndex = 1;
            reliability_lbl.Text = "0";
            reliability_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 26);
            label5.TabIndex = 1;
            label5.Tag = "muted";
            label5.Text = "Reliability (R sq)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trend_pnl
            // 
            trend_pnl.Controls.Add(sales_rend_table);
            trend_pnl.Location = new Point(159, 3);
            trend_pnl.Name = "trend_pnl";
            trend_pnl.Size = new Size(130, 100);
            trend_pnl.TabIndex = 0;
            trend_pnl.Tag = "hero";
            // 
            // sales_rend_table
            // 
            sales_rend_table.ColumnCount = 1;
            sales_rend_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sales_rend_table.Controls.Add(label4, 0, 0);
            sales_rend_table.Controls.Add(trend_lbl, 0, 1);
            sales_rend_table.Dock = DockStyle.Fill;
            sales_rend_table.Location = new Point(0, 0);
            sales_rend_table.Name = "sales_rend_table";
            sales_rend_table.RowCount = 2;
            sales_rend_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            sales_rend_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            sales_rend_table.Size = new Size(130, 100);
            sales_rend_table.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 26);
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
            trend_lbl.Location = new Point(3, 26);
            trend_lbl.Name = "trend_lbl";
            trend_lbl.Size = new Size(124, 74);
            trend_lbl.TabIndex = 1;
            trend_lbl.Text = "0%";
            trend_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confidence_pnl
            // 
            confidence_pnl.Controls.Add(confidence_table);
            confidence_pnl.Location = new Point(295, 3);
            confidence_pnl.Name = "confidence_pnl";
            confidence_pnl.Size = new Size(130, 100);
            confidence_pnl.TabIndex = 2;
            confidence_pnl.Tag = "hero";
            // 
            // confidence_table
            // 
            confidence_table.ColumnCount = 1;
            confidence_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            confidence_table.Controls.Add(label6, 0, 0);
            confidence_table.Controls.Add(confidence_lbl, 0, 1);
            confidence_table.Dock = DockStyle.Fill;
            confidence_table.Location = new Point(0, 0);
            confidence_table.Name = "confidence_table";
            confidence_table.RowCount = 2;
            confidence_table.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4F));
            confidence_table.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6F));
            confidence_table.Size = new Size(130, 100);
            confidence_table.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 26);
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
            confidence_lbl.Location = new Point(3, 26);
            confidence_lbl.Name = "confidence_lbl";
            confidence_lbl.Size = new Size(124, 74);
            confidence_lbl.TabIndex = 1;
            confidence_lbl.Text = "0";
            confidence_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ai_insights_rtb
            // 
            ai_insights_rtb.BorderStyle = BorderStyle.None;
            ai_insights_rtb.Dock = DockStyle.Fill;
            ai_insights_rtb.Font = new Font("Segoe UI", 10F);
            ai_insights_rtb.Location = new Point(20, 20);
            ai_insights_rtb.Name = "ai_insights_rtb";
            ai_insights_rtb.ReadOnly = true;
            ai_insights_rtb.Size = new Size(745, 243);
            ai_insights_rtb.TabIndex = 0;
            ai_insights_rtb.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(status_lbl);
            panel3.Controls.Add(progressBar1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 654);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 10);
            panel3.Size = new Size(785, 35);
            panel3.TabIndex = 10;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10F);
            status_lbl.Location = new Point(20, 0);
            status_lbl.Margin = new Padding(0, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(38, 23);
            status_lbl.TabIndex = 8;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Idle";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Right;
            progressBar1.Location = new Point(225, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(540, 25);
            progressBar1.TabIndex = 0;
            // 
            // results_divider
            // 
            results_divider.Dock = DockStyle.Top;
            results_divider.Location = new Point(10, 46);
            results_divider.Name = "results_divider";
            results_divider.Size = new Size(785, 1);
            results_divider.TabIndex = 13;
            results_divider.Tag = "divider";
            // 
            // results_title_lbl
            // 
            results_title_lbl.Dock = DockStyle.Top;
            results_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            results_title_lbl.Location = new Point(10, 10);
            results_title_lbl.Name = "results_title_lbl";
            results_title_lbl.Padding = new Padding(5, 5, 0, 5);
            results_title_lbl.Size = new Size(785, 36);
            results_title_lbl.TabIndex = 12;
            results_title_lbl.Text = "Results";
            results_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // query_results_gb
            // 
            query_results_gb.Controls.Add(query_dgv);
            query_results_gb.Controls.Add(query_divider);
            query_results_gb.Controls.Add(query_title_lbl);
            query_results_gb.Dock = DockStyle.Fill;
            query_results_gb.Location = new Point(0, 0);
            query_results_gb.Name = "query_results_gb";
            query_results_gb.Padding = new Padding(10, 10, 10, 3);
            query_results_gb.Size = new Size(805, 699);
            query_results_gb.TabIndex = 11;
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
            query_dgv.Dock = DockStyle.Fill;
            query_dgv.EnableHeadersVisualStyles = false;
            query_dgv.Location = new Point(10, 47);
            query_dgv.Name = "query_dgv";
            query_dgv.ReadOnly = true;
            query_dgv.RowHeadersVisible = false;
            query_dgv.RowHeadersWidth = 51;
            query_dgv.Size = new Size(785, 649);
            query_dgv.TabIndex = 0;
            // 
            // query_divider
            // 
            query_divider.Dock = DockStyle.Top;
            query_divider.Location = new Point(10, 46);
            query_divider.Name = "query_divider";
            query_divider.Size = new Size(785, 1);
            query_divider.TabIndex = 2;
            query_divider.Tag = "divider";
            // 
            // query_title_lbl
            // 
            query_title_lbl.Dock = DockStyle.Top;
            query_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            query_title_lbl.Location = new Point(10, 10);
            query_title_lbl.Name = "query_title_lbl";
            query_title_lbl.Padding = new Padding(5, 5, 0, 5);
            query_title_lbl.Size = new Size(785, 36);
            query_title_lbl.TabIndex = 1;
            query_title_lbl.Text = "Query Results";
            query_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnalyzeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 799);
            Controls.Add(base_pnl);
            Name = "AnalyzeForm";
            Padding = new Padding(30);
            Text = "AnalyzeForm";
            base_pnl.ResumeLayout(false);
            main_split.Panel1.ResumeLayout(false);
            main_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)main_split).EndInit();
            main_split.ResumeLayout(false);
            params_card.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            result_split.Panel1.ResumeLayout(false);
            result_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)result_split).EndInit();
            result_split.ResumeLayout(false);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            query_results_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)query_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private SplitContainer main_split;
        private Panel params_card;
        private Panel dynamic_params_pnl;
        private Panel panel2;
        private IconButton reset_btn;
        private Panel panel1;
        private ComboBox analysis_type_cb;
        private Label analisys_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox target_subject_cb;
        private IconButton run_btn;
        private Label label2;
        private DateTimePicker start_date_dtp;
        private DateTimePicker end_date_dtp;
        private Label params_title_lbl;
        private Panel params_divider;
        private Panel groupBox1;
        private Panel panel3;
        private Label status_lbl;
        private ProgressBar progressBar1;
        private SplitContainer result_split;
        private RichTextBox ai_insights_rtb;
        private FlowLayoutPanel quick_stats_pnl;
        private Panel reliability_pnl;
        private TableLayoutPanel reliability_table;
        private Label reliability_lbl;
        private Label label5;
        private Panel trend_pnl;
        private TableLayoutPanel sales_rend_table;
        private Label label4;
        private Label trend_lbl;
        private Panel confidence_pnl;
        private TableLayoutPanel confidence_table;
        private Label label6;
        private Label confidence_lbl;
        private Panel chart_pnl;
        private Label results_title_lbl;
        private Panel results_divider;
        private Panel query_results_gb;
        private DataGridView query_dgv;
        private Label query_title_lbl;
        private Panel query_divider;
    }
}
