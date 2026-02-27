namespace SmartStock.Forms.AddForms
{
    partial class Settings
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
            panel1 = new Panel();
            apply_btn = new Button();
            return_btn = new Button();
            add_instance_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            themes_cb = new ComboBox();
            label1 = new Label();
            settings_lbl = new Label();
            category_id_tb = new TextBox();
            selector_pnl = new Panel();
            label2 = new Label();
            base_pnl.SuspendLayout();
            panel1.SuspendLayout();
            add_instance_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            selector_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(panel1);
            base_pnl.Controls.Add(add_instance_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(0, 0);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(572, 423);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // panel1
            // 
            panel1.Controls.Add(apply_btn);
            panel1.Controls.Add(return_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 333);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(532, 70);
            panel1.TabIndex = 16;
            // 
            // apply_btn
            // 
            apply_btn.BackColor = Color.FromArgb(54, 54, 54);
            apply_btn.Dock = DockStyle.Right;
            apply_btn.FlatStyle = FlatStyle.Flat;
            apply_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.ForeColor = Color.White;
            apply_btn.Location = new Point(322, 0);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(200, 70);
            apply_btn.TabIndex = 1;
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.FromArgb(54, 54, 54);
            return_btn.Dock = DockStyle.Left;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            return_btn.ForeColor = Color.White;
            return_btn.Location = new Point(10, 0);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(200, 70);
            return_btn.TabIndex = 0;
            return_btn.Text = "Return";
            return_btn.UseVisualStyleBackColor = false;
            return_btn.Click += return_btn_Click;
            // 
            // add_instance_pnl
            // 
            add_instance_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_instance_pnl.Controls.Add(groupBox2);
            add_instance_pnl.Dock = DockStyle.Top;
            add_instance_pnl.Location = new Point(20, 95);
            add_instance_pnl.Name = "add_instance_pnl";
            add_instance_pnl.Padding = new Padding(10);
            add_instance_pnl.Size = new Size(532, 167);
            add_instance_pnl.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(512, 147);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(category_id_tb, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 34);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(492, 103);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // themes_cb
            // 
            themes_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            themes_cb.BackColor = Color.FromArgb(54, 54, 54);
            themes_cb.FlatStyle = FlatStyle.Flat;
            themes_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            themes_cb.ForeColor = Color.White;
            themes_cb.FormattingEnabled = true;
            themes_cb.Location = new Point(245, 8);
            themes_cb.Margin = new Padding(0, 5, 0, 5);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(247, 33);
            themes_cb.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 50);
            label1.TabIndex = 12;
            label1.Text = "Theme";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 50);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(135, 53);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Database path";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // category_id_tb
            // 
            category_id_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_id_tb.BackColor = Color.FromArgb(54, 54, 54);
            category_id_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            category_id_tb.ForeColor = Color.White;
            category_id_tb.Location = new Point(245, 61);
            category_id_tb.Margin = new Padding(0, 5, 0, 5);
            category_id_tb.Name = "category_id_tb";
            category_id_tb.Size = new Size(247, 31);
            category_id_tb.TabIndex = 11;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(label2);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10);
            selector_pnl.Size = new Size(532, 75);
            selector_pnl.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(512, 55);
            label2.TabIndex = 8;
            label2.Text = "Settings";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(base_pnl);
            Name = "Settings";
            Size = new Size(572, 423);
            base_pnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            add_instance_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            selector_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel add_instance_pnl;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label settings_lbl;
        private Label db_lbl;
        private TextBox category_name_tb;
        private TextBox category_id_tb;
        private Panel selector_pnl;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Button apply_btn;
        private Button return_btn;
        private Label label1;
        private ComboBox themes_cb;
    }
}
