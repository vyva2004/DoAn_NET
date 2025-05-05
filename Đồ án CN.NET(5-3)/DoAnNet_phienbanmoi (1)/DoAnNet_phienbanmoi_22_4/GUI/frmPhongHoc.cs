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
	public partial class frmPhongHoc : Form
	{
		public frmPhongHoc()
		{
			InitializeComponent();
		}
		//
		BUS_PhongHoc BUS_PhongHoc = new BUS_PhongHoc();

		//load thong tin bang
		public void LoadThongTin()
		{
			dgv_bangphonghoc.DataSource = BUS_PhongHoc.getALlPhongHoc();
		}
		//lay thong tin ma co so
		public void LoadThongTinMaCoSo()
		{
			cbo_mcs.DataSource = BUS_PhongHoc.getAllMaCoSo();
		}
		private void Phonghoc_Load(object sender, EventArgs e)
		{
			LoadThongTin();
			LoadThongTinMaCoSo();
		}

		private void dgv_bangphonghoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int iDong = e.RowIndex;
			txt_maph.Text = dgv_bangphonghoc.Rows[iDong].Cells[0].Value.ToString();
			txt_tenph.Text = dgv_bangphonghoc.Rows[iDong].Cells[1].Value.ToString();
			txt_succhua.Text = dgv_bangphonghoc.Rows[iDong].Cells[2].Value.ToString();
			cbo_mcs.Text = dgv_bangphonghoc.Rows[iDong].Cells[3].Value.ToString();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			PhongHoc phonghoc = new PhongHoc
			{
				MaPhong = txt_maph.Text,
				TenPhong = txt_tenph.Text,
				SucChua = int.Parse(txt_succhua.Text),
				MaCoSo = cbo_mcs.Text
			};
			BUS_PhongHoc.Them(phonghoc);
			MessageBox.Show("Thêm phòng học thành công!!!", "Thông báo");
            LoadThongTin();
        }

		private void btn_xoa_Click(object sender, EventArgs e)
		{
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string MaPhong = txt_maph.Text;
                BUS_PhongHoc.Xoa(MaPhong);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

		private void btn_capnhat_Click(object sender, EventArgs e)
		{
            PhongHoc phonghoc = new PhongHoc
            {
                MaPhong = txt_maph.Text,
                TenPhong = txt_tenph.Text,
                SucChua = int.Parse(txt_succhua.Text),
                MaCoSo = cbo_mcs.Text
            };
            BUS_PhongHoc.CapNhat(phonghoc);
            MessageBox.Show("Cập nhật phòng học thành công!!!", "Thông báo");
            LoadThongTin();
        }
	}
}
