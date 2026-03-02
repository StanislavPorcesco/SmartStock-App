namespace SmartStock.Forms.AddForms
{
    partial class AddAccount
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
            panel1 = new Panel();
            create_btn = new Button();
            return_btn = new Button();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            fullname_tb = new TextBox();
            label3 = new Label();
            settings_lbl = new Label();
            db_lbl = new Label();
            password_tb = new TextBox();
            username_tb = new TextBox();
            label1 = new Label();
            email_tb = new TextBox();
            selector_pnl = new Panel();
            label2 = new Label();
            base_pnl.SuspendLayout();
            panel1.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            selector_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(panel1);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(572, 427);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // panel1
            // 
            panel1.Controls.Add(create_btn);
            panel1.Controls.Add(return_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 337);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(532, 70);
            panel1.TabIndex = 16;
            // 
            // create_btn
            // 
            create_btn.BackColor = Color.FromArgb(54, 54, 54);
            create_btn.Dock = DockStyle.Right;
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_btn.ForeColor = Color.White;
            create_btn.Location = new Point(322, 0);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(200, 70);
            create_btn.TabIndex = 5;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.FromArgb(54, 54, 54);
            return_btn.Dock = DockStyle.Left;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            return_btn.ForeColor = Color.White;
            return_btn.Location = new Point(10, 0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(200, 70);
            return_btn.TabIndex = 6;
            return_btn.Text = "Return";
            return_btn.UseVisualStyleBackColor = false;
            return_btn.Click += return_btn_Click;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 95);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(532, 225);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(512, 205);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "New Account";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(fullname_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(password_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(username_tb, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 3);
            tableLayoutPanel2.Controls.Add(email_tb, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 34);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(492, 161);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.BackColor = Color.FromArgb(54, 54, 54);
            fullname_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            fullname_tb.ForeColor = Color.White;
            fullname_tb.Location = new Point(245, 87);
            fullname_tb.Margin = new Padding(0, 5, 0, 5);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(247, 31);
            fullname_tb.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(97, 41);
            label3.TabIndex = 15;
            label3.Text = "Full Name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(97, 41);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Username";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 41);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(92, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Password";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.BackColor = Color.FromArgb(54, 54, 54);
            password_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            password_tb.ForeColor = Color.White;
            password_tb.Location = new Point(245, 46);
            password_tb.Margin = new Padding(0, 5, 0, 5);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(247, 31);
            password_tb.TabIndex = 2;
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.BackColor = Color.FromArgb(54, 54, 54);
            username_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            username_tb.ForeColor = Color.White;
            username_tb.Location = new Point(245, 5);
            username_tb.Margin = new Padding(0, 5, 0, 5);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(247, 31);
            username_tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(3, 123);
            label1.Name = "label1";
            label1.Size = new Size(58, 41);
            label1.TabIndex = 13;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_tb.ForeColor = Color.White;
            email_tb.Location = new Point(245, 128);
            email_tb.Margin = new Padding(0, 5, 0, 5);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(247, 31);
            email_tb.TabIndex = 4;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(label2);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(532, 75);
            selector_pnl.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(512, 55);
            label2.TabIndex = 8;
            label2.Text = "Create Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "AddAccount";
            Size = new Size(572, 427);
            base_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            selector_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label settings_lbl;
        private Label db_lbl;
        private TextBox password_tb;
        private TextBox username_tb;
        private Panel selector_pnl;
        private Label label1;
        private Label label2;
        private TextBox email_tb;
        private Panel panel1;
        private Button create_btn;
        private Button return_btn;
        private TextBox fullname_tb;
        private Label label3;
    }
}
