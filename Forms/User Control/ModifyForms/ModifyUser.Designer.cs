using SmartStock.Classes.Utils;
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
            add_btn = new Button();
            margin_pnl = new Panel();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            is_active_ck = new CheckBox();
            label5 = new Label();
            db_lbl = new Label();
            password_tb = new TextBox();
            fullname_tb = new TextBox();
            username_tb = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            failed_count_tb = new TextBox();
            logs_lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            email_tb = new TextBox();
            role_selector_cb = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            search_btn = new Button();
            user_id_tb = new TextBox();
            selector_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            selector_cb = new ComboBox();
            label1 = new Label();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            selector_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(add_btn);
            base_pnl.Controls.Add(margin_pnl);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1299, 717);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(54, 54, 54);
            add_btn.Dock = DockStyle.Bottom;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(20, 627);
            add_btn.Margin = new Padding(0);
            add_btn.MaximumSize = new Size(0, 70);
            add_btn.MinimumSize = new Size(0, 70);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(1259, 70);
            add_btn.TabIndex = 0;
            add_btn.Text = "Apply Changes";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // margin_pnl
            // 
            margin_pnl.BackColor = Color.Transparent;
            margin_pnl.Dock = DockStyle.Top;
            margin_pnl.Location = new Point(20, 559);
            margin_pnl.MaximumSize = new Size(0, 20);
            margin_pnl.MinimumSize = new Size(0, 20);
            margin_pnl.Name = "margin_pnl";
            margin_pnl.Size = new Size(1259, 20);
            margin_pnl.TabIndex = 9;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 150);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1259, 409);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(1239, 389);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Product";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(is_active_ck, 1, 6);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(password_tb, 1, 3);
            tableLayoutPanel2.Controls.Add(fullname_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(username_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(label8, 0, 7);
            tableLayoutPanel2.Controls.Add(failed_count_tb, 1, 7);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(email_tb, 1, 4);
            tableLayoutPanel2.Controls.Add(role_selector_cb, 1, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1219, 329);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // is_active_ck
            // 
            is_active_ck.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            is_active_ck.AutoSize = true;
            is_active_ck.CheckAlign = ContentAlignment.MiddleRight;
            is_active_ck.ImageAlign = ContentAlignment.MiddleRight;
            is_active_ck.Location = new Point(608, 262);
            is_active_ck.Margin = new Padding(0, 10, 10, 10);
            is_active_ck.Name = "is_active_ck";
            is_active_ck.Size = new Size(601, 17);
            is_active_ck.TabIndex = 31;
            is_active_ck.TextAlign = ContentAlignment.MiddleRight;
            is_active_ck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 45);
            label5.TabIndex = 25;
            label5.Text = "User ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 45);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(97, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Username";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.BackColor = Color.FromArgb(54, 54, 54);
            password_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            password_tb.ForeColor = Color.White;
            password_tb.Location = new Point(608, 132);
            password_tb.Margin = new Padding(0, 5, 0, 5);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(611, 31);
            password_tb.TabIndex = 15;
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.BackColor = Color.FromArgb(54, 54, 54);
            fullname_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            fullname_tb.ForeColor = Color.White;
            fullname_tb.Location = new Point(608, 91);
            fullname_tb.Margin = new Padding(0, 5, 0, 5);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(611, 31);
            fullname_tb.TabIndex = 24;
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.BackColor = Color.FromArgb(54, 54, 54);
            username_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            username_tb.ForeColor = Color.White;
            username_tb.Location = new Point(608, 50);
            username_tb.Margin = new Padding(0, 5, 0, 5);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(611, 31);
            username_tb.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 14;
            label2.Text = "Full Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(3, 252);
            label7.Name = "label7";
            label7.Size = new Size(85, 37);
            label7.TabIndex = 28;
            label7.Text = "Is Active";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(3, 289);
            label8.Name = "label8";
            label8.Size = new Size(117, 41);
            label8.TabIndex = 29;
            label8.Text = "Failed Count";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // failed_count_tb
            // 
            failed_count_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            failed_count_tb.BackColor = Color.FromArgb(54, 54, 54);
            failed_count_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            failed_count_tb.ForeColor = Color.White;
            failed_count_tb.Location = new Point(608, 294);
            failed_count_tb.Margin = new Padding(0, 5, 0, 5);
            failed_count_tb.Name = "failed_count_tb";
            failed_count_tb.Size = new Size(611, 31);
            failed_count_tb.TabIndex = 30;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 127);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(126, 41);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "New Password";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 209);
            label3.Name = "label3";
            label3.Size = new Size(45, 43);
            label3.TabIndex = 16;
            label3.Text = "Role";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 41);
            label4.TabIndex = 18;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_tb.ForeColor = Color.White;
            email_tb.Location = new Point(608, 173);
            email_tb.Margin = new Padding(0, 5, 0, 5);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(611, 31);
            email_tb.TabIndex = 19;
            // 
            // role_selector_cb
            // 
            role_selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            role_selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            role_selector_cb.FlatStyle = FlatStyle.Flat;
            role_selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            role_selector_cb.ForeColor = Color.White;
            role_selector_cb.FormattingEnabled = true;
            role_selector_cb.Location = new Point(608, 214);
            role_selector_cb.Margin = new Padding(0, 5, 0, 5);
            role_selector_cb.Name = "role_selector_cb";
            role_selector_cb.Size = new Size(611, 33);
            role_selector_cb.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel3.Controls.Add(user_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(611, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(605, 39);
            tableLayoutPanel3.TabIndex = 32;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(54, 54, 54);
            search_btn.Dock = DockStyle.Fill;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(312, 4);
            search_btn.Margin = new Padding(10, 4, 0, 0);
            search_btn.MaximumSize = new Size(0, 34);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(293, 34);
            search_btn.TabIndex = 27;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // user_id_tb
            // 
            user_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            user_id_tb.Dock = DockStyle.Fill;
            user_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_id_tb.ForeColor = Color.White;
            user_id_tb.Location = new Point(0, 5);
            user_id_tb.Margin = new Padding(0, 5, 10, 5);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(292, 31);
            user_id_tb.TabIndex = 26;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(groupBox1);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(1259, 130);
            selector_pnl.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 20, 10, 20);
            groupBox1.Size = new Size(1239, 110);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instance selector";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(selector_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1219, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // selector_cb
            // 
            selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            selector_cb.ForeColor = Color.White;
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(609, 8);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(610, 33);
            selector_cb.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(603, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the desired instance";
            // 
            // ModifyUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyUser";
            Size = new Size(1299, 717);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            selector_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Button add_btn;
        private Panel margin_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox password_tb;
        private Label label2;
        private Label db_lbl;
        private TextBox username_tb;
        private Label logs_lbl;
        private Panel selector_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selector_cb;
        private Label label1;
        private ComboBox role_selector_cb;
        private TextBox fullname_tb;
        private TextBox email_tb;
        private Label label4;
        private Label label5;
        private TextBox user_id_tb;
        private Label label7;
        private Label label8;
        private TextBox failed_count_tb;
        private CheckBox is_active_ck;
        private Button search_btn;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
