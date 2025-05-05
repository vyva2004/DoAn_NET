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
    public partial class BangLuong : Form
    {
        public BangLuong()
        {
            InitializeComponent();
        }
        BUS_Luong busluong = new BUS_Luong();
        private void BangLuong_Load(object sender, EventArgs e)
        {
            dgv_Bangluong.DataSource = busluong.HienThi();
            cbo_magv.DataSource = busluong.HienThiGV();
            cbo_magv.DisplayMember = "HoTen";
            cbo_magv.ValueMember = "MaGiaoVien";
        }

        private void dgv_Bangluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e != null)
            {
                txt_maluong.Text = dgv_Bangluong.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_magv.SelectedValue = dgv_Bangluong.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_ngaytra.Text = dgv_Bangluong.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_sotienluong.Text = dgv_Bangluong.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_ghichu.Text = dgv_Bangluong.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_giolamviec.Text = dgv_Bangluong.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            busluong.themLuong(new DAO_Luong(txt_maluong.Text, cbo_magv.SelectedValue.ToString(),DateTime.Parse(dtp_ngaytra.Text),int.Parse(txt_sotienluong.Text), txt_ghichu.Text,int.Parse(txt_giolamviec.Text)));
            dgv_Bangluong.DataSource = busluong.HienThi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                busluong.XoaLuong(txt_maluong.Text);
                dgv_Bangluong.DataSource = busluong.HienThi();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            busluong.CapnhatLuong(new DAO_Luong(txt_maluong.Text, cbo_magv.SelectedValue.ToString(), DateTime.Parse(dtp_ngaytra.Text), int.Parse(txt_sotienluong.Text), txt_ghichu.Text, int.Parse(txt_giolamviec.Text)));
            dgv_Bangluong.DataSource = busluong.HienThi();
        }

        private void BangLuong_FormClosing(object sender, FormClosingEventArgs e)
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
            txt_maluong.Clear();
            cbo_magv.SelectedItem = null;
            txt_sotienluong.Clear();
            txt_ghichu.Clear();
            txt_giolamviec.Clear();
        }
    }
}
