namespace SmartStock.Forms.User_Control.AnalysisForms
{
    partial class StockOptimization
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
            panel3 = new Panel();
            label3 = new Label();
            buffer_nud = new NumericUpDown();
            panel4 = new Panel();
            label_ordering_unit = new Label();
            ordering_cost_nud = new NumericUpDown();
            risk_cb = new ComboBox();
            panel2 = new Panel();
            label4 = new Label();
            delivery_days_nud = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label_ordering = new Label();
            range_lbl = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buffer_nud).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordering_cost_nud).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delivery_days_nud).BeginInit();
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
            panel1.Size = new Size(729, 477);
            panel1.TabIndex = 3;
            panel1.Tag = "base";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(range_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label_ordering, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(risk_cb, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 10, 0);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(729, 467);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(buffer_nud);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(359, 20);
            panel3.Margin = new Padding(0, 10, 10, 5);
            panel3.MaximumSize = new Size(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 27);
            panel3.TabIndex = 33;
            //
            // label3  (%/yr suffix for holding cost)
            //
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 21;
            label3.Text = "%/yr";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            //
            // panel4  (ordering cost row)
            //
            panel4.Controls.Add(label_ordering_unit);
            panel4.Controls.Add(ordering_cost_nud);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(359, 120);
            panel4.Margin = new Padding(0, 10, 10, 5);
            panel4.MaximumSize = new Size(0, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 27);
            panel4.TabIndex = 40;
            //
            // label_ordering_unit
            //
            label_ordering_unit.AutoSize = true;
            label_ordering_unit.Dock = DockStyle.Left;
            label_ordering_unit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label_ordering_unit.ForeColor = Color.White;
            label_ordering_unit.Location = new Point(0, 0);
            label_ordering_unit.Name = "label_ordering_unit";
            label_ordering_unit.Size = new Size(35, 25);
            label_ordering_unit.TabIndex = 22;
            label_ordering_unit.Text = "lei";
            label_ordering_unit.TextAlign = ContentAlignment.MiddleLeft;
            //
            // ordering_cost_nud
            //
            ordering_cost_nud.Dock = DockStyle.Right;
            ordering_cost_nud.Location = new Point(222, 0);
            ordering_cost_nud.DecimalPlaces = 2;
            ordering_cost_nud.Name = "ordering_cost_nud";
            ordering_cost_nud.Size = new Size(128, 27);
            ordering_cost_nud.TabIndex = 1;
            // 
            // buffer_nud
            // 
            buffer_nud.Dock = DockStyle.Right;
            buffer_nud.Location = new Point(222, 0);
            buffer_nud.Margin = new Padding(0, 10, 0, 0);
            buffer_nud.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            buffer_nud.Name = "buffer_nud";
            buffer_nud.Size = new Size(128, 27);
            buffer_nud.TabIndex = 0;
            // 
            // risk_cb
            // 
            risk_cb.BackColor = Color.FromArgb(54, 54, 54);
            risk_cb.Dock = DockStyle.Fill;
            risk_cb.FlatStyle = FlatStyle.Flat;
            risk_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            risk_cb.ForeColor = Color.White;
            risk_cb.FormattingEnabled = true;
            risk_cb.Location = new Point(359, 115);
            risk_cb.Margin = new Padding(0, 5, 10, 10);
            risk_cb.Name = "risk_cb";
            risk_cb.Size = new Size(350, 33);
            risk_cb.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(delivery_days_nud);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(359, 70);
            panel2.Margin = new Padding(0, 10, 10, 5);
            panel2.MaximumSize = new Size(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 27);
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
            // delivery_days_nud
            // 
            delivery_days_nud.Dock = DockStyle.Right;
            delivery_days_nud.Location = new Point(222, 0);
            delivery_days_nud.Margin = new Padding(0, 10, 0, 0);
            delivery_days_nud.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            delivery_days_nud.Name = "delivery_days_nud";
            delivery_days_nud.Size = new Size(128, 27);
            delivery_days_nud.TabIndex = 0;
            //
            // range_lbl  (row 0 — Holding Cost %)
            //
            range_lbl.AutoSize = true;
            range_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            range_lbl.ForeColor = Color.White;
            range_lbl.Location = new Point(10, 10);
            range_lbl.Margin = new Padding(10, 0, 3, 0);
            range_lbl.Name = "range_lbl";
            range_lbl.Size = new Size(140, 25);
            range_lbl.TabIndex = 24;
            range_lbl.Text = "Holding Cost (h)";
            range_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // label1  (row 1 — Lead Time)
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 60);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 27;
            label1.Text = "Lead Time";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            //
            // label_ordering  (row 2 — Ordering Cost)
            //
            label_ordering.AutoSize = true;
            label_ordering.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label_ordering.ForeColor = Color.White;
            label_ordering.Location = new Point(10, 110);
            label_ordering.Margin = new Padding(10, 0, 3, 0);
            label_ordering.Name = "label_ordering";
            label_ordering.Size = new Size(130, 25);
            label_ordering.TabIndex = 35;
            label_ordering.Text = "Ordering Cost (S)";
            label_ordering.TextAlign = ContentAlignment.MiddleLeft;
            //
            // label2  (row 3 — Risk Tolerance)
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 160);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 28;
            label2.Text = "Risk Tolerance";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StockOptimization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "StockOptimization";
            Size = new Size(729, 477);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buffer_nud).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordering_cost_nud).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delivery_days_nud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label label3;
        private NumericUpDown buffer_nud;
        private Panel panel4;
        private Label label_ordering_unit;
        private NumericUpDown ordering_cost_nud;
        private ComboBox risk_cb;
        private Panel panel2;
        private Label label4;
        private NumericUpDown delivery_days_nud;
        private Label label2;
        private Label label1;
        private Label label_ordering;
        private Label range_lbl;
    }
}
