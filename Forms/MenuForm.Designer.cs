namespace SmartStock.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            root_shell = new TableLayoutPanel();
            menu_pnl = new Panel();
            menu_stack = new TableLayoutPanel();
            brand_pnl = new Panel();
            brand_grid = new TableLayoutPanel();
            logo_pc = new FontAwesome.Sharp.IconPictureBox();
            brand_text_pnl = new TableLayoutPanel();
            restart_lbl = new Label();
            restart_lbl2 = new Label();
            menu_buttons_pnl = new Panel();
            settings_btn = new FontAwesome.Sharp.IconButton();
            analyze_btn = new FontAwesome.Sharp.IconButton();
            search_btn = new FontAwesome.Sharp.IconButton();
            add_btn = new FontAwesome.Sharp.IconButton();
            user_footer_pnl = new Panel();
            user_card_pnl = new Panel();
            user_card_grid = new TableLayoutPanel();
            user_avatar_pc = new FontAwesome.Sharp.IconPictureBox();
            user_text_grid = new TableLayoutPanel();
            user_name_lbl = new Label();
            user_role_lbl = new Label();
            user_divider = new Panel();
            right_host = new Panel();
            desktop_pnl = new Panel();
            bottom_pnl = new Panel();
            bottom_grid = new TableLayoutPanel();
            panel1 = new Panel();
            status_lbl = new Label();
            version_lbl = new Label();
            titlebar_pnl = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            minimize_btn = new FontAwesome.Sharp.IconButton();
            maximize_btn = new FontAwesome.Sharp.IconButton();
            close_btn = new FontAwesome.Sharp.IconButton();
            titlebar_divider = new Panel();
            logo_pnl = new Panel();
            accent_pnl = new Panel();
            workplace_pnl = new Panel();
            workplace_layout = new TableLayoutPanel();
            root_shell.SuspendLayout();
            menu_pnl.SuspendLayout();
            menu_stack.SuspendLayout();
            brand_pnl.SuspendLayout();
            brand_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_pc).BeginInit();
            brand_text_pnl.SuspendLayout();
            menu_buttons_pnl.SuspendLayout();
            user_footer_pnl.SuspendLayout();
            user_card_pnl.SuspendLayout();
            user_card_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_avatar_pc).BeginInit();
            user_text_grid.SuspendLayout();
            right_host.SuspendLayout();
            bottom_pnl.SuspendLayout();
            bottom_grid.SuspendLayout();
            titlebar_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // root_shell
            // 
            root_shell.ColumnCount = 2;
            root_shell.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            root_shell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            root_shell.Controls.Add(menu_pnl, 0, 0);
            root_shell.Controls.Add(right_host, 1, 0);
            root_shell.Dock = DockStyle.Fill;
            root_shell.Location = new Point(0, 0);
            root_shell.Margin = new Padding(0);
            root_shell.Name = "root_shell";
            root_shell.RowCount = 1;
            root_shell.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_shell.Size = new Size(1361, 757);
            root_shell.TabIndex = 0;
            // 
            // menu_pnl
            // 
            menu_pnl.Controls.Add(menu_stack);
            menu_pnl.Dock = DockStyle.Fill;
            menu_pnl.Location = new Point(0, 0);
            menu_pnl.Margin = new Padding(0);
            menu_pnl.MinimumSize = new Size(320, 0);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(320, 757);
            menu_pnl.TabIndex = 0;
            menu_pnl.Tag = "base";
            // 
            // menu_stack
            // 
            menu_stack.ColumnCount = 1;
            menu_stack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menu_stack.Controls.Add(brand_pnl, 0, 0);
            menu_stack.Controls.Add(menu_buttons_pnl, 0, 1);
            menu_stack.Controls.Add(user_footer_pnl, 0, 2);
            menu_stack.Dock = DockStyle.Fill;
            menu_stack.Location = new Point(0, 0);
            menu_stack.Margin = new Padding(0);
            menu_stack.Name = "menu_stack";
            menu_stack.RowCount = 3;
            menu_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            menu_stack.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menu_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            menu_stack.Size = new Size(320, 757);
            menu_stack.TabIndex = 0;
            // 
            // brand_pnl
            // 
            brand_pnl.Controls.Add(brand_grid);
            brand_pnl.Dock = DockStyle.Fill;
            brand_pnl.Location = new Point(0, 0);
            brand_pnl.Margin = new Padding(0);
            brand_pnl.Name = "brand_pnl";
            brand_pnl.Padding = new Padding(24, 24, 0, 16);
            brand_pnl.Size = new Size(320, 128);
            brand_pnl.TabIndex = 0;
            brand_pnl.Tag = "base";
            // 
            // brand_grid
            // 
            brand_grid.ColumnCount = 2;
            brand_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            brand_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_grid.Controls.Add(logo_pc, 0, 0);
            brand_grid.Controls.Add(brand_text_pnl, 1, 0);
            brand_grid.Dock = DockStyle.Fill;
            brand_grid.Location = new Point(24, 24);
            brand_grid.Margin = new Padding(0);
            brand_grid.Name = "brand_grid";
            brand_grid.RowCount = 1;
            brand_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            brand_grid.Size = new Size(296, 88);
            brand_grid.TabIndex = 0;
            // 
            // logo_pc
            // 
            logo_pc.Anchor = AnchorStyles.Left;
            logo_pc.BackColor = Color.Transparent;
            logo_pc.ForeColor = SystemColors.ControlText;
            logo_pc.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            logo_pc.IconColor = SystemColors.ControlText;
            logo_pc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logo_pc.IconSize = 60;
            logo_pc.Location = new Point(0, 12);
            logo_pc.Margin = new Padding(0, 8, 12, 0);
            logo_pc.Name = "logo_pc";
            logo_pc.Size = new Size(60, 72);
            logo_pc.SizeMode = PictureBoxSizeMode.CenterImage;
            logo_pc.TabIndex = 0;
            logo_pc.TabStop = false;
            logo_pc.Tag = "accent-icon";
            // 
            // brand_text_pnl
            // 
            brand_text_pnl.ColumnCount = 1;
            brand_text_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_text_pnl.Controls.Add(restart_lbl, 0, 0);
            brand_text_pnl.Controls.Add(restart_lbl2, 0, 1);
            brand_text_pnl.Dock = DockStyle.Fill;
            brand_text_pnl.Location = new Point(72, 0);
            brand_text_pnl.Margin = new Padding(0);
            brand_text_pnl.Name = "brand_text_pnl";
            brand_text_pnl.Padding = new Padding(0, 10, 0, 0);
            brand_text_pnl.RowCount = 2;
            brand_text_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            brand_text_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            brand_text_pnl.Size = new Size(224, 88);
            brand_text_pnl.TabIndex = 1;
            // 
            // restart_lbl
            // 
            restart_lbl.Dock = DockStyle.Top;
            restart_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restart_lbl.Location = new Point(0, 10);
            restart_lbl.Margin = new Padding(0);
            restart_lbl.Name = "restart_lbl";
            restart_lbl.Size = new Size(224, 36);
            restart_lbl.TabIndex = 0;
            restart_lbl.Tag = "accent";
            restart_lbl.Text = "Smart Stock";
            // 
            // restart_lbl2
            // 
            restart_lbl2.Dock = DockStyle.Fill;
            restart_lbl2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            restart_lbl2.Location = new Point(0, 56);
            restart_lbl2.Margin = new Padding(0, 10, 0, 0);
            restart_lbl2.Name = "restart_lbl2";
            restart_lbl2.Size = new Size(224, 32);
            restart_lbl2.TabIndex = 1;
            restart_lbl2.Tag = "muted";
            restart_lbl2.Text = "INVENTORY  ·  INTELLIGENCE";
            // 
            // menu_buttons_pnl
            // 
            menu_buttons_pnl.Controls.Add(settings_btn);
            menu_buttons_pnl.Controls.Add(analyze_btn);
            menu_buttons_pnl.Controls.Add(search_btn);
            menu_buttons_pnl.Controls.Add(add_btn);
            menu_buttons_pnl.Dock = DockStyle.Fill;
            menu_buttons_pnl.Location = new Point(0, 128);
            menu_buttons_pnl.Margin = new Padding(0);
            menu_buttons_pnl.Name = "menu_buttons_pnl";
            menu_buttons_pnl.Padding = new Padding(12);
            menu_buttons_pnl.Size = new Size(320, 513);
            menu_buttons_pnl.TabIndex = 1;
            menu_buttons_pnl.Tag = "base";
            // 
            // settings_btn
            // 
            settings_btn.BackColor = Color.Transparent;
            settings_btn.Cursor = Cursors.Hand;
            settings_btn.Dock = DockStyle.Top;
            settings_btn.FlatAppearance.BorderSize = 0;
            settings_btn.FlatStyle = FlatStyle.Flat;
            settings_btn.Font = new Font("Segoe UI Semibold", 11F);
            settings_btn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            settings_btn.IconColor = Color.Black;
            settings_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settings_btn.IconSize = 24;
            settings_btn.ImageAlign = ContentAlignment.MiddleLeft;
            settings_btn.Location = new Point(12, 168);
            settings_btn.Margin = new Padding(0, 4, 0, 4);
            settings_btn.MinimumSize = new Size(0, 52);
            settings_btn.Name = "settings_btn";
            settings_btn.Padding = new Padding(18, 0, 12, 0);
            settings_btn.Size = new Size(296, 52);
            settings_btn.TabIndex = 4;
            settings_btn.Tag = "menu";
            settings_btn.Text = "  Settings";
            settings_btn.TextAlign = ContentAlignment.MiddleLeft;
            settings_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            settings_btn.UseVisualStyleBackColor = false;
            settings_btn.Click += settings_btn_Click;
            // 
            // analyze_btn
            // 
            analyze_btn.BackColor = Color.Transparent;
            analyze_btn.Cursor = Cursors.Hand;
            analyze_btn.Dock = DockStyle.Top;
            analyze_btn.FlatAppearance.BorderSize = 0;
            analyze_btn.FlatStyle = FlatStyle.Flat;
            analyze_btn.Font = new Font("Segoe UI Semibold", 11F);
            analyze_btn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            analyze_btn.IconColor = Color.Black;
            analyze_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            analyze_btn.IconSize = 24;
            analyze_btn.ImageAlign = ContentAlignment.MiddleLeft;
            analyze_btn.Location = new Point(12, 116);
            analyze_btn.Margin = new Padding(0, 4, 0, 4);
            analyze_btn.MinimumSize = new Size(0, 52);
            analyze_btn.Name = "analyze_btn";
            analyze_btn.Padding = new Padding(18, 0, 12, 0);
            analyze_btn.Size = new Size(296, 52);
            analyze_btn.TabIndex = 3;
            analyze_btn.Tag = "menu";
            analyze_btn.Text = "  Analyze";
            analyze_btn.TextAlign = ContentAlignment.MiddleLeft;
            analyze_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            analyze_btn.UseVisualStyleBackColor = false;
            analyze_btn.Click += analyze_btn_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Transparent;
            search_btn.Cursor = Cursors.Hand;
            search_btn.Dock = DockStyle.Top;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 11F);
            search_btn.IconChar = FontAwesome.Sharp.IconChar.Search;
            search_btn.IconColor = Color.Black;
            search_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            search_btn.IconSize = 24;
            search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            search_btn.Location = new Point(12, 64);
            search_btn.Margin = new Padding(0, 4, 0, 4);
            search_btn.MinimumSize = new Size(0, 52);
            search_btn.Name = "search_btn";
            search_btn.Padding = new Padding(18, 0, 12, 0);
            search_btn.Size = new Size(296, 52);
            search_btn.TabIndex = 1;
            search_btn.Tag = "menu";
            search_btn.Text = "  Search";
            search_btn.TextAlign = ContentAlignment.MiddleLeft;
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Transparent;
            add_btn.Cursor = Cursors.Hand;
            add_btn.Dock = DockStyle.Top;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI Semibold", 11F);
            add_btn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_btn.IconColor = Color.Black;
            add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_btn.IconSize = 24;
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(12, 12);
            add_btn.Margin = new Padding(0, 4, 0, 4);
            add_btn.MinimumSize = new Size(0, 52);
            add_btn.Name = "add_btn";
            add_btn.Padding = new Padding(18, 0, 12, 0);
            add_btn.Size = new Size(296, 52);
            add_btn.TabIndex = 0;
            add_btn.Tag = "menu";
            add_btn.Text = "  Add / Modify";
            add_btn.TextAlign = ContentAlignment.MiddleLeft;
            add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // user_footer_pnl
            // 
            user_footer_pnl.Controls.Add(user_card_pnl);
            user_footer_pnl.Controls.Add(user_divider);
            user_footer_pnl.Dock = DockStyle.Fill;
            user_footer_pnl.Location = new Point(0, 641);
            user_footer_pnl.Margin = new Padding(0);
            user_footer_pnl.Name = "user_footer_pnl";
            user_footer_pnl.Padding = new Padding(12, 0, 12, 12);
            user_footer_pnl.Size = new Size(320, 116);
            user_footer_pnl.TabIndex = 2;
            user_footer_pnl.Tag = "base";
            // 
            // user_card_pnl
            // 
            user_card_pnl.Controls.Add(user_card_grid);
            user_card_pnl.Dock = DockStyle.Fill;
            user_card_pnl.Location = new Point(12, 1);
            user_card_pnl.Margin = new Padding(0, 12, 0, 0);
            user_card_pnl.Name = "user_card_pnl";
            user_card_pnl.Padding = new Padding(12, 10, 12, 10);
            user_card_pnl.Size = new Size(296, 103);
            user_card_pnl.TabIndex = 1;
            user_card_pnl.Tag = "base";
            // 
            // user_card_grid
            // 
            user_card_grid.ColumnCount = 2;
            user_card_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            user_card_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            user_card_grid.Controls.Add(user_avatar_pc, 0, 0);
            user_card_grid.Controls.Add(user_text_grid, 1, 0);
            user_card_grid.Dock = DockStyle.Fill;
            user_card_grid.Location = new Point(12, 10);
            user_card_grid.Margin = new Padding(0);
            user_card_grid.Name = "user_card_grid";
            user_card_grid.RowCount = 1;
            user_card_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            user_card_grid.Size = new Size(272, 83);
            user_card_grid.TabIndex = 0;
            user_card_grid.Tag = "";
            // 
            // user_avatar_pc
            // 
            user_avatar_pc.Anchor = AnchorStyles.Left;
            user_avatar_pc.BackColor = Color.Transparent;
            user_avatar_pc.ForeColor = SystemColors.ControlText;
            user_avatar_pc.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            user_avatar_pc.IconColor = SystemColors.ControlText;
            user_avatar_pc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            user_avatar_pc.IconSize = 38;
            user_avatar_pc.Location = new Point(0, 17);
            user_avatar_pc.Margin = new Padding(0, 0, 10, 0);
            user_avatar_pc.Name = "user_avatar_pc";
            user_avatar_pc.Size = new Size(38, 48);
            user_avatar_pc.SizeMode = PictureBoxSizeMode.CenterImage;
            user_avatar_pc.TabIndex = 0;
            user_avatar_pc.TabStop = false;
            user_avatar_pc.Tag = "accent-icon";
            // 
            // user_text_grid
            // 
            user_text_grid.ColumnCount = 1;
            user_text_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            user_text_grid.Controls.Add(user_name_lbl, 0, 0);
            user_text_grid.Controls.Add(user_role_lbl, 0, 1);
            user_text_grid.Dock = DockStyle.Fill;
            user_text_grid.Location = new Point(48, 0);
            user_text_grid.Margin = new Padding(0);
            user_text_grid.Name = "user_text_grid";
            user_text_grid.RowCount = 2;
            user_text_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            user_text_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            user_text_grid.Size = new Size(224, 83);
            user_text_grid.TabIndex = 1;
            // 
            // user_name_lbl
            // 
            user_name_lbl.AutoEllipsis = true;
            user_name_lbl.Dock = DockStyle.Fill;
            user_name_lbl.Font = new Font("Segoe UI Semibold", 10F);
            user_name_lbl.Location = new Point(0, 0);
            user_name_lbl.Margin = new Padding(0);
            user_name_lbl.Name = "user_name_lbl";
            user_name_lbl.Size = new Size(224, 45);
            user_name_lbl.TabIndex = 0;
            user_name_lbl.Text = "Guest";
            user_name_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // user_role_lbl
            // 
            user_role_lbl.AutoEllipsis = true;
            user_role_lbl.Dock = DockStyle.Fill;
            user_role_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            user_role_lbl.Location = new Point(0, 45);
            user_role_lbl.Margin = new Padding(0);
            user_role_lbl.Name = "user_role_lbl";
            user_role_lbl.Size = new Size(224, 38);
            user_role_lbl.TabIndex = 1;
            user_role_lbl.Tag = "muted";
            user_role_lbl.Text = "OFFLINE";
            // 
            // user_divider
            // 
            user_divider.Dock = DockStyle.Top;
            user_divider.Location = new Point(12, 0);
            user_divider.Margin = new Padding(0, 0, 0, 12);
            user_divider.Name = "user_divider";
            user_divider.Size = new Size(296, 1);
            user_divider.TabIndex = 0;
            user_divider.Tag = "divider";
            // 
            // right_host
            // 
            right_host.Controls.Add(desktop_pnl);
            right_host.Controls.Add(bottom_pnl);
            right_host.Controls.Add(titlebar_pnl);
            right_host.Dock = DockStyle.Fill;
            right_host.Location = new Point(320, 0);
            right_host.Margin = new Padding(0);
            right_host.Name = "right_host";
            right_host.Size = new Size(1041, 757);
            right_host.TabIndex = 1;
            right_host.Tag = "base";
            // 
            // desktop_pnl
            // 
            desktop_pnl.Dock = DockStyle.Fill;
            desktop_pnl.Location = new Point(0, 43);
            desktop_pnl.Margin = new Padding(0);
            desktop_pnl.Name = "desktop_pnl";
            desktop_pnl.Size = new Size(1041, 671);
            desktop_pnl.TabIndex = 1;
            desktop_pnl.Tag = "workplace";
            // 
            // bottom_pnl
            // 
            bottom_pnl.Controls.Add(bottom_grid);
            bottom_pnl.Dock = DockStyle.Bottom;
            bottom_pnl.Location = new Point(0, 714);
            bottom_pnl.Margin = new Padding(0);
            bottom_pnl.Name = "bottom_pnl";
            bottom_pnl.Size = new Size(1041, 43);
            bottom_pnl.TabIndex = 2;
            bottom_pnl.Tag = "base";
            // 
            // bottom_grid
            // 
            bottom_grid.ColumnCount = 2;
            bottom_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bottom_grid.ColumnStyles.Add(new ColumnStyle());
            bottom_grid.Controls.Add(panel1, 0, 0);
            bottom_grid.Controls.Add(status_lbl, 0, 1);
            bottom_grid.Controls.Add(version_lbl, 1, 1);
            bottom_grid.Dock = DockStyle.Fill;
            bottom_grid.Location = new Point(0, 0);
            bottom_grid.Margin = new Padding(0);
            bottom_grid.Name = "bottom_grid";
            bottom_grid.Padding = new Padding(24, 0, 24, 0);
            bottom_grid.RowCount = 2;
            bottom_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottom_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            bottom_grid.Size = new Size(1041, 43);
            bottom_grid.TabIndex = 0;
            // 
            // panel1
            // 
            bottom_grid.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(27, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 1);
            panel1.TabIndex = 2;
            panel1.Tag = "divider";
            // 
            // status_lbl
            // 
            status_lbl.Dock = DockStyle.Fill;
            status_lbl.Font = new Font("Segoe UI", 8.25F);
            status_lbl.Location = new Point(24, 9);
            status_lbl.Margin = new Padding(0);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(885, 34);
            status_lbl.TabIndex = 0;
            status_lbl.Tag = "muted";
            status_lbl.Text = "Ready";
            status_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // version_lbl
            // 
            version_lbl.AutoSize = true;
            version_lbl.Dock = DockStyle.Fill;
            version_lbl.Font = new Font("Segoe UI", 8.25F);
            version_lbl.Location = new Point(909, 9);
            version_lbl.Margin = new Padding(0);
            version_lbl.Name = "version_lbl";
            version_lbl.Size = new Size(108, 34);
            version_lbl.TabIndex = 1;
            version_lbl.Tag = "muted";
            version_lbl.Text = "SmartStock v1.0";
            version_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // titlebar_pnl
            // 
            titlebar_pnl.Controls.Add(tableLayoutPanel1);
            titlebar_pnl.Controls.Add(titlebar_divider);
            titlebar_pnl.Dock = DockStyle.Top;
            titlebar_pnl.Location = new Point(0, 0);
            titlebar_pnl.Margin = new Padding(0);
            titlebar_pnl.Name = "titlebar_pnl";
            titlebar_pnl.Size = new Size(1041, 43);
            titlebar_pnl.TabIndex = 0;
            titlebar_pnl.Tag = "base";
            titlebar_pnl.MouseDoubleClick += titlebar_pnl_MouseDoubleClick;
            titlebar_pnl.MouseDown += titlebar_pnl_MouseDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(minimize_btn, 0, 0);
            tableLayoutPanel1.Controls.Add(maximize_btn, 1, 0);
            tableLayoutPanel1.Controls.Add(close_btn, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(855, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(186, 42);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // minimize_btn
            // 
            minimize_btn.BackColor = Color.Transparent;
            minimize_btn.Dock = DockStyle.Fill;
            minimize_btn.FlatAppearance.BorderSize = 0;
            minimize_btn.FlatStyle = FlatStyle.Flat;
            minimize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimize_btn.IconColor = Color.Black;
            minimize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimize_btn.IconSize = 30;
            minimize_btn.Location = new Point(3, 3);
            minimize_btn.Name = "minimize_btn";
            minimize_btn.Size = new Size(56, 36);
            minimize_btn.TabIndex = 0;
            minimize_btn.Tag = "titlebar_buttons";
            minimize_btn.UseVisualStyleBackColor = false;
            minimize_btn.Click += minimize_btn_Click;
            // 
            // maximize_btn
            // 
            maximize_btn.Dock = DockStyle.Fill;
            maximize_btn.FlatAppearance.BorderSize = 0;
            maximize_btn.FlatStyle = FlatStyle.Flat;
            maximize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximize_btn.IconColor = Color.Black;
            maximize_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximize_btn.IconSize = 30;
            maximize_btn.Location = new Point(65, 3);
            maximize_btn.Name = "maximize_btn";
            maximize_btn.Size = new Size(56, 36);
            maximize_btn.TabIndex = 1;
            maximize_btn.Tag = "titlebar_buttons";
            maximize_btn.UseVisualStyleBackColor = true;
            maximize_btn.Click += maximize_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Dock = DockStyle.Fill;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            close_btn.IconColor = Color.Black;
            close_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            close_btn.IconSize = 30;
            close_btn.Location = new Point(127, 3);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(56, 36);
            close_btn.TabIndex = 2;
            close_btn.Tag = "titlebar_buttons";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // titlebar_divider
            // 
            titlebar_divider.Dock = DockStyle.Bottom;
            titlebar_divider.Location = new Point(0, 42);
            titlebar_divider.Name = "titlebar_divider";
            titlebar_divider.Size = new Size(1041, 1);
            titlebar_divider.TabIndex = 0;
            titlebar_divider.Tag = "divider";
            // 
            // logo_pnl
            // 
            logo_pnl.Location = new Point(-1000, -1000);
            logo_pnl.Name = "logo_pnl";
            logo_pnl.Size = new Size(1, 1);
            logo_pnl.TabIndex = 0;
            // 
            // accent_pnl
            // 
            accent_pnl.Location = new Point(-1000, -1000);
            accent_pnl.Name = "accent_pnl";
            accent_pnl.Size = new Size(1, 1);
            accent_pnl.TabIndex = 0;
            // 
            // workplace_pnl
            // 
            workplace_pnl.Location = new Point(-1000, -1000);
            workplace_pnl.Name = "workplace_pnl";
            workplace_pnl.Size = new Size(1, 1);
            workplace_pnl.TabIndex = 0;
            // 
            // workplace_layout
            // 
            workplace_layout.Location = new Point(-1000, -1000);
            workplace_layout.Name = "workplace_layout";
            workplace_layout.Size = new Size(1, 1);
            workplace_layout.TabIndex = 0;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 757);
            Controls.Add(root_shell);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartStock";
            WindowState = FormWindowState.Maximized;
            FormClosing += MenuForm_FormClosing;
            root_shell.ResumeLayout(false);
            menu_pnl.ResumeLayout(false);
            menu_stack.ResumeLayout(false);
            brand_pnl.ResumeLayout(false);
            brand_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_pc).EndInit();
            brand_text_pnl.ResumeLayout(false);
            menu_buttons_pnl.ResumeLayout(false);
            user_footer_pnl.ResumeLayout(false);
            user_card_pnl.ResumeLayout(false);
            user_card_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_avatar_pc).EndInit();
            user_text_grid.ResumeLayout(false);
            right_host.ResumeLayout(false);
            bottom_pnl.ResumeLayout(false);
            bottom_grid.ResumeLayout(false);
            bottom_grid.PerformLayout();
            titlebar_pnl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Root
        private TableLayoutPanel root_shell;

        // Sidebar
        private Panel menu_pnl;
        private TableLayoutPanel menu_stack;
        private Panel brand_pnl;
        private TableLayoutPanel brand_grid;
        private FontAwesome.Sharp.IconPictureBox logo_pc;
        private TableLayoutPanel brand_text_pnl;
        private Label restart_lbl;
        private Label restart_lbl2;
        private Panel menu_buttons_pnl;
        private FontAwesome.Sharp.IconButton add_btn;
        private FontAwesome.Sharp.IconButton search_btn;
        private FontAwesome.Sharp.IconButton analyze_btn;
        private FontAwesome.Sharp.IconButton settings_btn;

        // User footer
        private Panel user_footer_pnl;
        private Panel user_divider;
        private Panel user_card_pnl;
        private TableLayoutPanel user_card_grid;
        private FontAwesome.Sharp.IconPictureBox user_avatar_pc;
        private TableLayoutPanel user_text_grid;
        private Label user_name_lbl;
        private Label user_role_lbl;

        // Right column
        private Panel right_host;
        private Panel titlebar_pnl;
        private Panel titlebar_divider;
        private Panel desktop_pnl;
        private Panel bottom_pnl;
        private TableLayoutPanel bottom_grid;
        private Label status_lbl;
        private Label version_lbl;

        // Legacy placeholders (kept to avoid breaking any stray references)
        private Panel logo_pnl;
        private Panel accent_pnl;
        private Panel workplace_pnl;
        private TableLayoutPanel workplace_layout;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton minimize_btn;
        private FontAwesome.Sharp.IconButton maximize_btn;
        private FontAwesome.Sharp.IconButton close_btn;
        private Panel panel1;
    }
}
