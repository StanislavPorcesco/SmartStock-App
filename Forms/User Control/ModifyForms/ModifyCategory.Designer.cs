using FontAwesome.Sharp;

namespace SmartStock.Forms.AddForms
{
    partial class ModifyCategory
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            base_pnl = new Panel();
            fields_table = new TableLayoutPanel();
            settings_lbl = new Label();
            search_row = new Panel();
            category_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            category_name_tb = new TextBox();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            search_row.SuspendLayout();
            SuspendLayout();
            //
            // base_pnl
            //
            base_pnl.Controls.Add(fields_table);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(28, 24, 28, 24);
            base_pnl.Size = new Size(907, 572);
            base_pnl.TabIndex = 0;
            base_pnl.Tag = "base";
            //
            // fields_table
            //
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(settings_lbl, 0, 0);
            fields_table.Controls.Add(search_row, 1, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(category_name_tb, 1, 1);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 2;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.Size = new Size(851, 104);
            fields_table.TabIndex = 0;
            //
            // settings_lbl
            //
            settings_lbl.Dock = DockStyle.Fill;
            settings_lbl.Font = new Font("Segoe UI", 10F);
            settings_lbl.Location = new Point(0, 0);
            settings_lbl.Margin = new Padding(0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(160, 52);
            settings_lbl.TabIndex = 0;
            settings_lbl.Tag = "muted";
            settings_lbl.Text = "Category ID";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // search_row
            //
            search_row.Controls.Add(category_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(163, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(685, 46);
            search_row.TabIndex = 1;
            //
            // category_id_tb
            //
            category_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            category_id_tb.Font = new Font("Segoe UI", 11F);
            category_id_tb.Location = new Point(0, 8);
            category_id_tb.Margin = new Padding(0);
            category_id_tb.Name = "category_id_tb";
            category_id_tb.Size = new Size(533, 32);
            category_id_tb.TabIndex = 0;
            category_id_tb.Tag = "flat";
            //
            // search_btn
            //
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.FlatAppearance.BorderSize = 1;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.MagnifyingGlass;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(545, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(140, 38);
            search_btn.TabIndex = 1;
            search_btn.Tag = "outlined";
            search_btn.Text = "  Search";
            search_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            //
            // db_lbl
            //
            db_lbl.Dock = DockStyle.Fill;
            db_lbl.Font = new Font("Segoe UI", 10F);
            db_lbl.Location = new Point(0, 52);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(160, 52);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Category Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // category_name_tb
            //
            category_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_name_tb.Font = new Font("Segoe UI", 11F);
            category_name_tb.Location = new Point(163, 62);
            category_name_tb.Margin = new Padding(3, 5, 3, 5);
            category_name_tb.Name = "category_name_tb";
            category_name_tb.Size = new Size(685, 32);
            category_name_tb.TabIndex = 3;
            category_name_tb.Tag = "flat";
            //
            // ModifyCategory
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyCategory";
            Size = new Size(907, 572);
            base_pnl.ResumeLayout(false);
            fields_table.ResumeLayout(false);
            fields_table.PerformLayout();
            search_row.ResumeLayout(false);
            search_row.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label settings_lbl;
        private Panel search_row;
        private TextBox category_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox category_name_tb;
    }
}
