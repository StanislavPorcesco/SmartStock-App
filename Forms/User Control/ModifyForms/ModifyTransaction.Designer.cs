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
            type_cb = new SmartStock.Classes.Utils.ThemedComboBox();
            label4 = new Label();
            date_picker = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            border_theme_pnl = new Panel();
            container_theme_pnl = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            base_pnl.SuspendLayout();
            fields_table.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            border_theme_pnl.SuspendLayout();
            container_theme_pnl.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            base_pnl.Tag = "card";
            // 
            // fields_table
            // 
            fields_table.ColumnCount = 2;
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            fields_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fields_table.Controls.Add(panel7, 1, 4);
            fields_table.Controls.Add(panel5, 1, 3);
            fields_table.Controls.Add(panel3, 1, 2);
            fields_table.Controls.Add(panel1, 1, 1);
            fields_table.Controls.Add(transaction_id, 0, 0);
            fields_table.Controls.Add(db_lbl, 0, 1);
            fields_table.Controls.Add(entity_lbl, 0, 2);
            fields_table.Controls.Add(logs_lbl, 0, 3);
            fields_table.Controls.Add(label6, 0, 4);
            fields_table.Controls.Add(label2, 0, 5);
            fields_table.Controls.Add(type_cb, 1, 5);
            fields_table.Controls.Add(label4, 0, 6);
            fields_table.Controls.Add(date_picker, 1, 6);
            fields_table.Controls.Add(tableLayoutPanel1, 1, 0);
            fields_table.Dock = DockStyle.Top;
            fields_table.Location = new Point(28, 24);
            fields_table.Name = "fields_table";
            fields_table.RowCount = 7;
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            fields_table.Size = new Size(851, 380);
            fields_table.TabIndex = 0;
            // 
            // transaction_id
            // 
            transaction_id.Dock = DockStyle.Fill;
            transaction_id.Font = new Font("Segoe UI", 10F);
            transaction_id.Location = new Point(0, 0);
            transaction_id.Margin = new Padding(0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(160, 54);
            transaction_id.TabIndex = 0;
            transaction_id.Tag = "muted";
            transaction_id.Text = "Transaction ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // transaction_id_tb
            // 
            transaction_id_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            transaction_id_tb.Font = new Font("Segoe UI", 11F);
            transaction_id_tb.Location = new Point(0, 0);
            transaction_id_tb.Margin = new Padding(0);
            transaction_id_tb.Name = "transaction_id_tb";
            transaction_id_tb.Size = new Size(573, 32);
            transaction_id_tb.TabIndex = 0;
            transaction_id_tb.Tag = "borderless";
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            search_btn.IconChar = IconChar.Search;
            search_btn.IconColor = Color.Black;
            search_btn.IconFont = IconFont.Auto;
            search_btn.IconSize = 18;
            search_btn.Location = new Point(587, 10);
            search_btn.Margin = new Padding(6, 10, 0, 10);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(104, 34);
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
            db_lbl.Location = new Point(0, 54);
            db_lbl.Margin = new Padding(0);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(160, 54);
            db_lbl.TabIndex = 2;
            db_lbl.Tag = "muted";
            db_lbl.Text = "Product ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.Font = new Font("Segoe UI", 11F);
            product_id_tb.Location = new Point(0, 0);
            product_id_tb.Margin = new Padding(0);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(683, 32);
            product_id_tb.TabIndex = 3;
            product_id_tb.Tag = "borderless";
            // 
            // entity_lbl
            // 
            entity_lbl.Dock = DockStyle.Fill;
            entity_lbl.Font = new Font("Segoe UI", 10F);
            entity_lbl.Location = new Point(0, 108);
            entity_lbl.Margin = new Padding(0);
            entity_lbl.Name = "entity_lbl";
            entity_lbl.Size = new Size(160, 54);
            entity_lbl.TabIndex = 4;
            entity_lbl.Tag = "muted";
            entity_lbl.Text = "Entity ID";
            entity_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entity_id_tb
            // 
            entity_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            entity_id_tb.Font = new Font("Segoe UI", 11F);
            entity_id_tb.Location = new Point(0, 0);
            entity_id_tb.Margin = new Padding(0);
            entity_id_tb.Name = "entity_id_tb";
            entity_id_tb.Size = new Size(683, 32);
            entity_id_tb.TabIndex = 5;
            entity_id_tb.Tag = "borderless";
            // 
            // logs_lbl
            // 
            logs_lbl.Dock = DockStyle.Fill;
            logs_lbl.Font = new Font("Segoe UI", 10F);
            logs_lbl.Location = new Point(0, 162);
            logs_lbl.Margin = new Padding(0);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(160, 54);
            logs_lbl.TabIndex = 6;
            logs_lbl.Tag = "muted";
            logs_lbl.Text = "User ID";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.Font = new Font("Segoe UI", 11F);
            user_id_tb.Location = new Point(0, 0);
            user_id_tb.Margin = new Padding(0);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(683, 32);
            user_id_tb.TabIndex = 7;
            user_id_tb.Tag = "borderless";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 216);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(160, 54);
            label6.TabIndex = 8;
            label6.Tag = "muted";
            label6.Text = "Quantity";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantity_tb
            // 
            quantity_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quantity_tb.Font = new Font("Segoe UI", 11F);
            quantity_tb.Location = new Point(0, 0);
            quantity_tb.Margin = new Padding(0);
            quantity_tb.Name = "quantity_tb";
            quantity_tb.Size = new Size(683, 32);
            quantity_tb.TabIndex = 9;
            quantity_tb.Tag = "borderless";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 270);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(160, 54);
            label2.TabIndex = 10;
            label2.Tag = "muted";
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // type_cb
            // 
            type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            type_cb.DrawMode = DrawMode.OwnerDrawFixed;
            type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            type_cb.FlatStyle = FlatStyle.Flat;
            type_cb.Font = new Font("Segoe UI", 11F);
            type_cb.FormattingEnabled = true;
            type_cb.ItemHeight = 30;
            type_cb.Location = new Point(163, 279);
            type_cb.Margin = new Padding(3, 5, 3, 5);
            type_cb.Name = "type_cb";
            type_cb.Size = new Size(685, 36);
            type_cb.TabIndex = 11;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(0, 324);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(160, 56);
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
            date_picker.Location = new Point(163, 336);
            date_picker.Margin = new Padding(3, 5, 3, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(685, 32);
            date_picker.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel1.Controls.Add(border_theme_pnl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(160, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(691, 54);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // border_theme_pnl
            // 
            border_theme_pnl.Controls.Add(container_theme_pnl);
            border_theme_pnl.Dock = DockStyle.Fill;
            border_theme_pnl.Location = new Point(6, 10);
            border_theme_pnl.Margin = new Padding(6, 10, 0, 10);
            border_theme_pnl.Name = "border_theme_pnl";
            border_theme_pnl.Padding = new Padding(1);
            border_theme_pnl.Size = new Size(575, 34);
            border_theme_pnl.TabIndex = 8;
            border_theme_pnl.Tag = "border_pnl";
            // 
            // container_theme_pnl
            // 
            container_theme_pnl.Controls.Add(tableLayoutPanel6);
            container_theme_pnl.Dock = DockStyle.Fill;
            container_theme_pnl.Location = new Point(1, 1);
            container_theme_pnl.Margin = new Padding(0);
            container_theme_pnl.Name = "container_theme_pnl";
            container_theme_pnl.Size = new Size(573, 32);
            container_theme_pnl.TabIndex = 0;
            container_theme_pnl.Tag = "card";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(transaction_id_tb, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(573, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(166, 64);
            panel1.Margin = new Padding(6, 10, 0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(685, 34);
            panel1.TabIndex = 15;
            panel1.Tag = "border_pnl";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 32);
            panel2.TabIndex = 0;
            panel2.Tag = "card";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(product_id_tb, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(683, 32);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(166, 118);
            panel3.Margin = new Padding(6, 10, 0, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(685, 34);
            panel3.TabIndex = 16;
            panel3.Tag = "border_pnl";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 32);
            panel4.TabIndex = 0;
            panel4.Tag = "card";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(entity_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(683, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(166, 172);
            panel5.Margin = new Padding(6, 10, 0, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(685, 34);
            panel5.TabIndex = 17;
            panel5.Tag = "border_pnl";
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(683, 32);
            panel6.TabIndex = 0;
            panel6.Tag = "card";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(user_id_tb, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(683, 32);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(166, 226);
            panel7.Margin = new Padding(6, 10, 0, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(685, 34);
            panel7.TabIndex = 18;
            panel7.Tag = "border_pnl";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(683, 32);
            panel8.TabIndex = 0;
            panel8.Tag = "card";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(quantity_tb, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(683, 32);
            tableLayoutPanel5.TabIndex = 0;
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
            tableLayoutPanel1.ResumeLayout(false);
            border_theme_pnl.ResumeLayout(false);
            container_theme_pnl.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private TableLayoutPanel fields_table;
        private Label transaction_id;
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
        private SmartStock.Classes.Utils.ThemedComboBox type_cb;
        private Label label4;
        private DateTimePicker date_picker;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel border_theme_pnl;
        private Panel container_theme_pnl;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
