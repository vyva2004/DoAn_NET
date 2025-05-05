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
	public partial class frmPhieuThu : Form
	{
		public frmPhieuThu()
		{
			InitializeComponent();
		}
		BUS_PhieuThu BUS_PhieuThu = new BUS_PhieuThu();
		private void dgv_bangphieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int iDong = e.RowIndex;
			txt_mapt.Text = dgv_bangphieuthu.Rows[iDong].Cells[0].Value.ToString();
			cbo_mahv.Text = dgv_bangphieuthu.Rows[iDong].Cells[1].Value.ToString();
			dtp_ngaythu.Text = dgv_bangphieuthu.Rows[iDong].Cells[2].Value.ToString();
			txt_sotien.Text = dgv_bangphieuthu.Rows[iDong].Cells[3].Value.ToString();
			txt_ghichu.Text = dgv_bangphieuthu.Rows[iDong].Cells[4].Value.ToString();
		}

		//load thong tin bang
		public void LoadThongTin()
		{
			dgv_bangphieuthu.DataSource = BUS_PhieuThu.getAllPhieuThu();
		}
		//load thong tin hoc vien
		public void LoadThongTinHocVien()
		{
			cbo_mahv.DataSource = BUS_PhieuThu.getAllMaHocVien();
		}
		private void PhieuThu_Load(object sender, EventArgs e)
		{
			LoadThongTin();
			LoadThongTinHocVien();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			PhieuThu pt = new PhieuThu
			{
				MaPhieuThu = txt_mapt.Text,
				MaHocVien = cbo_mahv.Text,
				NgayThu = DateTime.Parse(dtp_ngaythu.Text),
				SoTien = float.Parse(txt_sotien.Text),
				GhiChu = txt_ghichu.Text
			};
			BUS_PhieuThu.Them(pt);
            MessageBox.Show("Thêm phiếu thu thành công", "Thông báo");
            LoadThongTin();
        }

		private void btn_xoa_Click(object sender, EventArgs e)
		{
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string MaPT = txt_mapt.Text;
                BUS_PhieuThu.Xoa(MaPT);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

		private void btn_capnhat_Click(object sender, EventArgs e)
		{
            PhieuThu pt = new PhieuThu
            {
                MaPhieuThu = txt_mapt.Text,
                MaHocVien = cbo_mahv.Text,
                NgayThu = DateTime.Parse(dtp_ngaythu.Text),
                SoTien = float.Parse(txt_sotien.Text),
                GhiChu = txt_ghichu.Text
            };
            BUS_PhieuThu.CapNhat(pt);
            MessageBox.Show("Cập nhật phiếu thu thành công", "Thông báo");
            LoadThongTin();
        }
	}
}
