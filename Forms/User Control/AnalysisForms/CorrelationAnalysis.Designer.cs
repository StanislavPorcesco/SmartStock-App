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
            range_lbl = new Label();
            factor_type_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            lag_nud = new NumericUpDown();
            label2 = new Label();
            interval_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lag_nud).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(751, 463);
            panel1.TabIndex = 2;
            panel1.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(factor_type_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(interval_cb, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(751, 453);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // range_lbl
            // 
            range_lbl.AutoSize = true;
            range_lbl.Dock = DockStyle.Fill;
            range_lbl.Font = new Font("Segoe UI", 10F);
            range_lbl.Location = new Point(10, 10);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(357, 50);
            range_lbl.TabIndex = 0;
            range_lbl.Tag = "muted";
            range_lbl.Text = "Primary Factor";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // factor_type_cb
            // 
            factor_type_cb.Dock = DockStyle.Fill;
            factor_type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            factor_type_cb.FlatStyle = FlatStyle.Flat;
            factor_type_cb.Font = new Font("Segoe UI", 11F);
            factor_type_cb.FormattingEnabled = true;
            factor_type_cb.Location = new Point(370, 15);
            factor_type_cb.Margin = new Padding(0, 5, 10, 10);
            factor_type_cb.Name = "factor_type_cb";
            factor_type_cb.Size = new Size(361, 33);
            factor_type_cb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(10, 60);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 58);
            label1.TabIndex = 1;
            label1.Tag = "muted";
            label1.Text = "Lag Effect";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lag_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(370, 70);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 30);
            panel2.TabIndex = 1;
            panel2.Tag = "card";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 0;
            label4.Tag = "muted";
            label4.Text = "Days";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lag_nud
            // 
            lag_nud.Dock = DockStyle.Right;
            lag_nud.Font = new Font("Segoe UI", 11F);
            lag_nud.Location = new Point(233, 0);
            lag_nud.Margin = new Padding(0, 10, 0, 0);
            lag_nud.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            lag_nud.Name = "lag_nud";
            lag_nud.Size = new Size(128, 32);
            lag_nud.TabIndex = 0;
            lag_nud.Tag = "range_lock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(10, 118);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 335);
            label2.TabIndex = 2;
            label2.Tag = "muted";
            label2.Text = "Aggregation Level";
            // 
            // interval_cb
            // 
            interval_cb.Dock = DockStyle.Fill;
            interval_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            interval_cb.FlatStyle = FlatStyle.Flat;
            interval_cb.Font = new Font("Segoe UI", 11F);
            interval_cb.FormattingEnabled = true;
            interval_cb.Location = new Point(370, 123);
            interval_cb.Margin = new Padding(0, 5, 10, 10);
            interval_cb.Name = "interval_cb";
            interval_cb.Size = new Size(361, 33);
            interval_cb.TabIndex = 2;
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
        private Label range_lbl;
        private SmartStock.Classes.Utils.ThemedComboBox factor_type_cb;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private NumericUpDown lag_nud;
        private Label label2;
        private SmartStock.Classes.Utils.ThemedComboBox interval_cb;
    }
}
