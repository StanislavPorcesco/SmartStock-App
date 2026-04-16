using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            root_table = new TableLayoutPanel();
            hero_pnl = new Panel();
            hero_grid = new TableLayoutPanel();
            brand_row = new TableLayoutPanel();
            brand_icn = new IconPictureBox();
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
            welcome_lbl = new Label();
            subtitle_lbl = new Label();
            username_lbl = new Label();
            username_host = new Panel();
            username_inner = new TableLayoutPanel();
            user_icn = new IconPictureBox();
            username_tb = new TextBox();
            password_lbl = new Label();
            password_host = new Panel();
            password_inner = new TableLayoutPanel();
            lock_icn = new IconPictureBox();
            password_tb = new TextBox();
            login_btn = new Button();
            footer_pnl = new TableLayoutPanel();
            divider_pnl = new Panel();
            settings_btn = new Button();
            account_btn = new Button();
            base_pnl = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            login_btn_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            login_label_pnl = new Panel();
            theme_lbl = new Label();
            root_table.SuspendLayout();
            hero_pnl.SuspendLayout();
            hero_grid.SuspendLayout();
            brand_row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brand_icn).BeginInit();
            brand_stack.SuspendLayout();
            hero_quote.SuspendLayout();
            form_host.SuspendLayout();
            form_table.SuspendLayout();
            username_host.SuspendLayout();
            username_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_icn).BeginInit();
            password_host.SuspendLayout();
            password_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lock_icn).BeginInit();
            footer_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // root_table
            // 
            root_table.ColumnCount = 2;
            root_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root_table.Controls.Add(hero_pnl, 0, 0);
            root_table.Controls.Add(form_host, 1, 0);
            root_table.Dock = DockStyle.Fill;
            root_table.Location = new Point(0, 0);
            root_table.Margin = new Padding(0);
            root_table.Name = "root_table";
            root_table.RowCount = 1;
            root_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_table.Size = new Size(966, 584);
            root_table.TabIndex = 0;
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(hero_grid);
            hero_pnl.Dock = DockStyle.Fill;
            hero_pnl.Location = new Point(3, 3);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(40);
            hero_pnl.Size = new Size(477, 578);
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
            hero_grid.Size = new Size(397, 498);
            hero_grid.TabIndex = 0;
            // 
            // brand_row
            // 
            brand_row.ColumnCount = 2;
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_row.Controls.Add(brand_icn, 0, 0);
            brand_row.Controls.Add(brand_stack, 1, 0);
            brand_row.Dock = DockStyle.Fill;
            brand_row.Location = new Point(0, 0);
            brand_row.Margin = new Padding(0);
            brand_row.Name = "brand_row";
            brand_row.RowCount = 1;
            brand_row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            brand_row.Size = new Size(397, 96);
            brand_row.TabIndex = 0;
            // 
            // brand_icn
            // 
            brand_icn.Anchor = AnchorStyles.Left;
            brand_icn.BackColor = SystemColors.Control;
            brand_icn.ForeColor = SystemColors.ControlText;
            brand_icn.IconChar = IconChar.Cubes;
            brand_icn.IconColor = SystemColors.ControlText;
            brand_icn.IconFont = IconFont.Auto;
            brand_icn.IconSize = 80;
            brand_icn.Location = new Point(0, 8);
            brand_icn.Margin = new Padding(0);
            brand_icn.Name = "brand_icn";
            brand_icn.Size = new Size(82, 80);
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
            brand_stack.Location = new Point(82, 0);
            brand_stack.Margin = new Padding(0);
            brand_stack.Name = "brand_stack";
            brand_stack.Padding = new Padding(0, 8, 0, 0);
            brand_stack.RowCount = 2;
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            brand_stack.Size = new Size(315, 96);
            brand_stack.TabIndex = 1;
            // 
            // brand_lbl
            // 
            brand_lbl.Dock = DockStyle.Fill;
            brand_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brand_lbl.Location = new Point(0, 8);
            brand_lbl.Margin = new Padding(0);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(315, 50);
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
            wordmark_lbl.Size = new Size(315, 38);
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
            hero_spacer.Size = new Size(397, 242);
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
            hero_quote.Location = new Point(0, 338);
            hero_quote.Margin = new Padding(0);
            hero_quote.Name = "hero_quote";
            hero_quote.RowCount = 3;
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            hero_quote.Size = new Size(397, 160);
            hero_quote.TabIndex = 2;
            // 
            // tagline_lbl
            // 
            tagline_lbl.Dock = DockStyle.Fill;
            tagline_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline_lbl.Location = new Point(0, 0);
            tagline_lbl.Margin = new Padding(0);
            tagline_lbl.Name = "tagline_lbl";
            tagline_lbl.Size = new Size(397, 52);
            tagline_lbl.TabIndex = 0;
            tagline_lbl.Tag = "hero";
            tagline_lbl.Text = "Smart inventory,";
            tagline_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tagline2_lbl
            // 
            tagline2_lbl.Dock = DockStyle.Fill;
            tagline2_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline2_lbl.Location = new Point(0, 52);
            tagline2_lbl.Margin = new Padding(0);
            tagline2_lbl.Name = "tagline2_lbl";
            tagline2_lbl.Size = new Size(397, 52);
            tagline2_lbl.TabIndex = 1;
            tagline2_lbl.Tag = "accent";
            tagline2_lbl.Text = "measurable results.";
            // 
            // subtag_lbl
            // 
            subtag_lbl.Dock = DockStyle.Fill;
            subtag_lbl.Font = new Font("Segoe UI", 10F);
            subtag_lbl.Location = new Point(0, 110);
            subtag_lbl.Margin = new Padding(0, 6, 0, 0);
            subtag_lbl.Name = "subtag_lbl";
            subtag_lbl.Size = new Size(397, 50);
            subtag_lbl.TabIndex = 2;
            subtag_lbl.Tag = "hero-muted";
            subtag_lbl.Text = "Forecast demand, detect anomalies, and act on every signal.";
            // 
            // form_host
            // 
            form_host.Controls.Add(form_table);
            form_host.Dock = DockStyle.Fill;
            form_host.Location = new Point(486, 3);
            form_host.Name = "form_host";
            form_host.Padding = new Padding(56, 40, 56, 40);
            form_host.Size = new Size(477, 578);
            form_host.TabIndex = 1;
            form_host.TabStop = false;
            form_host.Tag = "base";
            // 
            // form_table
            // 
            form_table.ColumnCount = 1;
            form_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_table.Controls.Add(welcome_lbl, 0, 1);
            form_table.Controls.Add(subtitle_lbl, 0, 2);
            form_table.Controls.Add(username_lbl, 0, 4);
            form_table.Controls.Add(username_host, 0, 5);
            form_table.Controls.Add(password_lbl, 0, 7);
            form_table.Controls.Add(password_host, 0, 8);
            form_table.Controls.Add(login_btn, 0, 10);
            form_table.Controls.Add(footer_pnl, 0, 12);
            form_table.Dock = DockStyle.Fill;
            form_table.Location = new Point(56, 40);
            form_table.Margin = new Padding(0);
            form_table.Name = "form_table";
            form_table.RowCount = 13;
            form_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            form_table.Size = new Size(365, 498);
            form_table.TabIndex = 0;
            form_table.TabStop = false;
            // 
            // welcome_lbl
            // 
            welcome_lbl.Dock = DockStyle.Fill;
            welcome_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            welcome_lbl.Location = new Point(0, 57);
            welcome_lbl.Margin = new Padding(0);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(365, 42);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome back";
            welcome_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtitle_lbl
            // 
            subtitle_lbl.Dock = DockStyle.Fill;
            subtitle_lbl.Font = new Font("Segoe UI", 10F);
            subtitle_lbl.Location = new Point(0, 99);
            subtitle_lbl.Margin = new Padding(0);
            subtitle_lbl.Name = "subtitle_lbl";
            subtitle_lbl.Size = new Size(365, 26);
            subtitle_lbl.TabIndex = 1;
            subtitle_lbl.Tag = "muted";
            subtitle_lbl.Text = "Sign in to continue to SmartStock.";
            subtitle_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_lbl
            // 
            username_lbl.Dock = DockStyle.Fill;
            username_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            username_lbl.Location = new Point(0, 157);
            username_lbl.Margin = new Padding(0, 0, 0, 4);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(365, 16);
            username_lbl.TabIndex = 2;
            username_lbl.Tag = "muted";
            username_lbl.Text = "USERNAME";
            username_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // username_host
            // 
            username_host.Controls.Add(username_inner);
            username_host.Dock = DockStyle.Fill;
            username_host.Location = new Point(0, 177);
            username_host.Margin = new Padding(0);
            username_host.Name = "username_host";
            username_host.Size = new Size(365, 48);
            username_host.TabIndex = 0;
            username_host.TabStop = false;
            username_host.Tag = "input";
            // 
            // username_inner
            // 
            username_inner.ColumnCount = 2;
            username_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            username_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            username_inner.Controls.Add(user_icn, 0, 0);
            username_inner.Controls.Add(username_tb, 1, 0);
            username_inner.Dock = DockStyle.Fill;
            username_inner.Location = new Point(0, 0);
            username_inner.Margin = new Padding(0);
            username_inner.Name = "username_inner";
            username_inner.Padding = new Padding(0, 0, 14, 0);
            username_inner.RowCount = 1;
            username_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            username_inner.Size = new Size(365, 48);
            username_inner.TabIndex = 0;
            username_inner.TabStop = false;
            // 
            // user_icn
            // 
            user_icn.BackColor = SystemColors.Control;
            user_icn.ForeColor = SystemColors.ControlText;
            user_icn.IconChar = IconChar.User;
            user_icn.IconColor = SystemColors.ControlText;
            user_icn.IconFont = IconFont.Auto;
            user_icn.IconSize = 30;
            user_icn.Location = new Point(0, 0);
            user_icn.Margin = new Padding(0);
            user_icn.Name = "user_icn";
            user_icn.Size = new Size(44, 48);
            user_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            user_icn.TabIndex = 0;
            user_icn.TabStop = false;
            user_icn.Tag = "input";
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.BorderStyle = BorderStyle.None;
            username_tb.Font = new Font("Segoe UI", 11F);
            username_tb.Location = new Point(44, 11);
            username_tb.Margin = new Padding(0);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(307, 25);
            username_tb.TabIndex = 0;
            username_tb.Tag = "flat";
            // 
            // password_lbl
            // 
            password_lbl.Dock = DockStyle.Fill;
            password_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            password_lbl.Location = new Point(0, 241);
            password_lbl.Margin = new Padding(0, 0, 0, 4);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(365, 16);
            password_lbl.TabIndex = 4;
            password_lbl.Tag = "muted";
            password_lbl.Text = "PASSWORD";
            password_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // password_host
            // 
            password_host.Controls.Add(password_inner);
            password_host.Dock = DockStyle.Fill;
            password_host.Location = new Point(0, 261);
            password_host.Margin = new Padding(0);
            password_host.Name = "password_host";
            password_host.Size = new Size(365, 48);
            password_host.TabIndex = 1;
            password_host.TabStop = false;
            password_host.Tag = "input";
            // 
            // password_inner
            // 
            password_inner.ColumnCount = 2;
            password_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            password_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            password_inner.Controls.Add(lock_icn, 0, 0);
            password_inner.Controls.Add(password_tb, 1, 0);
            password_inner.Dock = DockStyle.Fill;
            password_inner.Location = new Point(0, 0);
            password_inner.Margin = new Padding(0);
            password_inner.Name = "password_inner";
            password_inner.Padding = new Padding(0, 0, 14, 0);
            password_inner.RowCount = 1;
            password_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            password_inner.Size = new Size(365, 48);
            password_inner.TabIndex = 0;
            password_inner.TabStop = false;
            // 
            // lock_icn
            // 
            lock_icn.BackColor = SystemColors.Control;
            lock_icn.ForeColor = SystemColors.ControlText;
            lock_icn.IconChar = IconChar.Lock;
            lock_icn.IconColor = SystemColors.ControlText;
            lock_icn.IconFont = IconFont.Auto;
            lock_icn.IconSize = 30;
            lock_icn.Location = new Point(0, 0);
            lock_icn.Margin = new Padding(0);
            lock_icn.Name = "lock_icn";
            lock_icn.Size = new Size(44, 48);
            lock_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            lock_icn.TabIndex = 0;
            lock_icn.TabStop = false;
            lock_icn.Tag = "input";
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.BorderStyle = BorderStyle.None;
            password_tb.Font = new Font("Segoe UI", 11F);
            password_tb.Location = new Point(44, 11);
            password_tb.Margin = new Padding(0);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(307, 25);
            password_tb.TabIndex = 0;
            password_tb.Tag = "flat";
            password_tb.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.Cursor = Cursors.Hand;
            login_btn.Dock = DockStyle.Fill;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI Semibold", 11F);
            login_btn.Location = new Point(0, 337);
            login_btn.Margin = new Padding(0);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(365, 52);
            login_btn.TabIndex = 2;
            login_btn.Tag = "cta";
            login_btn.Text = "Sign in";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // footer_pnl
            // 
            footer_pnl.ColumnCount = 2;
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            footer_pnl.Controls.Add(divider_pnl, 0, 0);
            footer_pnl.Controls.Add(settings_btn, 0, 1);
            footer_pnl.Controls.Add(account_btn, 1, 1);
            footer_pnl.Dock = DockStyle.Fill;
            footer_pnl.Location = new Point(0, 446);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.RowCount = 2;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footer_pnl.Size = new Size(365, 52);
            footer_pnl.TabIndex = 3;
            footer_pnl.TabStop = false;
            // 
            // divider_pnl
            // 
            footer_pnl.SetColumnSpan(divider_pnl, 2);
            divider_pnl.Dock = DockStyle.Fill;
            divider_pnl.Location = new Point(0, 0);
            divider_pnl.Margin = new Padding(0, 0, 0, 14);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(365, 1);
            divider_pnl.TabIndex = 0;
            divider_pnl.Tag = "divider";
            // 
            // settings_btn
            // 
            settings_btn.Cursor = Cursors.Hand;
            settings_btn.Dock = DockStyle.Fill;
            settings_btn.FlatStyle = FlatStyle.Flat;
            settings_btn.Font = new Font("Segoe UI", 9.5F);
            settings_btn.Location = new Point(0, 1);
            settings_btn.Margin = new Padding(0);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(182, 51);
            settings_btn.TabIndex = 0;
            settings_btn.Tag = "ghost";
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // account_btn
            // 
            account_btn.Cursor = Cursors.Hand;
            account_btn.Dock = DockStyle.Fill;
            account_btn.FlatStyle = FlatStyle.Flat;
            account_btn.Font = new Font("Segoe UI", 9.5F);
            account_btn.Location = new Point(182, 1);
            account_btn.Margin = new Padding(0);
            account_btn.Name = "account_btn";
            account_btn.Size = new Size(183, 51);
            account_btn.TabIndex = 1;
            account_btn.Tag = "ghost";
            account_btn.Text = "Create account";
            account_btn.UseVisualStyleBackColor = true;
            account_btn.Click += account_btn_Click;
            // 
            // base_pnl
            // 
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Size = new Size(200, 100);
            base_pnl.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // login_btn_pnl
            // 
            login_btn_pnl.Location = new Point(0, 0);
            login_btn_pnl.Name = "login_btn_pnl";
            login_btn_pnl.Size = new Size(200, 100);
            login_btn_pnl.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // login_label_pnl
            // 
            login_label_pnl.Location = new Point(0, 0);
            login_label_pnl.Name = "login_label_pnl";
            login_label_pnl.Size = new Size(200, 100);
            login_label_pnl.TabIndex = 0;
            // 
            // theme_lbl
            // 
            theme_lbl.Location = new Point(0, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(100, 23);
            theme_lbl.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_table);
            Name = "Login";
            Size = new Size(966, 584);
            root_table.ResumeLayout(false);
            hero_pnl.ResumeLayout(false);
            hero_grid.ResumeLayout(false);
            brand_row.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brand_icn).EndInit();
            brand_stack.ResumeLayout(false);
            hero_quote.ResumeLayout(false);
            form_host.ResumeLayout(false);
            form_table.ResumeLayout(false);
            username_host.ResumeLayout(false);
            username_inner.ResumeLayout(false);
            username_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_icn).EndInit();
            password_host.ResumeLayout(false);
            password_inner.ResumeLayout(false);
            password_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lock_icn).EndInit();
            footer_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // New controls
        private TableLayoutPanel root_table;

        private Panel            hero_pnl;
        private TableLayoutPanel hero_grid;
        private TableLayoutPanel brand_row;
        private IconPictureBox   brand_icn;
        private TableLayoutPanel brand_stack;
        private Label            brand_lbl;
        private Label            wordmark_lbl;
        private Panel            hero_spacer;
        private TableLayoutPanel hero_quote;
        private Label            tagline_lbl;
        private Label            tagline2_lbl;
        private Label            subtag_lbl;

        private Panel            form_host;
        private TableLayoutPanel form_table;
        private Label            welcome_lbl;
        private Label            subtitle_lbl;
        private Label            username_lbl;
        private Panel            username_host;
        private TableLayoutPanel username_inner;
        private IconPictureBox   user_icn;
        private TextBox          username_tb;
        private Label            password_lbl;
        private Panel            password_host;
        private TableLayoutPanel password_inner;
        private IconPictureBox   lock_icn;
        private TextBox          password_tb;
        private Button           login_btn;
        private Panel            divider_pnl;
        private TableLayoutPanel footer_pnl;
        private Button           settings_btn;
        private Button           account_btn;

        // Legacy field placeholders (kept hidden to avoid breaking other code paths)
        private Panel       base_pnl;
        private Panel       panel1;
        private Panel       panel2;
        private Panel       login_btn_pnl;
        private GroupBox    groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label       label1;
        private Label       label2;
        private Panel       login_label_pnl;
        private Label       theme_lbl;
    }
}
