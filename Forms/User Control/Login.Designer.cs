namespace SmartStock.Forms.User_Control
{
    partial class Login
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
            panel2 = new Panel();
            login_btn = new Button();
            panel1 = new Panel();
            settings_btn = new Button();
            account_btn = new Button();
            login_btn_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            password_tb = new TextBox();
            username_tb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login_label_pnl = new Panel();
            theme_lbl = new Label();
            base_pnl.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            login_btn_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            login_label_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(panel2);
            base_pnl.Controls.Add(panel1);
            base_pnl.Controls.Add(login_btn_pnl);
            base_pnl.Controls.Add(login_label_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(890, 584);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // panel2
            // 
            panel2.Controls.Add(login_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(20, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 75);
            panel2.TabIndex = 24;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(54, 54, 54);
            login_btn.Dock = DockStyle.Fill;
            login_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(0, 0);
            login_btn.Margin = new Padding(0);
            login_btn.MaximumSize = new Size(0, 70);
            login_btn.MinimumSize = new Size(0, 70);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(850, 70);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(settings_btn);
            panel1.Controls.Add(account_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 524);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 40);
            panel1.TabIndex = 23;
            // 
            // settings_btn
            // 
            settings_btn.AutoSize = true;
            settings_btn.Dock = DockStyle.Left;
            settings_btn.FlatAppearance.BorderSize = 0;
            settings_btn.FlatStyle = FlatStyle.Flat;
            settings_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_btn.ForeColor = Color.White;
            settings_btn.Location = new Point(0, 0);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(136, 40);
            settings_btn.TabIndex = 0;
            settings_btn.Tag = "menu";
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // account_btn
            // 
            account_btn.AutoSize = true;
            account_btn.Dock = DockStyle.Right;
            account_btn.FlatAppearance.BorderSize = 0;
            account_btn.FlatStyle = FlatStyle.Flat;
            account_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            account_btn.ForeColor = Color.White;
            account_btn.Location = new Point(690, 0);
            account_btn.Name = "account_btn";
            account_btn.Size = new Size(160, 40);
            account_btn.TabIndex = 1;
            account_btn.Tag = "menu";
            account_btn.Text = "Create Account";
            account_btn.UseVisualStyleBackColor = true;
            account_btn.Click += account_btn_Click;
            // 
            // login_btn_pnl
            // 
            login_btn_pnl.Controls.Add(groupBox1);
            login_btn_pnl.Dock = DockStyle.Top;
            login_btn_pnl.Location = new Point(20, 94);
            login_btn_pnl.Name = "login_btn_pnl";
            login_btn_pnl.Size = new Size(850, 145);
            login_btn_pnl.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(850, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credentials";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(password_tb, 1, 1);
            tableLayoutPanel1.Controls.Add(username_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(830, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.BackColor = Color.FromArgb(54, 54, 54);
            password_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            password_tb.ForeColor = Color.White;
            password_tb.Location = new Point(415, 60);
            password_tb.Margin = new Padding(0, 5, 0, 5);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(415, 31);
            password_tb.TabIndex = 14;
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.BackColor = Color.FromArgb(54, 54, 54);
            username_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            username_tb.ForeColor = Color.White;
            username_tb.Location = new Point(415, 9);
            username_tb.Margin = new Padding(0, 5, 0, 5);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(415, 31);
            username_tb.TabIndex = 12;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 50);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(128, 51);
            label2.TabIndex = 13;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // login_label_pnl
            // 
            login_label_pnl.Controls.Add(theme_lbl);
            login_label_pnl.Dock = DockStyle.Top;
            login_label_pnl.Location = new Point(20, 20);
            login_label_pnl.Name = "login_label_pnl";
            login_label_pnl.Size = new Size(850, 74);
            login_label_pnl.TabIndex = 17;
            // 
            // theme_lbl
            // 
            theme_lbl.Dock = DockStyle.Fill;
            theme_lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            theme_lbl.ForeColor = Color.White;
            theme_lbl.Location = new Point(0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(850, 74);
            theme_lbl.TabIndex = 3;
            theme_lbl.Text = "Login";
            theme_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "Login";
            Size = new Size(890, 584);
            base_pnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            login_btn_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            login_label_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Button account_btn;
        private Button settings_btn;
        private Panel login_btn_pnl;
        private Button login_btn;
        private TextBox password_tb;
        private Label label2;
        private TextBox username_tb;
        private Label label1;
        private Panel login_label_pnl;
        private Label theme_lbl;
        private Panel panel2;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
