namespace SmartStock.Forms.User_Control.AnalysisForms
{
    partial class CorrelationAnalysis
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
            interval_cb = new ComboBox();
            panel2 = new Panel();
            label4 = new Label();
            lag_nud = new NumericUpDown();
            factor_type_cb = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            range_lbl = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lag_nud).BeginInit();
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
            panel1.Size = new Size(751, 463);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(interval_cb, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(factor_type_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(751, 453);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // interval_cb
            // 
            interval_cb.BackColor = Color.FromArgb(54, 54, 54);
            interval_cb.Dock = DockStyle.Fill;
            interval_cb.FlatStyle = FlatStyle.Flat;
            interval_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            interval_cb.ForeColor = Color.White;
            interval_cb.FormattingEnabled = true;
            interval_cb.Location = new Point(370, 115);
            interval_cb.Margin = new Padding(0, 5, 10, 10);
            interval_cb.Name = "interval_cb";
            interval_cb.Size = new Size(361, 33);
            interval_cb.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lag_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(370, 70);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 27);
            panel2.TabIndex = 31;
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
            // lag_nud
            // 
            lag_nud.Dock = DockStyle.Right;
            lag_nud.Location = new Point(233, 0);
            lag_nud.Margin = new Padding(0, 10, 0, 0);
            lag_nud.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            lag_nud.Name = "lag_nud";
            lag_nud.Size = new Size(128, 27);
            lag_nud.TabIndex = 0;
            // 
            // factor_type_cb
            // 
            factor_type_cb.BackColor = Color.FromArgb(54, 54, 54);
            factor_type_cb.Dock = DockStyle.Fill;
            factor_type_cb.FlatStyle = FlatStyle.Flat;
            factor_type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            factor_type_cb.ForeColor = Color.White;
            factor_type_cb.FormattingEnabled = true;
            factor_type_cb.Location = new Point(370, 15);
            factor_type_cb.Margin = new Padding(0, 5, 10, 10);
            factor_type_cb.Name = "factor_type_cb";
            factor_type_cb.Size = new Size(361, 33);
            factor_type_cb.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 110);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 28;
            label2.Text = "Aggregation Level";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 60);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 27;
            label1.Text = "Lag Effect";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 10);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(136, 25);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Primary Factor";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CorrelationAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CorrelationAnalysis";
            Size = new Size(751, 463);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lag_nud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Label range_lbl;
        private TrackBar confidence_tb;
        private ComboBox factor_type_cb;
        private ComboBox interval_cb;
        private Panel panel2;
        private Label label4;
        private NumericUpDown lag_nud;
    }
}
