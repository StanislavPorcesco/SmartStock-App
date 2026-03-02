namespace SmartStock.Forms.User_Control
{
    partial class MailConfirmation
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
            label1 = new Label();
            login_btn_pnl = new Panel();
            confirm_btn = new Button();
            password_tb_pnl = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox0 = new TextBox();
            login_label_pnl = new Panel();
            theme_lbl = new Label();
            base_pnl.SuspendLayout();
            panel1.SuspendLayout();
            login_btn_pnl.SuspendLayout();
            password_tb_pnl.SuspendLayout();
            login_label_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(panel1);
            base_pnl.Controls.Add(login_btn_pnl);
            base_pnl.Controls.Add(password_tb_pnl);
            base_pnl.Controls.Add(login_label_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20, 10, 20, 20);
            base_pnl.Size = new Size(572, 423);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 47);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(532, 47);
            label1.TabIndex = 0;
            label1.Text = "Use the code from your email to verify your new account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // login_btn_pnl
            // 
            login_btn_pnl.Controls.Add(confirm_btn);
            login_btn_pnl.Dock = DockStyle.Bottom;
            login_btn_pnl.Location = new Point(20, 333);
            login_btn_pnl.Name = "login_btn_pnl";
            login_btn_pnl.Size = new Size(532, 70);
            login_btn_pnl.TabIndex = 22;
            // 
            // confirm_btn
            // 
            confirm_btn.BackColor = Color.FromArgb(54, 54, 54);
            confirm_btn.Dock = DockStyle.Fill;
            confirm_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(0, 0);
            confirm_btn.Margin = new Padding(0);
            confirm_btn.MaximumSize = new Size(0, 70);
            confirm_btn.MinimumSize = new Size(0, 70);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(532, 70);
            confirm_btn.TabIndex = 7;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // password_tb_pnl
            // 
            password_tb_pnl.Controls.Add(textBox5);
            password_tb_pnl.Controls.Add(textBox4);
            password_tb_pnl.Controls.Add(textBox3);
            password_tb_pnl.Controls.Add(textBox2);
            password_tb_pnl.Controls.Add(textBox1);
            password_tb_pnl.Controls.Add(textBox0);
            password_tb_pnl.Dock = DockStyle.Top;
            password_tb_pnl.Location = new Point(20, 84);
            password_tb_pnl.Name = "password_tb_pnl";
            password_tb_pnl.Size = new Size(532, 151);
            password_tb_pnl.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(54, 54, 54);
            textBox5.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(416, 40);
            textBox5.Margin = new Padding(0, 5, 0, 5);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(50, 70);
            textBox5.TabIndex = 6;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += CodeTextBox_TextChanged;
            textBox5.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(54, 54, 54);
            textBox4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(345, 40);
            textBox4.Margin = new Padding(0, 5, 0, 5);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 70);
            textBox4.TabIndex = 5;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += CodeTextBox_TextChanged;
            textBox4.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(54, 54, 54);
            textBox3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(275, 40);
            textBox3.Margin = new Padding(0, 5, 0, 5);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 70);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += CodeTextBox_TextChanged;
            textBox3.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(54, 54, 54);
            textBox2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(204, 40);
            textBox2.Margin = new Padding(0, 5, 0, 5);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 70);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += CodeTextBox_TextChanged;
            textBox2.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(54, 54, 54);
            textBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(133, 40);
            textBox1.Margin = new Padding(0, 5, 0, 5);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 70);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += CodeTextBox_TextChanged;
            textBox1.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox0
            // 
            textBox0.BackColor = Color.FromArgb(54, 54, 54);
            textBox0.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox0.ForeColor = Color.White;
            textBox0.Location = new Point(63, 40);
            textBox0.Margin = new Padding(0, 5, 0, 5);
            textBox0.MaxLength = 1;
            textBox0.Name = "textBox0";
            textBox0.Size = new Size(50, 70);
            textBox0.TabIndex = 1;
            textBox0.TextAlign = HorizontalAlignment.Center;
            textBox0.TextChanged += CodeTextBox_TextChanged;
            textBox0.KeyDown += CodeTextBox_KeyDown;
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
            theme_lbl.Text = "Mail Confirmation Code";
            theme_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MailConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "MailConfirmation";
            Size = new Size(572, 423);
            base_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            login_btn_pnl.ResumeLayout(false);
            password_tb_pnl.ResumeLayout(false);
            password_tb_pnl.PerformLayout();
            login_label_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel login_btn_pnl;
        private Button confirm_btn;
        private Panel password_tb_pnl;
        private TextBox textBox0;
        private Panel login_label_pnl;
        private Label theme_lbl;
        private Panel panel1;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
