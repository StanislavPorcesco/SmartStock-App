using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class ModifyExternalFactor
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
            transaction_id = new Label();
            search_row = new Panel();
            factor_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            factor_type_tb = new TextBox();
            logs_lbl = new Label();
            description_tb = new TextBox();
            label5 = new Label();
            region_tb = new TextBox();
            label2 = new Label();
            impact_value_tb = new TextBox();
            label4 = new Label();
            value_type_cb = new ComboBox();
            label3 = new Label();
            date_picker = new DateTimePicker();
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
            fields_table.Controls.Add(transaction_id, 0, 0);
            fields_table.Controls.Add(search_row, 1, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(factor_type_tb, 1, 1);
            fields_table.Controls.Add(logs_lbl, 0, 2);
            fields_table.Controls.Add(description_tb, 1, 2);
            fields_table.Controls.Add(label5, 0, 3);
            fields_table.Controls.Add(region_tb, 1, 3);
            fields_table.Controls.Add(label2, 0, 4);
            fields_table.Controls.Add(impact_value_tb, 1, 4);
            fields_table.Controls.Add(label4, 0, 5);
            fields_table.Controls.Add(value_type_cb, 1, 5);
            fields_table.Controls.Add(label3, 0, 6);
            fields_table.Controls.Add(date_picker, 1, 6);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 7;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            fields_table.Size = new Size(851, 364);
            fields_table.TabIndex = 0;
            //
            // transaction_id
            //
            transaction_id.Dock = DockStyle.Fill;
            transaction_id.Font = new Font("Segoe UI", 10F);
            transaction_id.Location = new Point(0, 0);
            transaction_id.Margin = new Padding(0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(160, 52);
            transaction_id.TabIndex = 0;
            transaction_id.Tag = "muted";
            transaction_id.Text = "Factor ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            //
            // search_row
            //
            search_row.Controls.Add(factor_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(163, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(685, 46);
            search_row.TabIndex = 1;
            //
            // factor_id_tb
            //
            factor_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            factor_id_tb.Font = new Font("Segoe UI", 11F);
            factor_id_tb.Location = new Point(0, 8);
            factor_id_tb.Margin = new Padding(0);
            factor_id_tb.Name = "factor_id_tb";
            factor_id_tb.Size = new Size(533, 32);
            factor_id_tb.TabIndex = 0;
            factor_id_tb.Tag = "flat";
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
            db_lbl.Text = "Factor Type";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // factor_type_tb
            //
            factor_type_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            factor_type_tb.Font = new Font("Segoe UI", 11F);
            factor_type_tb.Location = new Point(163, 62);
            factor_type_tb.Margin = new Padding(3, 5, 3, 5);
            factor_type_tb.Name = "factor_type_tb";
            factor_type_tb.Size = new Size(685, 32);
            factor_type_tb.TabIndex = 3;
            factor_type_tb.Tag = "flat";
            //
            // logs_lbl
            //
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 104);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 52);
            logs_lbl.TabIndex = 4;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "Description";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // description_tb
            //
            description_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            description_tb.Font = new Font("Segoe UI", 11F);
            description_tb.Location = new Point(163, 114);
            description_tb.Margin = new Padding(3, 5, 3, 5);
            description_tb.Name = "description_tb";
            description_tb.Size = new Size(685, 32);
            description_tb.TabIndex = 5;
            description_tb.Tag = "flat";
            //
            // label5
            //
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 156);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(160, 52);
            label5.TabIndex = 6;
            label5.Tag = "muted";
            label5.Text = "Region";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            //
            // region_tb
            //
            region_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            region_tb.Font = new Font("Segoe UI", 11F);
            region_tb.Location = new Point(163, 166);
            region_tb.Margin = new Padding(3, 5, 3, 5);
            region_tb.Name = "region_tb";
            region_tb.Size = new Size(685, 32);
            region_tb.TabIndex = 7;
            region_tb.Tag = "flat";
            //
            // label2
            //
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 208);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 52);
            label2.TabIndex = 8;
            label2.Tag = "muted";
            label2.Text = "Impact Value";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            //
            // impact_value_tb
            //
            impact_value_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            impact_value_tb.Font = new Font("Segoe UI", 11F);
            impact_value_tb.Location = new Point(163, 218);
            impact_value_tb.Margin = new Padding(3, 5, 3, 5);
            impact_value_tb.Name = "impact_value_tb";
            impact_value_tb.Size = new Size(685, 32);
            impact_value_tb.TabIndex = 9;
            impact_value_tb.Tag = "flat";
            //
            // label4
            //
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 260);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(160, 52);
            label4.TabIndex = 10;
            label4.Tag = "muted";
            label4.Text = "Value Type";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            //
            // value_type_cb
            //
            value_type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            value_type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            value_type_cb.FlatStyle = FlatStyle.Flat;
            value_type_cb.Font = new Font("Segoe UI", 11F);
            value_type_cb.FormattingEnabled = true;
            value_type_cb.Location = new Point(163, 270);
            value_type_cb.Margin = new Padding(3, 5, 3, 5);
            value_type_cb.Name = "value_type_cb";
            value_type_cb.Size = new Size(685, 33);
            value_type_cb.TabIndex = 11;
            //
            // label3
            //
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 312);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 52);
            label3.TabIndex = 12;
            label3.Tag = "muted";
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            //
            // date_picker
            //
            date_picker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_picker.Font = new Font("Segoe UI", 11F);
            date_picker.Format = DateTimePickerFormat.Short;
            date_picker.Location = new Point(163, 322);
            date_picker.Margin = new Padding(3, 5, 3, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(685, 32);
            date_picker.TabIndex = 13;
            //
            // ModifyExternalFactor
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyExternalFactor";
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
        private Label transaction_id;
        private Panel search_row;
        private TextBox factor_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox factor_type_tb;
        private Label logs_lbl;
        private TextBox description_tb;
        private Label label5;
        private TextBox region_tb;
        private Label label2;
        private TextBox impact_value_tb;
        private Label label4;
        private ComboBox value_type_cb;
        private Label label3;
        private DateTimePicker date_picker;
    }
}
