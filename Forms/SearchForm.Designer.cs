using FontAwesome.Sharp;

namespace SmartStock
{
    partial class SearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            result_pnl = new Panel();
            table_pnl = new Panel();
            main_dgv = new DataGridView();
            result_divider = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new IconPictureBox();
            filters_card = new Panel();
            filters_pnl = new Panel();
            reset_pnl = new Panel();
            reset_btn = new IconButton();
            filters_divider = new Panel();
            panel1 = new Panel();
            filters_title_lbl = new Label();
            preferences_icon = new IconPictureBox();
            root_shell = new TableLayoutPanel();
            panel5 = new Panel();
            selector_inner = new TableLayoutPanel();
            selector_header_pnl = new Panel();
            selector_subtitle_lbl = new Label();
            selector_title_lbl = new Label();
            selector_icon = new IconPictureBox();
            selector_divider = new Panel();
            selector_fields_pnl = new TableLayoutPanel();
            selector_cb = new ComboBox();
            instance_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            result_pnl.SuspendLayout();
            table_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)main_dgv).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            filters_card.SuspendLayout();
            reset_pnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)preferences_icon).BeginInit();
            root_shell.SuspendLayout();
            panel5.SuspendLayout();
            selector_inner.SuspendLayout();
            selector_header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).BeginInit();
            selector_fields_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // result_pnl
            // 
            result_pnl.Controls.Add(table_pnl);
            result_pnl.Controls.Add(result_divider);
            result_pnl.Controls.Add(panel2);
            result_pnl.Dock = DockStyle.Fill;
            result_pnl.Location = new Point(397, 0);
            result_pnl.Margin = new Padding(10, 0, 0, 0);
            result_pnl.Name = "result_pnl";
            result_pnl.Padding = new Padding(24, 10, 24, 20);
            result_pnl.Size = new Size(764, 665);
            result_pnl.TabIndex = 7;
            result_pnl.Tag = "main_card";
            // 
            // table_pnl
            // 
            table_pnl.Controls.Add(main_dgv);
            table_pnl.Dock = DockStyle.Fill;
            table_pnl.Location = new Point(24, 51);
            table_pnl.Name = "table_pnl";
            table_pnl.Padding = new Padding(0, 10, 0, 0);
            table_pnl.Size = new Size(716, 594);
            table_pnl.TabIndex = 15;
            table_pnl.Tag = "card";
            // 
            // main_dgv
            // 
            main_dgv.AllowUserToAddRows = false;
            main_dgv.AllowUserToDeleteRows = false;
            main_dgv.AllowUserToOrderColumns = true;
            main_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            main_dgv.BorderStyle = BorderStyle.None;
            main_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            main_dgv.Dock = DockStyle.Fill;
            main_dgv.EnableHeadersVisualStyles = false;
            main_dgv.Location = new Point(0, 10);
            main_dgv.Name = "main_dgv";
            main_dgv.ReadOnly = true;
            main_dgv.RowHeadersVisible = false;
            main_dgv.RowHeadersWidth = 51;
            main_dgv.Size = new Size(716, 584);
            main_dgv.TabIndex = 10;
            main_dgv.Tag = "card";
            main_dgv.CellDoubleClick += main_dgv_CellDoubleClick;
            main_dgv.CellFormatting += main_dgv_CellFormatting;
            // 
            // result_divider
            // 
            result_divider.Dock = DockStyle.Top;
            result_divider.Location = new Point(24, 50);
            result_divider.Name = "result_divider";
            result_divider.Size = new Size(716, 1);
            result_divider.TabIndex = 14;
            result_divider.Tag = "divider";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(24, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 40);
            panel2.TabIndex = 16;
            panel2.Tag = "card";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(686, 40);
            label1.TabIndex = 8;
            label1.Text = "Result Table";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = IconChar.Table;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 40);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Tag = "accent-icon";
            // 
            // filters_card
            // 
            filters_card.Controls.Add(filters_pnl);
            filters_card.Controls.Add(reset_pnl);
            filters_card.Controls.Add(filters_divider);
            filters_card.Controls.Add(panel1);
            filters_card.Dock = DockStyle.Fill;
            filters_card.Location = new Point(0, 0);
            filters_card.Margin = new Padding(0, 0, 10, 0);
            filters_card.Name = "filters_card";
            filters_card.Padding = new Padding(24, 10, 24, 10);
            filters_card.Size = new Size(377, 665);
            filters_card.TabIndex = 4;
            filters_card.Tag = "main_card";
            // 
            // filters_pnl
            // 
            filters_pnl.Dock = DockStyle.Fill;
            filters_pnl.Location = new Point(24, 51);
            filters_pnl.Name = "filters_pnl";
            filters_pnl.Size = new Size(329, 514);
            filters_pnl.TabIndex = 1;
            filters_pnl.Tag = "card";
            // 
            // reset_pnl
            // 
            reset_pnl.Controls.Add(reset_btn);
            reset_pnl.Dock = DockStyle.Bottom;
            reset_pnl.Location = new Point(24, 565);
            reset_pnl.MaximumSize = new Size(0, 90);
            reset_pnl.MinimumSize = new Size(0, 90);
            reset_pnl.Name = "reset_pnl";
            reset_pnl.Padding = new Padding(0, 10, 0, 0);
            reset_pnl.Size = new Size(329, 90);
            reset_pnl.TabIndex = 2;
            reset_pnl.Tag = "card";
            // 
            // reset_btn
            // 
            reset_btn.Dock = DockStyle.Top;
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            reset_btn.IconChar = IconChar.RotateBack;
            reset_btn.IconColor = Color.Black;
            reset_btn.IconFont = IconFont.Auto;
            reset_btn.IconSize = 30;
            reset_btn.Location = new Point(0, 10);
            reset_btn.Margin = new Padding(0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(329, 70);
            reset_btn.TabIndex = 18;
            reset_btn.Tag = "outlined";
            reset_btn.Text = "  Reset Filters";
            reset_btn.TextAlign = ContentAlignment.MiddleRight;
            reset_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // filters_divider
            // 
            filters_divider.Dock = DockStyle.Top;
            filters_divider.Location = new Point(24, 50);
            filters_divider.Name = "filters_divider";
            filters_divider.Size = new Size(329, 1);
            filters_divider.TabIndex = 6;
            filters_divider.Tag = "divider";
            // 
            // panel1
            // 
            panel1.Controls.Add(filters_title_lbl);
            panel1.Controls.Add(preferences_icon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(24, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 40);
            panel1.TabIndex = 0;
            panel1.Tag = "card";
            // 
            // filters_title_lbl
            // 
            filters_title_lbl.Dock = DockStyle.Fill;
            filters_title_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            filters_title_lbl.Location = new Point(30, 0);
            filters_title_lbl.Name = "filters_title_lbl";
            filters_title_lbl.Size = new Size(299, 40);
            filters_title_lbl.TabIndex = 8;
            filters_title_lbl.Text = "Search Filters";
            filters_title_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // preferences_icon
            // 
            preferences_icon.BackColor = SystemColors.Control;
            preferences_icon.Dock = DockStyle.Left;
            preferences_icon.ForeColor = SystemColors.ControlText;
            preferences_icon.IconChar = IconChar.Filter;
            preferences_icon.IconColor = SystemColors.ControlText;
            preferences_icon.IconFont = IconFont.Auto;
            preferences_icon.IconSize = 30;
            preferences_icon.Location = new Point(0, 0);
            preferences_icon.Name = "preferences_icon";
            preferences_icon.Size = new Size(30, 40);
            preferences_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            preferences_icon.TabIndex = 1;
            preferences_icon.TabStop = false;
            preferences_icon.Tag = "accent-icon";
            // 
            // root_shell
            // 
            root_shell.ColumnCount = 1;
            root_shell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            root_shell.Controls.Add(panel5, 0, 0);
            root_shell.Controls.Add(tableLayoutPanel1, 0, 1);
            root_shell.Dock = DockStyle.Fill;
            root_shell.Location = new Point(30, 30);
            root_shell.Name = "root_shell";
            root_shell.RowCount = 2;
            root_shell.RowStyles.Add(new RowStyle());
            root_shell.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            root_shell.Size = new Size(1167, 887);
            root_shell.TabIndex = 3;
            root_shell.Tag = "base";
            // 
            // panel5
            // 
            panel5.Controls.Add(selector_inner);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0, 0, 0, 16);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(24, 20, 24, 22);
            panel5.Size = new Size(1167, 200);
            panel5.TabIndex = 0;
            panel5.Tag = "main_card";
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
            selector_inner.Size = new Size(1119, 158);
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
            selector_header_pnl.Size = new Size(1119, 57);
            selector_header_pnl.TabIndex = 0;
            selector_header_pnl.Tag = "card";
            // 
            // selector_subtitle_lbl
            // 
            selector_subtitle_lbl.AutoSize = true;
            selector_subtitle_lbl.Font = new Font("Segoe UI", 9.5F);
            selector_subtitle_lbl.Location = new Point(48, 33);
            selector_subtitle_lbl.Name = "selector_subtitle_lbl";
            selector_subtitle_lbl.Size = new Size(325, 21);
            selector_subtitle_lbl.TabIndex = 2;
            selector_subtitle_lbl.Tag = "muted";
            selector_subtitle_lbl.Text = "Filter and explore your data across all entities.";
            // 
            // selector_title_lbl
            // 
            selector_title_lbl.AutoSize = true;
            selector_title_lbl.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            selector_title_lbl.Location = new Point(46, -5);
            selector_title_lbl.Name = "selector_title_lbl";
            selector_title_lbl.Size = new Size(99, 37);
            selector_title_lbl.TabIndex = 1;
            selector_title_lbl.Text = "Search";
            // 
            // selector_icon
            // 
            selector_icon.BackColor = SystemColors.Control;
            selector_icon.ForeColor = Color.FromArgb(245, 181, 71);
            selector_icon.IconChar = IconChar.Search;
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
            selector_divider.Size = new Size(1119, 1);
            selector_divider.TabIndex = 1;
            selector_divider.Tag = "divider";
            // 
            // selector_fields_pnl
            // 
            selector_fields_pnl.ColumnCount = 1;
            selector_fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            selector_fields_pnl.Controls.Add(selector_cb, 0, 1);
            selector_fields_pnl.Controls.Add(instance_lbl, 0, 0);
            selector_fields_pnl.Dock = DockStyle.Fill;
            selector_fields_pnl.Location = new Point(3, 83);
            selector_fields_pnl.Name = "selector_fields_pnl";
            selector_fields_pnl.RowCount = 2;
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            selector_fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            selector_fields_pnl.Size = new Size(1113, 72);
            selector_fields_pnl.TabIndex = 2;
            selector_fields_pnl.Tag = "card";
            // 
            // selector_cb
            // 
            selector_cb.Dock = DockStyle.Fill;
            selector_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 11F);
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(0, 35);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(1113, 33);
            selector_cb.TabIndex = 16;
            selector_cb.SelectedIndexChanged += selector_cb_SelectedIndexChanged;
            // 
            // instance_lbl
            // 
            instance_lbl.AutoSize = true;
            instance_lbl.Dock = DockStyle.Bottom;
            instance_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            instance_lbl.Location = new Point(3, 4);
            instance_lbl.Margin = new Padding(3, 0, 3, 6);
            instance_lbl.Name = "instance_lbl";
            instance_lbl.Size = new Size(1107, 20);
            instance_lbl.TabIndex = 0;
            instance_lbl.Tag = "muted";
            instance_lbl.Text = "ENTITY TYPE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(result_pnl, 1, 0);
            tableLayoutPanel1.Controls.Add(filters_card, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 219);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1161, 665);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 947);
            Controls.Add(root_shell);
            Name = "SearchForm";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "Form1";
            result_pnl.ResumeLayout(false);
            table_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)main_dgv).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            filters_card.ResumeLayout(false);
            reset_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)preferences_icon).EndInit();
            root_shell.ResumeLayout(false);
            panel5.ResumeLayout(false);
            selector_inner.ResumeLayout(false);
            selector_header_pnl.ResumeLayout(false);
            selector_header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selector_icon).EndInit();
            selector_fields_pnl.ResumeLayout(false);
            selector_fields_pnl.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel filters_card;
        private Panel result_pnl;
        private DataGridView main_dgv;
        private Panel filters_pnl;
        private Panel reset_pnl;
        private IconButton reset_btn;
        private Panel filters_divider;
        private Panel result_divider;
        private Panel table_pnl;
        private Panel panel1;
        private Label filters_title_lbl;
        private IconPictureBox preferences_icon;
        private Panel panel2;
        private Label label1;
        private IconPictureBox iconPictureBox1;
        private TableLayoutPanel root_shell;
        private Panel panel5;
        private TableLayoutPanel selector_inner;
        private Panel selector_header_pnl;
        private Label selector_subtitle_lbl;
        private Label selector_title_lbl;
        private IconPictureBox selector_icon;
        private Panel selector_divider;
        private TableLayoutPanel selector_fields_pnl;
        private Label instance_lbl;
        private ComboBox selector_cb;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
