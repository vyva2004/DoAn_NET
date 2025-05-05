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
	public partial class Diemthi : Form
	{
		public Diemthi()
		{
			InitializeComponent();
		}
        BUS_DiemThi busdt = new BUS_DiemThi();
        private void Diemthi_Load(object sender, EventArgs e)
		{
            dgv_bangdiemthi.DataSource = busdt.HienThi();
            cbo_mahv.DataSource = busdt.HienThiHV();
            cbo_mahv.DisplayMember = "MaHocVien";
            cbo_mahv.ValueMember = "MaHocVien";
            cbo_mkh.DataSource = busdt.HienThiKH();
            cbo_mkh.DisplayMember = "TenKhoaHoc";
            cbo_mkh.ValueMember = "MaKhoaHoc";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            busdt.themDT(new DAO_DiemThi(txt_madiemthi.Text, cbo_mahv.SelectedValue.ToString(), cbo_mkh.SelectedValue.ToString(), double.Parse(txt_diem.Text), DateTime.Parse(dtp_ngaythi.Text)));
            dgv_bangdiemthi.DataSource = busdt.HienThi();
        }

        private void dgv_bangdiemthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e != null)
            {
                txt_madiemthi.Text = dgv_bangdiemthi.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_mahv.SelectedValue = dgv_bangdiemthi.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbo_mkh.SelectedValue = dgv_bangdiemthi.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_diem.Text = dgv_bangdiemthi.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtp_ngaythi.Text = dgv_bangdiemthi.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                busdt.XoaDT(txt_madiemthi.Text);
                dgv_bangdiemthi.DataSource = busdt.HienThi();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            busdt.CapnhatDT(new DAO_DiemThi(txt_madiemthi.Text, cbo_mahv.SelectedValue.ToString(), cbo_mkh.SelectedValue.ToString(), double.Parse(txt_diem.Text), DateTime.Parse(dtp_ngaythi.Text)));
            dgv_bangdiemthi.DataSource = busdt.HienThi();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_madiemthi.Clear();
            cbo_mahv.SelectedItem = null;
            cbo_mkh.SelectedItem = null;
            txt_diem.Clear();
        }

        private void Diemthi_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
