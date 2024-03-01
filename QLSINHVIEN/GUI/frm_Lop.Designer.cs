
namespace QLSINHVIEN.GUI
{
    partial class frm_Lop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            bt_Hủy = new System.Windows.Forms.Button();
            bt_Reset = new System.Windows.Forms.Button();
            txt_NienKhoa = new System.Windows.Forms.TextBox();
            txt_Khoa = new System.Windows.Forms.TextBox();
            txt_MaLop = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            bt_Xoa = new System.Windows.Forms.Button();
            bt_Sua = new System.Windows.Forms.Button();
            bt_Luu = new System.Windows.Forms.Button();
            bt_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(128, 128, 255);
            dataGridView1.Location = new System.Drawing.Point(99, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1023, 518);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(bt_Hủy);
            panel1.Controls.Add(bt_Reset);
            panel1.Controls.Add(txt_NienKhoa);
            panel1.Controls.Add(txt_Khoa);
            panel1.Controls.Add(txt_MaLop);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1187, 100);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(346, 518);
            panel1.TabIndex = 2;
            // 
            // bt_Hủy
            // 
            bt_Hủy.BackColor = System.Drawing.Color.LightCoral;
            bt_Hủy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_Hủy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Hủy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_Hủy.Location = new System.Drawing.Point(187, 404);
            bt_Hủy.Name = "bt_Hủy";
            bt_Hủy.Size = new System.Drawing.Size(115, 46);
            bt_Hủy.TabIndex = 12;
            bt_Hủy.Text = "Hủy";
            bt_Hủy.UseVisualStyleBackColor = false;
            bt_Hủy.Visible = false;
            bt_Hủy.Click += bt_Hủy_Click;
            // 
            // bt_Reset
            // 
            bt_Reset.BackColor = System.Drawing.Color.LightCoral;
            bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_Reset.Location = new System.Drawing.Point(20, 404);
            bt_Reset.Name = "bt_Reset";
            bt_Reset.Size = new System.Drawing.Size(115, 46);
            bt_Reset.TabIndex = 11;
            bt_Reset.Text = "Reset";
            bt_Reset.UseVisualStyleBackColor = false;
            bt_Reset.Visible = false;
            bt_Reset.Click += bt_Reset_Click;
            // 
            // txt_NienKhoa
            // 
            txt_NienKhoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_NienKhoa.Enabled = false;
            txt_NienKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_NienKhoa.Location = new System.Drawing.Point(20, 221);
            txt_NienKhoa.Name = "txt_NienKhoa";
            txt_NienKhoa.Size = new System.Drawing.Size(282, 34);
            txt_NienKhoa.TabIndex = 10;
            // 
            // txt_Khoa
            // 
            txt_Khoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_Khoa.Enabled = false;
            txt_Khoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Khoa.Location = new System.Drawing.Point(20, 127);
            txt_Khoa.Name = "txt_Khoa";
            txt_Khoa.Size = new System.Drawing.Size(282, 34);
            txt_Khoa.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            txt_MaLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_MaLop.Enabled = false;
            txt_MaLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_MaLop.Location = new System.Drawing.Point(18, 38);
            txt_MaLop.Name = "txt_MaLop";
            txt_MaLop.Size = new System.Drawing.Size(284, 34);
            txt_MaLop.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(20, 196);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 22);
            label4.TabIndex = 3;
            label4.Text = "Niên Khóa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(18, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Lớp";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.Color.SkyBlue;
            panel2.Controls.Add(bt_Xoa);
            panel2.Controls.Add(bt_Sua);
            panel2.Controls.Add(bt_Luu);
            panel2.Controls.Add(bt_Them);
            panel2.Location = new System.Drawing.Point(99, 650);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1434, 106);
            panel2.TabIndex = 3;
            // 
            // bt_Xoa
            // 
            bt_Xoa.BackColor = System.Drawing.Color.SkyBlue;
            bt_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            bt_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Xoa.Image = Properties.Resources.icons8_delete_100;
            bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_Xoa.Location = new System.Drawing.Point(1054, 0);
            bt_Xoa.Name = "bt_Xoa";
            bt_Xoa.Size = new System.Drawing.Size(380, 106);
            bt_Xoa.TabIndex = 3;
            bt_Xoa.Text = "Xóa";
            bt_Xoa.UseVisualStyleBackColor = false;
            bt_Xoa.Click += bt_Xoa_Click;
            // 
            // bt_Sua
            // 
            bt_Sua.BackColor = System.Drawing.Color.SkyBlue;
            bt_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Sua.Image = Properties.Resources.icons8_pencil_drawing_96;
            bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_Sua.Location = new System.Drawing.Point(768, 0);
            bt_Sua.Name = "bt_Sua";
            bt_Sua.Size = new System.Drawing.Size(390, 106);
            bt_Sua.TabIndex = 2;
            bt_Sua.Text = "Sửa";
            bt_Sua.UseVisualStyleBackColor = false;
            bt_Sua.Click += bt_Sua_Click;
            // 
            // bt_Luu
            // 
            bt_Luu.BackColor = System.Drawing.Color.SkyBlue;
            bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Luu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Luu.Image = Properties.Resources.icons8_save_96;
            bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_Luu.Location = new System.Drawing.Point(389, 0);
            bt_Luu.Name = "bt_Luu";
            bt_Luu.Size = new System.Drawing.Size(380, 106);
            bt_Luu.TabIndex = 1;
            bt_Luu.Text = "Lưu";
            bt_Luu.UseVisualStyleBackColor = false;
            bt_Luu.Click += bt_Luu_Click;
            // 
            // bt_Them
            // 
            bt_Them.BackColor = System.Drawing.Color.SkyBlue;
            bt_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Them.Image = Properties.Resources.icons8_add_80;
            bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_Them.Location = new System.Drawing.Point(0, 0);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new System.Drawing.Size(390, 106);
            bt_Them.TabIndex = 0;
            bt_Them.Text = "Thêm";
            bt_Them.UseVisualStyleBackColor = false;
            bt_Them.Click += bt_Them_Click;
            // 
            // frm_Lop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            ClientSize = new System.Drawing.Size(1571, 782);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frm_Lop";
            Text = "frm_Lop";
            Load += frm_Lop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Hủy;
        private System.Windows.Forms.Button bt_Reset;
        public System.Windows.Forms.TextBox txt_NienKhoa;
        public System.Windows.Forms.TextBox txt_Khoa;
        public System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Them;
    }
}