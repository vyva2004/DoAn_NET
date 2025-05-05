namespace GUI
{
    partial class Hoadon
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
            this.cbo_MaHocVienHD = new System.Windows.Forms.ComboBox();
            this.dgv_banghoadon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongTienHD = new System.Windows.Forms.TextBox();
            this.btn_LamMoiHD = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_CapNhatHD = new System.Windows.Forms.Button();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MGG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_LamMoiCTHoaDon = new System.Windows.Forms.Button();
            this.btn_CapNhapCTHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaCTHoaDon = new System.Windows.Forms.Button();
            this.cbo_MaHoaDonCT = new System.Windows.Forms.ComboBox();
            this.cbo_MaHoaDon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_TongTienCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_NgayLapDon = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banghoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_MaHocVienHD
            // 
            this.cbo_MaHocVienHD.FormattingEnabled = true;
            this.cbo_MaHocVienHD.Location = new System.Drawing.Point(163, 135);
            this.cbo_MaHocVienHD.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaHocVienHD.Name = "cbo_MaHocVienHD";
            this.cbo_MaHocVienHD.Size = new System.Drawing.Size(195, 24);
            this.cbo_MaHocVienHD.TabIndex = 90;
            this.cbo_MaHocVienHD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaHocVienHD_SelectedIndexChanged);
            // 
            // dgv_banghoadon
            // 
            this.dgv_banghoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_banghoadon.Location = new System.Drawing.Point(13, 241);
            this.dgv_banghoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_banghoadon.Name = "dgv_banghoadon";
            this.dgv_banghoadon.RowHeadersWidth = 51;
            this.dgv_banghoadon.Size = new System.Drawing.Size(1033, 206);
            this.dgv_banghoadon.TabIndex = 88;
            this.dgv_banghoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_banghoadon_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 42);
            this.label6.TabIndex = 83;
            this.label6.Text = "HÓA ĐƠN";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(163, 82);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(195, 22);
            this.txt_MaHD.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mã học viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txt_TongTienHD
            // 
            this.txt_TongTienHD.Location = new System.Drawing.Point(548, 137);
            this.txt_TongTienHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTienHD.Name = "txt_TongTienHD";
            this.txt_TongTienHD.Size = new System.Drawing.Size(185, 22);
            this.txt_TongTienHD.TabIndex = 82;
            // 
            // btn_LamMoiHD
            // 
            this.btn_LamMoiHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LamMoiHD.Location = new System.Drawing.Point(874, 93);
            this.btn_LamMoiHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoiHD.Name = "btn_LamMoiHD";
            this.btn_LamMoiHD.Size = new System.Drawing.Size(93, 55);
            this.btn_LamMoiHD.TabIndex = 95;
            this.btn_LamMoiHD.Text = "Làm mới";
            this.btn_LamMoiHD.UseVisualStyleBackColor = false;
            this.btn_LamMoiHD.Click += new System.EventHandler(this.btn_LamMoiHD_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Location = new System.Drawing.Point(874, 154);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_Thoat.TabIndex = 91;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // btn_CapNhatHD
            // 
            this.btn_CapNhatHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_CapNhatHD.Location = new System.Drawing.Point(774, 91);
            this.btn_CapNhatHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhatHD.Name = "btn_CapNhatHD";
            this.btn_CapNhatHD.Size = new System.Drawing.Size(93, 55);
            this.btn_CapNhatHD.TabIndex = 92;
            this.btn_CapNhatHD.Text = "cập nhật";
            this.btn_CapNhatHD.UseVisualStyleBackColor = false;
            this.btn_CapNhatHD.Click += new System.EventHandler(this.btn_CapNhatHD_Click);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XoaHD.Location = new System.Drawing.Point(874, 28);
            this.btn_XoaHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(93, 55);
            this.btn_XoaHD.TabIndex = 93;
            this.btn_XoaHD.Text = "Xóa";
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ThemHD.Location = new System.Drawing.Point(774, 28);
            this.btn_ThemHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(93, 55);
            this.btn_ThemHD.TabIndex = 94;
            this.btn_ThemHD.Text = "Thêm";
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Mã giảm giá";
            // 
            // txt_MGG
            // 
            this.txt_MGG.Location = new System.Drawing.Point(548, 82);
            this.txt_MGG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MGG.Name = "txt_MGG";
            this.txt_MGG.Size = new System.Drawing.Size(185, 22);
            this.txt_MGG.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 42);
            this.label4.TabIndex = 83;
            // 
            // btn_LamMoiCTHoaDon
            // 
            this.btn_LamMoiCTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LamMoiCTHoaDon.Location = new System.Drawing.Point(661, 718);
            this.btn_LamMoiCTHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoiCTHoaDon.Name = "btn_LamMoiCTHoaDon";
            this.btn_LamMoiCTHoaDon.Size = new System.Drawing.Size(93, 55);
            this.btn_LamMoiCTHoaDon.TabIndex = 121;
            this.btn_LamMoiCTHoaDon.Text = "Làm mới";
            this.btn_LamMoiCTHoaDon.UseVisualStyleBackColor = false;
            this.btn_LamMoiCTHoaDon.Click += new System.EventHandler(this.btn_LamMoiCTHoaDon_Click);
            // 
            // btn_CapNhapCTHoaDon
            // 
            this.btn_CapNhapCTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_CapNhapCTHoaDon.Location = new System.Drawing.Point(488, 718);
            this.btn_CapNhapCTHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhapCTHoaDon.Name = "btn_CapNhapCTHoaDon";
            this.btn_CapNhapCTHoaDon.Size = new System.Drawing.Size(93, 55);
            this.btn_CapNhapCTHoaDon.TabIndex = 118;
            this.btn_CapNhapCTHoaDon.Text = "cập nhật";
            this.btn_CapNhapCTHoaDon.UseVisualStyleBackColor = false;
            // 
            // btn_XoaCTHoaDon
            // 
            this.btn_XoaCTHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XoaCTHoaDon.Location = new System.Drawing.Point(324, 718);
            this.btn_XoaCTHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaCTHoaDon.Name = "btn_XoaCTHoaDon";
            this.btn_XoaCTHoaDon.Size = new System.Drawing.Size(93, 55);
            this.btn_XoaCTHoaDon.TabIndex = 119;
            this.btn_XoaCTHoaDon.Text = "Xóa";
            this.btn_XoaCTHoaDon.UseVisualStyleBackColor = false;
            // 
            // cbo_MaHoaDonCT
            // 
            this.cbo_MaHoaDonCT.FormattingEnabled = true;
            this.cbo_MaHoaDonCT.Location = new System.Drawing.Point(287, 557);
            this.cbo_MaHoaDonCT.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaHoaDonCT.Name = "cbo_MaHoaDonCT";
            this.cbo_MaHoaDonCT.Size = new System.Drawing.Size(228, 24);
            this.cbo_MaHoaDonCT.TabIndex = 115;
            // 
            // cbo_MaHoaDon
            // 
            this.cbo_MaHoaDon.FormattingEnabled = true;
            this.cbo_MaHoaDon.Location = new System.Drawing.Point(287, 606);
            this.cbo_MaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaHoaDon.Name = "cbo_MaHoaDon";
            this.cbo_MaHoaDon.Size = new System.Drawing.Size(228, 24);
            this.cbo_MaHoaDon.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 606);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 113;
            this.label5.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 551);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 114;
            this.label7.Text = "Tổng tiền";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(691, 606);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(228, 22);
            this.txt_GhiChu.TabIndex = 111;
            // 
            // txt_TongTienCT
            // 
            this.txt_TongTienCT.Location = new System.Drawing.Point(691, 557);
            this.txt_TongTienCT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTienCT.Name = "txt_TongTienCT";
            this.txt_TongTienCT.Size = new System.Drawing.Size(228, 22);
            this.txt_TongTienCT.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 606);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 109;
            this.label8.Text = "Mã hoá đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 555);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 24);
            this.label9.TabIndex = 110;
            this.label9.Text = "Mã hóa đơn chi tiết";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 472);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(371, 42);
            this.label11.TabIndex = 122;
            this.label11.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgv_ChiTietHoaDon
            // 
            this.dgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHoaDon.Location = new System.Drawing.Point(21, 826);
            this.dgv_ChiTietHoaDon.Name = "dgv_ChiTietHoaDon";
            this.dgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dgv_ChiTietHoaDon.RowTemplate.Height = 24;
            this.dgv_ChiTietHoaDon.Size = new System.Drawing.Size(1025, 192);
            this.dgv_ChiTietHoaDon.TabIndex = 123;
            this.dgv_ChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHoaDon_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 76;
            this.label12.Text = "Ngày lập đơn";
            // 
            // dtp_NgayLapDon
            // 
            this.dtp_NgayLapDon.Location = new System.Drawing.Point(163, 195);
            this.dtp_NgayLapDon.Name = "dtp_NgayLapDon";
            this.dtp_NgayLapDon.Size = new System.Drawing.Size(195, 22);
            this.dtp_NgayLapDon.TabIndex = 124;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(124, 657);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 24);
            this.label13.TabIndex = 114;
            this.label13.Text = "Mã khoá học";
            // 
            // cb_KhoaHoc
            // 
            this.cb_KhoaHoc.FormattingEnabled = true;
            this.cb_KhoaHoc.Location = new System.Drawing.Point(287, 659);
            this.cb_KhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cb_KhoaHoc.Name = "cb_KhoaHoc";
            this.cb_KhoaHoc.Size = new System.Drawing.Size(228, 24);
            this.cb_KhoaHoc.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 76;
            this.label10.Text = "Tổng tiền";
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1059, 1030);
            this.Controls.Add(this.dtp_NgayLapDon);
            this.Controls.Add(this.dgv_ChiTietHoaDon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_LamMoiCTHoaDon);
            this.Controls.Add(this.btn_CapNhapCTHoaDon);
            this.Controls.Add(this.btn_XoaCTHoaDon);
            this.Controls.Add(this.cbo_MaHoaDonCT);
            this.Controls.Add(this.cb_KhoaHoc);
            this.Controls.Add(this.cbo_MaHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_TongTienCT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_LamMoiHD);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CapNhatHD);
            this.Controls.Add(this.btn_XoaHD);
            this.Controls.Add(this.btn_ThemHD);
            this.Controls.Add(this.cbo_MaHocVienHD);
            this.Controls.Add(this.dgv_banghoadon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TongTienHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MGG);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hoadon";
            this.Text = "BẢNG HÓA ĐƠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hoadon_FormClosing);
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banghoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_MaHocVienHD;
        private System.Windows.Forms.DataGridView dgv_banghoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TongTienHD;
		private System.Windows.Forms.Button btn_LamMoiHD;
		private System.Windows.Forms.Button btn_Thoat;
		private System.Windows.Forms.Button btn_CapNhatHD;
		private System.Windows.Forms.Button btn_XoaHD;
		private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MGG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_LamMoiCTHoaDon;
        private System.Windows.Forms.Button btn_CapNhapCTHoaDon;
        private System.Windows.Forms.Button btn_XoaCTHoaDon;
        private System.Windows.Forms.ComboBox cbo_MaHoaDonCT;
        private System.Windows.Forms.ComboBox cbo_MaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_TongTienCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_ChiTietHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_KhoaHoc;
        private System.Windows.Forms.Label label10;
    }
}