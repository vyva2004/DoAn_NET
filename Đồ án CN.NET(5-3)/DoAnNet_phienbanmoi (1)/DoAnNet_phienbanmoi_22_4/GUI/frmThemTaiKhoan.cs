using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAO;
using BUS;

namespace GUI
{
	public partial class frmThemTaiKhoan : Form
	{
		public frmThemTaiKhoan()
		{
			InitializeComponent();
		}
		BUS_ThemTaiKhoan BUS_ThemTaiKhoan = new BUS_ThemTaiKhoan();
		//ham load thong tin
		public void LoadThongTin()
		{
			dgv_bangtaikhoan.DataSource = BUS_ThemTaiKhoan.getAllTaiKhoan();
		}

		private void dgv_bangtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int iDong = e.RowIndex;
			txt_username.Text = dgv_bangtaikhoan.Rows[iDong].Cells[0].Value.ToString();
			txt_password.Text = dgv_bangtaikhoan.Rows[iDong].Cells[1].Value.ToString();
		}

		private void frmThemTaiKhoan_Load(object sender, EventArgs e)
		{
			LoadThongTin();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			TaiKhoan tk = new TaiKhoan
			{
				TenTK = txt_username.Text,
				MatKhau = txt_password.Text
			};
			BUS_ThemTaiKhoan.Them(tk);
            MessageBox.Show("Thêm thành công.", "Thông báo");
            LoadThongTin();
        }

		private void btn_xoa_Click(object sender, EventArgs e)
		{
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string tk = txt_username.Text;
                BUS_ThemTaiKhoan.Xoa(tk);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

		private void btn_capnhat_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan
            {
                TenTK = txt_username.Text,
                MatKhau = txt_password.Text
            };
            BUS_ThemTaiKhoan.CapNhat(tk);
            MessageBox.Show("Cập nhật thành công.", "Thông báo");
            LoadThongTin();

        }
	}
}
