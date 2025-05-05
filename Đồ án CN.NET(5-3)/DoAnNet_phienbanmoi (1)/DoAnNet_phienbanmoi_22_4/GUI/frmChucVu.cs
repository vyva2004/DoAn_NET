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
using DAL;
using DAO;

namespace GUI
{
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        //
        BUS_ChucVu BUS_ChucVu = new BUS_ChucVu();
        //load thong tin bang
        private void LoadThongTin()
        {
            dgv_ChucVu.DataSource = BUS_ChucVu.getAllChucVu();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu
            {
                MaChucVu = txt_MaChucVu.Text,
                TenChucVu = txt_TenChucVu.Text
            };
            BUS_ChucVu.Them(cv);
            MessageBox.Show("Thêm chức vụ thành công!!!");
            LoadThongTin();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu
            {
                MaChucVu = txt_MaChucVu.Text,
                TenChucVu = txt_TenChucVu.Text
            };
            BUS_ChucVu.CapNhat(cv);
            MessageBox.Show("Cập nhật chức vụ thành công!!!");
            LoadThongTin();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string MaCV = txt_MaChucVu.Text;
                BUS_ChucVu.Xoa(MaCV);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadThongTin();
            }
        }

        private void dgv_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;

            txt_MaChucVu.Text = dgv_ChucVu.Rows[iDong].Cells[0].Value.ToString();
            txt_TenChucVu.Text = dgv_ChucVu.Rows[iDong].Cells[1].Value.ToString();
        }

        private void frmChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_TenChucVu.Clear();
            txt_MaChucVu.Clear();
        }
    }
}
