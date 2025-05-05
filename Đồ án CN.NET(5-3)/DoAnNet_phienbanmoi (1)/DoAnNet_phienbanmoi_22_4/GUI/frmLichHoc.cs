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
    public partial class frmLichHoc : Form
    {
        public frmLichHoc()
        {
            InitializeComponent();
        }
        //

        BUS_LichHoc lhoc = new BUS_LichHoc();
        
        //ham load thong tin
        public void LoadThongTin()
        {
            dgvLichHoc.DataSource = lhoc.GetAllLichHoc(); 
        }
        
        //hàm load mã lớp học
        public void LoadMaLopHoc()
        {
            cbo_MaLopHoc.DataSource = lhoc.getAllMaLopHoc();
        }
        //hàm load mã phòng
        public void LoadMaPhong()
        {
            cbo_MaPhong.DataSource = lhoc.getAllMaPhong();
        }
        //hàm load mã nhân viên
        public void LoadMaGiaoVien()
        {
            cbo_MaGiaoVien.DataSource = lhoc.getAllMaGiaoVien();
        }
		private void LichHoc_Load(object sender, EventArgs e)
		{
            LoadThongTin();
            LoadMaLopHoc();
            LoadMaPhong();
            LoadMaGiaoVien();
        }

        private void txtMaLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            LichHoc lh = new LichHoc
            {
                MaLichHoc = txtMaLichHoc.Text,
                MaLopHoc = cbo_MaLopHoc.Text,
                NgayHoc = DateTime.Parse(dtpNgayHoc.Text),
                CaHoc = txt_CaHoc.Text,
                MaPhong = cbo_MaPhong.Text,
                MaGiaoVien = cbo_MaGiaoVien.Text
            };
            lhoc.Them(lh);
            MessageBox.Show("Thêm thành công.", "Thông báo");
            LoadThongTin();
        }

        private void dgvLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaLichHoc.Text = dgvLichHoc.Rows[iDong].Cells[0].Value.ToString();
            cbo_MaLopHoc.Text = dgvLichHoc.Rows[iDong].Cells[1].Value.ToString();
            dtpNgayHoc.Text = dgvLichHoc.Rows[iDong].Cells[2].Value.ToString();
            txt_CaHoc.Text = dgvLichHoc.Rows[iDong].Cells[3].Value.ToString();
            cbo_MaPhong.Text = dgvLichHoc.Rows[iDong].Cells[4].Value.ToString();
            cbo_MaGiaoVien.Text = dgvLichHoc.Rows[iDong].Cells[5].Value.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txtMaLichHoc.Clear();
            cbo_MaLopHoc.SelectedItem = null;
            txt_CaHoc.Clear();
            cbo_MaPhong.SelectedItem = null;
            cbo_MaGiaoVien.SelectedItem = null;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            LichHoc lh = new LichHoc
            {
                MaLichHoc = txtMaLichHoc.Text,
                MaLopHoc = cbo_MaLopHoc.Text,
                NgayHoc = DateTime.Parse(dtpNgayHoc.Text),
                CaHoc = txt_CaHoc.Text,
                MaPhong = cbo_MaPhong.Text,
                MaGiaoVien = cbo_MaGiaoVien.Text
            };
            lhoc.CapNhat(lh);
            MessageBox.Show("Cập nhật thành công.", "Thông báo");
            LoadThongTin();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string maLH = txtMaLichHoc.Text;
                lhoc.Xoa(maLH);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLichHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
