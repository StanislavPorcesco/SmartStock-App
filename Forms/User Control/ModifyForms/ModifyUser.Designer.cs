using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class ModifyUser
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
            label5 = new Label();
            search_row = new Panel();
            user_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            username_tb = new TextBox();
            label2 = new Label();
            fullname_tb = new TextBox();
            logs_lbl = new Label();
            password_tb = new TextBox();
            label4 = new Label();
            email_tb = new TextBox();
            label3 = new Label();
            role_cb = new ComboBox();
            label7 = new Label();
            is_active_ck = new CheckBox();
            label8 = new Label();
            failed_count_tb = new TextBox();
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
            base_pnl.Tag = "card";
            // 
            // fields_table
            // 
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(label5, 0, 0);
            fields_table.Controls.Add(search_row, 1, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(username_tb, 1, 1);
            fields_table.Controls.Add(label2, 0, 2);
            fields_table.Controls.Add(fullname_tb, 1, 2);
            fields_table.Controls.Add(logs_lbl, 0, 3);
            fields_table.Controls.Add(password_tb, 1, 3);
            fields_table.Controls.Add(label4, 0, 4);
            fields_table.Controls.Add(email_tb, 1, 4);
            fields_table.Controls.Add(label3, 0, 5);
            fields_table.Controls.Add(role_cb, 1, 5);
            fields_table.Controls.Add(label7, 0, 6);
            fields_table.Controls.Add(is_active_ck, 1, 6);
            fields_table.Controls.Add(label8, 0, 7);
            fields_table.Controls.Add(failed_count_tb, 1, 7);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 8;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.Size = new Size(851, 416);
            fields_table.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(160, 52);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "User ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_row
            // 
            search_row.Controls.Add(user_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(163, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(685, 46);
            search_row.TabIndex = 1;
            search_row.Tag = "card";
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(0, 8);
            user_id_tb.Margin = new Padding(0);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(533, 32);
            user_id_tb.TabIndex = 0;
            user_id_tb.Tag = "";
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
            db_lbl.Text = "Username";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.Font = new Font("Segoe UI", 11F);
            username_tb.Location = new Point(163, 62);
            username_tb.Margin = new Padding(3, 5, 3, 5);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(685, 32);
            username_tb.TabIndex = 3;
            username_tb.Tag = "";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 104);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 52);
            label2.TabIndex = 4;
            label2.Tag = "muted";
            label2.Text = "Full Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.Font = new Font("Segoe UI", 11F);
            fullname_tb.Location = new Point(163, 114);
            fullname_tb.Margin = new Padding(3, 5, 3, 5);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(685, 32);
            fullname_tb.TabIndex = 5;
            fullname_tb.Tag = "";
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 156);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 52);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "New Password";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.Font = new Font("Segoe UI", 11F);
            password_tb.Location = new Point(163, 166);
            password_tb.Margin = new Padding(3, 5, 3, 5);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(685, 32);
            password_tb.TabIndex = 7;
            password_tb.Tag = "";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 208);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(160, 52);
            label4.TabIndex = 8;
            label4.Tag = "muted";
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            email_tb.Tag = "";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 260);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 52);
            label3.TabIndex = 10;
            label3.Tag = "muted";
            label3.Text = "Role";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // role_cb
            // 
            role_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            role_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            role_cb.FlatStyle = FlatStyle.Flat;
            role_cb.Font = new Font("Segoe UI", 11F);
            role_cb.FormattingEnabled = true;
            role_cb.Location = new Point(163, 269);
            role_cb.Margin = new Padding(3, 5, 3, 5);
            role_cb.Name = "role_cb";
            role_cb.Size = new Size(685, 33);
            role_cb.TabIndex = 11;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 312);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(160, 52);
            label7.TabIndex = 12;
            label7.Tag = "muted";
            label7.Text = "Is Active";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // is_active_ck
            // 
            is_active_ck.AutoSize = true;
            is_active_ck.CheckAlign = ContentAlignment.MiddleRight;
            is_active_ck.Dock = DockStyle.Fill;
            is_active_ck.Location = new Point(163, 317);
            is_active_ck.Margin = new Padding(3, 5, 3, 5);
            is_active_ck.Name = "is_active_ck";
            is_active_ck.Size = new Size(685, 42);
            is_active_ck.TabIndex = 13;
            is_active_ck.Text = "On / Off";
            is_active_ck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 364);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(160, 52);
            label8.TabIndex = 14;
            label8.Tag = "muted";
            label8.Text = "Failed Count";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // failed_count_tb
            // 
            failed_count_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            failed_count_tb.Font = new Font("Segoe UI", 11F);
            failed_count_tb.Location = new Point(163, 374);
            failed_count_tb.Margin = new Padding(3, 5, 3, 5);
            failed_count_tb.Name = "failed_count_tb";
            failed_count_tb.Size = new Size(685, 32);
            failed_count_tb.TabIndex = 15;
            failed_count_tb.Tag = "";
            // 
            // ModifyUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyUser";
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
        private Label label5;
        private Panel search_row;
        private TextBox user_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox username_tb;
        private Label label2;
        private TextBox fullname_tb;
        private Label logs_lbl;
        private TextBox password_tb;
        private Label label4;
        private TextBox email_tb;
        private Label label3;
        private ComboBox role_cb;
        private Label label7;
        private CheckBox is_active_ck;
        private Label label8;
        private TextBox failed_count_tb;
    }
}
