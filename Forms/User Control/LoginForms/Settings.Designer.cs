using FontAwesome.Sharp;

namespace SmartStock.Forms.AddForms
{
    partial class Settings
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
            footer_pnl = new TableLayoutPanel();
            return_btn = new Button();
            apply_btn = new Button();
            theme_host = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            theme_icn = new IconPictureBox();
            themes_cb = new ComboBox();
            title_lbl = new Label();
            subtitle_lbl = new Label();
            theme_lbl = new Label();
            base_pnl = new Panel();
            panel1 = new Panel();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            settings_lbl = new Label();
            category_id_tb = new TextBox();
            selector_pnl = new Panel();
            label1 = new Label();
            label2 = new Label();
            root_table.SuspendLayout();
            hero_pnl.SuspendLayout();
            hero_grid.SuspendLayout();
            brand_row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brand_icn).BeginInit();
            brand_stack.SuspendLayout();
            hero_quote.SuspendLayout();
            form_host.SuspendLayout();
            form_table.SuspendLayout();
            footer_pnl.SuspendLayout();
            theme_host.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)theme_icn).BeginInit();
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
            root_table.Size = new Size(1121, 682);
            root_table.TabIndex = 0;
            // 
            // hero_pnl
            // 
            hero_pnl.Controls.Add(hero_grid);
            hero_pnl.Dock = DockStyle.Fill;
            hero_pnl.Location = new Point(3, 3);
            hero_pnl.Name = "hero_pnl";
            hero_pnl.Padding = new Padding(40);
            hero_pnl.Size = new Size(554, 676);
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
            hero_grid.Size = new Size(474, 596);
            hero_grid.TabIndex = 0;
            // 
            // brand_row
            // 
            brand_row.ColumnCount = 2;
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            brand_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brand_row.Controls.Add(brand_icn, 0, 0);
            brand_row.Controls.Add(brand_stack, 1, 0);
            brand_row.Dock = DockStyle.Fill;
            brand_row.Location = new Point(0, 0);
            brand_row.Margin = new Padding(0);
            brand_row.Name = "brand_row";
            brand_row.RowCount = 1;
            brand_row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            brand_row.Size = new Size(474, 96);
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
            brand_stack.Location = new Point(80, 0);
            brand_stack.Margin = new Padding(0);
            brand_stack.Name = "brand_stack";
            brand_stack.Padding = new Padding(0, 8, 0, 0);
            brand_stack.RowCount = 2;
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            brand_stack.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            brand_stack.Size = new Size(394, 96);
            brand_stack.TabIndex = 1;
            // 
            // brand_lbl
            // 
            brand_lbl.Dock = DockStyle.Fill;
            brand_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brand_lbl.Location = new Point(0, 8);
            brand_lbl.Margin = new Padding(0);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(394, 50);
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
            wordmark_lbl.Size = new Size(394, 38);
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
            hero_spacer.Size = new Size(474, 340);
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
            hero_quote.Location = new Point(0, 436);
            hero_quote.Margin = new Padding(0);
            hero_quote.Name = "hero_quote";
            hero_quote.RowCount = 3;
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            hero_quote.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            hero_quote.Size = new Size(474, 160);
            hero_quote.TabIndex = 2;
            // 
            // tagline_lbl
            // 
            tagline_lbl.Dock = DockStyle.Fill;
            tagline_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline_lbl.Location = new Point(0, 0);
            tagline_lbl.Margin = new Padding(0);
            tagline_lbl.Name = "tagline_lbl";
            tagline_lbl.Size = new Size(474, 52);
            tagline_lbl.TabIndex = 0;
            tagline_lbl.Tag = "hero";
            tagline_lbl.Text = "Tune your";
            tagline_lbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tagline2_lbl
            // 
            tagline2_lbl.Dock = DockStyle.Fill;
            tagline2_lbl.Font = new Font("Segoe UI Semibold", 20F);
            tagline2_lbl.Location = new Point(0, 52);
            tagline2_lbl.Margin = new Padding(0);
            tagline2_lbl.Name = "tagline2_lbl";
            tagline2_lbl.Size = new Size(474, 52);
            tagline2_lbl.TabIndex = 1;
            tagline2_lbl.Tag = "accent";
            tagline2_lbl.Text = "workspace.";
            // 
            // subtag_lbl
            // 
            subtag_lbl.Dock = DockStyle.Fill;
            subtag_lbl.Font = new Font("Segoe UI", 10F);
            subtag_lbl.Location = new Point(0, 110);
            subtag_lbl.Margin = new Padding(0, 6, 0, 0);
            subtag_lbl.Name = "subtag_lbl";
            subtag_lbl.Size = new Size(474, 50);
            subtag_lbl.TabIndex = 2;
            subtag_lbl.Tag = "hero-muted";
            subtag_lbl.Text = "Set the look and feel that fits your team's rhythm.";
            // 
            // form_host
            // 
            form_host.Controls.Add(form_table);
            form_host.Dock = DockStyle.Fill;
            form_host.Location = new Point(563, 3);
            form_host.Name = "form_host";
            form_host.Padding = new Padding(56, 40, 56, 40);
            form_host.Size = new Size(555, 676);
            form_host.TabIndex = 1;
            form_host.Tag = "base";
            // 
            // form_table
            // 
            form_table.ColumnCount = 1;
            form_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            form_table.Controls.Add(footer_pnl, 0, 4);
            form_table.Controls.Add(theme_host, 0, 3);
            form_table.Controls.Add(title_lbl, 0, 0);
            form_table.Controls.Add(subtitle_lbl, 0, 1);
            form_table.Controls.Add(theme_lbl, 0, 2);
            form_table.Dock = DockStyle.Fill;
            form_table.Location = new Point(56, 40);
            form_table.Margin = new Padding(0);
            form_table.Name = "form_table";
            form_table.RowCount = 5;
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            form_table.Size = new Size(443, 596);
            form_table.TabIndex = 0;
            // 
            // footer_pnl
            // 
            footer_pnl.ColumnCount = 3;
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            footer_pnl.Controls.Add(return_btn, 0, 0);
            footer_pnl.Controls.Add(apply_btn, 2, 0);
            footer_pnl.Dock = DockStyle.Bottom;
            footer_pnl.Location = new Point(0, 543);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.RowCount = 1;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footer_pnl.Size = new Size(443, 53);
            footer_pnl.TabIndex = 5;
            // 
            // return_btn
            // 
            return_btn.Cursor = Cursors.Hand;
            return_btn.Dock = DockStyle.Fill;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI", 9.5F);
            return_btn.Location = new Point(0, 0);
            return_btn.Margin = new Padding(0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(120, 53);
            return_btn.TabIndex = 2;
            return_btn.Tag = "ghost";
            return_btn.Text = "Back";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // apply_btn
            // 
            apply_btn.Cursor = Cursors.Hand;
            apply_btn.Dock = DockStyle.Fill;
            apply_btn.FlatStyle = FlatStyle.Flat;
            apply_btn.Font = new Font("Segoe UI Semibold", 11F);
            apply_btn.Location = new Point(303, 0);
            apply_btn.Margin = new Padding(0);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(140, 53);
            apply_btn.TabIndex = 3;
            apply_btn.Tag = "cta";
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // theme_host
            // 
            theme_host.Controls.Add(tableLayoutPanel1);
            theme_host.Location = new Point(0, 150);
            theme_host.Margin = new Padding(0);
            theme_host.Name = "theme_host";
            theme_host.Size = new Size(443, 36);
            theme_host.TabIndex = 3;
            theme_host.Tag = "input";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7697515F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.23025F));
            tableLayoutPanel1.Controls.Add(theme_icn, 0, 0);
            tableLayoutPanel1.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(443, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // theme_icn
            // 
            theme_icn.BackColor = SystemColors.Control;
            theme_icn.Dock = DockStyle.Fill;
            theme_icn.ForeColor = SystemColors.ControlText;
            theme_icn.IconChar = IconChar.Palette;
            theme_icn.IconColor = SystemColors.ControlText;
            theme_icn.IconFont = IconFont.Auto;
            theme_icn.IconSize = 36;
            theme_icn.Location = new Point(0, 0);
            theme_icn.Margin = new Padding(0);
            theme_icn.Name = "theme_icn";
            theme_icn.Size = new Size(61, 36);
            theme_icn.SizeMode = PictureBoxSizeMode.CenterImage;
            theme_icn.TabIndex = 0;
            theme_icn.TabStop = false;
            theme_icn.Tag = "input";
            // 
            // themes_cb
            // 
            themes_cb.Dock = DockStyle.Fill;
            themes_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            themes_cb.FlatStyle = FlatStyle.Flat;
            themes_cb.Font = new Font("Segoe UI", 11F);
            themes_cb.FormattingEnabled = true;
            themes_cb.Location = new Point(61, 0);
            themes_cb.Margin = new Padding(0);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(382, 33);
            themes_cb.TabIndex = 1;
            // 
            // title_lbl
            // 
            title_lbl.Dock = DockStyle.Fill;
            title_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            title_lbl.Location = new Point(0, 0);
            title_lbl.Margin = new Padding(0);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(443, 92);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Preferences";
            title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtitle_lbl
            // 
            subtitle_lbl.Dock = DockStyle.Fill;
            subtitle_lbl.Font = new Font("Segoe UI", 10F);
            subtitle_lbl.Location = new Point(0, 92);
            subtitle_lbl.Margin = new Padding(0);
            subtitle_lbl.Name = "subtitle_lbl";
            subtitle_lbl.Size = new Size(443, 18);
            subtitle_lbl.TabIndex = 1;
            subtitle_lbl.Tag = "muted";
            subtitle_lbl.Text = "Customize your SmartStock experience.";
            subtitle_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // theme_lbl
            // 
            theme_lbl.Dock = DockStyle.Fill;
            theme_lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            theme_lbl.Location = new Point(0, 110);
            theme_lbl.Margin = new Padding(0, 0, 0, 4);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(443, 36);
            theme_lbl.TabIndex = 2;
            theme_lbl.Tag = "muted";
            theme_lbl.Text = "THEME";
            theme_lbl.TextAlign = ContentAlignment.BottomLeft;
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
            // category_id_tb
            // 
            category_id_tb.Location = new Point(0, 0);
            category_id_tb.Name = "category_id_tb";
            category_id_tb.Size = new Size(100, 27);
            category_id_tb.TabIndex = 0;
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
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(root_table);
            Name = "Settings";
            Size = new Size(1121, 682);
            root_table.ResumeLayout(false);
            hero_pnl.ResumeLayout(false);
            hero_grid.ResumeLayout(false);
            brand_row.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brand_icn).EndInit();
            brand_stack.ResumeLayout(false);
            hero_quote.ResumeLayout(false);
            form_host.ResumeLayout(false);
            form_table.ResumeLayout(false);
            footer_pnl.ResumeLayout(false);
            theme_host.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)theme_icn).EndInit();
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
        private Label            subtitle_lbl;
        private Label            theme_lbl;
        private Panel            theme_host;
        private IconPictureBox   theme_icn;
        private ComboBox         themes_cb;
        private TableLayoutPanel footer_pnl;
        private Button           return_btn;
        private Button           apply_btn;

        // Legacy placeholders
        private Panel            base_pnl;
        private Panel            panel1;
        private Panel            add_instance_pnl;
        private GroupBox         groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label            settings_lbl;
        private TextBox          category_id_tb;
        private Panel            selector_pnl;
        private Label            label1;
        private Label            label2;
        private Label title_lbl;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
