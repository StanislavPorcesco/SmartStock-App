namespace SmartStock
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_btn = new Button();
            base_pnl = new Panel();
            options_panel = new Panel();
            account_btn = new Button();
            settings_btn = new Button();
            login_btn_pnl = new Panel();
            password_tb_pnl = new Panel();
            password_tb = new TextBox();
            password_lbl_pnl = new Panel();
            label2 = new Label();
            username_tb_pnl = new Panel();
            username_tb = new TextBox();
            username_lbl_pnl = new Panel();
            label1 = new Label();
            login_label_pnl = new Panel();
            theme_lbl = new Label();
            base_pnl.SuspendLayout();
            options_panel.SuspendLayout();
            login_btn_pnl.SuspendLayout();
            password_tb_pnl.SuspendLayout();
            password_lbl_pnl.SuspendLayout();
            username_tb_pnl.SuspendLayout();
            username_lbl_pnl.SuspendLayout();
            login_label_pnl.SuspendLayout();
            SuspendLayout();
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
            login_btn.Size = new Size(532, 70);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // base_pnl
            // 
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(options_panel);
            base_pnl.Controls.Add(login_btn_pnl);
            base_pnl.Controls.Add(password_tb_pnl);
            base_pnl.Controls.Add(password_lbl_pnl);
            base_pnl.Controls.Add(username_tb_pnl);
            base_pnl.Controls.Add(username_lbl_pnl);
            base_pnl.Controls.Add(login_label_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20, 10, 20, 10);
            base_pnl.Size = new Size(572, 423);
            base_pnl.TabIndex = 2;
            base_pnl.Tag = "base";
            // 
            // options_panel
            // 
            options_panel.Controls.Add(account_btn);
            options_panel.Controls.Add(settings_btn);
            options_panel.Dock = DockStyle.Top;
            options_panel.Location = new Point(20, 347);
            options_panel.Name = "options_panel";
            options_panel.Size = new Size(532, 61);
            options_panel.TabIndex = 23;
            // 
            // account_btn
            // 
            account_btn.AutoSize = true;
            account_btn.Dock = DockStyle.Right;
            account_btn.FlatAppearance.BorderSize = 0;
            account_btn.FlatStyle = FlatStyle.Flat;
            account_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            account_btn.ForeColor = Color.White;
            account_btn.Location = new Point(372, 0);
            account_btn.Name = "account_btn";
            account_btn.Size = new Size(160, 61);
            account_btn.TabIndex = 1;
            account_btn.Tag = "menu";
            account_btn.Text = "Create Account";
            account_btn.UseVisualStyleBackColor = true;
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
            settings_btn.Size = new Size(160, 61);
            settings_btn.TabIndex = 0;
            settings_btn.Tag = "menu";
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = true;
            // 
            // login_btn_pnl
            // 
            login_btn_pnl.Controls.Add(login_btn);
            login_btn_pnl.Dock = DockStyle.Top;
            login_btn_pnl.Location = new Point(20, 254);
            login_btn_pnl.Name = "login_btn_pnl";
            login_btn_pnl.Size = new Size(532, 93);
            login_btn_pnl.TabIndex = 22;
            // 
            // password_tb_pnl
            // 
            password_tb_pnl.Controls.Add(password_tb);
            password_tb_pnl.Dock = DockStyle.Top;
            password_tb_pnl.Location = new Point(20, 194);
            password_tb_pnl.Name = "password_tb_pnl";
            password_tb_pnl.Size = new Size(532, 60);
            password_tb_pnl.TabIndex = 21;
            // 
            // password_tb
            // 
            password_tb.BackColor = Color.FromArgb(54, 54, 54);
            password_tb.Dock = DockStyle.Fill;
            password_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            password_tb.ForeColor = Color.White;
            password_tb.Location = new Point(0, 0);
            password_tb.Margin = new Padding(0, 5, 0, 5);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(532, 31);
            password_tb.TabIndex = 14;
            // 
            // password_lbl_pnl
            // 
            password_lbl_pnl.Controls.Add(label2);
            password_lbl_pnl.Dock = DockStyle.Top;
            password_lbl_pnl.Location = new Point(20, 164);
            password_lbl_pnl.Name = "password_lbl_pnl";
            password_lbl_pnl.Size = new Size(532, 30);
            password_lbl_pnl.TabIndex = 20;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(532, 30);
            label2.TabIndex = 13;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_tb_pnl
            // 
            username_tb_pnl.Controls.Add(username_tb);
            username_tb_pnl.Dock = DockStyle.Top;
            username_tb_pnl.Location = new Point(20, 114);
            username_tb_pnl.Name = "username_tb_pnl";
            username_tb_pnl.Size = new Size(532, 50);
            username_tb_pnl.TabIndex = 19;
            // 
            // username_tb
            // 
            username_tb.BackColor = Color.FromArgb(54, 54, 54);
            username_tb.Dock = DockStyle.Fill;
            username_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            username_tb.ForeColor = Color.White;
            username_tb.Location = new Point(0, 0);
            username_tb.Margin = new Padding(0, 5, 0, 5);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(532, 31);
            username_tb.TabIndex = 12;
            // 
            // username_lbl_pnl
            // 
            username_lbl_pnl.Controls.Add(label1);
            username_lbl_pnl.Dock = DockStyle.Top;
            username_lbl_pnl.Location = new Point(20, 84);
            username_lbl_pnl.Name = "username_lbl_pnl";
            username_lbl_pnl.Size = new Size(532, 30);
            username_lbl_pnl.TabIndex = 18;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(532, 30);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // login_label_pnl
            // 
            login_label_pnl.Controls.Add(theme_lbl);
            login_label_pnl.Dock = DockStyle.Top;
            login_label_pnl.Location = new Point(20, 10);
            login_label_pnl.Name = "login_label_pnl";
            login_label_pnl.Size = new Size(532, 74);
            login_label_pnl.TabIndex = 17;
            // 
            // theme_lbl
            // 
            theme_lbl.Dock = DockStyle.Fill;
            theme_lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            theme_lbl.ForeColor = Color.White;
            theme_lbl.Location = new Point(0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(532, 74);
            theme_lbl.TabIndex = 3;
            theme_lbl.Text = "Login";
            theme_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(632, 483);
            Controls.Add(base_pnl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(650, 530);
            MinimizeBox = false;
            MinimumSize = new Size(650, 530);
            Name = "LoginForm";
            Padding = new Padding(30);
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "workplace";
            Text = "Login";
            base_pnl.ResumeLayout(false);
            options_panel.ResumeLayout(false);
            options_panel.PerformLayout();
            login_btn_pnl.ResumeLayout(false);
            password_tb_pnl.ResumeLayout(false);
            password_tb_pnl.PerformLayout();
            password_lbl_pnl.ResumeLayout(false);
            username_tb_pnl.ResumeLayout(false);
            username_tb_pnl.PerformLayout();
            username_lbl_pnl.ResumeLayout(false);
            login_label_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button login_btn;
        private Panel base_pnl;
        private Label label1;
        private Label theme_lbl;
        private TextBox username_tb;
        private Label label2;
        private TextBox password_tb;
        private Panel username_tb_pnl;
        private Panel username_lbl_pnl;
        private Panel login_label_pnl;
        private Panel password_lbl_pnl;
        private Panel password_tb_pnl;
        private Panel login_btn_pnl;
        private Panel options_panel;
        private Button account_btn;
        private Button settings_btn;
    }
}
