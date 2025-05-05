namespace GUI
{
	partial class Timkiem_DiemThi
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.dgv_bangdiemthi = new System.Windows.Forms.DataGridView();
            this.txt_mahv = new System.Windows.Forms.TextBox();
            this.btn_intt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiemthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 42);
            this.label6.TabIndex = 112;
            this.label6.Text = "BẢNG TÌM KIẾM ĐIỂM THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 110;
            this.label2.Text = "Mã học viên:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(609, 199);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_thoat.TabIndex = 117;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_timkiem.Location = new System.Drawing.Point(609, 102);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(93, 55);
            this.btn_timkiem.TabIndex = 118;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // dgv_bangdiemthi
            // 
            this.dgv_bangdiemthi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bangdiemthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangdiemthi.Location = new System.Drawing.Point(13, 262);
            this.dgv_bangdiemthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_bangdiemthi.Name = "dgv_bangdiemthi";
            this.dgv_bangdiemthi.RowHeadersWidth = 51;
            this.dgv_bangdiemthi.Size = new System.Drawing.Size(821, 218);
            this.dgv_bangdiemthi.TabIndex = 119;
            // 
            // txt_mahv
            // 
            this.txt_mahv.Location = new System.Drawing.Point(307, 118);
            this.txt_mahv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mahv.Multiline = true;
            this.txt_mahv.Name = "txt_mahv";
            this.txt_mahv.Size = new System.Drawing.Size(241, 32);
            this.txt_mahv.TabIndex = 120;
            // 
            // btn_intt
            // 
            this.btn_intt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_intt.Location = new System.Drawing.Point(720, 148);
            this.btn_intt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_intt.Name = "btn_intt";
            this.btn_intt.Size = new System.Drawing.Size(93, 55);
            this.btn_intt.TabIndex = 135;
            this.btn_intt.Text = "In thông tin";
            this.btn_intt.UseVisualStyleBackColor = false;
            // 
            // Timkiem_DiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.Controls.Add(this.btn_intt);
            this.Controls.Add(this.txt_mahv);
            this.Controls.Add(this.dgv_bangdiemthi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Timkiem_DiemThi";
            this.Text = "BẢNG TÌM KIẾM ĐIỂM THI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiemthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_timkiem;
		private System.Windows.Forms.DataGridView dgv_bangdiemthi;
		private System.Windows.Forms.TextBox txt_mahv;
		private System.Windows.Forms.Button btn_intt;
	}
}