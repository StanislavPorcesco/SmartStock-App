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
            confirm_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox0 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            theme_lbl = new Label();
            root_table = new TableLayoutPanel();
            title_pnl = new Panel();
            close_btn = new FontAwesome.Sharp.IconButton();
            hero_pnl = new Panel();
            hero_grid = new TableLayoutPanel();
            brand_row = new TableLayoutPanel();
            brand_icn = new FontAwesome.Sharp.IconPictureBox();
            brand_stack = new TableLayoutPanel();
            brand_lbl = new Label();
            wordmark_lbl = new Label();
            hero_spacer = new Panel();
            hero_quote = new TableLayoutPanel();
            tagline_lbl = new Label();
            tagline2_lbl = new Label();
            subtag_lbl = new Label();
            form_host = new Panel();
            form_table = new TableLayoutPanel();
            footer_pnl = new TableLayoutPanel();
            divider_pnl = new Panel();
            signin_hint_lbl = new Label();
            return_btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            root_table.SuspendLayout();
            title_pnl.SuspendLayout();
            hero_pnl.SuspendLayout();
            hero_grid.SuspendLayout();
            brand_row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brand_icn).BeginInit();
            brand_stack.SuspendLayout();
            hero_quote.SuspendLayout();
            form_host.SuspendLayout();
            form_table.SuspendLayout();
            footer_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // confirm_btn
            // 
            confirm_btn.Dock = DockStyle.Fill;
            confirm_btn.Font = new Font("Segoe UI Semibold", 11F);
            confirm_btn.Location = new Point(0, 315);
            confirm_btn.Margin = new Padding(0);
            confirm_btn.MaximumSize = new Size(0, 50);
            confirm_btn.MinimumSize = new Size(0, 50);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(359, 50);
            confirm_btn.TabIndex = 1;
            confirm_btn.Tag = "cta";
            confirm_btn.Text = "Create Account";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.049181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3770485F));
            tableLayoutPanel1.Controls.Add(textBox0, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox5, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 220);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(353, 74);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Tag = "base";
            // 
            // textBox0
            // 
            textBox0.Dock = DockStyle.Fill;
            textBox0.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox0.Location = new Point(10, 10);
            textBox0.Margin = new Padding(10);
            textBox0.MaxLength = 1;
            textBox0.Name = "textBox0";
            textBox0.Size = new Size(38, 51);
            textBox0.TabIndex = 1;
            textBox0.Tag = "otp";
            textBox0.TextAlign = HorizontalAlignment.Center;
            textBox0.TextChanged += CodeTextBox_TextChanged;
            textBox0.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox1.Location = new Point(68, 10);
            textBox1.Margin = new Padding(10);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 51);
            textBox1.TabIndex = 2;
            textBox1.Tag = "otp";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += CodeTextBox_TextChanged;
            textBox1.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox2.Location = new Point(126, 10);
            textBox2.Margin = new Padding(10);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 51);
            textBox2.TabIndex = 3;
            textBox2.Tag = "otp";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += CodeTextBox_TextChanged;
            textBox2.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox3.Location = new Point(184, 10);
            textBox3.Margin = new Padding(10);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(38, 51);
            textBox3.TabIndex = 4;
            textBox3.Tag = "otp";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += CodeTextBox_TextChanged;
            textBox3.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox4.Location = new Point(242, 10);
            textBox4.Margin = new Padding(10);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(39, 51);
            textBox4.TabIndex = 5;
            textBox4.Tag = "otp";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += CodeTextBox_TextChanged;
            textBox4.KeyDown += CodeTextBox_KeyDown;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            textBox5.Location = new Point(301, 10);
            textBox5.Margin = new Padding(10);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(42, 51);
            textBox5.TabIndex = 6;
            textBox5.Tag = "otp";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += CodeTextBox_TextChanged;
            textBox5.KeyDown += CodeTextBox_KeyDown;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.Location = new Point(3, 173);
            label1.Name = "label1";
            label1.Size = new Size(353, 24);
            label1.TabIndex = 0;
            label1.Tag = "muted";
            label1.Text = "Enter the 6-digit code sent to your email address";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theme_lbl
            // 
            theme_lbl.Dock = DockStyle.Fill;
            theme_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            theme_lbl.Location = new Point(3, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(353, 173);
            theme_lbl.TabIndex = 3;
            theme_lbl.Text = "Mail Confirmation";
            theme_lbl.TextAlign = ContentAlignment.BottomCenter;
            // 
            // root_table
            // 
            root_table.ColumnCount = 2;
            root_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root_table.Controls.Add(title_pnl, 1, 0);
            root_table.Controls.Add(hero_pnl, 0, 0);
            root_table.Controls.Add(form_host, 1, 1);
            root_table.Dock = DockStyle.Fill;
            root_table.Location = new Point(0, 0);
            root_table.Margin = new Padding(0);
            root_table.Name = "root_table";
            root_table.RowCount = 2;
            root_table.RowStyles.Add(new RowStyle());
            root_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_table.Size = new Size(921, 650);
            root_table.TabIndex = 8;
            // 
            // title_pnl
            // 
            title_pnl.Controls.Add(close_btn);
            title_pnl.Dock = DockStyle.Fill;
            title_pnl.Location = new Point(463, 3);
            title_pnl.MaximumSize = new Size(0, 30);
            title_pnl.Name = "title_pnl";
            title_pnl.Size = new Size(455, 20);
            title_pnl.TabIndex = 3;
            // 
            // close_btn
            // 
            close_btn.Dock = DockStyle.Right;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.IconChar = FontAwesome.Sharp.IconChar.X;
            close_btn.IconColor = Color.Black;
            close_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            close_btn.IconSize = 15;
            close_btn.Location = new Point(440, 0);
            close_btn.MaximumSize = new Size(15, 15);
            close_btn.MinimumSize = new Size(15, 15);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(15, 15);
            close_btn.TabIndex = 3;
            close_btn.Tag = "ghost";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(hero_grid);
            hero_pnl.Dock = DockStyle.Fill;
            hero_pnl.Location = new Point(3, 3);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(40);
            root_table.SetRowSpan(hero_pnl, 2);
            hero_pnl.Size = new Size(454, 644);
            hero_pnl.TabIndex = 0;
            hero_pnl.Tag = "hero";
            // 
            // hero_grid
            // 
            hero_grid.ColumnCount = 1;
            hero_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            hero_grid.Controls.Add(brand_row, 0, 0);
            hero_grid.Controls.Add(hero_spacer, 0, 1);
            hero_grid.Controls.Add(hero_quote, 0, 2);
            hero_grid.Dock = DockStyle.Fill;
            hero_grid.Location = new Point(40, 40);
            hero_grid.Margin = new Padding(0);
            hero_grid.Name = "hero_grid";
            hero_grid.RowCount = 3;
            hero_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            hero_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            hero_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            hero_grid.Size = new Size(374, 564);
            hero_grid.TabIndex = 0;
            // 
            // brand_row
            // 
            brand_row.ColumnCount = 2;
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_row.Controls.Add(brand_icn, 0, 0);
            brand_row.Controls.Add(brand_stack, 1, 0);
            brand_row.Dock = DockStyle.Fill;
            brand_row.Location = new Point(0, 0);
            brand_row.Margin = new Padding(0);
            brand_row.Name = "brand_row";
            brand_row.RowCount = 1;
            brand_row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            brand_row.Size = new Size(374, 96);
            brand_row.TabIndex = 0;
            // 
            // brand_icn
            // 
            brand_icn.Anchor = AnchorStyles.Left;
            brand_icn.BackColor = SystemColors.Control;
            brand_icn.ForeColor = SystemColors.ControlText;
            brand_icn.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            brand_icn.IconColor = SystemColors.ControlText;
            brand_icn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            brand_icn.IconSize = 80;
            brand_icn.Location = new Point(0, 8);
            brand_icn.Margin = new Padding(0);
            brand_icn.Name = "brand_icn";
            brand_icn.Size = new Size(80, 80);
            brand_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            brand_icn.TabIndex = 0;
            brand_icn.TabStop = false;
            brand_icn.Tag = "accent-icon";
            // 
            // brand_stack
            // 
            brand_stack.ColumnCount = 1;
            brand_stack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_stack.Controls.Add(brand_lbl, 0, 0);
            brand_stack.Controls.Add(wordmark_lbl, 0, 1);
            brand_stack.Dock = DockStyle.Fill;
            brand_stack.Location = new Point(83, 0);
            brand_stack.Margin = new Padding(0);
            brand_stack.Name = "brand_stack";
            brand_stack.Padding = new Padding(0, 8, 0, 0);
            brand_stack.RowCount = 2;
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            brand_stack.Size = new Size(291, 96);
            brand_stack.TabIndex = 1;
            // 
            // brand_lbl
            // 
            brand_lbl.Dock = DockStyle.Fill;
            brand_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brand_lbl.Location = new Point(0, 8);
            brand_lbl.Margin = new Padding(0);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(291, 50);
            brand_lbl.TabIndex = 0;
            brand_lbl.Tag = "hero";
            brand_lbl.Text = "SmartStock";
            brand_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // wordmark_lbl
            // 
            wordmark_lbl.Dock = DockStyle.Fill;
            wordmark_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            wordmark_lbl.Location = new Point(0, 58);
            wordmark_lbl.Margin = new Padding(0);
            wordmark_lbl.Name = "wordmark_lbl";
            wordmark_lbl.Size = new Size(291, 38);
            wordmark_lbl.TabIndex = 1;
            wordmark_lbl.Tag = "hero-muted";
            wordmark_lbl.Text = "INVENTORY  ·  INTELLIGENCE";
            // 
            // hero_spacer
            // 
            hero_spacer.Dock = DockStyle.Fill;
            hero_spacer.Location = new Point(0, 96);
            hero_spacer.Margin = new Padding(0);
            hero_spacer.Name = "hero_spacer";
            hero_spacer.Size = new Size(374, 308);
            hero_spacer.TabIndex = 1;
            hero_spacer.Tag = "hero";
            // 
            // hero_quote
            // 
            hero_quote.ColumnCount = 1;
            hero_quote.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            hero_quote.Controls.Add(tagline_lbl, 0, 0);
            hero_quote.Controls.Add(tagline2_lbl, 0, 1);
            hero_quote.Controls.Add(subtag_lbl, 0, 2);
            hero_quote.Dock = DockStyle.Fill;
            hero_quote.Location = new Point(0, 404);
            hero_quote.Margin = new Padding(0);
            hero_quote.Name = "hero_quote";
            hero_quote.RowCount = 3;
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            hero_quote.Size = new Size(374, 160);
            hero_quote.TabIndex = 2;
            // 
            // tagline_lbl
            // 
            tagline_lbl.Dock = DockStyle.Fill;
            tagline_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline_lbl.Location = new Point(0, 0);
            tagline_lbl.Margin = new Padding(0);
            tagline_lbl.Name = "tagline_lbl";
            tagline_lbl.Size = new Size(374, 52);
            tagline_lbl.TabIndex = 0;
            tagline_lbl.Tag = "hero";
            tagline_lbl.Text = "Join the team.";
            tagline_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tagline2_lbl
            // 
            tagline2_lbl.Dock = DockStyle.Fill;
            tagline2_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline2_lbl.Location = new Point(0, 52);
            tagline2_lbl.Margin = new Padding(0);
            tagline2_lbl.Name = "tagline2_lbl";
            tagline2_lbl.Size = new Size(374, 52);
            tagline2_lbl.TabIndex = 1;
            tagline2_lbl.Tag = "accent";
            tagline2_lbl.Text = "Start in minutes.";
            // 
            // subtag_lbl
            // 
            subtag_lbl.Dock = DockStyle.Fill;
            subtag_lbl.Font = new Font("Segoe UI", 10F);
            subtag_lbl.Location = new Point(0, 110);
            subtag_lbl.Margin = new Padding(0, 6, 0, 0);
            subtag_lbl.Name = "subtag_lbl";
            subtag_lbl.Size = new Size(374, 50);
            subtag_lbl.TabIndex = 2;
            subtag_lbl.Tag = "hero-muted";
            subtag_lbl.Text = "One account unlocks every module — analytics, alerts, AI.";
            // 
            // form_host
            // 
            form_host.Controls.Add(form_table);
            form_host.Controls.Add(footer_pnl);
            form_host.Dock = DockStyle.Fill;
            form_host.Location = new Point(463, 29);
            form_host.Name = "form_host";
            form_host.Padding = new Padding(48, 28, 48, 0);
            form_host.Size = new Size(455, 618);
            form_host.TabIndex = 1;
            form_host.Tag = "base";
            // 
            // form_table
            // 
            form_table.ColumnCount = 1;
            form_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_table.Controls.Add(confirm_btn, 0, 5);
            form_table.Controls.Add(tableLayoutPanel1, 0, 3);
            form_table.Controls.Add(theme_lbl, 0, 0);
            form_table.Controls.Add(label1, 0, 1);
            form_table.Dock = DockStyle.Fill;
            form_table.Location = new Point(48, 28);
            form_table.Margin = new Padding(0);
            form_table.Name = "form_table";
            form_table.RowCount = 7;
            form_table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            form_table.Size = new Size(359, 538);
            form_table.TabIndex = 0;
            // 
            // footer_pnl
            // 
            footer_pnl.ColumnCount = 2;
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            footer_pnl.Controls.Add(divider_pnl, 0, 0);
            footer_pnl.Controls.Add(signin_hint_lbl, 0, 1);
            footer_pnl.Controls.Add(return_btn, 1, 1);
            footer_pnl.Dock = DockStyle.Bottom;
            footer_pnl.Location = new Point(48, 566);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.RowCount = 2;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footer_pnl.Size = new Size(359, 52);
            footer_pnl.TabIndex = 1;
            // 
            // divider_pnl
            // 
            footer_pnl.SetColumnSpan(divider_pnl, 2);
            divider_pnl.Dock = DockStyle.Fill;
            divider_pnl.Location = new Point(0, 0);
            divider_pnl.Margin = new Padding(0, 0, 0, 10);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(359, 1);
            divider_pnl.TabIndex = 0;
            divider_pnl.Tag = "divider";
            // 
            // signin_hint_lbl
            // 
            signin_hint_lbl.Dock = DockStyle.Fill;
            signin_hint_lbl.Font = new Font("Segoe UI", 9.5F);
            signin_hint_lbl.Location = new Point(0, 1);
            signin_hint_lbl.Margin = new Padding(0);
            signin_hint_lbl.Name = "signin_hint_lbl";
            signin_hint_lbl.Size = new Size(199, 51);
            signin_hint_lbl.TabIndex = 1;
            signin_hint_lbl.Tag = "muted";
            signin_hint_lbl.Text = "Already have an account?";
            signin_hint_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // return_btn
            // 
            return_btn.Cursor = Cursors.Hand;
            return_btn.Dock = DockStyle.Fill;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI Semibold", 9.5F);
            return_btn.Location = new Point(199, 1);
            return_btn.Margin = new Padding(0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(160, 51);
            return_btn.TabIndex = 1;
            return_btn.Tag = "ghost";
            return_btn.Text = "Sign in";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // MailConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_table);
            Name = "MailConfirmation";
            Size = new Size(921, 650);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            root_table.ResumeLayout(false);
            title_pnl.ResumeLayout(false);
            hero_pnl.ResumeLayout(false);
            hero_grid.ResumeLayout(false);
            brand_row.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brand_icn).EndInit();
            brand_stack.ResumeLayout(false);
            hero_quote.ResumeLayout(false);
            form_host.ResumeLayout(false);
            form_table.ResumeLayout(false);
            footer_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button  confirm_btn;
        private TextBox textBox0;
        private Label   theme_lbl;
        private Label   label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel root_table;
        private Panel title_pnl;
        private FontAwesome.Sharp.IconButton close_btn;
        private Panel hero_pnl;
        private TableLayoutPanel hero_grid;
        private TableLayoutPanel brand_row;
        private FontAwesome.Sharp.IconPictureBox brand_icn;
        private TableLayoutPanel brand_stack;
        private Label brand_lbl;
        private Label wordmark_lbl;
        private Panel hero_spacer;
        private TableLayoutPanel hero_quote;
        private Label tagline_lbl;
        private Label tagline2_lbl;
        private Label subtag_lbl;
        private Panel form_host;
        private TableLayoutPanel form_table;
        private TableLayoutPanel footer_pnl;
        private Panel divider_pnl;
        private Label signin_hint_lbl;
        private Button return_btn;
    }
}
