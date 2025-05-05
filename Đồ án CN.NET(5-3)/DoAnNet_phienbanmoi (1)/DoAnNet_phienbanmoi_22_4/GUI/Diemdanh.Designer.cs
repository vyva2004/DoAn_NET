namespace GUI
{
	partial class Diemdanh
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
            this.dtp_NgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.dgv_bangdiemdanh = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_madiemdanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbo_MaGiaoVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_MaHocVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenGiaoVien = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiemdanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_NgayDiemDanh
            // 
            this.dtp_NgayDiemDanh.Enabled = false;
            this.dtp_NgayDiemDanh.Location = new System.Drawing.Point(715, 75);
            this.dtp_NgayDiemDanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayDiemDanh.Name = "dtp_NgayDiemDanh";
            this.dtp_NgayDiemDanh.Size = new System.Drawing.Size(228, 22);
            this.dtp_NgayDiemDanh.TabIndex = 125;
            // 
            // dgv_bangdiemdanh
            // 
            this.dgv_bangdiemdanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bangdiemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangdiemdanh.Location = new System.Drawing.Point(13, 343);
            this.dgv_bangdiemdanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bangdiemdanh.Name = "dgv_bangdiemdanh";
            this.dgv_bangdiemdanh.RowHeadersWidth = 51;
            this.dgv_bangdiemdanh.Size = new System.Drawing.Size(1041, 198);
            this.dgv_bangdiemdanh.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 42);
            this.label6.TabIndex = 116;
            this.label6.Text = "BẢNG ĐIỂM DANH";
            // 
            // txt_madiemdanh
            // 
            this.txt_madiemdanh.Location = new System.Drawing.Point(244, 73);
            this.txt_madiemdanh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madiemdanh.Name = "txt_madiemdanh";
            this.txt_madiemdanh.Size = new System.Drawing.Size(228, 22);
            this.txt_madiemdanh.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 111;
            this.label2.Text = "Mã giáo viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ngày điểm danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mã điểm danh:";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lammoi.Location = new System.Drawing.Point(663, 250);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(93, 55);
            this.btn_lammoi.TabIndex = 130;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(823, 250);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_thoat.TabIndex = 126;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_capnhat.Location = new System.Drawing.Point(480, 250);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(93, 55);
            this.btn_capnhat.TabIndex = 127;
            this.btn_capnhat.Text = "cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xoa.Location = new System.Drawing.Point(316, 250);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 55);
            this.btn_xoa.TabIndex = 128;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(152, 250);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 55);
            this.btn_them.TabIndex = 129;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cbo_MaGiaoVien
            // 
            this.cbo_MaGiaoVien.FormattingEnabled = true;
            this.cbo_MaGiaoVien.Location = new System.Drawing.Point(244, 136);
            this.cbo_MaGiaoVien.Name = "cbo_MaGiaoVien";
            this.cbo_MaGiaoVien.Size = new System.Drawing.Size(228, 24);
            this.cbo_MaGiaoVien.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 111;
            this.label4.Text = "Mã học viên:";
            // 
            // cbo_MaHocVien
            // 
            this.cbo_MaHocVien.Enabled = false;
            this.cbo_MaHocVien.FormattingEnabled = true;
            this.cbo_MaHocVien.Location = new System.Drawing.Point(244, 184);
            this.cbo_MaHocVien.Name = "cbo_MaHocVien";
            this.cbo_MaHocVien.Size = new System.Drawing.Size(228, 24);
            this.cbo_MaHocVien.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 111;
            this.label7.Text = "Tên giáo viên:";
            // 
            // txt_TenGiaoVien
            // 
            this.txt_TenGiaoVien.Enabled = false;
            this.txt_TenGiaoVien.Location = new System.Drawing.Point(715, 138);
            this.txt_TenGiaoVien.Name = "txt_TenGiaoVien";
            this.txt_TenGiaoVien.Size = new System.Drawing.Size(228, 22);
            this.txt_TenGiaoVien.TabIndex = 133;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Enabled = false;
            this.txt_TrangThai.Location = new System.Drawing.Point(715, 190);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(228, 22);
            this.txt_TrangThai.TabIndex = 133;
            // 
            // Diemdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.txt_TenGiaoVien);
            this.Controls.Add(this.cbo_MaHocVien);
            this.Controls.Add(this.cbo_MaGiaoVien);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_NgayDiemDanh);
            this.Controls.Add(this.dgv_bangdiemdanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_madiemdanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Diemdanh";
            this.Text = "BẢNG ĐIỂM DANH";
            this.Load += new System.EventHandler(this.Diemdanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiemdanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtp_NgayDiemDanh;
		private System.Windows.Forms.DataGridView dgv_bangdiemdanh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_madiemdanh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_lammoi;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_capnhat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_MaGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_MaHocVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenGiaoVien;
        private System.Windows.Forms.TextBox txt_TrangThai;
    }
}