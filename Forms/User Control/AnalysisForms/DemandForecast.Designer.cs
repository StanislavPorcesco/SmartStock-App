namespace SmartStock.Forms.User_Control.AnalysisForms
{
    partial class DemandForecast
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            horizon_nud = new NumericUpDown();
            range_lbl = new Label();
            factors_clb = new CheckedListBox();
            confidence_tb = new TrackBar();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)horizon_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)confidence_tb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(641, 688);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(factors_clb, 1, 1);
            tableLayoutPanel1.Controls.Add(confidence_tb, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 20, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 201F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(641, 678);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 271);
            label2.Margin = new Padding(10, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 28;
            label2.Text = "Confidence Interval";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 70);
            label1.Margin = new Padding(10, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 27;
            label1.Text = "External Variables";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(horizon_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(310, 20);
            panel2.Margin = new Padding(0, 10, 0, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 27);
            panel2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 21;
            label4.Text = "Days";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // horizon_nud
            // 
            horizon_nud.Dock = DockStyle.Right;
            horizon_nud.Location = new Point(168, 0);
            horizon_nud.Margin = new Padding(0, 10, 0, 0);
            horizon_nud.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            horizon_nud.Name = "horizon_nud";
            horizon_nud.Size = new Size(143, 27);
            horizon_nud.TabIndex = 0;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 10);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(156, 25);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Forecast Horizon";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factors_clb
            // 
            factors_clb.Dock = DockStyle.Fill;
            factors_clb.FormattingEnabled = true;
            factors_clb.Items.AddRange(new object[] { "d", "d", "d", "d", "d", "d", "d" });
            factors_clb.Location = new Point(310, 70);
            factors_clb.Margin = new Padding(0, 10, 0, 0);
            factors_clb.MinimumSize = new Size(0, 100);
            factors_clb.Name = "factors_clb";
            factors_clb.Size = new Size(311, 191);
            factors_clb.TabIndex = 26;
            // 
            // confidence_tb
            // 
            confidence_tb.Dock = DockStyle.Top;
            confidence_tb.Location = new Point(310, 271);
            confidence_tb.Margin = new Padding(0, 10, 0, 0);
            confidence_tb.Maximum = 100;
            confidence_tb.Name = "confidence_tb";
            confidence_tb.Size = new Size(311, 56);
            confidence_tb.TabIndex = 29;
            // 
            // DemandForecast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DemandForecast";
            Size = new Size(641, 688);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)horizon_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)confidence_tb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label name_lbl;
        private TextBox category_name_tb;
        private Label range_lbl;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private NumericUpDown horizon_nud;
        private CheckedListBox factors_clb;
        private TrackBar confidence_tb;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private NumericUpDown max_numeric;
    }
}
