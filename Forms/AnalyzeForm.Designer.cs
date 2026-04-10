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
            paths_gb = new GroupBox();
            dynamic_params_pnl = new Panel();
            panel2 = new Panel();
            run_btn = new Button();
            reset_btn = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            analisys_lbl = new Label();
            analysis_type_cb = new ComboBox();
            target_subject_cb = new ComboBox();
            start_date_dtp = new DateTimePicker();
            end_date_dtp = new DateTimePicker();
            groupBox1 = new GroupBox();
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
            base_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)main_split).BeginInit();
            main_split.Panel1.SuspendLayout();
            main_split.Panel2.SuspendLayout();
            main_split.SuspendLayout();
            paths_gb.SuspendLayout();
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
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
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
            main_split.Panel1.Controls.Add(paths_gb);
            // 
            // main_split.Panel2
            // 
            main_split.Panel2.Controls.Add(groupBox1);
            main_split.Size = new Size(1280, 699);
            main_split.SplitterDistance = 471;
            main_split.TabIndex = 0;
            // 
            // paths_gb
            // 
            paths_gb.Controls.Add(dynamic_params_pnl);
            paths_gb.Controls.Add(panel2);
            paths_gb.Controls.Add(panel1);
            paths_gb.Dock = DockStyle.Fill;
            paths_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paths_gb.ForeColor = Color.White;
            paths_gb.Location = new Point(0, 0);
            paths_gb.Margin = new Padding(0);
            paths_gb.Name = "paths_gb";
            paths_gb.Padding = new Padding(10, 20, 10, 20);
            paths_gb.Size = new Size(471, 699);
            paths_gb.TabIndex = 5;
            paths_gb.TabStop = false;
            paths_gb.Text = "Analysis Parameters";
            // 
            // dynamic_params_pnl
            // 
            dynamic_params_pnl.Dock = DockStyle.Fill;
            dynamic_params_pnl.Location = new Point(10, 205);
            dynamic_params_pnl.Name = "dynamic_params_pnl";
            dynamic_params_pnl.Size = new Size(451, 323);
            dynamic_params_pnl.TabIndex = 1;
            dynamic_params_pnl.Tag = "base";
            // 
            // panel2
            // 
            panel2.Controls.Add(run_btn);
            panel2.Controls.Add(reset_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 151);
            panel2.TabIndex = 2;
            // 
            // run_btn
            // 
            run_btn.BackColor = Color.FromArgb(54, 54, 54);
            run_btn.Dock = DockStyle.Top;
            run_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            run_btn.ForeColor = Color.White;
            run_btn.Location = new Point(0, 0);
            run_btn.Margin = new Padding(10, 0, 0, 0);
            run_btn.MaximumSize = new Size(0, 70);
            run_btn.MinimumSize = new Size(0, 70);
            run_btn.Name = "run_btn";
            run_btn.Size = new Size(451, 70);
            run_btn.TabIndex = 19;
            run_btn.Text = "Run Analysis";
            run_btn.UseVisualStyleBackColor = false;
            run_btn.Click += run_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(54, 54, 54);
            reset_btn.Dock = DockStyle.Bottom;
            reset_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_btn.ForeColor = Color.White;
            reset_btn.Location = new Point(0, 81);
            reset_btn.Margin = new Padding(10, 0, 0, 0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(451, 70);
            reset_btn.TabIndex = 18;
            reset_btn.Text = "Reset Parameters";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 40);
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
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(0, 81);
            label2.Margin = new Padding(0, 0, 3, 0);
            label2.Name = "label2";
            tableLayoutPanel1.SetRowSpan(label2, 2);
            label2.Size = new Size(152, 84);
            label2.TabIndex = 44;
            label2.Text = "Historical Range";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(0, 48);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 33);
            label1.TabIndex = 16;
            label1.Text = "Target Subject";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // analisys_lbl
            // 
            analisys_lbl.AutoSize = true;
            analisys_lbl.Dock = DockStyle.Left;
            analisys_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            analisys_lbl.Location = new Point(0, 0);
            analisys_lbl.Margin = new Padding(0, 0, 3, 0);
            analisys_lbl.Name = "analisys_lbl";
            analisys_lbl.Size = new Size(165, 48);
            analisys_lbl.TabIndex = 7;
            analisys_lbl.Text = "Analysis Selection";
            analisys_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // analysis_type_cb
            // 
            analysis_type_cb.BackColor = Color.FromArgb(54, 54, 54);
            analysis_type_cb.Dock = DockStyle.Fill;
            analysis_type_cb.FlatStyle = FlatStyle.Flat;
            analysis_type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            analysis_type_cb.ForeColor = Color.White;
            analysis_type_cb.FormattingEnabled = true;
            analysis_type_cb.Location = new Point(215, 5);
            analysis_type_cb.Margin = new Padding(0, 5, 10, 10);
            analysis_type_cb.Name = "analysis_type_cb";
            analysis_type_cb.Size = new Size(206, 33);
            analysis_type_cb.TabIndex = 14;
            // 
            // target_subject_cb
            // 
            target_subject_cb.BackColor = Color.FromArgb(54, 54, 54);
            target_subject_cb.Dock = DockStyle.Fill;
            target_subject_cb.FlatStyle = FlatStyle.Flat;
            target_subject_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            target_subject_cb.ForeColor = Color.White;
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
            start_date_dtp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            start_date_dtp.Format = DateTimePickerFormat.Custom;
            start_date_dtp.Location = new Point(215, 86);
            start_date_dtp.Margin = new Padding(0, 5, 10, 5);
            start_date_dtp.Name = "start_date_dtp";
            start_date_dtp.Size = new Size(206, 31);
            start_date_dtp.TabIndex = 42;
            // 
            // end_date_dtp
            // 
            end_date_dtp.Dock = DockStyle.Fill;
            end_date_dtp.DropDownAlign = LeftRightAlignment.Right;
            end_date_dtp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            end_date_dtp.Format = DateTimePickerFormat.Custom;
            end_date_dtp.Location = new Point(215, 127);
            end_date_dtp.Margin = new Padding(0, 5, 10, 0);
            end_date_dtp.Name = "end_date_dtp";
            end_date_dtp.Size = new Size(206, 31);
            end_date_dtp.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(result_split);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(805, 699);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // result_split
            // 
            result_split.Dock = DockStyle.Fill;
            result_split.Location = new Point(3, 23);
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
            result_split.Size = new Size(799, 638);
            result_split.SplitterDistance = 320;
            result_split.TabIndex = 11;
            // 
            // chart_pnl
            // 
            chart_pnl.Dock = DockStyle.Fill;
            chart_pnl.Location = new Point(0, 0);
            chart_pnl.Name = "chart_pnl";
            chart_pnl.Padding = new Padding(20, 0, 20, 0);
            chart_pnl.Size = new Size(799, 220);
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
            quick_stats_pnl.Size = new Size(799, 100);
            quick_stats_pnl.TabIndex = 1;
            // 
            // reliability_pnl
            // 
            reliability_pnl.Controls.Add(reliability_table);
            reliability_pnl.Location = new Point(23, 3);
            reliability_pnl.Name = "reliability_pnl";
            reliability_pnl.Size = new Size(130, 100);
            reliability_pnl.TabIndex = 1;
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
            reliability_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 26);
            label5.TabIndex = 1;
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
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 26);
            label4.TabIndex = 0;
            label4.Text = "Sales Trend (%)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trend_lbl
            // 
            trend_lbl.AutoSize = true;
            trend_lbl.Dock = DockStyle.Fill;
            trend_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 26);
            label6.TabIndex = 0;
            label6.Text = "AI Confidence";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confidence_lbl
            // 
            confidence_lbl.AutoSize = true;
            confidence_lbl.Dock = DockStyle.Fill;
            confidence_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confidence_lbl.Location = new Point(3, 26);
            confidence_lbl.Name = "confidence_lbl";
            confidence_lbl.Size = new Size(124, 74);
            confidence_lbl.TabIndex = 1;
            confidence_lbl.Text = "0";
            confidence_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ai_insights_rtb
            // 
            ai_insights_rtb.BackColor = Color.FromArgb(54, 54, 54);
            ai_insights_rtb.Dock = DockStyle.Fill;
            ai_insights_rtb.ForeColor = Color.White;
            ai_insights_rtb.Location = new Point(20, 20);
            ai_insights_rtb.Name = "ai_insights_rtb";
            ai_insights_rtb.ReadOnly = true;
            ai_insights_rtb.Size = new Size(759, 274);
            ai_insights_rtb.TabIndex = 0;
            ai_insights_rtb.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(status_lbl);
            panel3.Controls.Add(progressBar1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 661);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 20, 10);
            panel3.Size = new Size(799, 35);
            panel3.TabIndex = 10;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Dock = DockStyle.Left;
            status_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            status_lbl.ForeColor = Color.White;
            status_lbl.Location = new Point(20, 0);
            status_lbl.Margin = new Padding(0, 0, 3, 0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(44, 25);
            status_lbl.TabIndex = 8;
            status_lbl.Text = "Idle";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Right;
            progressBar1.Location = new Point(225, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(554, 25);
            progressBar1.TabIndex = 0;
            // 
            // AnalyzeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
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
            paths_gb.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private SplitContainer main_split;
        private GroupBox paths_gb;
        private Panel dynamic_params_pnl;
        private Panel panel2;
        private Button reset_btn;
        private Panel panel1;
        private ComboBox analysis_type_cb;
        private Label analisys_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox target_subject_cb;
        private Button run_btn;
        private Label label2;
        private DateTimePicker start_date_dtp;
        private DateTimePicker end_date_dtp;
        private GroupBox groupBox1;
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
    }
}