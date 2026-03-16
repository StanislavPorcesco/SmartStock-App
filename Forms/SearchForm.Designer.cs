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
            main_dgv = new DataGridView();
            path_pnl = new Panel();
            paths_gb = new GroupBox();
            filters_pnl = new Panel();
            panel2 = new Panel();
            reset_btn = new Button();
            panel1 = new Panel();
            selector_cb = new ComboBox();
            settings_lbl = new Label();
            base_pnl.SuspendLayout();
            ai_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)main_dgv).BeginInit();
            path_pnl.SuspendLayout();
            paths_gb.SuspendLayout();
            panel2.SuspendLayout();
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
            ai_pnl.Controls.Add(main_dgv);
            ai_pnl.Dock = DockStyle.Fill;
            ai_pnl.Location = new Point(508, 20);
            ai_pnl.Name = "ai_pnl";
            ai_pnl.Padding = new Padding(10, 20, 10, 10);
            ai_pnl.Size = new Size(743, 703);
            ai_pnl.TabIndex = 7;
            // 
            // main_dgv
            // 
            main_dgv.AllowUserToAddRows = false;
            main_dgv.AllowUserToDeleteRows = false;
            main_dgv.AllowUserToOrderColumns = true;
            main_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            main_dgv.BackgroundColor = Color.FromArgb(54, 54, 54);
            main_dgv.BorderStyle = BorderStyle.Fixed3D;
            main_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            main_dgv.Dock = DockStyle.Fill;
            main_dgv.GridColor = Color.FromArgb(54, 54, 54);
            main_dgv.Location = new Point(10, 20);
            main_dgv.Name = "main_dgv";
            main_dgv.ReadOnly = true;
            main_dgv.RowHeadersWidth = 51;
            main_dgv.Size = new Size(723, 673);
            main_dgv.TabIndex = 10;
            main_dgv.CellDoubleClick += main_dgv_CellDoubleClick;
            main_dgv.CellFormatting += main_dgv_CellFormatting;
            // 
            // path_pnl
            // 
            path_pnl.Controls.Add(paths_gb);
            path_pnl.Dock = DockStyle.Left;
            path_pnl.Location = new Point(20, 20);
            path_pnl.Margin = new Padding(0);
            path_pnl.Name = "path_pnl";
            path_pnl.Padding = new Padding(10);
            path_pnl.Size = new Size(488, 703);
            path_pnl.TabIndex = 6;
            // 
            // paths_gb
            // 
            paths_gb.Controls.Add(filters_pnl);
            paths_gb.Controls.Add(panel2);
            paths_gb.Controls.Add(panel1);
            paths_gb.Dock = DockStyle.Fill;
            paths_gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paths_gb.ForeColor = Color.White;
            paths_gb.Location = new Point(10, 10);
            paths_gb.Margin = new Padding(0);
            paths_gb.Name = "paths_gb";
            paths_gb.Padding = new Padding(10, 20, 10, 20);
            paths_gb.Size = new Size(468, 683);
            paths_gb.TabIndex = 4;
            paths_gb.TabStop = false;
            paths_gb.Text = "Search Filters";
            // 
            // filters_pnl
            // 
            filters_pnl.Dock = DockStyle.Fill;
            filters_pnl.Location = new Point(10, 73);
            filters_pnl.Name = "filters_pnl";
            filters_pnl.Size = new Size(448, 515);
            filters_pnl.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(reset_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 588);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 75);
            panel2.TabIndex = 2;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(54, 54, 54);
            reset_btn.Dock = DockStyle.Bottom;
            reset_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_btn.ForeColor = Color.White;
            reset_btn.Location = new Point(0, 5);
            reset_btn.Margin = new Padding(10, 0, 0, 0);
            reset_btn.MaximumSize = new Size(0, 70);
            reset_btn.MinimumSize = new Size(0, 70);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(448, 70);
            reset_btn.TabIndex = 18;
            reset_btn.Text = "Reset Filters";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(selector_cb);
            panel1.Controls.Add(settings_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 55, 0);
            panel1.Size = new Size(448, 33);
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
            selector_cb.Location = new Point(194, 0);
            selector_cb.Margin = new Padding(0, 5, 0, 5);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(199, 33);
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
            ((System.ComponentModel.ISupportInitialize)main_dgv).EndInit();
            path_pnl.ResumeLayout(false);
            paths_gb.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private DataGridView main_dgv;
        private Panel panel1;
        private Panel filters_pnl;
        private Panel panel2;
        private Button reset_btn;
    }
}
