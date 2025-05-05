namespace GUI
{
    partial class frmKhoaHoc
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
            this.dgv_bangkhoahoc = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_thoigianhoc = new System.Windows.Forms.TextBox();
            this.txt_hocphi = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbo_MaKhoaHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangkhoahoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bangkhoahoc
            // 
            this.dgv_bangkhoahoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bangkhoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangkhoahoc.Location = new System.Drawing.Point(13, 331);
            this.dgv_bangkhoahoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bangkhoahoc.Name = "dgv_bangkhoahoc";
            this.dgv_bangkhoahoc.RowHeadersWidth = 51;
            this.dgv_bangkhoahoc.Size = new System.Drawing.Size(1041, 210);
            this.dgv_bangkhoahoc.TabIndex = 20;
            this.dgv_bangkhoahoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bangkhoahoc_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(321, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "BẢNG KHÓA HỌC";
            // 
            // txt_thoigianhoc
            // 
            this.txt_thoigianhoc.Location = new System.Drawing.Point(689, 139);
            this.txt_thoigianhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thoigianhoc.Name = "txt_thoigianhoc";
            this.txt_thoigianhoc.Size = new System.Drawing.Size(228, 22);
            this.txt_thoigianhoc.TabIndex = 10;
            // 
            // txt_hocphi
            // 
            this.txt_hocphi.Location = new System.Drawing.Point(689, 91);
            this.txt_hocphi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hocphi.Name = "txt_hocphi";
            this.txt_hocphi.Size = new System.Drawing.Size(228, 22);
            this.txt_hocphi.TabIndex = 11;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(249, 197);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(228, 22);
            this.txt_mota.TabIndex = 12;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(249, 139);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(228, 22);
            this.txt_tenkh.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khóa học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học phí:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã khóa học:";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lammoi.Location = new System.Drawing.Point(663, 250);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(93, 55);
            this.btn_lammoi.TabIndex = 53;
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
            this.btn_thoat.TabIndex = 49;
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
            this.btn_capnhat.TabIndex = 50;
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
            this.btn_xoa.TabIndex = 51;
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
            this.btn_them.TabIndex = 52;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // cbo_MaKhoaHoc
            // 
            this.cbo_MaKhoaHoc.Enabled = false;
            this.cbo_MaKhoaHoc.FormattingEnabled = true;
            this.cbo_MaKhoaHoc.Location = new System.Drawing.Point(249, 91);
            this.cbo_MaKhoaHoc.Name = "cbo_MaKhoaHoc";
            this.cbo_MaKhoaHoc.Size = new System.Drawing.Size(228, 24);
            this.cbo_MaKhoaHoc.TabIndex = 54;
            // 
            // frmKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbo_MaKhoaHoc);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_bangkhoahoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_thoigianhoc);
            this.Controls.Add(this.txt_hocphi);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoaHoc";
            this.Text = "BẢNG KHÓA HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Khoahoc_FormClosing);
            this.Load += new System.EventHandler(this.frmKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangkhoahoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bangkhoahoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_thoigianhoc;
        private System.Windows.Forms.TextBox txt_hocphi;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_lammoi;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_capnhat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_MaKhoaHoc;
    }
}