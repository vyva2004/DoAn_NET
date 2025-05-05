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
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        BUS_HocVien hocVienBLL = new BUS_HocVien();
        BUS_HoaDon hoaDonBLL = new BUS_HoaDon();
        BUS_ChiTietHoaDon ChiTietHoaDon = new BUS_ChiTietHoaDon();
        BUS_KhoaHoc KhoaHoc = new BUS_KhoaHoc();

        private void loadThongTin()
        {
            dgv_banghoadon.DataSource = hoaDonBLL.GetAll();
            dgv_ChiTietHoaDon.DataSource = ChiTietHoaDon.getAllChiTietHoaDon;
        }
        //hàm load mã hóa đơn 
        private void LoadMaHocDon()
        {
            cbo_MaHoaDon.DataSource = ChiTietHoaDon.getAllMaHoaDon;
        }
        //làm load mã khóa học 
        private void LoadMaKhoaHoc()
        {
            cb_KhoaHoc.DataSource = ChiTietHoaDon.getAllMaKhoaHoc;
        }
        //Hàm load mã học viên
        private void LoadHocVien()
        {
            cbo_MaHocVienHD.DataSource = hocVienBLL.getAllMaHocVien();
            cbo_MaHocVienHD.DisplayMember = "MaHocVien"; // nếu là list object
            cbo_MaHocVienHD.ValueMember = "MaHocVien";
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
            loadThongTin();
            LoadHocVien();
            LoadMaHocDon();
            LoadMaKhoaHoc();
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon frm_chitiethoadon = new ChiTietHoaDon();
            frm_chitiethoadon.Show(this);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgv_banghoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hàm if...else

            if (dgv_banghoadon.CurrentRow != null && dgv_banghoadon.CurrentRow.Cells[0].Value != null)
            {
                int dong = e.RowIndex;
                txt_MaHD.Text = dgv_banghoadon.Rows[dong].Cells[0].Value.ToString();
                cbo_MaHocVienHD.Text = dgv_banghoadon.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayLapDon.Text = dgv_banghoadon.Rows[dong].Cells[2].Value.ToString();
                txt_TongTienHD.Text = dgv_banghoadon.Rows[dong].Cells[3].Value.ToString();
                /*
                 * ?.ToString() sẽ chỉ gọi .ToString() nếu .Value khác null
                 * ?? "" đảm bảo nếu kết quả vẫn là null thì sẽ gán chuỗi rỗng
                 */
                txt_MGG.Text = dgv_banghoadon.Rows[dong].Cells[4].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc hàng đang chọn trống!");
            }

        }

       

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon
            {
                MaHoaDon = txt_MaHD.Text,
                MaHocVien = cbo_MaHocVienHD.Text,
                NgayLapHoaDon = DateTime.Parse(dtp_NgayLapDon.Text),
                TongTien = float.Parse(txt_TongTienHD.Text),
                MaGiamGia = string.IsNullOrWhiteSpace(txt_MGG.Text) ? null : txt_MGG.Text
            };
            hoaDonBLL.Them(hd);
            MessageBox.Show("Thêm thành công.", "Thông báo");
            loadThongTin();
            
        }

        private void cbo_MaHocVienHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon
            {
                MaHoaDon = txt_MaHD.Text,
                MaHocVien = cbo_MaHocVienHD.Text,
                NgayLapHoaDon = DateTime.Parse(dtp_NgayLapDon.Text),
                TongTien = float.Parse(txt_TongTienHD.Text),
                MaGiamGia = string.IsNullOrWhiteSpace(txt_MGG.Text) ? null : txt_MGG.Text
            };
            //Cập nhật hoá đơn
            hoaDonBLL.CapNhat(hd);
            //thông báo cập nhật thành công
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            //tải lại bảng đã cập nhật
            loadThongTin();

        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string maHD = txt_MaHD.Text;
                hoaDonBLL.Xoa(maHD);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                loadThongTin();
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LamMoiHD_Click(object sender, EventArgs e)
        {
            txt_MaHD.Clear();
            cbo_MaHocVienHD.SelectedItem = null;
            txt_MGG.Clear();
            txt_TongTienHD.Clear();
        }

        private void btn_LamMoiCTHoaDon_Click(object sender, EventArgs e)
        {
            cbo_MaHoaDonCT.SelectedItem = null;
            cbo_MaHoaDonCT.SelectedItem = null;
            cb_KhoaHoc.SelectedItem = null;
            txt_TongTienCT.Clear();
            txt_GhiChu.Clear();
        }

        private void dgv_ChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;

            cbo_MaHoaDonCT.Text = dgv_ChiTietHoaDon.Rows[iDong].Cells[0].Value.ToString();
            cbo_MaHoaDon.Text = dgv_ChiTietHoaDon.Rows[iDong].Cells[1].Value.ToString();
            cb_KhoaHoc.Text = dgv_ChiTietHoaDon.Rows[iDong].Cells[2].Value.ToString();
            txt_TongTienCT.Text = dgv_ChiTietHoaDon.Rows[iDong].Cells[3].Value.ToString();
            txt_GhiChu.Text = dgv_ChiTietHoaDon.Rows[iDong].Cells[4].Value.ToString();
        }
    }
}
