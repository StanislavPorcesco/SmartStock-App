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
                components.Dispose();
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
            login_btn_pnl = new Panel();
            confirm_btn = new Button();
            password_tb_pnl = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox0 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            subtitle_pnl = new Panel();
            label1 = new Label();
            login_label_pnl = new Panel();
            theme_lbl = new Label();
            base_pnl.SuspendLayout();
            login_btn_pnl.SuspendLayout();
            password_tb_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            subtitle_pnl.SuspendLayout();
            login_label_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.Controls.Add(login_btn_pnl);
            base_pnl.Controls.Add(password_tb_pnl);
            base_pnl.Controls.Add(subtitle_pnl);
            base_pnl.Controls.Add(login_label_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20, 10, 20, 20);
            base_pnl.Size = new Size(1011, 606);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // login_btn_pnl
            // 
            login_btn_pnl.Controls.Add(confirm_btn);
            login_btn_pnl.Dock = DockStyle.Bottom;
            login_btn_pnl.Location = new Point(20, 536);
            login_btn_pnl.Name = "login_btn_pnl";
            login_btn_pnl.Size = new Size(971, 50);
            login_btn_pnl.TabIndex = 22;
            // 
            // confirm_btn
            // 
            confirm_btn.Dock = DockStyle.Fill;
            confirm_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_btn.Location = new Point(0, 0);
            confirm_btn.Margin = new Padding(0);
            confirm_btn.MaximumSize = new Size(0, 50);
            confirm_btn.MinimumSize = new Size(0, 50);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(971, 50);
            confirm_btn.TabIndex = 7;
            confirm_btn.Tag = "cta";
            confirm_btn.Text = "Create Account";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // password_tb_pnl
            // 
            password_tb_pnl.Controls.Add(tableLayoutPanel1);
            password_tb_pnl.Dock = DockStyle.Top;
            password_tb_pnl.Location = new Point(20, 125);
            password_tb_pnl.Name = "password_tb_pnl";
            password_tb_pnl.Size = new Size(971, 165);
            password_tb_pnl.TabIndex = 21;
            password_tb_pnl.Tag = "base";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.Controls.Add(textBox0, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox5, 5, 0);
            tableLayoutPanel1.Location = new Point(228, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(503, 100);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Tag = "base";
            // 
            // textBox0
            // 
            textBox0.Anchor = AnchorStyles.None;
            textBox0.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox0.Location = new Point(16, 15);
            textBox0.Margin = new Padding(10);
            textBox0.MaxLength = 1;
            textBox0.Name = "textBox0";
            textBox0.Size = new Size(50, 70);
            textBox0.TabIndex = 1;
            textBox0.Tag = "otp";
            textBox0.TextAlign = HorizontalAlignment.Center;
            textBox0.TextChanged += CodeTextBox_TextChanged;
            textBox0.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(99, 15);
            textBox1.Margin = new Padding(10);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 70);
            textBox1.TabIndex = 2;
            textBox1.Tag = "otp";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += CodeTextBox_TextChanged;
            textBox1.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(182, 15);
            textBox2.Margin = new Padding(10);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 70);
            textBox2.TabIndex = 3;
            textBox2.Tag = "otp";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += CodeTextBox_TextChanged;
            textBox2.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(265, 15);
            textBox3.Margin = new Padding(10);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 70);
            textBox3.TabIndex = 4;
            textBox3.Tag = "otp";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += CodeTextBox_TextChanged;
            textBox3.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(348, 15);
            textBox4.Margin = new Padding(10);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 70);
            textBox4.TabIndex = 5;
            textBox4.Tag = "otp";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += CodeTextBox_TextChanged;
            textBox4.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(434, 15);
            textBox5.Margin = new Padding(10);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(50, 70);
            textBox5.TabIndex = 6;
            textBox5.Tag = "otp";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += CodeTextBox_TextChanged;
            textBox5.KeyDown += CodeTextBox_KeyDown;
            // 
            // subtitle_pnl
            // 
            subtitle_pnl.Controls.Add(label1);
            subtitle_pnl.Dock = DockStyle.Top;
            subtitle_pnl.Location = new Point(20, 80);
            subtitle_pnl.Name = "subtitle_pnl";
            subtitle_pnl.Size = new Size(971, 45);
            subtitle_pnl.TabIndex = 23;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(971, 45);
            label1.TabIndex = 0;
            label1.Tag = "muted";
            label1.Text = "Enter the 6-digit code sent to your email address";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_label_pnl
            // 
            login_label_pnl.Controls.Add(theme_lbl);
            login_label_pnl.Dock = DockStyle.Top;
            login_label_pnl.Location = new Point(20, 10);
            login_label_pnl.Name = "login_label_pnl";
            login_label_pnl.Size = new Size(971, 70);
            login_label_pnl.TabIndex = 17;
            // 
            // theme_lbl
            // 
            theme_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            theme_lbl.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            theme_lbl.Location = new Point(0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(971, 70);
            theme_lbl.TabIndex = 3;
            theme_lbl.Text = "Mail Confirmation";
            theme_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MailConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "MailConfirmation";
            Size = new Size(1011, 606);
            base_pnl.ResumeLayout(false);
            login_btn_pnl.ResumeLayout(false);
            password_tb_pnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            subtitle_pnl.ResumeLayout(false);
            login_label_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel   base_pnl;
        private Panel   login_btn_pnl;
        private Button  confirm_btn;
        private Panel   password_tb_pnl;
        private TextBox textBox0;
        private Panel   login_label_pnl;
        private Label   theme_lbl;
        private Panel   subtitle_pnl;
        private Label   label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
