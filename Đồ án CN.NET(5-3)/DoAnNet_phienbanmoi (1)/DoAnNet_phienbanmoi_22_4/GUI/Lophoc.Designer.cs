namespace GUI
{
    partial class Lophoc
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
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_banglophoc = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenlh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_malh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.cbo_macoso = new System.Windows.Forms.ComboBox();
            this.cbo_magv = new System.Windows.Forms.ComboBox();
            this.txt_cahoc = new System.Windows.Forms.TextBox();
            this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_maphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banglophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 69;
            this.label10.Text = "Mã khóa học:";
            // 
            // dgv_banglophoc
            // 
            this.dgv_banglophoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_banglophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_banglophoc.Location = new System.Drawing.Point(0, 352);
            this.dgv_banglophoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_banglophoc.Name = "dgv_banglophoc";
            this.dgv_banglophoc.RowHeadersWidth = 51;
            this.dgv_banglophoc.Size = new System.Drawing.Size(1066, 174);
            this.dgv_banglophoc.TabIndex = 65;
            this.dgv_banglophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_banglophoc_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 42);
            this.label6.TabIndex = 60;
            this.label6.Text = "BẢNG LỚP HỌC";
            // 
            // txt_tenlh
            // 
            this.txt_tenlh.Location = new System.Drawing.Point(244, 126);
            this.txt_tenlh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenlh.Name = "txt_tenlh";
            this.txt_tenlh.Size = new System.Drawing.Size(228, 22);
            this.txt_tenlh.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Ca học:";
            // 
            // txt_malh
            // 
            this.txt_malh.Location = new System.Drawing.Point(244, 78);
            this.txt_malh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_malh.Name = "txt_malh";
            this.txt_malh.Size = new System.Drawing.Size(228, 22);
            this.txt_malh.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Ngày kết thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Mã cơ sở:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tên lớp học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mã giáo viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã lớp học:";
            // 
            // cbo_makh
            // 
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(244, 169);
            this.cbo_makh.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(228, 24);
            this.cbo_makh.TabIndex = 71;
            // 
            // cbo_macoso
            // 
            this.cbo_macoso.FormattingEnabled = true;
            this.cbo_macoso.Location = new System.Drawing.Point(244, 223);
            this.cbo_macoso.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_macoso.Name = "cbo_macoso";
            this.cbo_macoso.Size = new System.Drawing.Size(228, 24);
            this.cbo_macoso.TabIndex = 71;
            // 
            // cbo_magv
            // 
            this.cbo_magv.FormattingEnabled = true;
            this.cbo_magv.Location = new System.Drawing.Point(695, 76);
            this.cbo_magv.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_magv.Name = "cbo_magv";
            this.cbo_magv.Size = new System.Drawing.Size(228, 24);
            this.cbo_magv.TabIndex = 71;
            // 
            // txt_cahoc
            // 
            this.txt_cahoc.Location = new System.Drawing.Point(695, 223);
            this.txt_cahoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cahoc.Name = "txt_cahoc";
            this.txt_cahoc.Size = new System.Drawing.Size(228, 22);
            this.txt_cahoc.TabIndex = 55;
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(695, 134);
            this.dtp_ngaybatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(228, 22);
            this.dtp_ngaybatdau.TabIndex = 72;
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(695, 178);
            this.dtp_ngayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(228, 22);
            this.dtp_ngayketthuc.TabIndex = 72;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lammoi.Location = new System.Drawing.Point(661, 289);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(93, 55);
            this.btn_lammoi.TabIndex = 135;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(821, 289);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_thoat.TabIndex = 131;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_capnhat.Location = new System.Drawing.Point(478, 289);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(93, 55);
            this.btn_capnhat.TabIndex = 132;
            this.btn_capnhat.Text = "cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xoa.Location = new System.Drawing.Point(314, 289);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 55);
            this.btn_xoa.TabIndex = 133;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(150, 289);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 55);
            this.btn_them.TabIndex = 134;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mã phòng học:";
            // 
            // cbo_maphong
            // 
            this.cbo_maphong.FormattingEnabled = true;
            this.cbo_maphong.Location = new System.Drawing.Point(695, 256);
            this.cbo_maphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_maphong.Name = "cbo_maphong";
            this.cbo_maphong.Size = new System.Drawing.Size(228, 24);
            this.cbo_maphong.TabIndex = 71;
            // 
            // Lophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_ngayketthuc);
            this.Controls.Add(this.dtp_ngaybatdau);
            this.Controls.Add(this.cbo_magv);
            this.Controls.Add(this.cbo_maphong);
            this.Controls.Add(this.cbo_macoso);
            this.Controls.Add(this.cbo_makh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_banglophoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cahoc);
            this.Controls.Add(this.txt_tenlh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_malh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lophoc";
            this.Text = "BẢNG LỚP HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lophoc_FormClosing);
            this.Load += new System.EventHandler(this.Lophoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banglophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_banglophoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenlh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_malh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_makh;
        private System.Windows.Forms.ComboBox cbo_macoso;
        private System.Windows.Forms.ComboBox cbo_magv;
        private System.Windows.Forms.TextBox txt_cahoc;
        private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
        private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
		private System.Windows.Forms.Button btn_lammoi;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_capnhat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_maphong;
    }
}