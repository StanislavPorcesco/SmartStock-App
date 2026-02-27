using SmartStock.Classes.Utils;
namespace SmartStock.Forms.User_Control
{
    partial class AddCustomer
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
            add_btn = new Button();
            margin_pnl = new Panel();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            contact_person_tb = new TextBox();
            email_tb = new TextBox();
            label2 = new Label();
            transaction_id = new Label();
            db_lbl = new Label();
            supplier_name_tb = new TextBox();
            logs_lbl = new Label();
            supplier_id_tb = new TextBox();
            selector_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            selector_cb = new ComboBox();
            label1 = new Label();
            base_pnl.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            selector_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(add_btn);
            base_pnl.Controls.Add(margin_pnl);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1299, 717);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(54, 54, 54);
            add_btn.Dock = DockStyle.Bottom;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(20, 627);
            add_btn.Margin = new Padding(0);
            add_btn.MaximumSize = new Size(0, 70);
            add_btn.MinimumSize = new Size(0, 70);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(1259, 70);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add Instance";
            add_btn.UseVisualStyleBackColor = false;
            // 
            // margin_pnl
            // 
            margin_pnl.BackColor = Color.Transparent;
            margin_pnl.Dock = DockStyle.Top;
            margin_pnl.Location = new Point(20, 428);
            margin_pnl.MaximumSize = new Size(0, 20);
            margin_pnl.MinimumSize = new Size(0, 20);
            margin_pnl.Name = "margin_pnl";
            margin_pnl.Size = new Size(1259, 20);
            margin_pnl.TabIndex = 9;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 150);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(1259, 278);
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
            groupBox2.Size = new Size(1239, 258);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Instance: Customer";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(contact_person_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(email_tb, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(transaction_id, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(supplier_name_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(supplier_id_tb, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(1219, 198);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // contact_person_tb
            // 
            contact_person_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            contact_person_tb.BackColor = Color.FromArgb(54, 54, 54);
            contact_person_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            contact_person_tb.ForeColor = Color.White;
            contact_person_tb.Location = new Point(608, 109);
            contact_person_tb.Margin = new Padding(0, 5, 0, 5);
            contact_person_tb.Name = "contact_person_tb";
            contact_person_tb.Size = new Size(611, 31);
            contact_person_tb.TabIndex = 20;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_tb.BackColor = Color.FromArgb(54, 54, 54);
            email_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            email_tb.ForeColor = Color.White;
            email_tb.Location = new Point(608, 159);
            email_tb.Margin = new Padding(0, 5, 0, 5);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(611, 31);
            email_tb.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(3, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 50);
            label2.TabIndex = 14;
            label2.Text = "Phone";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // transaction_id
            // 
            transaction_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            transaction_id.AutoSize = true;
            transaction_id.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            transaction_id.Location = new Point(3, 0);
            transaction_id.Name = "transaction_id";
            transaction_id.Size = new Size(117, 50);
            transaction_id.TabIndex = 7;
            transaction_id.Text = "Customer ID";
            transaction_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 50);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(97, 50);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Full Name";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_name_tb
            // 
            supplier_name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_name_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_name_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_name_tb.ForeColor = Color.White;
            supplier_name_tb.Location = new Point(608, 59);
            supplier_name_tb.Margin = new Padding(0, 5, 0, 5);
            supplier_name_tb.Name = "supplier_name_tb";
            supplier_name_tb.Size = new Size(611, 31);
            supplier_name_tb.TabIndex = 12;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 100);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(54, 50);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Email";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // supplier_id_tb
            // 
            supplier_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplier_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            supplier_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            supplier_id_tb.ForeColor = Color.White;
            supplier_id_tb.Location = new Point(608, 9);
            supplier_id_tb.Margin = new Padding(0, 5, 0, 5);
            supplier_id_tb.Name = "supplier_id_tb";
            supplier_id_tb.Size = new Size(611, 31);
            supplier_id_tb.TabIndex = 11;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(groupBox1);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(1259, 130);
            selector_pnl.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 20, 10, 20);
            groupBox1.Size = new Size(1239, 110);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instance selector";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(selector_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1219, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // selector_cb
            // 
            selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            selector_cb.ForeColor = Color.White;
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(609, 8);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(610, 33);
            selector_cb.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(603, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the desired instance";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "AddCustomer";
            Size = new Size(1299, 717);
            base_pnl.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            selector_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Button add_btn;
        private Panel margin_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox product_caategory_cb;
        private TextBox unit_measure_tb;
        private Label label5;
        private TextBox safety_stock_tb;
        private TextBox current_stock_tb;
        private TextBox email_tb;
        private Label label2;
        private Label transaction_id;
        private Label db_lbl;
        private TextBox supplier_name_tb;
        private Label logs_lbl;
        private TextBox supplier_id_tb;
        private Panel selector_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selector_cb;
        private Label label1;
        private TextBox contact_person_tb;
    }
}
