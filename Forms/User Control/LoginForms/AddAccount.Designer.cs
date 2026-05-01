using FontAwesome.Sharp;

namespace SmartStock.Forms.AddForms
{
    partial class AddAccount
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            root_table = new TableLayoutPanel();
            title_pnl = new Panel();
            close_btn = new IconButton();
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
            footer_pnl = new TableLayoutPanel();
            panel6 = new Panel();
            label6 = new Label();
            return_btn = new Button();
            title_lbl = new Label();
            subtitle_lbl = new Label();
            username_lbl = new Label();
            username_host = new Panel();
            username_inner = new TableLayoutPanel();
            user_icn = new IconPictureBox();
            username_tb = new TextBox();
            password_lbl = new Label();
            password_host = new Panel();
            password_inner = new TableLayoutPanel();
            view_pass_btn = new IconButton();
            lock_icn = new IconPictureBox();
            password_tb = new TextBox();
            fullname_lbl = new Label();
            fullname_host = new Panel();
            fullname_inner = new TableLayoutPanel();
            id_icn = new IconPictureBox();
            fullname_tb = new TextBox();
            email_lbl = new Label();
            email_host = new Panel();
            email_inner = new TableLayoutPanel();
            mail_icn = new IconPictureBox();
            email_tb = new TextBox();
            create_btn = new Button();
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
            username_host.SuspendLayout();
            username_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_icn).BeginInit();
            password_host.SuspendLayout();
            password_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lock_icn).BeginInit();
            fullname_host.SuspendLayout();
            fullname_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)id_icn).BeginInit();
            email_host.SuspendLayout();
            email_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mail_icn).BeginInit();
            SuspendLayout();
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
            root_table.Size = new Size(966, 728);
            root_table.TabIndex = 0;
            // 
            // title_pnl
            // 
            title_pnl.Controls.Add(close_btn);
            title_pnl.Dock = DockStyle.Fill;
            title_pnl.Location = new Point(486, 3);
            title_pnl.MaximumSize = new Size(0, 30);
            title_pnl.Name = "title_pnl";
            title_pnl.Size = new Size(477, 20);
            title_pnl.TabIndex = 3;
            // 
            // close_btn
            // 
            close_btn.Dock = DockStyle.Right;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.IconChar = IconChar.X;
            close_btn.IconColor = Color.Black;
            close_btn.IconFont = IconFont.Auto;
            close_btn.IconSize = 15;
            close_btn.Location = new Point(462, 0);
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
            hero_pnl.Size = new Size(477, 722);
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
            hero_grid.Size = new Size(397, 642);
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
            brand_stack.Size = new Size(314, 96);
            brand_stack.TabIndex = 1;
            // 
            // brand_lbl
            // 
            brand_lbl.Dock = DockStyle.Fill;
            brand_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brand_lbl.Location = new Point(0, 8);
            brand_lbl.Margin = new Padding(0);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(314, 50);
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
            wordmark_lbl.Size = new Size(314, 38);
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
            hero_spacer.Size = new Size(397, 386);
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
            hero_quote.Location = new Point(0, 482);
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
            tagline2_lbl.Size = new Size(397, 52);
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
            subtag_lbl.Size = new Size(397, 50);
            subtag_lbl.TabIndex = 2;
            subtag_lbl.Tag = "hero-muted";
            subtag_lbl.Text = "One account unlocks every module — analytics, alerts, AI.";
            // 
            // form_host
            // 
            form_host.Controls.Add(form_table);
            form_host.Dock = DockStyle.Fill;
            form_host.Location = new Point(486, 29);
            form_host.Name = "form_host";
            form_host.Padding = new Padding(56, 40, 56, 0);
            form_host.Size = new Size(477, 696);
            form_host.TabIndex = 1;
            form_host.Tag = "base";
            // 
            // form_table
            // 
            form_table.ColumnCount = 1;
            form_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_table.Controls.Add(footer_pnl, 0, 17);
            form_table.Controls.Add(title_lbl, 0, 0);
            form_table.Controls.Add(subtitle_lbl, 0, 1);
            form_table.Controls.Add(username_lbl, 0, 3);
            form_table.Controls.Add(username_host, 0, 4);
            form_table.Controls.Add(password_lbl, 0, 6);
            form_table.Controls.Add(password_host, 0, 7);
            form_table.Controls.Add(fullname_lbl, 0, 9);
            form_table.Controls.Add(fullname_host, 0, 10);
            form_table.Controls.Add(email_lbl, 0, 12);
            form_table.Controls.Add(email_host, 0, 13);
            form_table.Controls.Add(create_btn, 0, 15);
            form_table.Dock = DockStyle.Fill;
            form_table.Location = new Point(56, 40);
            form_table.Margin = new Padding(0);
            form_table.Name = "form_table";
            form_table.RowCount = 18;
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle());
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            form_table.Size = new Size(365, 656);
            form_table.TabIndex = 0;
            // 
            // footer_pnl
            // 
            footer_pnl.ColumnCount = 2;
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            footer_pnl.Controls.Add(panel6, 0, 0);
            footer_pnl.Controls.Add(label6, 0, 1);
            footer_pnl.Controls.Add(return_btn, 1, 1);
            footer_pnl.Dock = DockStyle.Fill;
            footer_pnl.Location = new Point(0, 604);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.RowCount = 2;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footer_pnl.Size = new Size(365, 52);
            footer_pnl.TabIndex = 5;
            // 
            // panel6
            // 
            footer_pnl.SetColumnSpan(panel6, 2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0, 0, 0, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(365, 1);
            panel6.TabIndex = 0;
            panel6.Tag = "divider";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.Location = new Point(0, 1);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(205, 51);
            label6.TabIndex = 1;
            label6.Tag = "muted";
            label6.Text = "Already have an account?";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // return_btn
            // 
            return_btn.Cursor = Cursors.Hand;
            return_btn.Dock = DockStyle.Fill;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI Semibold", 9.5F);
            return_btn.Location = new Point(205, 1);
            return_btn.Margin = new Padding(0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(160, 51);
            return_btn.TabIndex = 7;
            return_btn.Tag = "ghost";
            return_btn.Text = "Sign in";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // title_lbl
            // 
            title_lbl.Dock = DockStyle.Fill;
            title_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title_lbl.Location = new Point(0, 0);
            title_lbl.Margin = new Padding(0);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(365, 40);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Create your account";
            title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtitle_lbl
            // 
            subtitle_lbl.Dock = DockStyle.Fill;
            subtitle_lbl.Font = new Font("Segoe UI", 9.5F);
            subtitle_lbl.Location = new Point(0, 40);
            subtitle_lbl.Margin = new Padding(0);
            subtitle_lbl.Name = "subtitle_lbl";
            subtitle_lbl.Size = new Size(365, 24);
            subtitle_lbl.TabIndex = 1;
            subtitle_lbl.Tag = "muted";
            subtitle_lbl.Text = "A verification code will be sent to your email.";
            subtitle_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // username_lbl
            // 
            username_lbl.Dock = DockStyle.Fill;
            username_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            username_lbl.Location = new Point(0, 84);
            username_lbl.Margin = new Padding(0);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(365, 20);
            username_lbl.TabIndex = 2;
            username_lbl.Tag = "muted";
            username_lbl.Text = "USERNAME";
            username_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // username_host
            // 
            username_host.Controls.Add(username_inner);
            username_host.Dock = DockStyle.Fill;
            username_host.Location = new Point(0, 104);
            username_host.Margin = new Padding(0);
            username_host.Name = "username_host";
            username_host.Size = new Size(365, 44);
            username_host.TabIndex = 0;
            username_host.Tag = "input";
            // 
            // username_inner
            // 
            username_inner.ColumnCount = 2;
            username_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            username_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            username_inner.Controls.Add(user_icn, 0, 0);
            username_inner.Controls.Add(username_tb, 1, 0);
            username_inner.Dock = DockStyle.Fill;
            username_inner.Location = new Point(0, 0);
            username_inner.Margin = new Padding(0);
            username_inner.Name = "username_inner";
            username_inner.RowCount = 1;
            username_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            username_inner.Size = new Size(365, 44);
            username_inner.TabIndex = 0;
            // 
            // user_icn
            // 
            user_icn.BackColor = SystemColors.Control;
            user_icn.Dock = DockStyle.Fill;
            user_icn.ForeColor = SystemColors.ControlText;
            user_icn.IconChar = IconChar.User;
            user_icn.IconColor = SystemColors.ControlText;
            user_icn.IconFont = IconFont.Auto;
            user_icn.IconSize = 40;
            user_icn.Location = new Point(0, 0);
            user_icn.Margin = new Padding(0);
            user_icn.Name = "user_icn";
            user_icn.Size = new Size(40, 44);
            user_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            user_icn.TabIndex = 0;
            user_icn.TabStop = false;
            user_icn.Tag = "input";
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.BorderStyle = BorderStyle.None;
            username_tb.Font = new Font("Segoe UI", 10.5F);
            username_tb.Location = new Point(40, 10);
            username_tb.Margin = new Padding(0, 0, 8, 0);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(317, 24);
            username_tb.TabIndex = 1;
            username_tb.Tag = "flat";
            // 
            // password_lbl
            // 
            password_lbl.Dock = DockStyle.Fill;
            password_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            password_lbl.Location = new Point(0, 158);
            password_lbl.Margin = new Padding(0);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(365, 20);
            password_lbl.TabIndex = 4;
            password_lbl.Tag = "muted";
            password_lbl.Text = "PASSWORD";
            password_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // password_host
            // 
            password_host.Controls.Add(password_inner);
            password_host.Dock = DockStyle.Fill;
            password_host.Location = new Point(0, 178);
            password_host.Margin = new Padding(0);
            password_host.Name = "password_host";
            password_host.Size = new Size(365, 44);
            password_host.TabIndex = 1;
            password_host.Tag = "input";
            // 
            // password_inner
            // 
            password_inner.ColumnCount = 3;
            password_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            password_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            password_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            password_inner.Controls.Add(view_pass_btn, 2, 0);
            password_inner.Controls.Add(lock_icn, 0, 0);
            password_inner.Controls.Add(password_tb, 1, 0);
            password_inner.Dock = DockStyle.Fill;
            password_inner.Location = new Point(0, 0);
            password_inner.Margin = new Padding(0);
            password_inner.Name = "password_inner";
            password_inner.Padding = new Padding(0, 0, 10, 0);
            password_inner.RowCount = 1;
            password_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            password_inner.Size = new Size(365, 44);
            password_inner.TabIndex = 0;
            // 
            // view_pass_btn
            // 
            view_pass_btn.Cursor = Cursors.Hand;
            view_pass_btn.Dock = DockStyle.Fill;
            view_pass_btn.FlatAppearance.BorderSize = 0;
            view_pass_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            view_pass_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            view_pass_btn.FlatStyle = FlatStyle.Flat;
            view_pass_btn.IconChar = IconChar.EyeSlash;
            view_pass_btn.IconColor = Color.Black;
            view_pass_btn.IconFont = IconFont.Auto;
            view_pass_btn.IconSize = 22;
            view_pass_btn.Location = new Point(331, 9);
            view_pass_btn.Margin = new Padding(6, 9, 0, 9);
            view_pass_btn.Name = "view_pass_btn";
            view_pass_btn.Size = new Size(24, 26);
            view_pass_btn.TabIndex = 3;
            view_pass_btn.Tag = "view_pass";
            view_pass_btn.UseVisualStyleBackColor = false;
            // 
            // lock_icn
            // 
            lock_icn.BackColor = SystemColors.Control;
            lock_icn.Dock = DockStyle.Fill;
            lock_icn.ForeColor = SystemColors.ControlText;
            lock_icn.IconChar = IconChar.Lock;
            lock_icn.IconColor = SystemColors.ControlText;
            lock_icn.IconFont = IconFont.Auto;
            lock_icn.IconSize = 40;
            lock_icn.Location = new Point(0, 0);
            lock_icn.Margin = new Padding(0);
            lock_icn.Name = "lock_icn";
            lock_icn.Size = new Size(40, 44);
            lock_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            lock_icn.TabIndex = 0;
            lock_icn.TabStop = false;
            lock_icn.Tag = "input";
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.BorderStyle = BorderStyle.None;
            password_tb.Font = new Font("Segoe UI", 10.5F);
            password_tb.Location = new Point(40, 10);
            password_tb.Margin = new Padding(0, 0, 8, 0);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(277, 24);
            password_tb.TabIndex = 2;
            password_tb.Tag = "flat";
            password_tb.UseSystemPasswordChar = true;
            // 
            // fullname_lbl
            // 
            fullname_lbl.Dock = DockStyle.Fill;
            fullname_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            fullname_lbl.Location = new Point(0, 232);
            fullname_lbl.Margin = new Padding(0);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(365, 20);
            fullname_lbl.TabIndex = 6;
            fullname_lbl.Tag = "muted";
            fullname_lbl.Text = "FULL NAME";
            fullname_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // fullname_host
            // 
            fullname_host.Controls.Add(fullname_inner);
            fullname_host.Dock = DockStyle.Fill;
            fullname_host.Location = new Point(0, 252);
            fullname_host.Margin = new Padding(0);
            fullname_host.Name = "fullname_host";
            fullname_host.Size = new Size(365, 44);
            fullname_host.TabIndex = 2;
            fullname_host.Tag = "input";
            // 
            // fullname_inner
            // 
            fullname_inner.ColumnCount = 2;
            fullname_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            fullname_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fullname_inner.Controls.Add(id_icn, 0, 0);
            fullname_inner.Controls.Add(fullname_tb, 1, 0);
            fullname_inner.Dock = DockStyle.Fill;
            fullname_inner.Location = new Point(0, 0);
            fullname_inner.Margin = new Padding(0);
            fullname_inner.Name = "fullname_inner";
            fullname_inner.RowCount = 1;
            fullname_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fullname_inner.Size = new Size(365, 44);
            fullname_inner.TabIndex = 0;
            // 
            // id_icn
            // 
            id_icn.BackColor = SystemColors.Control;
            id_icn.Dock = DockStyle.Fill;
            id_icn.ForeColor = SystemColors.ControlText;
            id_icn.IconChar = IconChar.Vcard;
            id_icn.IconColor = SystemColors.ControlText;
            id_icn.IconFont = IconFont.Auto;
            id_icn.IconSize = 40;
            id_icn.Location = new Point(0, 0);
            id_icn.Margin = new Padding(0);
            id_icn.Name = "id_icn";
            id_icn.Size = new Size(40, 44);
            id_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            id_icn.TabIndex = 0;
            id_icn.TabStop = false;
            id_icn.Tag = "input";
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.BorderStyle = BorderStyle.None;
            fullname_tb.Font = new Font("Segoe UI", 10.5F);
            fullname_tb.Location = new Point(40, 10);
            fullname_tb.Margin = new Padding(0, 0, 8, 0);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(317, 24);
            fullname_tb.TabIndex = 1;
            fullname_tb.Tag = "flat";
            // 
            // email_lbl
            // 
            email_lbl.Dock = DockStyle.Fill;
            email_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            email_lbl.Location = new Point(0, 306);
            email_lbl.Margin = new Padding(0);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(365, 20);
            email_lbl.TabIndex = 8;
            email_lbl.Tag = "muted";
            email_lbl.Text = "EMAIL";
            email_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // email_host
            // 
            email_host.Controls.Add(email_inner);
            email_host.Dock = DockStyle.Fill;
            email_host.Location = new Point(0, 326);
            email_host.Margin = new Padding(0);
            email_host.Name = "email_host";
            email_host.Size = new Size(365, 44);
            email_host.TabIndex = 3;
            email_host.Tag = "input";
            // 
            // email_inner
            // 
            email_inner.ColumnCount = 2;
            email_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            email_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            email_inner.Controls.Add(mail_icn, 0, 0);
            email_inner.Controls.Add(email_tb, 1, 0);
            email_inner.Dock = DockStyle.Fill;
            email_inner.Location = new Point(0, 0);
            email_inner.Margin = new Padding(0);
            email_inner.Name = "email_inner";
            email_inner.RowCount = 1;
            email_inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            email_inner.Size = new Size(365, 44);
            email_inner.TabIndex = 0;
            // 
            // mail_icn
            // 
            mail_icn.BackColor = SystemColors.Control;
            mail_icn.Dock = DockStyle.Fill;
            mail_icn.ForeColor = SystemColors.ControlText;
            mail_icn.IconChar = IconChar.Envelope;
            mail_icn.IconColor = SystemColors.ControlText;
            mail_icn.IconFont = IconFont.Auto;
            mail_icn.IconSize = 40;
            mail_icn.Location = new Point(0, 0);
            mail_icn.Margin = new Padding(0);
            mail_icn.Name = "mail_icn";
            mail_icn.Size = new Size(40, 44);
            mail_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            mail_icn.TabIndex = 0;
            mail_icn.TabStop = false;
            mail_icn.Tag = "input";
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.BorderStyle = BorderStyle.None;
            email_tb.Font = new Font("Segoe UI", 10.5F);
            email_tb.Location = new Point(40, 10);
            email_tb.Margin = new Padding(0, 0, 8, 0);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(317, 24);
            email_tb.TabIndex = 1;
            email_tb.Tag = "flat";
            // 
            // create_btn
            // 
            create_btn.Cursor = Cursors.Hand;
            create_btn.Dock = DockStyle.Fill;
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Font = new Font("Segoe UI Semibold", 11F);
            create_btn.Location = new Point(0, 398);
            create_btn.Margin = new Padding(0, 0, 0, 16);
            create_btn.MaximumSize = new Size(0, 52);
            create_btn.MinimumSize = new Size(0, 52);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(365, 52);
            create_btn.TabIndex = 4;
            create_btn.Tag = "cta";
            create_btn.Text = "Send verification";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_table);
            Name = "AddAccount";
            Size = new Size(966, 728);
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
            username_host.ResumeLayout(false);
            username_inner.ResumeLayout(false);
            username_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_icn).EndInit();
            password_host.ResumeLayout(false);
            password_inner.ResumeLayout(false);
            password_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lock_icn).EndInit();
            fullname_host.ResumeLayout(false);
            fullname_inner.ResumeLayout(false);
            fullname_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)id_icn).EndInit();
            email_host.ResumeLayout(false);
            email_inner.ResumeLayout(false);
            email_inner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mail_icn).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel title_pnl;
        private IconButton close_btn;
        private Label title_lbl;
        private TableLayoutPanel footer_pnl;
        private Panel panel6;
        private Label label6;
        private Button return_btn;
        private IconButton view_pass_btn;
    }
}
