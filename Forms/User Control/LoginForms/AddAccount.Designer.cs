using FontAwesome.Sharp;

namespace SmartStock.Forms.AddForms
{
    partial class AddAccount
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
            footer_pnl = new TableLayoutPanel();
            divider_pnl = new Panel();
            signin_hint_lbl = new Label();
            return_btn = new Button();
            form_table = new TableLayoutPanel();
            title_lbl = new Label();
            subtitle_lbl = new Label();
            username_lbl = new Label();
            username_host = new Panel();
            password_lbl = new Label();
            password_host = new Panel();
            fullname_lbl = new Label();
            fullname_host = new Panel();
            email_lbl = new Label();
            email_host = new Panel();
            create_btn = new Button();
            username_inner = new TableLayoutPanel();
            user_icn = new IconPictureBox();
            username_tb = new TextBox();
            password_inner = new TableLayoutPanel();
            lock_icn = new IconPictureBox();
            password_tb = new TextBox();
            fullname_inner = new TableLayoutPanel();
            id_icn = new IconPictureBox();
            fullname_tb = new TextBox();
            email_inner = new TableLayoutPanel();
            mail_icn = new IconPictureBox();
            email_tb = new TextBox();
            base_pnl = new Panel();
            panel1 = new Panel();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            settings_lbl = new Label();
            db_lbl = new Label();
            selector_pnl = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            root_table.SuspendLayout();
            hero_pnl.SuspendLayout();
            hero_grid.SuspendLayout();
            brand_row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brand_icn).BeginInit();
            brand_stack.SuspendLayout();
            hero_quote.SuspendLayout();
            form_host.SuspendLayout();
            footer_pnl.SuspendLayout();
            form_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_icn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lock_icn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)id_icn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mail_icn).BeginInit();
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
            root_table.Size = new Size(890, 584);
            root_table.TabIndex = 0;
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(hero_grid);
            hero_pnl.Dock = DockStyle.Fill;
            hero_pnl.Location = new Point(3, 3);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(40);
            hero_pnl.Size = new Size(439, 578);
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
            hero_grid.Size = new Size(359, 498);
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
            brand_row.Size = new Size(359, 96);
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
            brand_stack.Size = new Size(276, 96);
            brand_stack.TabIndex = 1;
            // 
            // brand_lbl
            // 
            brand_lbl.Dock = DockStyle.Fill;
            brand_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brand_lbl.Location = new Point(0, 8);
            brand_lbl.Margin = new Padding(0);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(276, 50);
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
            wordmark_lbl.Size = new Size(276, 38);
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
            hero_spacer.Size = new Size(359, 242);
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
            hero_quote.Size = new Size(359, 160);
            hero_quote.TabIndex = 2;
            // 
            // tagline_lbl
            // 
            tagline_lbl.Dock = DockStyle.Fill;
            tagline_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline_lbl.Location = new Point(0, 0);
            tagline_lbl.Margin = new Padding(0);
            tagline_lbl.Name = "tagline_lbl";
            tagline_lbl.Size = new Size(359, 52);
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
            tagline2_lbl.Size = new Size(359, 52);
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
            subtag_lbl.Size = new Size(359, 50);
            subtag_lbl.TabIndex = 2;
            subtag_lbl.Tag = "hero-muted";
            subtag_lbl.Text = "One account unlocks every module — analytics, alerts, AI.";
            // 
            // form_host
            // 
            form_host.Controls.Add(footer_pnl);
            form_host.Controls.Add(form_table);
            form_host.Dock = DockStyle.Fill;
            form_host.Location = new Point(448, 3);
            form_host.Name = "form_host";
            form_host.Padding = new Padding(48, 28, 48, 28);
            form_host.Size = new Size(439, 578);
            form_host.TabIndex = 1;
            form_host.Tag = "base";
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
            footer_pnl.Location = new Point(48, 504);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.RowCount = 2;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footer_pnl.Size = new Size(343, 46);
            footer_pnl.TabIndex = 1;
            // 
            // divider_pnl
            // 
            footer_pnl.SetColumnSpan(divider_pnl, 2);
            divider_pnl.Dock = DockStyle.Fill;
            divider_pnl.Location = new Point(0, 0);
            divider_pnl.Margin = new Padding(0, 0, 0, 10);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(343, 1);
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
            signin_hint_lbl.Size = new Size(183, 45);
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
            return_btn.Location = new Point(183, 1);
            return_btn.Margin = new Padding(0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(160, 45);
            return_btn.TabIndex = 6;
            return_btn.Tag = "ghost";
            return_btn.Text = "Sign in";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // form_table
            // 
            form_table.ColumnCount = 1;
            form_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_table.Controls.Add(title_lbl, 0, 1);
            form_table.Controls.Add(subtitle_lbl, 0, 2);
            form_table.Controls.Add(username_lbl, 0, 4);
            form_table.Controls.Add(username_host, 0, 5);
            form_table.Controls.Add(password_lbl, 0, 7);
            form_table.Controls.Add(password_host, 0, 8);
            form_table.Controls.Add(fullname_lbl, 0, 10);
            form_table.Controls.Add(fullname_host, 0, 11);
            form_table.Controls.Add(email_lbl, 0, 13);
            form_table.Controls.Add(email_host, 0, 14);
            form_table.Controls.Add(create_btn, 0, 16);
            form_table.Dock = DockStyle.Fill;
            form_table.Location = new Point(48, 28);
            form_table.Margin = new Padding(0);
            form_table.Name = "form_table";
            form_table.RowCount = 17;
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            form_table.Size = new Size(343, 522);
            form_table.TabIndex = 0;
            // 
            // title_lbl
            // 
            title_lbl.Dock = DockStyle.Fill;
            title_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title_lbl.Location = new Point(0, 8);
            title_lbl.Margin = new Padding(0);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(343, 40);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Create your account";
            title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtitle_lbl
            // 
            subtitle_lbl.Dock = DockStyle.Fill;
            subtitle_lbl.Font = new Font("Segoe UI", 9.5F);
            subtitle_lbl.Location = new Point(0, 48);
            subtitle_lbl.Margin = new Padding(0);
            subtitle_lbl.Name = "subtitle_lbl";
            subtitle_lbl.Size = new Size(343, 24);
            subtitle_lbl.TabIndex = 1;
            subtitle_lbl.Tag = "muted";
            subtitle_lbl.Text = "A verification code will be sent to your email.";
            subtitle_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_lbl
            // 
            username_lbl.Location = new Point(3, 92);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(100, 18);
            username_lbl.TabIndex = 2;
            // 
            // username_host
            // 
            username_host.Dock = DockStyle.Fill;
            username_host.Location = new Point(3, 113);
            username_host.Name = "username_host";
            username_host.Size = new Size(337, 38);
            username_host.TabIndex = 3;
            // 
            // password_lbl
            // 
            password_lbl.Location = new Point(3, 164);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(100, 18);
            password_lbl.TabIndex = 4;
            // 
            // password_host
            // 
            password_host.Dock = DockStyle.Fill;
            password_host.Location = new Point(3, 185);
            password_host.Name = "password_host";
            password_host.Size = new Size(337, 38);
            password_host.TabIndex = 5;
            // 
            // fullname_lbl
            // 
            fullname_lbl.Location = new Point(3, 236);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(100, 18);
            fullname_lbl.TabIndex = 6;
            // 
            // fullname_host
            // 
            fullname_host.Dock = DockStyle.Fill;
            fullname_host.Location = new Point(3, 257);
            fullname_host.Name = "fullname_host";
            fullname_host.Size = new Size(337, 38);
            fullname_host.TabIndex = 7;
            // 
            // email_lbl
            // 
            email_lbl.Location = new Point(3, 308);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(100, 18);
            email_lbl.TabIndex = 8;
            // 
            // email_host
            // 
            email_host.Dock = DockStyle.Fill;
            email_host.Location = new Point(3, 329);
            email_host.Name = "email_host";
            email_host.Size = new Size(337, 38);
            email_host.TabIndex = 9;
            // 
            // create_btn
            // 
            create_btn.Cursor = Cursors.Hand;
            create_btn.Dock = DockStyle.Top;
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Font = new Font("Segoe UI Semibold", 11F);
            create_btn.Location = new Point(0, 388);
            create_btn.Margin = new Padding(0);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(343, 66);
            create_btn.TabIndex = 5;
            create_btn.Tag = "cta";
            create_btn.Text = "Send verification  →";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // username_inner
            // 
            username_inner.Location = new Point(0, 0);
            username_inner.Name = "username_inner";
            username_inner.Size = new Size(200, 100);
            username_inner.TabIndex = 0;
            // 
            // user_icn
            // 
            user_icn.BackColor = SystemColors.Control;
            user_icn.ForeColor = SystemColors.ControlText;
            user_icn.IconChar = IconChar.None;
            user_icn.IconColor = SystemColors.ControlText;
            user_icn.IconFont = IconFont.Auto;
            user_icn.Location = new Point(0, 0);
            user_icn.Name = "user_icn";
            user_icn.Size = new Size(32, 32);
            user_icn.TabIndex = 0;
            user_icn.TabStop = false;
            // 
            // username_tb
            // 
            username_tb.Location = new Point(0, 0);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(100, 27);
            username_tb.TabIndex = 1;
            // 
            // password_inner
            // 
            password_inner.Location = new Point(0, 0);
            password_inner.Name = "password_inner";
            password_inner.Size = new Size(200, 100);
            password_inner.TabIndex = 0;
            // 
            // lock_icn
            // 
            lock_icn.BackColor = SystemColors.Control;
            lock_icn.ForeColor = SystemColors.ControlText;
            lock_icn.IconChar = IconChar.None;
            lock_icn.IconColor = SystemColors.ControlText;
            lock_icn.IconFont = IconFont.Auto;
            lock_icn.Location = new Point(0, 0);
            lock_icn.Name = "lock_icn";
            lock_icn.Size = new Size(32, 32);
            lock_icn.TabIndex = 0;
            lock_icn.TabStop = false;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(0, 0);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(100, 27);
            password_tb.TabIndex = 2;
            // 
            // fullname_inner
            // 
            fullname_inner.Location = new Point(0, 0);
            fullname_inner.Name = "fullname_inner";
            fullname_inner.Size = new Size(200, 100);
            fullname_inner.TabIndex = 0;
            // 
            // id_icn
            // 
            id_icn.BackColor = SystemColors.Control;
            id_icn.ForeColor = SystemColors.ControlText;
            id_icn.IconChar = IconChar.None;
            id_icn.IconColor = SystemColors.ControlText;
            id_icn.IconFont = IconFont.Auto;
            id_icn.Location = new Point(0, 0);
            id_icn.Name = "id_icn";
            id_icn.Size = new Size(32, 32);
            id_icn.TabIndex = 0;
            id_icn.TabStop = false;
            // 
            // fullname_tb
            // 
            fullname_tb.Location = new Point(0, 0);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(100, 27);
            fullname_tb.TabIndex = 3;
            // 
            // email_inner
            // 
            email_inner.Location = new Point(0, 0);
            email_inner.Name = "email_inner";
            email_inner.Size = new Size(200, 100);
            email_inner.TabIndex = 0;
            // 
            // mail_icn
            // 
            mail_icn.BackColor = SystemColors.Control;
            mail_icn.ForeColor = SystemColors.ControlText;
            mail_icn.IconChar = IconChar.None;
            mail_icn.IconColor = SystemColors.ControlText;
            mail_icn.IconFont = IconFont.Auto;
            mail_icn.Location = new Point(0, 0);
            mail_icn.Name = "mail_icn";
            mail_icn.Size = new Size(32, 32);
            mail_icn.TabIndex = 0;
            mail_icn.TabStop = false;
            // 
            // email_tb
            // 
            email_tb.Location = new Point(0, 0);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(100, 27);
            email_tb.TabIndex = 4;
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
            // add_instance_pnl
            // 
            add_instance_pnl.Location = new Point(0, 0);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Size = new Size(200, 100);
            add_instance_pnl.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // settings_lbl
            // 
            settings_lbl.Location = new Point(0, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(100, 23);
            settings_lbl.TabIndex = 0;
            // 
            // db_lbl
            // 
            db_lbl.Location = new Point(0, 0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(100, 23);
            db_lbl.TabIndex = 0;
            // 
            // selector_pnl
            // 
            selector_pnl.Location = new Point(0, 0);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Size = new Size(200, 100);
            selector_pnl.TabIndex = 0;
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
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_table);
            Name = "AddAccount";
            Size = new Size(890, 584);
            root_table.ResumeLayout(false);
            hero_pnl.ResumeLayout(false);
            hero_grid.ResumeLayout(false);
            brand_row.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brand_icn).EndInit();
            brand_stack.ResumeLayout(false);
            hero_quote.ResumeLayout(false);
            form_host.ResumeLayout(false);
            footer_pnl.ResumeLayout(false);
            form_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_icn).EndInit();
            ((System.ComponentModel.ISupportInitialize)lock_icn).EndInit();
            ((System.ComponentModel.ISupportInitialize)id_icn).EndInit();
            ((System.ComponentModel.ISupportInitialize)mail_icn).EndInit();
            ResumeLayout(false);
        }

        // --- Local helpers (kept inside Designer for self-containment) -----------------
        private static void ConfigureFieldLabel(Label lbl, string caption)
        {
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lbl.Text = caption;
            lbl.TextAlign = ContentAlignment.BottomLeft;
            lbl.Tag = "muted";
            lbl.Margin = new Padding(0, 0, 0, 2);
        }

        private static void ConfigureInputHost(
            Panel host, TableLayoutPanel inner, IconPictureBox icon,
            TextBox tb, IconChar iconChar, bool isPassword, int tabIndex, string name)
        {
            host.Dock = DockStyle.Fill;
            host.Tag = "input";
            host.Margin = new Padding(0);
            host.Name = name + "_host";
            host.Controls.Add(inner);

            inner.Dock = DockStyle.Fill;
            inner.ColumnCount = 2;
            inner.RowCount = 1;
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inner.Controls.Add(icon, 0, 0);
            inner.Controls.Add(tb, 1, 0);
            inner.Padding = new Padding(0, 0, 12, 0);
            inner.Margin = new Padding(0);
            inner.Name = name + "_inner";

            icon.IconChar = iconChar;
            icon.IconSize = 16;
            icon.Size = new Size(40, 44);
            icon.SizeMode = PictureBoxSizeMode.CenterImage;
            icon.Tag = "input";
            icon.Margin = new Padding(0);
            icon.Name = name + "_icn";
            icon.TabStop = false;

            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb.BorderStyle = BorderStyle.None;
            tb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            tb.UseSystemPasswordChar = isPassword;
            tb.Tag = "flat";
            tb.Location = new Point(0, 12);
            tb.Size = new Size(200, 20);
            tb.Margin = new Padding(0);
            tb.Name = name + "_tb";
            tb.TabIndex = tabIndex;
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
        private Label            title_lbl;
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

        private Label            fullname_lbl;
        private Panel            fullname_host;
        private TableLayoutPanel fullname_inner;
        private IconPictureBox   id_icn;
        private TextBox          fullname_tb;

        private Label            email_lbl;
        private Panel            email_host;
        private TableLayoutPanel email_inner;
        private IconPictureBox   mail_icn;
        private TextBox          email_tb;

        private Button           create_btn;
        private Panel            divider_pnl;
        private TableLayoutPanel footer_pnl;
        private Button           return_btn;
        private Label            signin_hint_lbl;

        // Legacy placeholders
        private Panel            base_pnl;
        private Panel            panel1;
        private Panel            add_instance_pnl;
        private GroupBox         groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label            settings_lbl;
        private Label            db_lbl;
        private Panel            selector_pnl;
        private Label            label1;
        private Label            label2;
        private Label            label3;
    }
}
