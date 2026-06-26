using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class ModifyCustomer
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
            base_pnl = new Panel();
            fields_table = new TableLayoutPanel();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            email_tb = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            phone_tb = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            city_tb = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            full_name_tb = new TextBox();
            transaction_id = new Label();
            db_lbl = new Label();
            label3 = new Label();
            label2 = new Label();
            logs_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            customer_id_tb = new TextBox();
            search_btn = new IconButton();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(fields_table);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(28, 24, 28, 24);
            base_pnl.Size = new Size(907, 572);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "card";
            // 
            // fields_table
            // 
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(panel7, 1, 4);
            fields_table.Controls.Add(panel5, 1, 3);
            fields_table.Controls.Add(panel3, 1, 2);
            fields_table.Controls.Add(panel1, 1, 1);
            fields_table.Controls.Add(transaction_id, 0, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(label3, 0, 2);
            fields_table.Controls.Add(label2, 0, 3);
            fields_table.Controls.Add(logs_lbl, 0, 4);
            fields_table.Controls.Add(tableLayoutPanel1, 1, 0);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 5;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fields_table.Size = new Size(851, 271);
            fields_table.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(166, 226);
            panel7.Margin = new Padding(6, 10, 0, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(685, 35);
            panel7.TabIndex = 14;
            panel7.Tag = "border_pnl";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(683, 33);
            panel8.TabIndex = 0;
            panel8.Tag = "card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(email_tb, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(683, 33);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.Font = new Font("Segoe UI", 11F);
            email_tb.Location = new Point(15, 0);
            email_tb.Margin = new Padding(0);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(653, 32);
            email_tb.TabIndex = 9;
            email_tb.Tag = "borderless";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(166, 172);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(685, 34);
            panel5.TabIndex = 13;
            panel5.Tag = "border_pnl";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(683, 32);
            panel6.TabIndex = 0;
            panel6.Tag = "card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(phone_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(683, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // phone_tb
            // 
            phone_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phone_tb.Font = new Font("Segoe UI", 11F);
            phone_tb.Location = new Point(15, 0);
            phone_tb.Margin = new Padding(0);
            phone_tb.Name = "phone_tb";
            phone_tb.Size = new Size(653, 32);
            phone_tb.TabIndex = 7;
            phone_tb.Tag = "borderless";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(166, 118);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(685, 34);
            panel3.TabIndex = 12;
            panel3.Tag = "border_pnl";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 32);
            panel4.TabIndex = 0;
            panel4.Tag = "card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(city_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(683, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // city_tb
            // 
            city_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            city_tb.Font = new Font("Segoe UI", 11F);
            city_tb.Location = new Point(15, 0);
            city_tb.Margin = new Padding(0);
            city_tb.Name = "city_tb";
            city_tb.Size = new Size(653, 32);
            city_tb.TabIndex = 5;
            city_tb.Tag = "borderless";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(166, 64);
            panel1.Margin = new Padding(6, 10, 0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(685, 34);
            panel1.TabIndex = 11;
            panel1.Tag = "border_pnl";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 32);
            panel2.TabIndex = 0;
            panel2.Tag = "card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(full_name_tb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(683, 32);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // full_name_tb
            // 
            full_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            full_name_tb.Font = new Font("Segoe UI", 11F);
            full_name_tb.Location = new Point(15, 0);
            full_name_tb.Margin = new Padding(0);
            full_name_tb.Name = "full_name_tb";
            full_name_tb.Size = new Size(653, 32);
            full_name_tb.TabIndex = 3;
            full_name_tb.Tag = "borderless";
            // 
            // transaction_id
            // 
            transaction_id.Dock = DockStyle.Fill;
            transaction_id.Font = new Font("Segoe UI", 10F);
            transaction_id.Location = new Point(0, 0);
            transaction_id.Margin = new Padding(0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(160, 54);
            transaction_id.TabIndex = 0;
            transaction_id.Tag = "muted";
            transaction_id.Text = "Customer ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 54);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(160, 54);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Full Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 108);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 54);
            label3.TabIndex = 4;
            label3.Tag = "muted";
            label3.Text = "City";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 162);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 54);
            label2.TabIndex = 6;
            label2.Tag = "muted";
            label2.Text = "Phone";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 216);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 55);
            logs_lbl.TabIndex = 8;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Email";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 0, 0);
            tableLayoutPanel1.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(160, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(691, 54);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(6, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(575, 34);
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
            container_theme_pnl.Size = new Size(573, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(customer_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(15, 0, 15, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(573, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // customer_id_tb
            // 
            customer_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.Font = new Font("Segoe UI", 11F);
            customer_id_tb.Location = new Point(15, 0);
            customer_id_tb.Margin = new Padding(0);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(543, 32);
            customer_id_tb.TabIndex = 0;
            customer_id_tb.Tag = "borderless";
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.Search;
            search_btn.IconColor = Color.Black;
            search_btn.IconFont = IconFont.Auto;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(591, 10);
            search_btn.Margin = new Padding(10, 10, 0, 10);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(100, 34);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // ModifyCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyCustomer";
            Size = new Size(907, 572);
            base_pnl.ResumeLayout(false);
            fields_table.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label transaction_id;
        private TextBox customer_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox full_name_tb;
        private Label label3;
        private TextBox city_tb;
        private Label label2;
        private TextBox phone_tb;
        private Label logs_lbl;
        private TextBox email_tb;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
