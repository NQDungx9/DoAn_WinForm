
namespace QLSINHVIEN.GUI
{
    partial class frm_SinhVien
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
            bt_ChiTiet = new System.Windows.Forms.Button();
            bt_Hủy = new System.Windows.Forms.Button();
            bt_Reset = new System.Windows.Forms.Button();
            txt_SDT = new System.Windows.Forms.TextBox();
            cb_Lop = new System.Windows.Forms.ComboBox();
            NgaySinh = new System.Windows.Forms.DateTimePicker();
            txt_TenSV = new System.Windows.Forms.TextBox();
            txt_MaSV = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            bt_Xoa = new System.Windows.Forms.Button();
            bt_Sua = new System.Windows.Forms.Button();
            bt_Luu = new System.Windows.Forms.Button();
            bt_Them = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txt_TimKiem = new System.Windows.Forms.TextBox();
            bt_Tim = new System.Windows.Forms.Button();
            bt_LoadLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(128, 128, 255);
            dataGridView1.Location = new System.Drawing.Point(99, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1023, 518);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(bt_ChiTiet);
            panel1.Controls.Add(bt_Hủy);
            panel1.Controls.Add(bt_Reset);
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(cb_Lop);
            panel1.Controls.Add(NgaySinh);
            panel1.Controls.Add(txt_TenSV);
            panel1.Controls.Add(txt_MaSV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1187, 100);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(346, 518);
            panel1.TabIndex = 1;
            // 
            // bt_ChiTiet
            // 
            bt_ChiTiet.BackColor = System.Drawing.Color.LightCoral;
            bt_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_ChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_ChiTiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_ChiTiet.Location = new System.Drawing.Point(187, 457);
            bt_ChiTiet.Name = "bt_ChiTiet";
            bt_ChiTiet.Size = new System.Drawing.Size(115, 46);
            bt_ChiTiet.TabIndex = 13;
            bt_ChiTiet.Text = "Chi Tiết";
            bt_ChiTiet.UseVisualStyleBackColor = false;
            bt_ChiTiet.Click += bt_ChiTiet_Click;
            // 
            // bt_Hủy
            // 
            bt_Hủy.BackColor = System.Drawing.Color.LightCoral;
            bt_Hủy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_Hủy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Hủy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_Hủy.Location = new System.Drawing.Point(187, 391);
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
            bt_Reset.Location = new System.Drawing.Point(20, 391);
            bt_Reset.Name = "bt_Reset";
            bt_Reset.Size = new System.Drawing.Size(115, 46);
            bt_Reset.TabIndex = 11;
            bt_Reset.Text = "Reset";
            bt_Reset.UseVisualStyleBackColor = false;
            bt_Reset.Visible = false;
            bt_Reset.Click += bt_Reset_Click;
            // 
            // txt_SDT
            // 
            txt_SDT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_SDT.Enabled = false;
            txt_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_SDT.Location = new System.Drawing.Point(20, 254);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new System.Drawing.Size(282, 34);
            txt_SDT.TabIndex = 10;
            // 
            // cb_Lop
            // 
            cb_Lop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            cb_Lop.Enabled = false;
            cb_Lop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_Lop.FormattingEnabled = true;
            cb_Lop.Location = new System.Drawing.Point(20, 330);
            cb_Lop.Name = "cb_Lop";
            cb_Lop.Size = new System.Drawing.Size(282, 34);
            cb_Lop.TabIndex = 9;
            cb_Lop.SelectedIndexChanged += cb_Lop_SelectedIndexChanged;
            // 
            // NgaySinh
            // 
            NgaySinh.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NgaySinh.CustomFormat = "MM/dd/yyyy";
            NgaySinh.Enabled = false;
            NgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            NgaySinh.Location = new System.Drawing.Point(18, 188);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new System.Drawing.Size(284, 34);
            NgaySinh.TabIndex = 7;
            NgaySinh.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            // 
            // txt_TenSV
            // 
            txt_TenSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_TenSV.Enabled = false;
            txt_TenSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_TenSV.Location = new System.Drawing.Point(20, 116);
            txt_TenSV.Name = "txt_TenSV";
            txt_TenSV.Size = new System.Drawing.Size(282, 34);
            txt_TenSV.TabIndex = 6;
            // 
            // txt_MaSV
            // 
            txt_MaSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txt_MaSV.Enabled = false;
            txt_MaSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_MaSV.Location = new System.Drawing.Point(18, 38);
            txt_MaSV.Name = "txt_MaSV";
            txt_MaSV.Size = new System.Drawing.Size(284, 34);
            txt_MaSV.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(20, 305);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 22);
            label5.TabIndex = 4;
            label5.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(18, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(125, 22);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(18, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên Sinh Viên";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(18, 166);
            label.Name = "label";
            label.Size = new System.Drawing.Size(91, 22);
            label.TabIndex = 1;
            label.Text = "Ngày Sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
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
            panel2.TabIndex = 2;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            pictureBox1.Image = Properties.Resources.icons8_search_96;
            pictureBox1.Location = new System.Drawing.Point(99, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(52, 39);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.BackColor = System.Drawing.Color.SkyBlue;
            txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            txt_TimKiem.Location = new System.Drawing.Point(157, 56);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new System.Drawing.Size(251, 39);
            txt_TimKiem.TabIndex = 4;
            txt_TimKiem.Tag = "";
            txt_TimKiem.WordWrap = false;
            txt_TimKiem.KeyDown += Tim_KD;
            // 
            // bt_Tim
            // 
            bt_Tim.BackColor = System.Drawing.Color.LightCoral;
            bt_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_Tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_Tim.Location = new System.Drawing.Point(414, 56);
            bt_Tim.Name = "bt_Tim";
            bt_Tim.Size = new System.Drawing.Size(115, 39);
            bt_Tim.TabIndex = 13;
            bt_Tim.Text = "Tìm";
            bt_Tim.UseVisualStyleBackColor = false;
            bt_Tim.Click += bt_Tim_Click;
            // 
            // bt_LoadLai
            // 
            bt_LoadLai.BackColor = System.Drawing.Color.LightCoral;
            bt_LoadLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_LoadLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_LoadLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_LoadLai.Location = new System.Drawing.Point(986, 55);
            bt_LoadLai.Name = "bt_LoadLai";
            bt_LoadLai.Size = new System.Drawing.Size(136, 39);
            bt_LoadLai.TabIndex = 14;
            bt_LoadLai.Text = "Load Lại";
            bt_LoadLai.UseVisualStyleBackColor = false;
            bt_LoadLai.Click += bt_LoadLai_Click;
            // 
            // frm_SinhVien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            ClientSize = new System.Drawing.Size(1571, 782);
            Controls.Add(bt_LoadLai);
            Controls.Add(bt_Tim);
            Controls.Add(txt_TimKiem);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frm_SinhVien";
            Text = "frm_SinhVien";
            Load += frm_SinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cb_Lop;
        public System.Windows.Forms.DateTimePicker NgaySinh;
        public System.Windows.Forms.TextBox txt_TenSV;
        public System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Hủy;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_LoadLai;
        private System.Windows.Forms.Button bt_ChiTiet;
    }
}