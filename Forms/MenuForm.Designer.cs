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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            menu_pnl = new Panel();
            menu_buttons_pnl = new Panel();
            settings_btn = new FontAwesome.Sharp.IconButton();
            analyze_btn = new FontAwesome.Sharp.IconButton();
            modify_btn = new FontAwesome.Sharp.IconButton();
            search_btn = new FontAwesome.Sharp.IconButton();
            add_btn = new FontAwesome.Sharp.IconButton();
            logo_pnl = new Panel();
            logo_pc = new FontAwesome.Sharp.IconPictureBox();
            restart_lbl = new Label();
            restart_lbl2 = new Label();
            titlebar_pnl = new Panel();
            accent_pnl = new Panel();
            workplace_pnl = new Panel();
            workplace_layout = new TableLayoutPanel();
            labelCurentChildForm = new Label();
            iconCurentChildForm = new FontAwesome.Sharp.IconPictureBox();
            desktop_pnl = new Panel();
            bottom_pnl = new Panel();
            menu_pnl.SuspendLayout();
            menu_buttons_pnl.SuspendLayout();
            logo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_pc).BeginInit();
            titlebar_pnl.SuspendLayout();
            accent_pnl.SuspendLayout();
            workplace_pnl.SuspendLayout();
            workplace_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).BeginInit();
            SuspendLayout();
            // 
            // menu_pnl
            // 
            menu_pnl.BackColor = Color.FromArgb(54, 54, 54);
            menu_pnl.Controls.Add(menu_buttons_pnl);
            menu_pnl.Controls.Add(logo_pnl);
            menu_pnl.Dock = DockStyle.Left;
            menu_pnl.Location = new Point(0, 1);
            menu_pnl.MinimumSize = new Size(320, 0);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(320, 1001);
            menu_pnl.TabIndex = 0;
            // 
            // menu_buttons_pnl
            // 
            menu_buttons_pnl.AutoScroll = true;
            menu_buttons_pnl.Controls.Add(settings_btn);
            menu_buttons_pnl.Controls.Add(analyze_btn);
            menu_buttons_pnl.Controls.Add(modify_btn);
            menu_buttons_pnl.Controls.Add(search_btn);
            menu_buttons_pnl.Controls.Add(add_btn);
            menu_buttons_pnl.Dock = DockStyle.Fill;
            menu_buttons_pnl.Location = new Point(0, 125);
            menu_buttons_pnl.Name = "menu_buttons_pnl";
            menu_buttons_pnl.Size = new Size(320, 876);
            menu_buttons_pnl.TabIndex = 0;
            menu_buttons_pnl.Tag = "menu";
            // 
            // settings_btn
            // 
            settings_btn.BackColor = Color.Transparent;
            settings_btn.Dock = DockStyle.Bottom;
            settings_btn.FlatAppearance.BorderSize = 0;
            settings_btn.FlatStyle = FlatStyle.Flat;
            settings_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            settings_btn.ForeColor = Color.White;
            settings_btn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            settings_btn.IconColor = Color.White;
            settings_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settings_btn.ImageAlign = ContentAlignment.MiddleLeft;
            settings_btn.Location = new Point(0, 776);
            settings_btn.Name = "settings_btn";
            settings_btn.Padding = new Padding(30, 0, 21, 0);
            settings_btn.Size = new Size(320, 100);
            settings_btn.TabIndex = 7;
            settings_btn.Tag = "menu";
            settings_btn.Text = "Settings";
            settings_btn.TextAlign = ContentAlignment.MiddleLeft;
            settings_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            settings_btn.UseVisualStyleBackColor = false;
            settings_btn.Click += settings_btn_Click;
            // 
            // analyze_btn
            // 
            analyze_btn.BackColor = Color.Transparent;
            analyze_btn.Dock = DockStyle.Top;
            analyze_btn.FlatAppearance.BorderSize = 0;
            analyze_btn.FlatStyle = FlatStyle.Flat;
            analyze_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            analyze_btn.ForeColor = Color.White;
            analyze_btn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            analyze_btn.IconColor = Color.White;
            analyze_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            analyze_btn.ImageAlign = ContentAlignment.MiddleLeft;
            analyze_btn.Location = new Point(0, 300);
            analyze_btn.Name = "analyze_btn";
            analyze_btn.Padding = new Padding(30, 0, 21, 0);
            analyze_btn.Size = new Size(320, 100);
            analyze_btn.TabIndex = 5;
            analyze_btn.Tag = "menu";
            analyze_btn.Text = "Analyze";
            analyze_btn.TextAlign = ContentAlignment.MiddleLeft;
            analyze_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            analyze_btn.UseVisualStyleBackColor = false;
            analyze_btn.Click += analyze_btn_Click;
            // 
            // modify_btn
            // 
            modify_btn.BackColor = Color.Transparent;
            modify_btn.Dock = DockStyle.Top;
            modify_btn.FlatAppearance.BorderSize = 0;
            modify_btn.FlatStyle = FlatStyle.Flat;
            modify_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            modify_btn.ForeColor = Color.White;
            modify_btn.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            modify_btn.IconColor = Color.White;
            modify_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modify_btn.ImageAlign = ContentAlignment.MiddleLeft;
            modify_btn.Location = new Point(0, 200);
            modify_btn.Name = "modify_btn";
            modify_btn.Padding = new Padding(30, 0, 21, 0);
            modify_btn.Size = new Size(320, 100);
            modify_btn.TabIndex = 4;
            modify_btn.Tag = "menu";
            modify_btn.Text = "Modify";
            modify_btn.TextAlign = ContentAlignment.MiddleLeft;
            modify_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_btn.UseVisualStyleBackColor = false;
            modify_btn.Click += modify_btn_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Transparent;
            search_btn.Dock = DockStyle.Top;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            search_btn.ForeColor = Color.White;
            search_btn.IconChar = FontAwesome.Sharp.IconChar.Search;
            search_btn.IconColor = Color.White;
            search_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            search_btn.Location = new Point(0, 100);
            search_btn.Name = "search_btn";
            search_btn.Padding = new Padding(30, 0, 21, 0);
            search_btn.Size = new Size(320, 100);
            search_btn.TabIndex = 3;
            search_btn.Tag = "menu";
            search_btn.Text = "Search";
            search_btn.TextAlign = ContentAlignment.MiddleLeft;
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Transparent;
            add_btn.Dock = DockStyle.Top;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            add_btn.ForeColor = Color.White;
            add_btn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_btn.IconColor = Color.White;
            add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_btn.Location = new Point(0, 0);
            add_btn.Name = "add_btn";
            add_btn.Padding = new Padding(30, 0, 21, 0);
            add_btn.Size = new Size(320, 100);
            add_btn.TabIndex = 1;
            add_btn.Tag = "menu";
            add_btn.Text = "Add Instance";
            add_btn.TextAlign = ContentAlignment.MiddleLeft;
            add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // logo_pnl
            // 
            logo_pnl.Controls.Add(logo_pc);
            logo_pnl.Controls.Add(restart_lbl);
            logo_pnl.Controls.Add(restart_lbl2);
            logo_pnl.Dock = DockStyle.Top;
            logo_pnl.Location = new Point(0, 0);
            logo_pnl.Name = "logo_pnl";
            logo_pnl.Size = new Size(320, 125);
            logo_pnl.TabIndex = 0;
            logo_pnl.Tag = "menu";
            // 
            // logo_pc
            // 
            logo_pc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo_pc.BackColor = Color.Transparent;
            logo_pc.BackgroundImageLayout = ImageLayout.None;
            logo_pc.IconChar = FontAwesome.Sharp.IconChar.Box;
            logo_pc.IconColor = Color.White;
            logo_pc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logo_pc.IconSize = 99;
            logo_pc.Location = new Point(5, 13);
            logo_pc.Name = "logo_pc";
            logo_pc.Padding = new Padding(21, 0, 21, 0);
            logo_pc.Size = new Size(123, 99);
            logo_pc.TabIndex = 4;
            logo_pc.TabStop = false;
            logo_pc.Tag = "menu";
            // 
            // restart_lbl
            // 
            restart_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            restart_lbl.AutoSize = true;
            restart_lbl.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            restart_lbl.ForeColor = Color.White;
            restart_lbl.Location = new Point(122, 10);
            restart_lbl.Margin = new Padding(0);
            restart_lbl.Name = "restart_lbl";
            restart_lbl.Size = new Size(127, 50);
            restart_lbl.TabIndex = 0;
            restart_lbl.Text = "Smart";
            restart_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // restart_lbl2
            // 
            restart_lbl2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            restart_lbl2.AutoSize = true;
            restart_lbl2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            restart_lbl2.ForeColor = Color.White;
            restart_lbl2.Location = new Point(122, 47);
            restart_lbl2.Name = "restart_lbl2";
            restart_lbl2.Size = new Size(118, 50);
            restart_lbl2.TabIndex = 0;
            restart_lbl2.Text = "Stock";
            // 
            // titlebar_pnl
            // 
            titlebar_pnl.BackColor = Color.FromArgb(54, 54, 54);
            titlebar_pnl.Controls.Add(accent_pnl);
            titlebar_pnl.Dock = DockStyle.Top;
            titlebar_pnl.Location = new Point(320, 1);
            titlebar_pnl.Margin = new Padding(0);
            titlebar_pnl.MaximumSize = new Size(0, 53);
            titlebar_pnl.MinimumSize = new Size(0, 35);
            titlebar_pnl.Name = "titlebar_pnl";
            titlebar_pnl.Size = new Size(1582, 53);
            titlebar_pnl.TabIndex = 1;
            // 
            // accent_pnl
            // 
            accent_pnl.BackColor = Color.White;
            accent_pnl.Controls.Add(workplace_pnl);
            accent_pnl.Dock = DockStyle.Left;
            accent_pnl.Location = new Point(0, 0);
            accent_pnl.Name = "accent_pnl";
            accent_pnl.Padding = new Padding(0, 7, 0, 0);
            accent_pnl.Size = new Size(308, 53);
            accent_pnl.TabIndex = 3;
            accent_pnl.Tag = "accent";
            // 
            // workplace_pnl
            // 
            workplace_pnl.BackColor = Color.FromArgb(64, 64, 64);
            workplace_pnl.Controls.Add(workplace_layout);
            workplace_pnl.Dock = DockStyle.Fill;
            workplace_pnl.Location = new Point(0, 7);
            workplace_pnl.Name = "workplace_pnl";
            workplace_pnl.Size = new Size(308, 46);
            workplace_pnl.TabIndex = 5;
            workplace_pnl.Tag = "workplace";
            // 
            // workplace_layout
            // 
            workplace_layout.ColumnCount = 2;
            workplace_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6233768F));
            workplace_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.3766251F));
            workplace_layout.Controls.Add(labelCurentChildForm, 1, 0);
            workplace_layout.Controls.Add(iconCurentChildForm, 0, 0);
            workplace_layout.Dock = DockStyle.Fill;
            workplace_layout.Location = new Point(0, 0);
            workplace_layout.Name = "workplace_layout";
            workplace_layout.RowCount = 1;
            workplace_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            workplace_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            workplace_layout.Size = new Size(308, 46);
            workplace_layout.TabIndex = 5;
            workplace_layout.Tag = "workplace";
            // 
            // labelCurentChildForm
            // 
            labelCurentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            labelCurentChildForm.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurentChildForm.ForeColor = Color.White;
            labelCurentChildForm.Location = new Point(85, 0);
            labelCurentChildForm.Margin = new Padding(3, 0, 3, 7);
            labelCurentChildForm.Name = "labelCurentChildForm";
            labelCurentChildForm.Size = new Size(218, 39);
            labelCurentChildForm.TabIndex = 4;
            labelCurentChildForm.Tag = "workplace";
            labelCurentChildForm.Text = "Acasă";
            labelCurentChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCurentChildForm
            // 
            iconCurentChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconCurentChildForm.BackColor = Color.Transparent;
            iconCurentChildForm.BackgroundImageLayout = ImageLayout.None;
            iconCurentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurentChildForm.IconColor = Color.White;
            iconCurentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurentChildForm.IconSize = 40;
            iconCurentChildForm.Location = new Point(3, 3);
            iconCurentChildForm.Name = "iconCurentChildForm";
            iconCurentChildForm.Padding = new Padding(21, 0, 21, 0);
            iconCurentChildForm.Size = new Size(76, 40);
            iconCurentChildForm.TabIndex = 3;
            iconCurentChildForm.TabStop = false;
            iconCurentChildForm.Tag = "workplace";
            // 
            // desktop_pnl
            // 
            desktop_pnl.Dock = DockStyle.Fill;
            desktop_pnl.Location = new Point(320, 54);
            desktop_pnl.Name = "desktop_pnl";
            desktop_pnl.Size = new Size(1582, 948);
            desktop_pnl.TabIndex = 2;
            desktop_pnl.Tag = "workplace";
            // 
            // bottom_pnl
            // 
            bottom_pnl.BackColor = Color.FromArgb(54, 54, 54);
            bottom_pnl.Dock = DockStyle.Bottom;
            bottom_pnl.Location = new Point(0, 1002);
            bottom_pnl.Name = "bottom_pnl";
            bottom_pnl.Size = new Size(1902, 53);
            bottom_pnl.TabIndex = 0;
            bottom_pnl.Tag = "menu";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1902, 1055);
            Controls.Add(desktop_pnl);
            Controls.Add(titlebar_pnl);
            Controls.Add(menu_pnl);
            Controls.Add(bottom_pnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Padding = new Padding(0, 1, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartStock";
            WindowState = FormWindowState.Maximized;
            FormClosing += MenuForm_FormClosing;
            menu_pnl.ResumeLayout(false);
            menu_buttons_pnl.ResumeLayout(false);
            logo_pnl.ResumeLayout(false);
            logo_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_pc).EndInit();
            titlebar_pnl.ResumeLayout(false);
            accent_pnl.ResumeLayout(false);
            workplace_pnl.ResumeLayout(false);
            workplace_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu_pnl;
        private FontAwesome.Sharp.IconButton add_btn;
        private Panel logo_pnl;
        private Panel titlebar_pnl;
        private FontAwesome.Sharp.IconPictureBox iconCurentChildForm;
        private Label labelCurentChildForm;
        private Panel accent_pnl;
        private Panel desktop_pnl;
        private Label restart_lbl2;
        private Label restart_lbl;
        private Panel workplace_pnl;
        private TableLayoutPanel workplace_layout;
        private Panel menu_buttons_pnl;
        private FontAwesome.Sharp.IconPictureBox logo_pc;
        private Panel bottom_pnl;
        private FontAwesome.Sharp.IconButton analyze_btn;
        private FontAwesome.Sharp.IconButton modify_btn;
        private FontAwesome.Sharp.IconButton search_btn;
        private FontAwesome.Sharp.IconButton settings_btn;
    }
}