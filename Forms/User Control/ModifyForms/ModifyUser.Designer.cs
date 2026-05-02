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
            role_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label7 = new Label();
            is_active_ck = new CheckBox();
            label8 = new Label();
            failed_count_tb = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel9 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
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
            fields_table.Controls.Add(panel9, 1, 7);
            fields_table.Controls.Add(panel7, 1, 4);
            fields_table.Controls.Add(panel5, 1, 3);
            fields_table.Controls.Add(panel3, 1, 2);
            fields_table.Controls.Add(panel1, 1, 1);
            fields_table.Controls.Add(label5, 0, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(label2, 0, 2);
            fields_table.Controls.Add(logs_lbl, 0, 3);
            fields_table.Controls.Add(label4, 0, 4);
            fields_table.Controls.Add(label3, 0, 5);
            fields_table.Controls.Add(role_cb, 1, 5);
            fields_table.Controls.Add(label7, 0, 6);
            fields_table.Controls.Add(is_active_ck, 1, 6);
            fields_table.Controls.Add(label8, 0, 7);
            fields_table.Controls.Add(tableLayoutPanel1, 1, 0);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 8;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.Size = new Size(851, 431);
            fields_table.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(160, 54);
            label5.TabIndex = 0;
            label5.Tag = "muted";
            label5.Text = "User ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(0, 0);
            user_id_tb.Margin = new Padding(0);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(573, 32);
            user_id_tb.TabIndex = 0;
            user_id_tb.Tag = "borderless";
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
            search_btn.Location = new Point(587, 10);
            search_btn.Margin = new Padding(6, 10, 0, 10);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(104, 34);
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
            db_lbl.Location = new Point(0, 54);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(160, 54);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Username";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.Font = new Font("Segoe UI", 11F);
            username_tb.Location = new Point(0, 0);
            username_tb.Margin = new Padding(0);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(683, 32);
            username_tb.TabIndex = 3;
            username_tb.Tag = "borderless";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 108);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 54);
            label2.TabIndex = 4;
            label2.Tag = "muted";
            label2.Text = "Full Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.Font = new Font("Segoe UI", 11F);
            fullname_tb.Location = new Point(0, 0);
            fullname_tb.Margin = new Padding(0);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(683, 32);
            fullname_tb.TabIndex = 5;
            fullname_tb.Tag = "borderless";
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 162);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 54);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "New Password";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.Font = new Font("Segoe UI", 11F);
            password_tb.Location = new Point(0, 0);
            password_tb.Margin = new Padding(0);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(683, 32);
            password_tb.TabIndex = 7;
            password_tb.Tag = "borderless";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 216);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(160, 54);
            label4.TabIndex = 8;
            label4.Tag = "muted";
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.Font = new Font("Segoe UI", 11F);
            email_tb.Location = new Point(0, 0);
            email_tb.Margin = new Padding(0);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(683, 32);
            email_tb.TabIndex = 9;
            email_tb.Tag = "borderless";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 270);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 54);
            label3.TabIndex = 10;
            label3.Tag = "muted";
            label3.Text = "Role";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // role_cb
            // 
            role_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            role_cb.DrawMode = DrawMode.OwnerDrawFixed;
            role_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            role_cb.FlatStyle = FlatStyle.Flat;
            role_cb.Font = new Font("Segoe UI", 11F);
            role_cb.FormattingEnabled = true;
            role_cb.ItemHeight = 30;
            role_cb.Location = new Point(163, 279);
            role_cb.Margin = new Padding(3, 5, 3, 5);
            role_cb.Name = "role_cb";
            role_cb.Size = new Size(685, 36);
            role_cb.TabIndex = 11;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 324);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(160, 54);
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
            is_active_ck.Location = new Point(163, 329);
            is_active_ck.Margin = new Padding(3, 5, 3, 5);
            is_active_ck.Name = "is_active_ck";
            is_active_ck.Size = new Size(685, 44);
            is_active_ck.TabIndex = 13;
            is_active_ck.Text = "On / Off";
            is_active_ck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 378);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(160, 54);
            label8.TabIndex = 14;
            label8.Tag = "muted";
            label8.Text = "Failed Count";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // failed_count_tb
            // 
            failed_count_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            failed_count_tb.Font = new Font("Segoe UI", 11F);
            failed_count_tb.Location = new Point(0, 0);
            failed_count_tb.Margin = new Padding(0);
            failed_count_tb.Name = "failed_count_tb";
            failed_count_tb.Size = new Size(683, 32);
            failed_count_tb.TabIndex = 15;
            failed_count_tb.Tag = "borderless";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(160, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(691, 54);
            tableLayoutPanel1.TabIndex = 16;
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
            border_theme_pnl.TabIndex = 9;
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
            tableLayoutPanel6.Controls.Add(user_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(573, 32);
            tableLayoutPanel6.TabIndex = 0;
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
            panel1.TabIndex = 17;
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
            tableLayoutPanel2.Controls.Add(username_tb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(683, 32);
            tableLayoutPanel2.TabIndex = 0;
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
            panel3.TabIndex = 18;
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
            tableLayoutPanel3.Controls.Add(fullname_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(683, 32);
            tableLayoutPanel3.TabIndex = 0;
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
            panel5.TabIndex = 19;
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
            tableLayoutPanel4.Controls.Add(password_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(683, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(166, 226);
            panel7.Margin = new Padding(6, 10, 0, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(685, 34);
            panel7.TabIndex = 20;
            panel7.Tag = "border_pnl";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(683, 32);
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
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(683, 32);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(166, 388);
            panel9.Margin = new Padding(6, 10, 0, 10);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(1);
            panel9.Size = new Size(685, 34);
            panel9.TabIndex = 21;
            panel9.Tag = "border_pnl";
            // 
            // panel10
            // 
            panel10.Controls.Add(tableLayoutPanel7);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1, 1);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(683, 32);
            panel10.TabIndex = 0;
            panel10.Tag = "card";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(failed_count_tb, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(683, 32);
            tableLayoutPanel7.TabIndex = 0;
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
            tableLayoutPanel1.ResumeLayout(false);
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label label5;
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
        private SmartStock.Classes.Utils.ThemedComboBox role_cb;
        private Label label7;
        private CheckBox is_active_ck;
        private Label label8;
        private TextBox failed_count_tb;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel9;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel7;
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
    }
}
