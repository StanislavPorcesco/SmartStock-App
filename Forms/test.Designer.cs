namespace SmartStock.Forms
{
    partial class test
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
            panel1 = new Panel();
            shell_table = new TableLayoutPanel();
            base_pnl = new Panel();
            container = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            shell_table.SuspendLayout();
            base_pnl.SuspendLayout();
            container.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(shell_table);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(40, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 395);
            panel1.TabIndex = 0;
            panel1.Tag = "base";
            // 
            // shell_table
            // 
            shell_table.ColumnCount = 2;
            shell_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shell_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shell_table.Controls.Add(base_pnl, 1, 0);
            shell_table.Dock = DockStyle.Fill;
            shell_table.Location = new Point(0, 0);
            shell_table.Margin = new Padding(0);
            shell_table.Name = "shell_table";
            shell_table.RowCount = 4;
            shell_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            shell_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            shell_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            shell_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            shell_table.Size = new Size(756, 395);
            shell_table.TabIndex = 0;
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(container);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(378, 10);
            base_pnl.Margin = new Padding(0, 10, 0, 10);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(1);
            base_pnl.Size = new Size(378, 36);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "border_pnl";
            // 
            // container
            // 
            container.Controls.Add(tableLayoutPanel1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(1, 1);
            container.Margin = new Padding(0);
            container.Name = "container";
            container.Size = new Size(376, 34);
            container.TabIndex = 0;
            container.Tag = "card";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(376, 34);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 27);
            textBox1.TabIndex = 0;
            textBox1.Tag = "borderless";
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 475);
            Controls.Add(panel1);
            Name = "test";
            Padding = new Padding(40);
            Text = "test";
            panel1.ResumeLayout(false);
            shell_table.ResumeLayout(false);
            base_pnl.ResumeLayout(false);
            container.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel shell_table;
        private Panel base_pnl;
        private Panel container;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
    }
}