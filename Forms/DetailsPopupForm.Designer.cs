namespace SmartStock.Forms
{
    partial class DetailsPopupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            details_dgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)details_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(details_dgv);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 410);
            panel1.TabIndex = 0;
            // 
            // details_dgv
            // 
            details_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            details_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            details_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            details_dgv.Dock = DockStyle.Fill;
            details_dgv.Location = new Point(0, 0);
            details_dgv.Name = "details_dgv";
            details_dgv.ReadOnly = true;
            details_dgv.RowHeadersWidth = 51;
            details_dgv.Size = new Size(760, 410);
            details_dgv.TabIndex = 0;
            // 
            // DetailsPopupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DetailsPopupForm";
            Padding = new Padding(20);
            Text = "DetailsPopupForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)details_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView details_dgv;
    }
}