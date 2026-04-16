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
            transaction_id = new Label();
            search_row = new Panel();
            customer_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            full_name_tb = new TextBox();
            label3 = new Label();
            city_tb = new TextBox();
            label2 = new Label();
            phone_tb = new TextBox();
            logs_lbl = new Label();
            email_tb = new TextBox();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            search_row.SuspendLayout();
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
            base_pnl.Tag = "base";
            //
            // fields_table
            //
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(transaction_id, 0, 0);
            fields_table.Controls.Add(search_row, 1, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(full_name_tb, 1, 1);
            fields_table.Controls.Add(label3, 0, 2);
            fields_table.Controls.Add(city_tb, 1, 2);
            fields_table.Controls.Add(label2, 0, 3);
            fields_table.Controls.Add(phone_tb, 1, 3);
            fields_table.Controls.Add(logs_lbl, 0, 4);
            fields_table.Controls.Add(email_tb, 1, 4);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 5;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.Size = new Size(851, 260);
            fields_table.TabIndex = 0;
            //
            // transaction_id
            //
            transaction_id.Dock = DockStyle.Fill;
            transaction_id.Font = new Font("Segoe UI", 10F);
            transaction_id.Location = new Point(0, 0);
            transaction_id.Margin = new Padding(0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(160, 52);
            transaction_id.TabIndex = 0;
            transaction_id.Tag = "muted";
            transaction_id.Text = "Customer ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            //
            // search_row
            //
            search_row.Controls.Add(customer_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(163, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(685, 46);
            search_row.TabIndex = 1;
            //
            // customer_id_tb
            //
            customer_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customer_id_tb.Font = new Font("Segoe UI", 11F);
            customer_id_tb.Location = new Point(0, 8);
            customer_id_tb.Margin = new Padding(0);
            customer_id_tb.Name = "customer_id_tb";
            customer_id_tb.Size = new Size(533, 32);
            customer_id_tb.TabIndex = 0;
            customer_id_tb.Tag = "flat";
            //
            // search_btn
            //
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.FlatAppearance.BorderSize = 1;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.MagnifyingGlass;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(545, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(140, 38);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            //
            // db_lbl
            //
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 52);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(160, 52);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Full Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // full_name_tb
            //
            full_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            full_name_tb.Font = new Font("Segoe UI", 11F);
            full_name_tb.Location = new Point(163, 62);
            full_name_tb.Margin = new Padding(3, 5, 3, 5);
            full_name_tb.Name = "full_name_tb";
            full_name_tb.Size = new Size(685, 32);
            full_name_tb.TabIndex = 3;
            full_name_tb.Tag = "flat";
            //
            // label3
            //
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 104);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 52);
            label3.TabIndex = 4;
            label3.Tag = "muted";
            label3.Text = "City";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            //
            // city_tb
            //
            city_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            city_tb.Font = new Font("Segoe UI", 11F);
            city_tb.Location = new Point(163, 114);
            city_tb.Margin = new Padding(3, 5, 3, 5);
            city_tb.Name = "city_tb";
            city_tb.Size = new Size(685, 32);
            city_tb.TabIndex = 5;
            city_tb.Tag = "flat";
            //
            // label2
            //
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 156);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 52);
            label2.TabIndex = 6;
            label2.Tag = "muted";
            label2.Text = "Phone";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            //
            // phone_tb
            //
            phone_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phone_tb.Font = new Font("Segoe UI", 11F);
            phone_tb.Location = new Point(163, 166);
            phone_tb.Margin = new Padding(3, 5, 3, 5);
            phone_tb.Name = "phone_tb";
            phone_tb.Size = new Size(685, 32);
            phone_tb.TabIndex = 7;
            phone_tb.Tag = "flat";
            //
            // logs_lbl
            //
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 208);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 52);
            logs_lbl.TabIndex = 8;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Email";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // email_tb
            //
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.Font = new Font("Segoe UI", 11F);
            email_tb.Location = new Point(163, 218);
            email_tb.Margin = new Padding(3, 5, 3, 5);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(685, 32);
            email_tb.TabIndex = 9;
            email_tb.Tag = "flat";
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
            fields_table.PerformLayout();
            search_row.ResumeLayout(false);
            search_row.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label transaction_id;
        private Panel search_row;
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
    }
}
