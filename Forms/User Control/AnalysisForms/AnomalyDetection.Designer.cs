namespace SmartStock.Forms.User_Control.AnalysisForms
{
    partial class AnomalyDetection
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1            = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_sensitivity   = new Label();
            sensitivity_cb    = new ComboBox();
            lbl_aggregation   = new Label();
            aggregation_cb    = new ComboBox();
            lbl_info          = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock     = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name     = "panel1";
            panel1.Padding  = new Padding(0, 10, 0, 0);
            panel1.Size     = new Size(729, 477);
            panel1.TabIndex = 0;
            panel1.Tag      = "base";
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_sensitivity, 0, 0);
            tableLayoutPanel1.Controls.Add(sensitivity_cb,  1, 0);
            tableLayoutPanel1.Controls.Add(lbl_aggregation, 0, 1);
            tableLayoutPanel1.Controls.Add(aggregation_cb,  1, 1);
            tableLayoutPanel1.Controls.Add(lbl_info,        0, 2);
            tableLayoutPanel1.SetColumnSpan(lbl_info, 2);
            tableLayoutPanel1.Dock     = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin   = new Padding(0);
            tableLayoutPanel1.Name     = "tableLayoutPanel1";
            tableLayoutPanel1.Padding  = new Padding(0, 10, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size     = new Size(729, 467);
            tableLayoutPanel1.TabIndex = 0;
            //
            // lbl_sensitivity
            //
            lbl_sensitivity.AutoSize  = true;
            lbl_sensitivity.Dock      = DockStyle.Fill;
            lbl_sensitivity.Font      = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_sensitivity.ForeColor = Color.White;
            lbl_sensitivity.Margin    = new Padding(10, 0, 3, 0);
            lbl_sensitivity.Name      = "lbl_sensitivity";
            lbl_sensitivity.Text      = "Sensitivity Threshold";
            lbl_sensitivity.TextAlign = ContentAlignment.MiddleLeft;
            //
            // sensitivity_cb
            //
            sensitivity_cb.BackColor         = Color.FromArgb(54, 54, 54);
            sensitivity_cb.Dock              = DockStyle.Fill;
            sensitivity_cb.FlatStyle         = FlatStyle.Flat;
            sensitivity_cb.Font              = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            sensitivity_cb.ForeColor         = Color.White;
            sensitivity_cb.FormattingEnabled = true;
            sensitivity_cb.Margin            = new Padding(0, 10, 10, 10);
            sensitivity_cb.Name              = "sensitivity_cb";
            sensitivity_cb.TabIndex          = 0;
            sensitivity_cb.DropDownStyle     = ComboBoxStyle.DropDownList;
            //
            // lbl_aggregation
            //
            lbl_aggregation.AutoSize  = true;
            lbl_aggregation.Dock      = DockStyle.Fill;
            lbl_aggregation.Font      = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_aggregation.ForeColor = Color.White;
            lbl_aggregation.Margin    = new Padding(10, 0, 3, 0);
            lbl_aggregation.Name      = "lbl_aggregation";
            lbl_aggregation.Text      = "Aggregation Level";
            lbl_aggregation.TextAlign = ContentAlignment.MiddleLeft;
            //
            // aggregation_cb
            //
            aggregation_cb.BackColor         = Color.FromArgb(54, 54, 54);
            aggregation_cb.Dock              = DockStyle.Fill;
            aggregation_cb.FlatStyle         = FlatStyle.Flat;
            aggregation_cb.Font              = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            aggregation_cb.ForeColor         = Color.White;
            aggregation_cb.FormattingEnabled = true;
            aggregation_cb.Margin            = new Padding(0, 10, 10, 10);
            aggregation_cb.Name              = "aggregation_cb";
            aggregation_cb.TabIndex          = 1;
            aggregation_cb.DropDownStyle     = ComboBoxStyle.DropDownList;
            //
            // lbl_info
            //
            lbl_info.AutoSize  = false;
            lbl_info.Dock      = DockStyle.Fill;
            lbl_info.Font      = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lbl_info.ForeColor = Color.FromArgb(180, 180, 180);
            lbl_info.Margin    = new Padding(10, 10, 10, 0);
            lbl_info.Name      = "lbl_info";
            lbl_info.Text      = "Points outside the tolerance band  (mean ± N·σ)  are flagged as anomalies.\r\nLower σ = stricter detection (more false positives).\r\nHigher σ = only extreme deviations are flagged.";
            lbl_info.TextAlign = ContentAlignment.TopLeft;
            //
            // AnomalyDetection
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AnomalyDetection";
            Size = new Size(729, 477);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel            panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label            lbl_sensitivity;
        private ComboBox         sensitivity_cb;
        private Label            lbl_aggregation;
        private ComboBox         aggregation_cb;
        private Label            lbl_info;
    }
}
