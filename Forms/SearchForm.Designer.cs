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
            base_pnl = new Panel();
            ai_pnl = new Panel();
            dataGridView1 = new DataGridView();
            theme_pnl = new Panel();
            preferences_gb = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            path_pnl = new Panel();
            paths_gb = new GroupBox();
            filters_pnl = new Panel();
            panel1 = new Panel();
            selector_cb = new ComboBox();
            settings_lbl = new Label();
            base_pnl.SuspendLayout();
            ai_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            theme_pnl.SuspendLayout();
            preferences_gb.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            path_pnl.SuspendLayout();
            paths_gb.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(ai_pnl);
            base_pnl.Controls.Add(path_pnl);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1271, 743);
            base_pnl.TabIndex = 2;
            base_pnl.Tag = "base";
            // 
            // ai_pnl
            // 
            ai_pnl.Controls.Add(dataGridView1);
            ai_pnl.Controls.Add(theme_pnl);
            ai_pnl.Dock = DockStyle.Fill;
            ai_pnl.Location = new Point(442, 20);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Padding = new Padding(10, 20, 10, 10);
            ai_pnl.Size = new Size(809, 703);
            ai_pnl.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(54, 54, 54);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(54, 54, 54);
            dataGridView1.Location = new Point(10, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(789, 529);
            dataGridView1.TabIndex = 10;
            // 
            // theme_pnl
            // 
            theme_pnl.Controls.Add(preferences_gb);
            theme_pnl.Dock = DockStyle.Bottom;
            theme_pnl.Location = new Point(10, 549);
            theme_pnl.Margin = new Padding(0);
            theme_pnl.Name = "theme_pnl";
            theme_pnl.Padding = new Padding(0, 10, 0, 0);
            theme_pnl.Size = new Size(789, 144);
            theme_pnl.TabIndex = 9;
            // 
            // preferences_gb
            // 
            preferences_gb.Controls.Add(tableLayoutPanel1);
            preferences_gb.Dock = DockStyle.Fill;
            preferences_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preferences_gb.ForeColor = Color.White;
            preferences_gb.Location = new Point(0, 10);
            preferences_gb.Margin = new Padding(0);
            preferences_gb.Name = "preferences_gb";
            preferences_gb.Padding = new Padding(10);
            preferences_gb.Size = new Size(789, 134);
            preferences_gb.TabIndex = 3;
            preferences_gb.TabStop = false;
            preferences_gb.Text = "Advanced Search";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8461533F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.15385F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 30);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.50746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(769, 94);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(54, 54, 54);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(193, 12);
            button1.Margin = new Padding(10, 0, 10, 0);
            button1.MaximumSize = new Size(0, 70);
            button1.MinimumSize = new Size(0, 70);
            button1.Name = "button1";
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Size = new Size(566, 70);
            button1.TabIndex = 16;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(54, 54, 54);
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(10, 12);
            textBox2.Margin = new Padding(10, 0, 10, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 31);
            textBox2.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(10, 56);
            checkBox1.Margin = new Padding(10, 0, 10, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 38);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Regex";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // path_pnl
            // 
            path_pnl.Controls.Add(paths_gb);
            path_pnl.Dock = DockStyle.Left;
            path_pnl.Location = new Point(20, 20);
            path_pnl.Margin = new Padding(0);
            path_pnl.Name = "path_pnl";
            path_pnl.Padding = new Padding(10);
            path_pnl.Size = new Size(422, 703);
            path_pnl.TabIndex = 6;
            // 
            // paths_gb
            // 
            paths_gb.Controls.Add(filters_pnl);
            paths_gb.Controls.Add(panel1);
            paths_gb.Dock = DockStyle.Fill;
            paths_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paths_gb.ForeColor = Color.White;
            paths_gb.Location = new Point(10, 10);
            paths_gb.Margin = new Padding(0);
            paths_gb.Name = "paths_gb";
            paths_gb.Padding = new Padding(10, 20, 10, 20);
            paths_gb.Size = new Size(402, 683);
            paths_gb.TabIndex = 4;
            paths_gb.TabStop = false;
            paths_gb.Text = "Search Filters";
            // 
            // filters_pnl
            // 
            filters_pnl.Dock = DockStyle.Fill;
            filters_pnl.Location = new Point(10, 73);
            filters_pnl.Name = "filters_pnl";
            filters_pnl.Size = new Size(382, 590);
            filters_pnl.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(selector_cb);
            panel1.Controls.Add(settings_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(382, 33);
            panel1.TabIndex = 0;
            // 
            // selector_cb
            // 
            selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            selector_cb.Dock = DockStyle.Right;
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            selector_cb.ForeColor = Color.White;
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(190, 0);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(182, 33);
            selector_cb.TabIndex = 14;
            selector_cb.SelectedIndexChanged += selector_cb_SelectedIndexChanged;
            // 
            // settings_lbl
            // 
            settings_lbl.AutoSize = true;
            settings_lbl.Dock = DockStyle.Left;
            settings_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            settings_lbl.Location = new Point(10, 0);
            settings_lbl.Margin = new Padding(0, 0, 3, 0);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(130, 25);
            settings_lbl.TabIndex = 7;
            settings_lbl.Text = "Instance Type";
            settings_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(1331, 803);
            Controls.Add(base_pnl);
            Name = "SearchForm";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "Form1";
            base_pnl.ResumeLayout(false);
            ai_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            theme_pnl.ResumeLayout(false);
            preferences_gb.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            path_pnl.ResumeLayout(false);
            paths_gb.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel base_pnl;
        private GroupBox paths_gb;
        private Label settings_lbl;
        private Panel ai_pnl;
        private Panel path_pnl;
        private ComboBox selector_cb;
        private DataGridView dataGridView1;
        private Panel theme_pnl;
        private GroupBox preferences_gb;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Panel panel1;
        private Panel filters_pnl;
    }
}
