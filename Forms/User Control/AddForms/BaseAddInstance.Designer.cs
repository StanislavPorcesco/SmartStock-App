namespace SmartStock
{
    partial class BaseAddInstance
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
            usercontrol_pnl = new Panel();
            selector_pnl = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            action_cb = new ComboBox();
            label2 = new Label();
            selector_cb = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            archive_btn = new Button();
            save_btn = new Button();
            base_pnl.SuspendLayout();
            selector_pnl.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // base_pnl
            // 
            base_pnl.AutoScroll = true;
            base_pnl.BackColor = Color.FromArgb(64, 64, 64);
            base_pnl.Controls.Add(usercontrol_pnl);
            base_pnl.Controls.Add(selector_pnl);
            base_pnl.Controls.Add(panel1);
            base_pnl.Dock = DockStyle.Fill;
            base_pnl.Location = new Point(30, 30);
            base_pnl.Margin = new Padding(30);
            base_pnl.Name = "base_pnl";
            base_pnl.Padding = new Padding(20);
            base_pnl.Size = new Size(1271, 702);
            base_pnl.TabIndex = 3;
            base_pnl.Tag = "base";
            // 
            // usercontrol_pnl
            // 
            usercontrol_pnl.Dock = DockStyle.Fill;
            usercontrol_pnl.Location = new Point(20, 182);
            usercontrol_pnl.Name = "usercontrol_pnl";
            usercontrol_pnl.Size = new Size(1231, 340);
            usercontrol_pnl.TabIndex = 5;
            // 
            // selector_pnl
            // 
            selector_pnl.Controls.Add(groupBox1);
            selector_pnl.Dock = DockStyle.Top;
            selector_pnl.Location = new Point(20, 20);
            selector_pnl.Name = "selector_pnl";
            selector_pnl.Padding = new Padding(10, 11, 10, 11);
            selector_pnl.Size = new Size(1231, 162);
            selector_pnl.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 11);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1211, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instance selector";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(action_cb, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(selector_cb, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1191, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // action_cb
            // 
            action_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            action_cb.BackColor = Color.FromArgb(54, 54, 54);
            action_cb.FlatStyle = FlatStyle.Flat;
            action_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            action_cb.ForeColor = Color.White;
            action_cb.FormattingEnabled = true;
            action_cb.Location = new Point(605, 63);
            action_cb.Margin = new Padding(10);
            action_cb.Name = "action_cb";
            action_cb.Size = new Size(576, 33);
            action_cb.TabIndex = 5;
            action_cb.SelectedIndexChanged += action_cb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(589, 31);
            label2.TabIndex = 4;
            label2.Text = "Action";
            // 
            // selector_cb
            // 
            selector_cb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selector_cb.BackColor = Color.FromArgb(54, 54, 54);
            selector_cb.FlatStyle = FlatStyle.Flat;
            selector_cb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            selector_cb.ForeColor = Color.White;
            selector_cb.FormattingEnabled = true;
            selector_cb.Location = new Point(605, 10);
            selector_cb.Margin = new Padding(10);
            selector_cb.Name = "selector_cb";
            selector_cb.Size = new Size(576, 33);
            selector_cb.TabIndex = 3;
            selector_cb.SelectedIndexChanged += selector_cb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(589, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the desired instance";
            // 
            // panel1
            // 
            panel1.Controls.Add(archive_btn);
            panel1.Controls.Add(save_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 522);
            panel1.MaximumSize = new Size(0, 160);
            panel1.MinimumSize = new Size(0, 150);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 10, 0, 0);
            panel1.Size = new Size(1231, 160);
            panel1.TabIndex = 6;
            // 
            // archive_btn
            // 
            archive_btn.BackColor = Color.FromArgb(54, 54, 54);
            archive_btn.Dock = DockStyle.Top;
            archive_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archive_btn.ForeColor = Color.White;
            archive_btn.Location = new Point(15, 10);
            archive_btn.Margin = new Padding(0);
            archive_btn.MaximumSize = new Size(0, 70);
            archive_btn.MinimumSize = new Size(0, 70);
            archive_btn.Name = "archive_btn";
            archive_btn.Size = new Size(1216, 70);
            archive_btn.TabIndex = 10;
            archive_btn.Text = "Delete instance";
            archive_btn.UseVisualStyleBackColor = false;
            archive_btn.Click += archive_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.FromArgb(54, 54, 54);
            save_btn.Dock = DockStyle.Bottom;
            save_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.ForeColor = Color.White;
            save_btn.Location = new Point(15, 90);
            save_btn.Margin = new Padding(0);
            save_btn.MaximumSize = new Size(0, 70);
            save_btn.MinimumSize = new Size(0, 70);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(1216, 70);
            save_btn.TabIndex = 9;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // BaseAddInstance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(1331, 762);
            Controls.Add(base_pnl);
            Name = "BaseAddInstance";
            Padding = new Padding(30);
            Tag = "workplace";
            Text = "Form1";
            base_pnl.ResumeLayout(false);
            selector_pnl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel base_pnl;
        private Panel selector_pnl;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selector_cb;
        private Label label1;
        private ComboBox action_cb;
        private Label label2;
        private Panel usercontrol_pnl;
        private Panel panel1;
        private Button archive_btn;
        private Button save_btn;
    }
}
