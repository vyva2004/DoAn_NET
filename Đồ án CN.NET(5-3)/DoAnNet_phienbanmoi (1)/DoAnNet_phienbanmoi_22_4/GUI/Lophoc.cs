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
    public partial class Lophoc : Form
    {
        public Lophoc()
        {
            InitializeComponent();
        }
        BUS_LopHoc buslh = new BUS_LopHoc();
        private void Lophoc_Load(object sender, EventArgs e)
        {
            dgv_banglophoc.DataSource = buslh.HienThi();
            cbo_makh.DataSource = buslh.HienThiKH();
            cbo_makh.DisplayMember = "TenKhoaHoc";
            cbo_makh.ValueMember = "MaKhoaHoc";
            cbo_macoso.DataSource = buslh.HienThiCS();
            cbo_macoso.DisplayMember = "TenCoSo";
            cbo_macoso.ValueMember = "MaCoSo";
            cbo_magv.DataSource = buslh.HienThiGV();
            cbo_magv.DisplayMember = "HoTen";
            cbo_magv.ValueMember = "MaGiaoVien";
            cbo_maphong.DataSource = buslh.HienThiPhong();
            cbo_maphong.DisplayMember = "TenPhong";
            cbo_maphong.ValueMember = "MaPhong";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lophoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgv_banglophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e != null)
            {
                txt_malh.Text = dgv_banglophoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenlh.Text = dgv_banglophoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbo_makh.SelectedValue = dgv_banglophoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbo_macoso.SelectedValue = dgv_banglophoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbo_magv.SelectedValue = dgv_banglophoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtp_ngaybatdau.Text = dgv_banglophoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtp_ngayketthuc.Text = dgv_banglophoc.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_cahoc.Text = dgv_banglophoc.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbo_maphong.SelectedValue = dgv_banglophoc.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            buslh.ThemLH(new DAO_LopHoc(txt_malh.Text, txt_tenlh.Text, cbo_makh.SelectedValue.ToString(), cbo_macoso.SelectedValue.ToString(), cbo_magv.SelectedValue.ToString(), DateTime.Parse(dtp_ngaybatdau.Text), DateTime.Parse(dtp_ngayketthuc.Text), txt_cahoc.Text, cbo_maphong.SelectedValue.ToString()));
            dgv_banglophoc.DataSource = buslh.HienThi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                buslh.XoaLH(txt_malh.Text);
                dgv_banglophoc.DataSource = buslh.HienThi();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            buslh.CapnhatLH(new DAO_LopHoc(txt_malh.Text, txt_tenlh.Text, cbo_makh.SelectedValue.ToString(), cbo_macoso.SelectedValue.ToString(), cbo_magv.SelectedValue.ToString(), DateTime.Parse(dtp_ngaybatdau.Text), DateTime.Parse(dtp_ngayketthuc.Text), txt_cahoc.Text, cbo_maphong.SelectedValue.ToString()));
            dgv_banglophoc.DataSource = buslh.HienThi();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_malh.Clear();
            txt_tenlh.Clear();
            cbo_makh.SelectedItem = null;
            cbo_macoso.SelectedItem = null;
            cbo_magv.SelectedItem = null;
            txt_cahoc.Clear();
            cbo_maphong.SelectedItem = null;
        }
    }
}
