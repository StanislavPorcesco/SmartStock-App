using FontAwesome.Sharp;

namespace SmartStock.Forms.User_Control
{
    partial class ModifyTransaction
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
            transaction_id_tb = new TextBox();
            search_btn = new IconButton();
            db_lbl = new Label();
            product_id_tb = new TextBox();
            entity_lbl = new Label();
            entity_id_tb = new TextBox();
            logs_lbl = new Label();
            user_id_tb = new TextBox();
            label6 = new Label();
            quantity_tb = new TextBox();
            label2 = new Label();
            type_cb = new ComboBox();
            label4 = new Label();
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
            fields_table.Controls.Add(product_id_tb, 1, 1);
            fields_table.Controls.Add(entity_lbl, 0, 2);
            fields_table.Controls.Add(entity_id_tb, 1, 2);
            fields_table.Controls.Add(logs_lbl, 0, 3);
            fields_table.Controls.Add(user_id_tb, 1, 3);
            fields_table.Controls.Add(label6, 0, 4);
            fields_table.Controls.Add(quantity_tb, 1, 4);
            fields_table.Controls.Add(label2, 0, 5);
            fields_table.Controls.Add(type_cb, 1, 5);
            fields_table.Controls.Add(label4, 0, 6);
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
            transaction_id.Text = "Transaction ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            //
            // search_row
            //
            search_row.Controls.Add(transaction_id_tb);
            search_row.Controls.Add(search_btn);
            search_row.Dock = DockStyle.Fill;
            search_row.Location = new Point(163, 3);
            search_row.Name = "search_row";
            search_row.Size = new Size(685, 46);
            search_row.TabIndex = 1;
            //
            // transaction_id_tb
            //
            transaction_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            transaction_id_tb.Font = new Font("Segoe UI", 11F);
            transaction_id_tb.Location = new Point(0, 8);
            transaction_id_tb.Margin = new Padding(0);
            transaction_id_tb.Name = "transaction_id_tb";
            transaction_id_tb.Size = new Size(533, 32);
            transaction_id_tb.TabIndex = 0;
            transaction_id_tb.Tag = "flat";
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
            db_lbl.Text = "Product ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // product_id_tb
            //
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(163, 62);
            product_id_tb.Margin = new Padding(3, 5, 3, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(685, 32);
            product_id_tb.TabIndex = 3;
            product_id_tb.Tag = "flat";
            //
            // entity_lbl
            //
            entity_lbl.Dock = DockStyle.Fill;
            entity_lbl.Font = new Font("Segoe UI", 10F);
            entity_lbl.Location = new Point(0, 104);
            entity_lbl.Margin = new Padding(0);
            entity_lbl.Name = "entity_lbl";
            entity_lbl.Size = new Size(160, 52);
            entity_lbl.TabIndex = 4;
            entity_lbl.Tag = "muted";
            entity_lbl.Text = "Entity ID";
            entity_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // entity_id_tb
            //
            entity_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            entity_id_tb.Font = new Font("Segoe UI", 11F);
            entity_id_tb.Location = new Point(163, 114);
            entity_id_tb.Margin = new Padding(3, 5, 3, 5);
            entity_id_tb.Name = "entity_id_tb";
            entity_id_tb.Size = new Size(685, 32);
            entity_id_tb.TabIndex = 5;
            entity_id_tb.Tag = "flat";
            //
            // logs_lbl
            //
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 156);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 52);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "User ID";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // user_id_tb
            //
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(163, 166);
            user_id_tb.Margin = new Padding(3, 5, 3, 5);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(685, 32);
            user_id_tb.TabIndex = 7;
            user_id_tb.Tag = "flat";
            //
            // label6
            //
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 208);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(160, 52);
            label6.TabIndex = 8;
            label6.Tag = "muted";
            label6.Text = "Quantity";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            //
            // quantity_tb
            //
            quantity_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quantity_tb.Font = new Font("Segoe UI", 11F);
            quantity_tb.Location = new Point(163, 218);
            quantity_tb.Margin = new Padding(3, 5, 3, 5);
            quantity_tb.Name = "quantity_tb";
            quantity_tb.Size = new Size(685, 32);
            quantity_tb.TabIndex = 9;
            quantity_tb.Tag = "flat";
            //
            // label2
            //
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 260);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 52);
            label2.TabIndex = 10;
            label2.Tag = "muted";
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            //
            // type_cb
            //
            type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            type_cb.FlatStyle = FlatStyle.Flat;
            type_cb.Font = new Font("Segoe UI", 11F);
            type_cb.FormattingEnabled = true;
            type_cb.Location = new Point(163, 270);
            type_cb.Margin = new Padding(3, 5, 3, 5);
            type_cb.Name = "type_cb";
            type_cb.Size = new Size(685, 33);
            type_cb.TabIndex = 11;
            //
            // label4
            //
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 312);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(160, 52);
            label4.TabIndex = 12;
            label4.Tag = "muted";
            label4.Text = "Date";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            // ModifyTransaction
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyTransaction";
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
        private TextBox transaction_id_tb;
        private IconButton search_btn;
        private Label db_lbl;
        private TextBox product_id_tb;
        private Label entity_lbl;
        private TextBox entity_id_tb;
        private Label logs_lbl;
        private TextBox user_id_tb;
        private Label label6;
        private TextBox quantity_tb;
        private Label label2;
        private ComboBox type_cb;
        private Label label4;
        private DateTimePicker date_picker;
    }
}
