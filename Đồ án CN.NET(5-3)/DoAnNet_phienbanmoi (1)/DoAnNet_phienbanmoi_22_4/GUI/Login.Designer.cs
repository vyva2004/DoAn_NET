namespace GUI
{
	partial class Login
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
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rad_quanli = new System.Windows.Forms.RadioButton();
            this.rad_giaovien = new System.Windows.Forms.RadioButton();
            this.rad_ketoan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_dangnhap.Location = new System.Drawing.Point(125, 334);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(93, 55);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(227, 135);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(287, 32);
            this.txt_username.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(227, 194);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(287, 32);
            this.txt_password.TabIndex = 4;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(421, 334);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 55);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // rad_quanli
            // 
            this.rad_quanli.AutoSize = true;
            this.rad_quanli.Location = new System.Drawing.Point(127, 271);
            this.rad_quanli.Name = "rad_quanli";
            this.rad_quanli.Size = new System.Drawing.Size(69, 20);
            this.rad_quanli.TabIndex = 6;
            this.rad_quanli.TabStop = true;
            this.rad_quanli.Text = "Quản lí";
            this.rad_quanli.UseVisualStyleBackColor = true;
            // 
            // rad_giaovien
            // 
            this.rad_giaovien.AutoSize = true;
            this.rad_giaovien.Location = new System.Drawing.Point(411, 271);
            this.rad_giaovien.Name = "rad_giaovien";
            this.rad_giaovien.Size = new System.Drawing.Size(85, 20);
            this.rad_giaovien.TabIndex = 6;
            this.rad_giaovien.TabStop = true;
            this.rad_giaovien.Text = "Giáo viên";
            this.rad_giaovien.UseVisualStyleBackColor = true;
            // 
            // rad_ketoan
            // 
            this.rad_ketoan.AutoSize = true;
            this.rad_ketoan.Location = new System.Drawing.Point(276, 271);
            this.rad_ketoan.Name = "rad_ketoan";
            this.rad_ketoan.Size = new System.Drawing.Size(73, 20);
            this.rad_ketoan.TabIndex = 6;
            this.rad_ketoan.TabStop = true;
            this.rad_ketoan.Text = "Kế toán";
            this.rad_ketoan.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(683, 470);
            this.Controls.Add(this.rad_ketoan);
            this.Controls.Add(this.rad_giaovien);
            this.Controls.Add(this.rad_quanli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Dangkytaikhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_dangnhap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_password;
		private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rad_quanli;
		private System.Windows.Forms.RadioButton rad_giaovien;
		private System.Windows.Forms.RadioButton rad_ketoan;
	}
}