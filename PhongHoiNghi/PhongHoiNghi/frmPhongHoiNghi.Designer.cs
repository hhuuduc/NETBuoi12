namespace PhongHoiNghi
{
    partial class frmPhongHoiNghi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaHoiNghi = new System.Windows.Forms.TextBox();
            this.txt_TenHoiNghi = new System.Windows.Forms.TextBox();
            this.txtSoNguoiThamGia = new System.Windows.Forms.TextBox();
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.grb_DSPHN = new System.Windows.Forms.GroupBox();
            this.dtgv_PhongHoiNghi = new System.Windows.Forms.DataGridView();
            this.btn_LocDanhSach = new System.Windows.Forms.Button();
            this.grb_DSPHN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhongHoiNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "- THÔNG TIN PHÒNG HỘI NGHỊ - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hội Nghị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hội Nghị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Phòng HN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số người tham gia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Huỳnh Hữu Đức - 2001207422";
            // 
            // txt_MaHoiNghi
            // 
            this.txt_MaHoiNghi.Location = new System.Drawing.Point(112, 52);
            this.txt_MaHoiNghi.Name = "txt_MaHoiNghi";
            this.txt_MaHoiNghi.Size = new System.Drawing.Size(643, 22);
            this.txt_MaHoiNghi.TabIndex = 6;
            // 
            // txt_TenHoiNghi
            // 
            this.txt_TenHoiNghi.Location = new System.Drawing.Point(112, 83);
            this.txt_TenHoiNghi.Name = "txt_TenHoiNghi";
            this.txt_TenHoiNghi.Size = new System.Drawing.Size(643, 22);
            this.txt_TenHoiNghi.TabIndex = 7;
            // 
            // txtSoNguoiThamGia
            // 
            this.txtSoNguoiThamGia.Location = new System.Drawing.Point(474, 112);
            this.txtSoNguoiThamGia.Name = "txtSoNguoiThamGia";
            this.txtSoNguoiThamGia.Size = new System.Drawing.Size(281, 22);
            this.txtSoNguoiThamGia.TabIndex = 8;
            this.txtSoNguoiThamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNguoiThamGia_KeyPress);
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Location = new System.Drawing.Point(112, 112);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(239, 23);
            this.cb_LoaiPhong.TabIndex = 9;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(50, 160);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(130, 30);
            this.btn_ThemMoi.TabIndex = 10;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(240, 160);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(130, 30);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu Thêm Mới";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(430, 160);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(130, 30);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa Phòng HN";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.Location = new System.Drawing.Point(620, 160);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(130, 30);
            this.btn_KetThuc.TabIndex = 13;
            this.btn_KetThuc.Text = "Kết Thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = true;
            this.btn_KetThuc.Click += new System.EventHandler(this.btn_KetThuc_Click);
            // 
            // grb_DSPHN
            // 
            this.grb_DSPHN.Controls.Add(this.dtgv_PhongHoiNghi);
            this.grb_DSPHN.Location = new System.Drawing.Point(12, 197);
            this.grb_DSPHN.Name = "grb_DSPHN";
            this.grb_DSPHN.Size = new System.Drawing.Size(760, 137);
            this.grb_DSPHN.TabIndex = 14;
            this.grb_DSPHN.TabStop = false;
            this.grb_DSPHN.Text = "Danh sách phòng hội nghị";
            // 
            // dtgv_PhongHoiNghi
            // 
            this.dtgv_PhongHoiNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PhongHoiNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PhongHoiNghi.Location = new System.Drawing.Point(6, 21);
            this.dtgv_PhongHoiNghi.Name = "dtgv_PhongHoiNghi";
            this.dtgv_PhongHoiNghi.Size = new System.Drawing.Size(748, 110);
            this.dtgv_PhongHoiNghi.TabIndex = 0;
            this.dtgv_PhongHoiNghi.CurrentCellChanged += new System.EventHandler(this.dtgv_PhongHoiNghi_CurrentCellChanged);
            // 
            // btn_LocDanhSach
            // 
            this.btn_LocDanhSach.Location = new System.Drawing.Point(409, 344);
            this.btn_LocDanhSach.Name = "btn_LocDanhSach";
            this.btn_LocDanhSach.Size = new System.Drawing.Size(346, 25);
            this.btn_LocDanhSach.TabIndex = 15;
            this.btn_LocDanhSach.Text = "Lọc danh sách theo phòng hội nghị";
            this.btn_LocDanhSach.UseVisualStyleBackColor = true;
            this.btn_LocDanhSach.Click += new System.EventHandler(this.btn_LocDanhSach_Click);
            // 
            // frmPhongHoiNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.btn_LocDanhSach);
            this.Controls.Add(this.grb_DSPHN);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.cb_LoaiPhong);
            this.Controls.Add(this.txtSoNguoiThamGia);
            this.Controls.Add(this.txt_TenHoiNghi);
            this.Controls.Add(this.txt_MaHoiNghi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhongHoiNghi";
            this.Text = "THÔNG TIN PHÒNG HỘI NGHỊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhongHoiNghi_FormClosing);
            this.Load += new System.EventHandler(this.frmPhongHoiNghi_Load);
            this.grb_DSPHN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhongHoiNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaHoiNghi;
        private System.Windows.Forms.TextBox txt_TenHoiNghi;
        private System.Windows.Forms.TextBox txtSoNguoiThamGia;
        private System.Windows.Forms.ComboBox cb_LoaiPhong;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KetThuc;
        private System.Windows.Forms.GroupBox grb_DSPHN;
        private System.Windows.Forms.DataGridView dtgv_PhongHoiNghi;
        private System.Windows.Forms.Button btn_LocDanhSach;
    }
}

