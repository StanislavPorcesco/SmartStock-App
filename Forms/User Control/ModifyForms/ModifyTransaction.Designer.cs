using SmartStock.Classes.Utils;
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
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            search_btn = new Button();
            transaction_id_tb = new TextBox();
            transaction_id = new Label();
            db_lbl = new Label();
            product_id_tb = new TextBox();
            label4 = new Label();
            date_picker = new DateTimePicker();
            logs_lbl = new Label();
            entity_lbl = new Label();
            user_id_tb = new TextBox();
            entity_id_tb = new TextBox();
            label2 = new Label();
            label6 = new Label();
            type_cb = new ComboBox();
            quantity_tb = new TextBox();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Size = new Size(1299, 816);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(0, 0);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1299, 372);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 20, 10, 20);
            groupBox2.Size = new Size(1279, 352);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Transaction";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(transaction_id, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(product_id_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(date_picker, 1, 6);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 3);
            tableLayoutPanel2.Controls.Add(entity_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(user_id_tb, 1, 3);
            tableLayoutPanel2.Controls.Add(entity_id_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(type_cb, 1, 5);
            tableLayoutPanel2.Controls.Add(quantity_tb, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1259, 292);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel3.Controls.Add(transaction_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(631, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(625, 39);
            tableLayoutPanel3.TabIndex = 34;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(54, 54, 54);
            search_btn.Dock = DockStyle.Fill;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(322, 4);
            search_btn.Margin = new Padding(10, 4, 0, 0);
            search_btn.MaximumSize = new Size(0, 34);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(303, 34);
            search_btn.TabIndex = 27;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // transaction_id_tb
            // 
            transaction_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            transaction_id_tb.Dock = DockStyle.Fill;
            transaction_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            transaction_id_tb.ForeColor = Color.White;
            transaction_id_tb.Location = new Point(0, 5);
            transaction_id_tb.Margin = new Padding(0, 5, 10, 5);
            transaction_id_tb.Name = "transaction_id_tb";
            transaction_id_tb.Size = new Size(302, 31);
            transaction_id_tb.TabIndex = 26;
            // 
            // transaction_id
            // 
            transaction_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            transaction_id.AutoSize = true;
            transaction_id.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            transaction_id.Location = new Point(3, 0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(135, 45);
            transaction_id.TabIndex = 7;
            transaction_id.Text = "Transaction ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 45);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(103, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Product ID";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_id_tb
            // 
            product_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            product_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            product_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            product_id_tb.ForeColor = Color.White;
            product_id_tb.Location = new Point(628, 50);
            product_id_tb.Margin = new Padding(0, 5, 0, 5);
            product_id_tb.Name = "product_id_tb";
            product_id_tb.Size = new Size(631, 31);
            product_id_tb.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(3, 252);
            label4.Name = "label4";
            label4.Size = new Size(52, 40);
            label4.TabIndex = 18;
            label4.Text = "Date";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_picker
            // 
            date_picker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_picker.CustomFormat = "";
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(631, 258);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(625, 27);
            date_picker.TabIndex = 35;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 127);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(74, 41);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "User ID";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // entity_lbl
            // 
            entity_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            entity_lbl.AutoSize = true;
            entity_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            entity_lbl.Location = new Point(3, 86);
            entity_lbl.Name = "entity_lbl";
            entity_lbl.Size = new Size(86, 41);
            entity_lbl.TabIndex = 16;
            entity_lbl.Text = "Entity ID";
            entity_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user_id_tb
            // 
            user_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            user_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            user_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            user_id_tb.ForeColor = Color.White;
            user_id_tb.Location = new Point(628, 132);
            user_id_tb.Margin = new Padding(0, 5, 0, 5);
            user_id_tb.Name = "user_id_tb";
            user_id_tb.Size = new Size(631, 31);
            user_id_tb.TabIndex = 20;
            // 
            // entity_id_tb
            // 
            entity_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            entity_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            entity_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            entity_id_tb.ForeColor = Color.White;
            entity_id_tb.Location = new Point(628, 91);
            entity_id_tb.Margin = new Padding(0, 5, 0, 5);
            entity_id_tb.Name = "entity_id_tb";
            entity_id_tb.Size = new Size(631, 31);
            entity_id_tb.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(3, 209);
            label2.Name = "label2";
            label2.Size = new Size(53, 43);
            label2.TabIndex = 14;
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(3, 168);
            label6.Name = "label6";
            label6.Size = new Size(87, 41);
            label6.TabIndex = 23;
            label6.Text = "Quantity";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // type_cb
            // 
            type_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            type_cb.BackColor = Color.FromArgb(54, 54, 54);
            type_cb.FlatStyle = FlatStyle.Flat;
            type_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            type_cb.ForeColor = Color.White;
            type_cb.FormattingEnabled = true;
            type_cb.Location = new Point(628, 214);
            type_cb.Margin = new Padding(0, 5, 0, 5);
            type_cb.Name = "type_cb";
            type_cb.Size = new Size(631, 33);
            type_cb.TabIndex = 25;
            // 
            // quantity_tb
            // 
            quantity_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quantity_tb.BackColor = Color.FromArgb(54, 54, 54);
            quantity_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            quantity_tb.ForeColor = Color.White;
            quantity_tb.Location = new Point(628, 173);
            quantity_tb.Margin = new Padding(0, 5, 0, 5);
            quantity_tb.Name = "quantity_tb";
            quantity_tb.Size = new Size(631, 31);
            quantity_tb.TabIndex = 24;
            // 
            // ModifyTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifyTransaction";
            Size = new Size(1299, 816);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox product_caategory_cb;
        private TextBox unit_measure_tb;
        private Label label5;
        private TextBox safety_stock_tb;
        private Label label4;
        private TextBox current_stock_tb;
        private Label entity_lbl;
        private Label label2;
        private Label transaction_id;
        private Label db_lbl;
        private TextBox product_id_tb;
        private Label logs_lbl;
        private TextBox user_id_tb;
        private TextBox entity_id_tb;
        private Label label6;
        private TextBox quantity_tb;
        private ComboBox type_cb;
        private TableLayoutPanel tableLayoutPanel3;
        private Button search_btn;
        private TextBox transaction_id_tb;
        private DateTimePicker date_picker;
    }
}
