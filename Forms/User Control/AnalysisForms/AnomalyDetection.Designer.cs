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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_sensitivity = new Label();
            sensitivity_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            lbl_aggregation = new Label();
            aggregation_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            lbl_info = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(729, 477);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_sensitivity, 0, 0);
            tableLayoutPanel1.Controls.Add(sensitivity_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_aggregation, 0, 1);
            tableLayoutPanel1.Controls.Add(aggregation_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_info, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(729, 467);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_sensitivity
            // 
            lbl_sensitivity.AutoSize = true;
            lbl_sensitivity.Dock = DockStyle.Fill;
            lbl_sensitivity.Font = new Font("Segoe UI", 10F);
            lbl_sensitivity.Location = new Point(10, 10);
            lbl_sensitivity.Margin = new Padding(10, 0, 3, 0);
            lbl_sensitivity.Name = "lbl_sensitivity";
            lbl_sensitivity.Size = new Size(346, 55);
            lbl_sensitivity.TabIndex = 0;
            lbl_sensitivity.Tag = "muted";
            lbl_sensitivity.Text = "Sensitivity Threshold";
            lbl_sensitivity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sensitivity_cb
            // 
            sensitivity_cb.Dock = DockStyle.Fill;
            sensitivity_cb.DrawMode = DrawMode.OwnerDrawFixed;
            sensitivity_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            sensitivity_cb.FlatStyle = FlatStyle.Flat;
            sensitivity_cb.Font = new Font("Segoe UI", 11F);
            sensitivity_cb.FormattingEnabled = true;
            sensitivity_cb.ItemHeight = 30;
            sensitivity_cb.Location = new Point(359, 20);
            sensitivity_cb.Margin = new Padding(0, 10, 10, 10);
            sensitivity_cb.Name = "sensitivity_cb";
            sensitivity_cb.Size = new Size(350, 36);
            sensitivity_cb.TabIndex = 0;
            // 
            // lbl_aggregation
            // 
            lbl_aggregation.AutoSize = true;
            lbl_aggregation.Dock = DockStyle.Fill;
            lbl_aggregation.Font = new Font("Segoe UI", 10F);
            lbl_aggregation.Location = new Point(10, 65);
            lbl_aggregation.Margin = new Padding(10, 0, 3, 0);
            lbl_aggregation.Name = "lbl_aggregation";
            lbl_aggregation.Size = new Size(346, 55);
            lbl_aggregation.TabIndex = 1;
            lbl_aggregation.Tag = "muted";
            lbl_aggregation.Text = "Aggregation Level";
            lbl_aggregation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // aggregation_cb
            // 
            aggregation_cb.Dock = DockStyle.Fill;
            aggregation_cb.DrawMode = DrawMode.OwnerDrawFixed;
            aggregation_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            aggregation_cb.FlatStyle = FlatStyle.Flat;
            aggregation_cb.Font = new Font("Segoe UI", 11F);
            aggregation_cb.FormattingEnabled = true;
            aggregation_cb.ItemHeight = 30;
            aggregation_cb.Location = new Point(359, 75);
            aggregation_cb.Margin = new Padding(0, 10, 10, 10);
            aggregation_cb.Name = "aggregation_cb";
            aggregation_cb.Size = new Size(350, 36);
            aggregation_cb.TabIndex = 1;
            // 
            // lbl_info
            // 
            tableLayoutPanel1.SetColumnSpan(lbl_info, 2);
            lbl_info.Dock = DockStyle.Fill;
            lbl_info.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lbl_info.Location = new Point(10, 130);
            lbl_info.Margin = new Padding(10, 10, 10, 0);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(699, 337);
            lbl_info.TabIndex = 2;
            lbl_info.Tag = "muted";
            lbl_info.Text = "Points outside the tolerance band  (mean ± N·σ)  are flagged as anomalies.\r\nLower σ = stricter detection (more false positives).\r\nHigher σ = only extreme deviations are flagged.\r\n\nStrict (1.5σ) - more anomalies\r\nStandard (2.0σ) - balanced\r\nRelaxed (2.5σ) - fewer anomalies\r\nConservative (3.0σ) - only extremes";
            // 
            // AnomalyDetection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AnomalyDetection";
            Size = new Size(729, 477);
            Tag = "card";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_sensitivity;
        private SmartStock.Classes.Utils.ThemedComboBox sensitivity_cb;
        private Label lbl_aggregation;
        private SmartStock.Classes.Utils.ThemedComboBox aggregation_cb;
        private Label lbl_info;
    }
}
