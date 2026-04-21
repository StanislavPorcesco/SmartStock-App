namespace SmartStock.Forms.User_Control.AnalysisForms
{
    partial class LanguageQuery
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
            base_pnl = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            query_tb = new TextBox();
            base_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(tableLayoutPanel1);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(5);
            base_pnl.Size = new Size(451, 323);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(query_tb, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(441, 313);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(435, 42);
            label1.TabIndex = 0;
            label1.Tag = "muted";
            label1.Text = "Describe your query in natural language:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // query_tb
            // 
            query_tb.AcceptsReturn = true;
            query_tb.Dock = DockStyle.Fill;
            query_tb.Font = new Font("Segoe UI", 11F);
            query_tb.Location = new Point(3, 45);
            query_tb.Multiline = true;
            query_tb.Name = "query_tb";
            query_tb.ScrollBars = ScrollBars.Vertical;
            query_tb.Size = new Size(435, 265);
            query_tb.TabIndex = 1;
            query_tb.Tag = "flat";
            // 
            // LanguageQuery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "LanguageQuery";
            Size = new Size(451, 323);
            base_pnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox query_tb;
    }
}
