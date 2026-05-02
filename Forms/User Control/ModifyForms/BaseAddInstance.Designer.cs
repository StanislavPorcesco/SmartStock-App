using FontAwesome.Sharp;

namespace SmartStock
{
    partial class BaseAddInstance
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            root_shell = new TableLayoutPanel();
            selector_card = new Panel();
            selector_inner = new TableLayoutPanel();
            selector_header_pnl = new Panel();
            selector_subtitle_lbl = new Label();
            selector_title_lbl = new Label();
            selector_icon = new IconPictureBox();
            selector_divider = new Panel();
            selector_fields_pnl = new TableLayoutPanel();
            instance_lbl = new Label();
            action_lbl = new Label();
            selector_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            action_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            content_row = new TableLayoutPanel();
            content_card = new Panel();
            usercontrol_pnl = new Panel();
            content_divider = new Panel();
            content_header_pnl = new Panel();
            content_title_lbl = new Label();
            content_icon = new IconPictureBox();
            browser_card = new Panel();
            browser_dgv = new DataGridView();
            browser_divider = new Panel();
            browser_header_pnl = new Panel();
            browser_title_lbl = new Label();
            browser_icon = new IconPictureBox();
            footer_pnl = new TableLayoutPanel();
            archive_btn = new IconButton();
            save_btn = new IconButton();
            root_shell.SuspendLayout();
            selector_card.SuspendLayout();
            selector_inner.SuspendLayout();
            selector_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).BeginInit();
            selector_fields_pnl.SuspendLayout();
            content_row.SuspendLayout();
            content_card.SuspendLayout();
            content_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)content_icon).BeginInit();
            browser_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)browser_dgv).BeginInit();
            browser_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)browser_icon).BeginInit();
            footer_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // root_shell
            // 
            root_shell.ColumnCount = 1;
            root_shell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            root_shell.Controls.Add(selector_card, 0, 0);
            root_shell.Controls.Add(content_row, 0, 1);
            root_shell.Controls.Add(footer_pnl, 0, 2);
            root_shell.Dock = DockStyle.Fill;
            root_shell.Location = new Point(30, 30);
            root_shell.Name = "root_shell";
            root_shell.RowCount = 3;
            root_shell.RowStyles.Add(new RowStyle());
            root_shell.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_shell.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            root_shell.Size = new Size(1271, 702);
            root_shell.TabIndex = 0;
            root_shell.Tag = "base";
            // 
            // selector_card
            // 
            selector_card.Controls.Add(selector_inner);
            selector_card.Dock = DockStyle.Fill;
            selector_card.Location = new Point(0, 0);
            selector_card.Margin = new Padding(0, 0, 0, 16);
            selector_card.Name = "selector_card";
            selector_card.Padding = new Padding(24, 20, 24, 22);
            selector_card.Size = new Size(1271, 200);
            selector_card.TabIndex = 0;
            selector_card.Tag = "main_card";
            // 
            // selector_inner
            // 
            selector_inner.ColumnCount = 1;
            selector_inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selector_inner.Controls.Add(selector_header_pnl, 0, 0);
            selector_inner.Controls.Add(selector_divider, 0, 1);
            selector_inner.Controls.Add(selector_fields_pnl, 0, 2);
            selector_inner.Dock = DockStyle.Fill;
            selector_inner.Location = new Point(24, 20);
            selector_inner.Name = "selector_inner";
            selector_inner.RowCount = 3;
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.RowStyles.Add(new RowStyle());
            selector_inner.Size = new Size(1223, 158);
            selector_inner.TabIndex = 0;
            // 
            // selector_header_pnl
            // 
            selector_header_pnl.Controls.Add(selector_subtitle_lbl);
            selector_header_pnl.Controls.Add(selector_title_lbl);
            selector_header_pnl.Controls.Add(selector_icon);
            selector_header_pnl.Dock = DockStyle.Fill;
            selector_header_pnl.Location = new Point(0, 0);
            selector_header_pnl.Margin = new Padding(0, 0, 0, 10);
            selector_header_pnl.Name = "selector_header_pnl";
            selector_header_pnl.Size = new Size(1223, 57);
            selector_header_pnl.TabIndex = 0;
            selector_header_pnl.Tag = "card";
            // 
            // selector_subtitle_lbl
            // 
            selector_subtitle_lbl.AutoSize = true;
            selector_subtitle_lbl.Font = new Font("Segoe UI", 9.5F);
            selector_subtitle_lbl.Location = new Point(48, 33);
            selector_subtitle_lbl.Name = "selector_subtitle_lbl";
            selector_subtitle_lbl.Size = new Size(435, 21);
            selector_subtitle_lbl.TabIndex = 2;
            selector_subtitle_lbl.Tag = "muted";
            selector_subtitle_lbl.Text = "Choose an entity type and whether to add or modify a record.";
            // 
            // selector_title_lbl
            // 
            selector_title_lbl.AutoSize = true;
            selector_title_lbl.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            selector_title_lbl.Location = new Point(46, -5);
            selector_title_lbl.Name = "selector_title_lbl";
            selector_title_lbl.Size = new Size(226, 37);
            selector_title_lbl.TabIndex = 1;
            selector_title_lbl.Text = "Manage Instance";
            // 
            // selector_icon
            // 
            selector_icon.BackColor = SystemColors.Control;
            selector_icon.ForeColor = Color.FromArgb(245, 181, 71);
            selector_icon.IconChar = IconChar.PencilRuler;
            selector_icon.IconColor = Color.FromArgb(245, 181, 71);
            selector_icon.IconFont = IconFont.Auto;
            selector_icon.IconSize = 34;
            selector_icon.Location = new Point(0, 0);
            selector_icon.Name = "selector_icon";
            selector_icon.Size = new Size(34, 34);
            selector_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            selector_icon.TabIndex = 0;
            selector_icon.TabStop = false;
            selector_icon.Tag = "accent-icon";
            // 
            // selector_divider
            // 
            selector_divider.Dock = DockStyle.Fill;
            selector_divider.Location = new Point(0, 67);
            selector_divider.Margin = new Padding(0, 0, 0, 12);
            selector_divider.Name = "selector_divider";
            selector_divider.Size = new Size(1223, 1);
            selector_divider.TabIndex = 1;
            selector_divider.Tag = "divider";
            // 
            // selector_fields_pnl
            // 
            selector_fields_pnl.ColumnCount = 2;
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            selector_fields_pnl.Controls.Add(instance_lbl, 0, 0);
            selector_fields_pnl.Controls.Add(action_lbl, 1, 0);
            selector_fields_pnl.Controls.Add(selector_cb, 0, 1);
            selector_fields_pnl.Controls.Add(action_cb, 1, 1);
            selector_fields_pnl.Dock = DockStyle.Fill;
            selector_fields_pnl.Location = new Point(3, 83);
            selector_fields_pnl.Name = "selector_fields_pnl";
            selector_fields_pnl.RowCount = 2;
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            selector_fields_pnl.Size = new Size(1217, 72);
            selector_fields_pnl.TabIndex = 2;
            selector_fields_pnl.Tag = "card";
            // 
            // instance_lbl
            // 
            instance_lbl.AutoSize = true;
            instance_lbl.Dock = DockStyle.Bottom;
            instance_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            instance_lbl.Location = new Point(3, 4);
            instance_lbl.Margin = new Padding(3, 0, 3, 6);
            instance_lbl.Name = "instance_lbl";
            instance_lbl.Size = new Size(602, 20);
            instance_lbl.TabIndex = 0;
            instance_lbl.Tag = "muted";
            instance_lbl.Text = "ENTITY TYPE";
            // 
            // action_lbl
            // 
            action_lbl.AutoSize = true;
            action_lbl.Dock = DockStyle.Bottom;
            action_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            action_lbl.Location = new Point(622, 4);
            action_lbl.Margin = new Padding(14, 0, 3, 6);
            action_lbl.Name = "action_lbl";
            action_lbl.Size = new Size(592, 20);
            action_lbl.TabIndex = 1;
            action_lbl.Tag = "muted";
            action_lbl.Text = "ACTION";
            // 
            // selector_cb
            // 
            selector_cb.Dock = DockStyle.Top;
            selector_cb.DrawMode = DrawMode.OwnerDrawFixed;
            selector_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 11F);
            selector_cb.FormattingEnabled = true;
            selector_cb.ItemHeight = 30;
            selector_cb.Location = new Point(0, 35);
            selector_cb.Margin = new Padding(0, 5, 10, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(598, 36);
            selector_cb.TabIndex = 2;
            selector_cb.SelectedIndexChanged += selector_cb_SelectedIndexChanged;
            // 
            // action_cb
            // 
            action_cb.Dock = DockStyle.Top;
            action_cb.DrawMode = DrawMode.OwnerDrawFixed;
            action_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            action_cb.FlatStyle = FlatStyle.Flat;
            action_cb.Font = new Font("Segoe UI", 11F);
            action_cb.FormattingEnabled = true;
            action_cb.ItemHeight = 30;
            action_cb.Location = new Point(618, 35);
            action_cb.Margin = new Padding(10, 5, 0, 5);
            action_cb.Name = "action_cb";
            action_cb.Size = new Size(599, 36);
            action_cb.TabIndex = 3;
            action_cb.SelectedIndexChanged += action_cb_SelectedIndexChanged;
            // 
            // content_row
            // 
            content_row.ColumnCount = 2;
            content_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            content_row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            content_row.Controls.Add(content_card, 0, 0);
            content_row.Controls.Add(browser_card, 1, 0);
            content_row.Dock = DockStyle.Fill;
            content_row.Location = new Point(0, 216);
            content_row.Margin = new Padding(0, 0, 0, 16);
            content_row.Name = "content_row";
            content_row.RowCount = 1;
            content_row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            content_row.Size = new Size(1271, 380);
            content_row.TabIndex = 1;
            content_row.Tag = "base";
            // 
            // content_card
            // 
            content_card.Controls.Add(usercontrol_pnl);
            content_card.Controls.Add(content_divider);
            content_card.Controls.Add(content_header_pnl);
            content_card.Dock = DockStyle.Fill;
            content_card.Location = new Point(0, 0);
            content_card.Margin = new Padding(0, 0, 10, 0);
            content_card.Name = "content_card";
            content_card.Size = new Size(413, 380);
            content_card.TabIndex = 0;
            content_card.Tag = "main_card";
            // 
            // usercontrol_pnl
            // 
            usercontrol_pnl.Dock = DockStyle.Fill;
            usercontrol_pnl.Location = new Point(0, 57);
            usercontrol_pnl.Name = "usercontrol_pnl";
            usercontrol_pnl.Padding = new Padding(4);
            usercontrol_pnl.Size = new Size(413, 323);
            usercontrol_pnl.TabIndex = 2;
            usercontrol_pnl.Tag = "card";
            // 
            // content_divider
            // 
            content_divider.Dock = DockStyle.Top;
            content_divider.Location = new Point(0, 56);
            content_divider.Name = "content_divider";
            content_divider.Size = new Size(413, 1);
            content_divider.TabIndex = 3;
            content_divider.Tag = "divider";
            // 
            // content_header_pnl
            // 
            content_header_pnl.Controls.Add(content_title_lbl);
            content_header_pnl.Controls.Add(content_icon);
            content_header_pnl.Dock = DockStyle.Top;
            content_header_pnl.Location = new Point(0, 0);
            content_header_pnl.Name = "content_header_pnl";
            content_header_pnl.Padding = new Padding(24, 0, 24, 0);
            content_header_pnl.Size = new Size(413, 56);
            content_header_pnl.TabIndex = 4;
            content_header_pnl.Tag = "card";
            // 
            // content_title_lbl
            // 
            content_title_lbl.AutoSize = true;
            content_title_lbl.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold);
            content_title_lbl.Location = new Point(56, 18);
            content_title_lbl.Name = "content_title_lbl";
            content_title_lbl.Size = new Size(162, 28);
            content_title_lbl.TabIndex = 1;
            content_title_lbl.Text = "Current Instance";
            // 
            // content_icon
            // 
            content_icon.BackColor = SystemColors.Control;
            content_icon.ForeColor = SystemColors.ControlText;
            content_icon.IconChar = IconChar.TableList;
            content_icon.IconColor = SystemColors.ControlText;
            content_icon.IconFont = IconFont.Auto;
            content_icon.IconSize = 22;
            content_icon.Location = new Point(24, 25);
            content_icon.Name = "content_icon";
            content_icon.Size = new Size(22, 22);
            content_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            content_icon.TabIndex = 0;
            content_icon.TabStop = false;
            content_icon.Tag = "accent-icon";
            // 
            // browser_card
            // 
            browser_card.Controls.Add(browser_dgv);
            browser_card.Controls.Add(browser_divider);
            browser_card.Controls.Add(browser_header_pnl);
            browser_card.Dock = DockStyle.Fill;
            browser_card.Location = new Point(433, 0);
            browser_card.Margin = new Padding(10, 0, 0, 0);
            browser_card.Name = "browser_card";
            browser_card.Size = new Size(838, 380);
            browser_card.TabIndex = 1;
            browser_card.Tag = "main_card";
            // 
            // browser_dgv
            // 
            browser_dgv.AllowUserToAddRows = false;
            browser_dgv.AllowUserToDeleteRows = false;
            browser_dgv.AllowUserToResizeRows = false;
            browser_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            browser_dgv.BackgroundColor = SystemColors.Control;
            browser_dgv.BorderStyle = BorderStyle.None;
            browser_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            browser_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            browser_dgv.Cursor = Cursors.Hand;
            browser_dgv.Dock = DockStyle.Fill;
            browser_dgv.Location = new Point(0, 57);
            browser_dgv.MultiSelect = false;
            browser_dgv.Name = "browser_dgv";
            browser_dgv.ReadOnly = true;
            browser_dgv.RowHeadersVisible = false;
            browser_dgv.RowHeadersWidth = 51;
            browser_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            browser_dgv.Size = new Size(838, 323);
            browser_dgv.TabIndex = 3;
            browser_dgv.CellClick += browser_dgv_CellClick;
            // 
            // browser_divider
            // 
            browser_divider.Dock = DockStyle.Top;
            browser_divider.Location = new Point(0, 56);
            browser_divider.Name = "browser_divider";
            browser_divider.Size = new Size(838, 1);
            browser_divider.TabIndex = 2;
            browser_divider.Tag = "divider";
            // 
            // browser_header_pnl
            // 
            browser_header_pnl.Controls.Add(browser_title_lbl);
            browser_header_pnl.Controls.Add(browser_icon);
            browser_header_pnl.Dock = DockStyle.Top;
            browser_header_pnl.Location = new Point(0, 0);
            browser_header_pnl.Name = "browser_header_pnl";
            browser_header_pnl.Padding = new Padding(24, 0, 24, 0);
            browser_header_pnl.Size = new Size(838, 56);
            browser_header_pnl.TabIndex = 0;
            browser_header_pnl.Tag = "card";
            // 
            // browser_title_lbl
            // 
            browser_title_lbl.AutoSize = true;
            browser_title_lbl.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold);
            browser_title_lbl.Location = new Point(56, 18);
            browser_title_lbl.Name = "browser_title_lbl";
            browser_title_lbl.Size = new Size(162, 28);
            browser_title_lbl.TabIndex = 1;
            browser_title_lbl.Text = "Records Browser";
            // 
            // browser_icon
            // 
            browser_icon.BackColor = SystemColors.Control;
            browser_icon.ForeColor = SystemColors.ControlText;
            browser_icon.IconChar = IconChar.TableList;
            browser_icon.IconColor = SystemColors.ControlText;
            browser_icon.IconFont = IconFont.Auto;
            browser_icon.IconSize = 22;
            browser_icon.Location = new Point(24, 25);
            browser_icon.Name = "browser_icon";
            browser_icon.Size = new Size(22, 22);
            browser_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            browser_icon.TabIndex = 0;
            browser_icon.TabStop = false;
            browser_icon.Tag = "accent-icon";
            // 
            // footer_pnl
            // 
            footer_pnl.ColumnCount = 2;
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            footer_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            footer_pnl.Controls.Add(archive_btn, 0, 0);
            footer_pnl.Controls.Add(save_btn, 1, 0);
            footer_pnl.Dock = DockStyle.Fill;
            footer_pnl.Location = new Point(0, 612);
            footer_pnl.Margin = new Padding(0);
            footer_pnl.MaximumSize = new Size(0, 90);
            footer_pnl.MinimumSize = new Size(0, 90);
            footer_pnl.Name = "footer_pnl";
            footer_pnl.Padding = new Padding(0, 16, 0, 0);
            footer_pnl.RowCount = 1;
            footer_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            footer_pnl.Size = new Size(1271, 90);
            footer_pnl.TabIndex = 2;
            footer_pnl.Tag = "base";
            // 
            // archive_btn
            // 
            archive_btn.Cursor = Cursors.Hand;
            archive_btn.Dock = DockStyle.Fill;
            archive_btn.FlatStyle = FlatStyle.Flat;
            archive_btn.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            archive_btn.IconChar = IconChar.BoxArchive;
            archive_btn.IconColor = Color.Black;
            archive_btn.IconFont = IconFont.Auto;
            archive_btn.IconSize = 30;
            archive_btn.Location = new Point(0, 16);
            archive_btn.Margin = new Padding(0, 0, 10, 0);
            archive_btn.MaximumSize = new Size(0, 70);
            archive_btn.MinimumSize = new Size(0, 70);
            archive_btn.Name = "archive_btn";
            archive_btn.Padding = new Padding(24, 0, 24, 0);
            archive_btn.Size = new Size(413, 70);
            archive_btn.TabIndex = 0;
            archive_btn.Tag = "outlined";
            archive_btn.Text = "  Archive Instance";
            archive_btn.TextAlign = ContentAlignment.MiddleRight;
            archive_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            archive_btn.UseVisualStyleBackColor = false;
            archive_btn.Click += archive_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Cursor = Cursors.Hand;
            save_btn.Dock = DockStyle.Fill;
            save_btn.FlatAppearance.BorderSize = 0;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            save_btn.IconChar = IconChar.Save;
            save_btn.IconColor = Color.Black;
            save_btn.IconFont = IconFont.Auto;
            save_btn.IconSize = 30;
            save_btn.Location = new Point(433, 16);
            save_btn.Margin = new Padding(10, 0, 0, 0);
            save_btn.MaximumSize = new Size(0, 70);
            save_btn.MinimumSize = new Size(0, 70);
            save_btn.Name = "save_btn";
            save_btn.Padding = new Padding(24, 0, 24, 0);
            save_btn.Size = new Size(838, 70);
            save_btn.TabIndex = 1;
            save_btn.Tag = "cta";
            save_btn.Text = "  Save Changes";
            save_btn.TextAlign = ContentAlignment.MiddleRight;
            save_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // BaseAddInstance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 762);
            Controls.Add(root_shell);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseAddInstance";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "BaseAddInstance";
            root_shell.ResumeLayout(false);
            selector_card.ResumeLayout(false);
            selector_inner.ResumeLayout(false);
            selector_header_pnl.ResumeLayout(false);
            selector_header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).EndInit();
            selector_fields_pnl.ResumeLayout(false);
            selector_fields_pnl.PerformLayout();
            content_row.ResumeLayout(false);
            content_card.ResumeLayout(false);
            content_header_pnl.ResumeLayout(false);
            content_header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)content_icon).EndInit();
            browser_card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)browser_dgv).EndInit();
            browser_header_pnl.ResumeLayout(false);
            browser_header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)browser_icon).EndInit();
            footer_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel root_shell;

        private Panel selector_card;
        private TableLayoutPanel selector_inner;
        private Panel selector_header_pnl;
        private IconPictureBox selector_icon;
        private Label selector_title_lbl;
        private Label selector_subtitle_lbl;
        private Panel selector_divider;
        private TableLayoutPanel selector_fields_pnl;
        private Label instance_lbl;
        private Label action_lbl;
        private SmartStock.Classes.Utils.ThemedComboBox selector_cb;
        private SmartStock.Classes.Utils.ThemedComboBox action_cb;

        private TableLayoutPanel content_row;

        private Panel content_card;
        private Panel content_header_pnl;
        private IconPictureBox content_icon;
        private Label content_title_lbl;
        private Panel content_divider;
        private Panel usercontrol_pnl;

        private Panel browser_card;
        private Panel browser_header_pnl;
        private IconPictureBox browser_icon;
        private Label browser_title_lbl;
        private Panel browser_divider;
        private DataGridView browser_dgv;

        private TableLayoutPanel footer_pnl;
        private IconButton archive_btn;
        private IconButton save_btn;
    }
}
