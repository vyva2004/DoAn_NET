using BUS;
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
    public partial class Hocvien : Form
    {
        public Hocvien()
        {
            InitializeComponent();
        }
        BUS_HocVien hocVienBLL = new BUS_HocVien();

        //load thông tin 
        public void LoadThongTin()
        {
            dgv_banghocvien.DataSource = hocVienBLL.getAllMaHocVien();
        }
        public void LoadMaCoSo()
        {
            cbo_macoso.DataSource = hocVienBLL.getAllMaCoSo();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hocvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgv_banghocvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txt_mhv.Text = dgv_banghocvien.Rows[iDong].Cells[0].Value.ToString();
            txt_tenhv.Text = dgv_banghocvien.Rows[iDong].Cells[1].Value.ToString();
            dtp_ngaysinh.Text = dgv_banghocvien.Rows[iDong].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_banghocvien.Rows[iDong].Cells[3].Value.ToString();
            txt_email.Text = dgv_banghocvien.Rows[iDong].Cells[4].Value.ToString();
            txt_trangthai.Text = dgv_banghocvien.Rows[iDong].Cells[5].Value.ToString();
            cbo_macoso.Text = dgv_banghocvien.Rows[iDong].Cells[6].Value.ToString();
        }

        private void Hocvien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadMaCoSo();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien
            {
                MaHocVien = txt_mhv.Text.Trim(),
                HoTen = hocVienBLL.ChuanHoaHoTen(txt_tenhv.Text),
                NgaySinh = dtp_ngaysinh.Value,
                SoDienThoai = txt_sdt.Text.Trim(),
                Email = txt_email.Text.Trim(),
                TrangThai = txt_trangthai.Text.Trim(),
                MaCoSo = cbo_macoso.SelectedValue.ToString()
            };
            if (hocVienBLL.Them(hv))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại!");
            LoadThongTin();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string MaHV = txt_mhv.Text;
                hocVienBLL.Xoa(MaHV);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien
            {
                MaHocVien = txt_mhv.Text,
                HoTen = txt_tenhv.Text,
                NgaySinh = DateTime.Parse(dtp_ngaysinh.Text),
                SoDienThoai = txt_sdt.Text,
                Email = txt_email.Text,
                TrangThai = txt_trangthai.Text,
                MaCoSo = cbo_macoso.Text
            };
            //cập nhật học viên
            hocVienBLL.Sua(hv);
            //thông báo
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            //tải lại bảng đã cập nhật
            LoadThongTin();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mhv.Clear();
            txt_tenhv.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
            txt_trangthai.Clear();
            cbo_macoso.SelectedItem = null;
        }
    }
}
