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
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            query_tb = new TextBox();
            base_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(tableLayoutPanel1);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(5);
            base_pnl.Size = new Size(962, 641);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.Size = new Size(952, 631);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(946, 42);
            label1.TabIndex = 0;
            label1.Tag = "muted";
            label1.Text = "Describe your query in natural language:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(0, 42);
            border_theme_pnl.Margin = new Padding(0);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(952, 589);
            border_theme_pnl.TabIndex = 7;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(950, 587);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(query_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(950, 587);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // query_tb
            // 
            query_tb.AcceptsReturn = true;
            query_tb.Dock = DockStyle.Fill;
            query_tb.Font = new Font("Segoe UI", 11F);
            query_tb.Location = new Point(3, 3);
            query_tb.Multiline = true;
            query_tb.Name = "query_tb";
            query_tb.ScrollBars = ScrollBars.Vertical;
            query_tb.Size = new Size(944, 581);
            query_tb.TabIndex = 1;
            query_tb.Tag = "flat";
            // 
            // LanguageQuery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "LanguageQuery";
            Size = new Size(962, 641);
            base_pnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox query_tb;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
