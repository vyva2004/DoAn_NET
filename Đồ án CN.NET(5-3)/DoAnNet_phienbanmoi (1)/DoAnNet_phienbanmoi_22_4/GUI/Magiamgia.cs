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
	public partial class Magiamgia : Form
	{
		public Magiamgia()
		{
			InitializeComponent();
		}
		BUS_GiamGia busgg = new BUS_GiamGia();
		private void Magiamgia_Load(object sender, EventArgs e)
		{
            dgv_bangmagiamgia.DataSource = busgg.HienThi();
        }

		private void dgv_bangmagiamgia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex > -1 && e != null)
            {
                txt_magiamgia.Text = dgv_bangmagiamgia.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenmagiamgia.Text = dgv_bangmagiamgia.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_sotienduocgiam.Text = dgv_bangmagiamgia.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtp_hsd.Text = dgv_bangmagiamgia.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_ghichu.Text = dgv_bangmagiamgia.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

		private void btn_them_Click(object sender, EventArgs e)
		{
            busgg.themGG(new DAO_GiamGia(txt_magiamgia.Text, txt_tenmagiamgia.Text, double.Parse(txt_sotienduocgiam.Text), DateTime.Parse(dtp_hsd.Text), txt_ghichu.Text));
            dgv_bangmagiamgia.DataSource = busgg.HienThi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                busgg.XoaGG(txt_magiamgia.Text);
                dgv_bangmagiamgia.DataSource = busgg.HienThi();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            busgg.CapnhatGG(new DAO_GiamGia(txt_magiamgia.Text, txt_tenmagiamgia.Text, double.Parse(txt_sotienduocgiam.Text), DateTime.Parse(dtp_hsd.Text), txt_ghichu.Text));
            dgv_bangmagiamgia.DataSource = busgg.HienThi();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_magiamgia.Clear();
            txt_tenmagiamgia.Clear();
            txt_sotienduocgiam.Clear();
            txt_ghichu.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Magiamgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
