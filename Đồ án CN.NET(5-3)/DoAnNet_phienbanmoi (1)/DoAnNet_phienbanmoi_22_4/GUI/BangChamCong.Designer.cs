namespace GUI
{
    partial class BangChamCong
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
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_BangChamCong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_mahv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoGioLamViec = new System.Windows.Forms.TextBox();
            this.txt_MaChamCong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.dtp_NgayLamViec = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lammoi.Location = new System.Drawing.Point(661, 253);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(93, 55);
            this.btn_lammoi.TabIndex = 101;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(821, 253);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_thoat.TabIndex = 97;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_capnhat.Location = new System.Drawing.Point(478, 253);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(93, 55);
            this.btn_capnhat.TabIndex = 98;
            this.btn_capnhat.Text = "cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xoa.Location = new System.Drawing.Point(314, 253);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 55);
            this.btn_xoa.TabIndex = 99;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(150, 253);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 55);
            this.btn_them.TabIndex = 100;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // dgv_BangChamCong
            // 
            this.dgv_BangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangChamCong.Location = new System.Drawing.Point(13, 335);
            this.dgv_BangChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BangChamCong.Name = "dgv_BangChamCong";
            this.dgv_BangChamCong.RowHeadersWidth = 51;
            this.dgv_BangChamCong.Size = new System.Drawing.Size(1041, 206);
            this.dgv_BangChamCong.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 42);
            this.label6.TabIndex = 102;
            this.label6.Text = "BẢNG CHẤM CÔNG";
            // 
            // cbo_mahv
            // 
            this.cbo_mahv.FormattingEnabled = true;
            this.cbo_mahv.Location = new System.Drawing.Point(207, 147);
            this.cbo_mahv.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_mahv.Name = "cbo_mahv";
            this.cbo_mahv.Size = new System.Drawing.Size(228, 24);
            this.cbo_mahv.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 24);
            this.label10.TabIndex = 116;
            this.label10.Text = "Ngày làm việc:";
            // 
            // txt_SoGioLamViec
            // 
            this.txt_SoGioLamViec.Location = new System.Drawing.Point(671, 68);
            this.txt_SoGioLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoGioLamViec.Name = "txt_SoGioLamViec";
            this.txt_SoGioLamViec.Size = new System.Drawing.Size(228, 22);
            this.txt_SoGioLamViec.TabIndex = 114;
            // 
            // txt_MaChamCong
            // 
            this.txt_MaChamCong.Location = new System.Drawing.Point(207, 77);
            this.txt_MaChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaChamCong.Name = "txt_MaChamCong";
            this.txt_MaChamCong.Size = new System.Drawing.Size(228, 22);
            this.txt_MaChamCong.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Số giờ làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 141);
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
            this.label3.Location = new System.Drawing.Point(542, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mã chấm công:";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(671, 141);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(228, 96);
            this.txt_GhiChu.TabIndex = 119;
            // 
            // dtp_NgayLamViec
            // 
            this.dtp_NgayLamViec.Location = new System.Drawing.Point(207, 215);
            this.dtp_NgayLamViec.Name = "dtp_NgayLamViec";
            this.dtp_NgayLamViec.Size = new System.Drawing.Size(228, 22);
            this.dtp_NgayLamViec.TabIndex = 120;
            // 
            // BangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtp_NgayLamViec);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.cbo_mahv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_SoGioLamViec);
            this.Controls.Add(this.txt_MaChamCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_BangChamCong);
            this.Name = "BangChamCong";
            this.Text = "BangChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_BangChamCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_mahv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SoGioLamViec;
        private System.Windows.Forms.TextBox txt_MaChamCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.DateTimePicker dtp_NgayLamViec;
    }
}