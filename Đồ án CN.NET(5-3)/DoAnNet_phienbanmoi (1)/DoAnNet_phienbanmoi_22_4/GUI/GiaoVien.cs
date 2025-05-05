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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        BUS_GiaoVien giaoVienBLL = new BUS_GiaoVien();
        public void LoadThongTin()
        {
            dgv_banggiaovien.DataSource = giaoVienBLL.GetAllMaGiaoVien();
        }
        public void LoadMaCoSo()
        {
            cbo_macoso.DataSource = giaoVienBLL.getAllMaCoSo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien
            {
                MaGiaoVien = txt_mgv.Text.Trim(),
                HoTen = giaoVienBLL.ChuanHoaHoTen(txt_tengv.Text),
                Gioitinh = gioitinh(),
                Ngaysinh = dtp_ngaysinh.Value,
                SoDienThoai = txt_sdt.Text.Trim(),
                Email = txt_email.Text.Trim(),
                MaCoSo = cbo_macoso.Text.Trim(),
                GhiChu = txt_ghichu.Text.Trim()

            };

            string msg;
            if (giaoVienBLL.IsValidGiaoVien(gv, out msg))
            {
                giaoVienBLL.Them(gv);
                MessageBox.Show("Thêm thành công!");
                LoadThongTin();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private string gioitinh()
        {
            if (rad_nam.Checked == true)
            {
                return rad_nam.Text;
            }else
            {
                return rad_nu.Text;
            }
        }

        private void dgv_banggiaovien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadMaCoSo();
        }

        private void dgv_banggiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txt_mgv.Text = dgv_banggiaovien.Rows[iDong].Cells[0].Value.ToString();
            txt_tengv.Text = dgv_banggiaovien.Rows[iDong].Cells[1].Value.ToString();
            if (dgv_banggiaovien.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            dtp_ngaysinh.Text = dgv_banggiaovien.Rows[iDong].Cells[3].Value.ToString();
            txt_sdt.Text = dgv_banggiaovien.Rows[iDong].Cells[4].Value.ToString();
            txt_email.Text = dgv_banggiaovien.Rows[iDong].Cells[5].Value.ToString();
            cbo_macoso.Text = dgv_banggiaovien.Rows[iDong].Cells[6].Value.ToString();
            txt_ghichu.Text = dgv_banggiaovien.Rows[iDong].Cells[7].Value.ToString();
        }

        private void GiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string MaGV = txt_mgv.Text;
                giaoVienBLL.Xoa(MaGV);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien
            {
                MaGiaoVien = txt_mgv.Text.Trim(),
                HoTen = giaoVienBLL.ChuanHoaHoTen(txt_tengv.Text),
                Gioitinh = gioitinh(),
                Ngaysinh = dtp_ngaysinh.Value,
                SoDienThoai = txt_sdt.Text.Trim(),
                Email = txt_email.Text.Trim(),
                MaCoSo = cbo_macoso.Text.Trim(),
                GhiChu = txt_ghichu.Text.Trim()

            };

            string msg;
            if (giaoVienBLL.IsValidGiaoVien(gv, out msg))
            {
                giaoVienBLL.Sua(gv);
                MessageBox.Show("Cập nhật thành công!");
                LoadThongTin();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
