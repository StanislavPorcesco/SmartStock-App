using SmartStock.Classes.Utils;
namespace SmartStock.Forms.User_Control
{
    partial class ModifySupplier
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
            supplier_id_tb = new TextBox();
            contact_person_tb = new TextBox();
            address_tb = new TextBox();
            label4 = new Label();
            phone_tb = new TextBox();
            label3 = new Label();
            email_tb = new TextBox();
            label2 = new Label();
            settings_lbl = new Label();
            db_lbl = new Label();
            supplier_name_tb = new TextBox();
            logs_lbl = new Label();
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
            base_pnl.Size = new Size(1299, 717);
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
            add_instance_pnl.Size = new Size(1299, 331);
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
            groupBox2.Size = new Size(1279, 311);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Supplier";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(contact_person_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(address_tb, 1, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(phone_tb, 1, 4);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(email_tb, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(supplier_name_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1259, 251);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(search_btn, 1, 0);
            tableLayoutPanel3.Controls.Add(supplier_id_tb, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(631, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
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
            // supplier_id_tb
            // 
            supplier_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_id_tb.Dock = DockStyle.Fill;
            supplier_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_id_tb.ForeColor = Color.White;
            supplier_id_tb.Location = new Point(0, 5);
            supplier_id_tb.Margin = new Padding(0, 5, 10, 5);
            supplier_id_tb.Name = "supplier_id_tb";
            supplier_id_tb.Size = new Size(302, 31);
            supplier_id_tb.TabIndex = 26;
            // 
            // contact_person_tb
            // 
            contact_person_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            contact_person_tb.BackColor = Color.FromArgb(54, 54, 54);
            contact_person_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            contact_person_tb.ForeColor = Color.White;
            contact_person_tb.Location = new Point(628, 91);
            contact_person_tb.Margin = new Padding(0, 5, 0, 5);
            contact_person_tb.Name = "contact_person_tb";
            contact_person_tb.Size = new Size(631, 31);
            contact_person_tb.TabIndex = 20;
            // 
            // address_tb
            // 
            address_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            address_tb.BackColor = Color.FromArgb(54, 54, 54);
            address_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            address_tb.ForeColor = Color.White;
            address_tb.Location = new Point(628, 214);
            address_tb.Margin = new Padding(0, 5, 0, 5);
            address_tb.Name = "address_tb";
            address_tb.Size = new Size(631, 31);
            address_tb.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(3, 209);
            label4.Name = "label4";
            label4.Size = new Size(74, 42);
            label4.TabIndex = 18;
            label4.Text = "Address";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phone_tb
            // 
            phone_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phone_tb.BackColor = Color.FromArgb(54, 54, 54);
            phone_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            phone_tb.ForeColor = Color.White;
            phone_tb.Location = new Point(628, 173);
            phone_tb.Margin = new Padding(0, 5, 0, 5);
            phone_tb.Name = "phone_tb";
            phone_tb.Size = new Size(631, 31);
            phone_tb.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 168);
            label3.Name = "label3";
            label3.Size = new Size(59, 41);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_tb.ForeColor = Color.White;
            email_tb.Location = new Point(628, 132);
            email_tb.Margin = new Padding(0, 5, 0, 5);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(631, 31);
            email_tb.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 41);
            label2.TabIndex = 14;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(106, 45);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Supplier ID";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 45);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(137, 41);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Supplier Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_name_tb
            // 
            supplier_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_name_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_name_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_name_tb.ForeColor = Color.White;
            supplier_name_tb.Location = new Point(628, 50);
            supplier_name_tb.Margin = new Padding(0, 5, 0, 5);
            supplier_name_tb.Name = "supplier_name_tb";
            supplier_name_tb.Size = new Size(631, 31);
            supplier_name_tb.TabIndex = 12;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 86);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(129, 41);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Contact Person";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ModifySupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "ModifySupplier";
            Size = new Size(1299, 717);
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
        private Label label3;
        private TextBox email_tb;
        private Label label2;
        private Label settings_lbl;
        private Label db_lbl;
        private TextBox supplier_name_tb;
        private Label logs_lbl;
        private TextBox contact_person_tb;
        private TextBox address_tb;
        private TextBox phone_tb;
        private TableLayoutPanel tableLayoutPanel3;
        private Button search_btn;
        private TextBox supplier_id_tb;
    }
}
