namespace SmartStock
{
    partial class MenuForm
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
            apply_btn = new Button();
            themes_cb = new ComboBox();
            base_pnl = new Panel();
            margin_pnl = new Panel();
            ai_pnl = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            api_tb = new TextBox();
            ai_logs_lbl = new Label();
            api_lbl = new Label();
            ai_logs_ck = new CheckBox();
            path_pnl = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            settings_lbl = new Label();
            db_lbl = new Label();
            db_tb = new TextBox();
            logs_lbl = new Label();
            logs_tb = new TextBox();
            settings_tb = new TextBox();
            theme_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            languages_cb = new ComboBox();
            language_lbl = new Label();
            theme_lbl = new Label();
            base_pnl.SuspendLayout();
            ai_pnl.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            path_pnl.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            theme_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // apply_btn
            // 
            apply_btn.BackColor = Color.FromArgb(54, 54, 54);
            apply_btn.Dock = DockStyle.Bottom;
            apply_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apply_btn.ForeColor = Color.White;
            apply_btn.Location = new Point(20, 612);
            apply_btn.Margin = new Padding(0);
            apply_btn.MaximumSize = new Size(0, 70);
            apply_btn.MinimumSize = new Size(0, 70);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(1231, 70);
            apply_btn.TabIndex = 0;
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // themes_cb
            // 
            themes_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            themes_cb.BackColor = Color.FromArgb(54, 54, 54);
            themes_cb.FlatStyle = FlatStyle.Flat;
            themes_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            themes_cb.ForeColor = Color.White;
            themes_cb.FormattingEnabled = true;
            themes_cb.Location = new Point(595, 7);
            themes_cb.Margin = new Padding(0, 5, 0, 5);
            themes_cb.Name = "themes_cb";
            themes_cb.Size = new Size(596, 33);
            themes_cb.TabIndex = 1;
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(apply_btn);
            base_pnl.Controls.Add(margin_pnl);
            base_pnl.Controls.Add(ai_pnl);
            base_pnl.Controls.Add(path_pnl);
            base_pnl.Controls.Add(theme_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1271, 702);
            base_pnl.TabIndex = 2;
            // 
            // margin_pnl
            // 
            margin_pnl.BackColor = Color.Transparent;
            margin_pnl.Dock = DockStyle.Top;
            margin_pnl.Location = new Point(20, 569);
            margin_pnl.MaximumSize = new Size(0, 20);
            margin_pnl.MinimumSize = new Size(0, 20);
            margin_pnl.Name = "margin_pnl";
            margin_pnl.Size = new Size(1231, 20);
            margin_pnl.TabIndex = 8;
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(groupBox3);
            ai_pnl.Dock = DockStyle.Top;
            ai_pnl.Location = new Point(20, 399);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Padding = new Padding(10);
            ai_pnl.Size = new Size(1231, 170);
            ai_pnl.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(10, 10);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(1211, 150);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "AI Settings";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7446365F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2553635F));
            tableLayoutPanel3.Controls.Add(api_tb, 1, 0);
            tableLayoutPanel3.Controls.Add(ai_logs_lbl, 0, 1);
            tableLayoutPanel3.Controls.Add(api_lbl, 0, 0);
            tableLayoutPanel3.Controls.Add(ai_logs_ck, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48.50746F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.49254F));
            tableLayoutPanel3.Size = new Size(1191, 110);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // api_tb
            // 
            api_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_tb.BackColor = Color.FromArgb(54, 54, 54);
            api_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_tb.ForeColor = Color.White;
            api_tb.Location = new Point(592, 11);
            api_tb.Margin = new Padding(0, 5, 0, 5);
            api_tb.Name = "api_tb";
            api_tb.Size = new Size(599, 31);
            api_tb.TabIndex = 14;
            // 
            // ai_logs_lbl
            // 
            ai_logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ai_logs_lbl.AutoSize = true;
            ai_logs_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ai_logs_lbl.Location = new Point(3, 53);
            ai_logs_lbl.Name = "ai_logs_lbl";
            ai_logs_lbl.Size = new Size(177, 57);
            ai_logs_lbl.TabIndex = 3;
            ai_logs_lbl.Text = "Detailed logs for AI";
            ai_logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // api_lbl
            // 
            api_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            api_lbl.AutoSize = true;
            api_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            api_lbl.Location = new Point(3, 0);
            api_lbl.Name = "api_lbl";
            api_lbl.Size = new Size(79, 53);
            api_lbl.TabIndex = 2;
            api_lbl.Text = "API Key";
            api_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ai_logs_ck
            // 
            ai_logs_ck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ai_logs_ck.AutoSize = true;
            ai_logs_ck.ForeColor = Color.FromArgb(64, 64, 64);
            ai_logs_ck.Location = new Point(1170, 56);
            ai_logs_ck.Name = "ai_logs_ck";
            ai_logs_ck.Size = new Size(18, 51);
            ai_logs_ck.TabIndex = 15;
            ai_logs_ck.UseVisualStyleBackColor = true;
            // 
            // path_pnl
            // 
            path_pnl.Controls.Add(groupBox2);
            path_pnl.Dock = DockStyle.Top;
            path_pnl.Location = new Point(20, 181);
            path_pnl.Margin = new Padding(0);
            path_pnl.Name = "path_pnl";
            path_pnl.Padding = new Padding(10);
            path_pnl.Size = new Size(1231, 218);
            path_pnl.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(1211, 198);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "File paths";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92504F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0749664F));
            tableLayoutPanel2.Controls.Add(settings_lbl, 0, 0);
            tableLayoutPanel2.Controls.Add(db_lbl, 0, 1);
            tableLayoutPanel2.Controls.Add(db_tb, 1, 1);
            tableLayoutPanel2.Controls.Add(logs_lbl, 0, 2);
            tableLayoutPanel2.Controls.Add(logs_tb, 1, 2);
            tableLayoutPanel2.Controls.Add(settings_tb, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.50746F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.49254F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(1191, 158);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // settings_lbl
            // 
            settings_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            settings_lbl.AutoSize = true;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(157, 54);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Settings file path";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_lbl
            // 
            db_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            db_lbl.AutoSize = true;
            db_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_lbl.Location = new Point(3, 54);
            db_lbl.Name = "db_lbl";
            db_lbl.Size = new Size(141, 58);
            db_lbl.TabIndex = 8;
            db_lbl.Text = "Data Base path";
            db_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // db_tb
            // 
            db_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            db_tb.BackColor = Color.FromArgb(54, 54, 54);
            db_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            db_tb.ForeColor = Color.White;
            db_tb.Location = new Point(594, 67);
            db_tb.Margin = new Padding(0, 5, 0, 5);
            db_tb.Name = "db_tb";
            db_tb.Size = new Size(597, 31);
            db_tb.TabIndex = 12;
            // 
            // logs_lbl
            // 
            logs_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            logs_lbl.AutoSize = true;
            logs_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            logs_lbl.Location = new Point(3, 112);
            logs_lbl.Name = "logs_lbl";
            logs_lbl.Size = new Size(150, 46);
            logs_lbl.TabIndex = 9;
            logs_lbl.Text = "Logging file path";
            logs_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logs_tb
            // 
            logs_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logs_tb.BackColor = Color.FromArgb(54, 54, 54);
            logs_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            logs_tb.ForeColor = Color.White;
            logs_tb.Location = new Point(594, 119);
            logs_tb.Margin = new Padding(0, 5, 0, 5);
            logs_tb.Name = "logs_tb";
            logs_tb.Size = new Size(597, 31);
            logs_tb.TabIndex = 13;
            // 
            // settings_tb
            // 
            settings_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            settings_tb.BackColor = Color.FromArgb(54, 54, 54);
            settings_tb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_tb.ForeColor = Color.White;
            settings_tb.Location = new Point(594, 11);
            settings_tb.Margin = new Padding(0, 5, 0, 5);
            settings_tb.Name = "settings_tb";
            settings_tb.Size = new Size(597, 31);
            settings_tb.TabIndex = 11;
            // 
            // theme_pnl
            // 
            theme_pnl.Controls.Add(groupBox1);
            theme_pnl.Dock = DockStyle.Top;
            theme_pnl.Location = new Point(20, 20);
            theme_pnl.Margin = new Padding(0);
            theme_pnl.Name = "theme_pnl";
            theme_pnl.Padding = new Padding(10);
            theme_pnl.Size = new Size(1231, 161);
            theme_pnl.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1211, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Theme and Preferences";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(languages_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(language_lbl, 0, 1);
            tableLayoutPanel1.Controls.Add(theme_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(themes_cb, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.50746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.49254F));
            tableLayoutPanel1.Size = new Size(1191, 101);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // languages_cb
            // 
            languages_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            languages_cb.BackColor = Color.FromArgb(54, 54, 54);
            languages_cb.FlatStyle = FlatStyle.Flat;
            languages_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            languages_cb.ForeColor = Color.White;
            languages_cb.FormattingEnabled = true;
            languages_cb.Location = new Point(595, 58);
            languages_cb.Margin = new Padding(0, 5, 0, 5);
            languages_cb.Name = "languages_cb";
            languages_cb.Size = new Size(596, 33);
            languages_cb.TabIndex = 5;
            // 
            // language_lbl
            // 
            language_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            language_lbl.AutoSize = true;
            language_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            language_lbl.Location = new Point(3, 48);
            language_lbl.Name = "language_lbl";
            language_lbl.Size = new Size(95, 53);
            language_lbl.TabIndex = 3;
            language_lbl.Text = "Language";
            language_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // theme_lbl
            // 
            theme_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            theme_lbl.AutoSize = true;
            theme_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            theme_lbl.Location = new Point(3, 0);
            theme_lbl.Name = "theme_lbl";
            theme_lbl.Size = new Size(70, 48);
            theme_lbl.TabIndex = 2;
            theme_lbl.Text = "Theme";
            theme_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(1331, 762);
            Controls.Add(base_pnl);
            Name = "MenuForm";
            Padding = new Padding(30);
            Text = "Form1";
            base_pnl.ResumeLayout(false);
            ai_pnl.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            path_pnl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            theme_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button apply_btn;
        private ComboBox themes_cb;
        private Panel base_pnl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label theme_lbl;
        private ComboBox languages_cb;
        private Label language_lbl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox settings_tb;
        private Label settings_lbl;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox api_tb;
        private Label ai_logs_lbl;
        private Label api_lbl;
        private CheckBox ai_logs_ck;
        private Label db_lbl;
        private TextBox db_tb;
        private Label logs_lbl;
        private TextBox logs_tb;
        private Panel ai_pnl;
        private Panel path_pnl;
        private Panel theme_pnl;
        private Panel margin_pnl;
    }
}
