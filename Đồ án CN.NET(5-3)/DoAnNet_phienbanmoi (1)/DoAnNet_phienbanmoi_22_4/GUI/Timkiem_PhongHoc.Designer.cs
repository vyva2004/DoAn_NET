namespace GUI
{
	partial class Timkiem_PhongHoc
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
            this.txt_maph = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_bangphonghoc = new System.Windows.Forms.DataGridView();
            this.btn_thoa = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_intt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangphonghoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(560, 42);
            this.label6.TabIndex = 139;
            this.label6.Text = "BẢNG TÌM KIẾM PHÒNG HỌC";
            // 
            // txt_maph
            // 
            this.txt_maph.Location = new System.Drawing.Point(279, 114);
            this.txt_maph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maph.Multiline = true;
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Size = new System.Drawing.Size(251, 32);
            this.txt_maph.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 135;
            this.label1.Text = "Mã phòng học:";
            // 
            // dgv_bangphonghoc
            // 
            this.dgv_bangphonghoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bangphonghoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangphonghoc.Location = new System.Drawing.Point(13, 263);
            this.dgv_bangphonghoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_bangphonghoc.Name = "dgv_bangphonghoc";
            this.dgv_bangphonghoc.RowHeadersWidth = 51;
            this.dgv_bangphonghoc.Size = new System.Drawing.Size(821, 217);
            this.dgv_bangphonghoc.TabIndex = 140;
            // 
            // btn_thoa
            // 
            this.btn_thoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoa.Location = new System.Drawing.Point(588, 180);
            this.btn_thoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoa.Name = "btn_thoa";
            this.btn_thoa.Size = new System.Drawing.Size(93, 55);
            this.btn_thoa.TabIndex = 143;
            this.btn_thoa.Text = "Thoát";
            this.btn_thoa.UseVisualStyleBackColor = false;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_timkiem.Location = new System.Drawing.Point(588, 98);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(93, 55);
            this.btn_timkiem.TabIndex = 144;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // btn_intt
            // 
            this.btn_intt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_intt.Location = new System.Drawing.Point(707, 139);
            this.btn_intt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_intt.Name = "btn_intt";
            this.btn_intt.Size = new System.Drawing.Size(93, 55);
            this.btn_intt.TabIndex = 145;
            this.btn_intt.Text = "In thông tin";
            this.btn_intt.UseVisualStyleBackColor = false;
            // 
            // Timkiem_PhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.Controls.Add(this.btn_intt);
            this.Controls.Add(this.btn_thoa);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dgv_bangphonghoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maph);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Timkiem_PhongHoc";
            this.Text = "BẢNG TÌM KIẾM PHÒNG HỌC";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangphonghoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_maph;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgv_bangphonghoc;
		private System.Windows.Forms.Button btn_thoa;
		private System.Windows.Forms.Button btn_timkiem;
		private System.Windows.Forms.Button btn_intt;
	}
}