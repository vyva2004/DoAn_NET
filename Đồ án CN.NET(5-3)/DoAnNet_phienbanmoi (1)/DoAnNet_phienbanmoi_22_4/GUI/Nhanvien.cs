using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace GUI
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		BUS_NhanVien busnv = new BUS_NhanVien();
        private void Nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
		
		private void Nhanvien_Load(object sender, EventArgs e)
		{
            dgv_bangnhanvien.DataSource = busnv.HienThiNV();
            cbo_chucvu.DataSource = busnv.HienThiCV();
            cbo_chucvu.DisplayMember = "TenChucVu";
            cbo_chucvu.ValueMember = "MaChucVu";
            cbo_macoso.DataSource = busnv.HienThiCS();
            cbo_macoso.DisplayMember = "MaCoSo";
            cbo_macoso.ValueMember = "MaCoSo";
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txt_manhanvien_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txt_tennv_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void cbo_chucvu_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void cbo_macoso_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dgv_bangnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_them_Click(object sender, EventArgs e)
		{
            busnv.themNV(new DAO_NhanVien(txt_manhanvien.Text, txt_tennv.Text, cbo_chucvu.SelectedValue.ToString(), LayGioiTinh(), txt_sdt.Text, txt_email.Text, txt_ghichu.Text, cbo_macoso.SelectedValue.ToString()));
            dgv_bangnhanvien.DataSource = busnv.HienThiNV();
        }
        public string LayGioiTinh()
        {
            string gioitinh;
            if (rad_nam.Checked == true)
            {
                gioitinh = rad_nam.Text;
            }
            else
            {
                gioitinh = rad_nu.Text;
            }
            return gioitinh;
        }

        private void dgv_bangnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e != null)
            {
                txt_manhanvien.Text = dgv_bangnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tennv.Text = dgv_bangnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbo_chucvu.SelectedValue = dgv_bangnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dgv_bangnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rad_nam.Checked = true;
                }
                else
                {
                    rad_nu.Checked = true;
                }
                txt_sdt.Text = dgv_bangnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_email.Text = dgv_bangnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_ghichu.Text = dgv_bangnhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbo_macoso.SelectedValue = dgv_bangnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                busnv.XoaNV(txt_manhanvien.Text);
                dgv_bangnhanvien.DataSource = busnv.HienThiNV();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            busnv.CapnhatNV(new DAO_NhanVien(txt_manhanvien.Text, txt_tennv.Text, cbo_chucvu.SelectedValue.ToString(), LayGioiTinh(), txt_sdt.Text, txt_email.Text, txt_ghichu.Text, cbo_macoso.SelectedValue.ToString()));
            dgv_bangnhanvien.DataSource = busnv.HienThiNV();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_manhanvien.Clear();
            txt_tennv.Clear();
            cbo_chucvu.SelectedItem = null;
            txt_sdt.Clear();
            txt_email.Clear();
            txt_ghichu.Clear();
            cbo_macoso.SelectedItem = null;
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
