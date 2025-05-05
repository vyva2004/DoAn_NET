using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cơSởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coso frm_coso = new Coso();
            frm_coso.Show(this);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien frm_nhanvien = new Nhanvien();
            frm_nhanvien.Show(this);
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hocvien frm_hocvien = new Hocvien();
            frm_hocvien.Show(this);
        }

        private void khóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoaHoc frm_khoahoc = new frmKhoaHoc();
            frm_khoahoc.Show(this);
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lophoc frm_lophoc = new Lophoc();
            frm_lophoc.Show(this);
        }

        private void đăngKýHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon frm_hoadon = new Hoadon();
            frm_hoadon.Show(this);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

		private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
		{
            
		}

		private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Diemthi frm_diemthi = new Diemthi();
            frm_diemthi.Show(this);
		}

		private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Diemdanh frm_diemdanh = new Diemdanh();
            frm_diemdanh.Show(this);
		}

		private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmPhongHoc frm_phonghoc = new frmPhongHoc();
            frm_phonghoc.Show(this);
		}



		private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Login frm_login = new Login();
            frm_login.Show(this);
		}

		private void họcViênToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void khóaHọcToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}


		private void điểmThiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            Timkiem_DiemThi frm_timkiemdiemthi = new Timkiem_DiemThi();
            frm_timkiemdiemthi.Show(this);
		}

		private void phiếuThuToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void điểmDanhToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void phongHocToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Timkiem_PhongHoc frm_timkiemphonghoc = new Timkiem_PhongHoc();
            frm_timkiemphonghoc.Show(this);
		}

        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void mãGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Magiamgia frm_magiamgia = new Magiamgia();
            frm_magiamgia.Show();
		}

		private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmThemTaiKhoan frm_themtaikhoan = new frmThemTaiKhoan();
            frm_themtaikhoan.Show(this);
		}

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucVu frmChucVu = new frmChucVu();
            frmChucVu.Show(this);
        }

        private void cơSởToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Coso frmCoso = new Coso();
            frmCoso.Show(this);
        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Nhanvien frmNhanVien = new Nhanvien();
            frmNhanVien.Show(this);
        }

        private void họcViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hocvien frmHocVien = new Hocvien();
            frmHocVien.Show(this);
        }

        private void khóaHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKhoaHoc frmKhoaHoc = new frmKhoaHoc();
            frmKhoaHoc.Show(this);
        }

        private void lớpHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Lophoc frmLopHoc = new Lophoc();
            frmLopHoc.Show(this);
        }

        private void hóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hoadon frmHoaDon = new Hoadon();
            frmHoaDon.Show(this);
        }

        private void phiếuThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPhieuThu frmPhieuThu = new frmPhieuThu();
            frmPhieuThu.Show(this);
        }

        private void điểmDanhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Diemdanh frmDiemDanh = new Diemdanh();
            frmDiemDanh.Show(this);
        }

        private void điểmThiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Diemthi frmDiemThi = new Diemthi();
            frmDiemThi.Show(this);
        }

        private void phòngHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPhongHoc frmPhongHoc = new frmPhongHoc();
            frmPhongHoc.Show(this);
        }

        private void lịchHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLichHoc frmLichHoc = new frmLichHoc();
            frmLichHoc.Show(this);
        }

        private void chứcVụToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmChucVu frmChucVu = new frmChucVu();
            frmChucVu.Show(this);
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGiaoVien frmgiaoVien = new frmGiaoVien();
            frmgiaoVien.Show(this);
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuong frmBangLuong = new BangLuong();
            frmBangLuong.Show(this);
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hoadon frmHoaDon = new Hoadon();
            frmHoaDon.Show(this);
        }

        private void phiếuThuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPhieuThu frmPhieuThu = new frmPhieuThu();
            frmPhieuThu.Show(this);
        }

        private void lươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BangLuong frmBangLuong = new BangLuong();
            frmBangLuong.Show(this);
        }

        private void khóaHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKhoaHoc frmKhoaHoc = new frmKhoaHoc();
            frmKhoaHoc.Show(this);
        }

        private void lớpHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lophoc frmLopHoc = new Lophoc();
            frmLopHoc.Show(this);
        }

        private void điểmThiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Diemthi frmDiemThi = new Diemthi();
            frmDiemThi.Show(this);
        }

        private void điểmDanhToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Diemdanh frmDiemDanh = new Diemdanh();
            frmDiemDanh.Show(this);
        }

        private void lịchHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLichHoc frmLichHoc = new frmLichHoc();
            frmLichHoc.Show(this);
        }

        private void kếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
