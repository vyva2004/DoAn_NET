using DAO;
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

namespace GUI
{
    public partial class Coso : Form
    {
        public Coso()
        {
            InitializeComponent();
        }
        BUS_CoSo buscs = new BUS_CoSo();
        DAO_CoSo daocs = new DAO_CoSo();
        private void Coso_Load(object sender, EventArgs e)
        {
            dgv_bangcoso.DataSource = buscs.HienThi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coso_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgv_bangcoso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e != null)
            {
                txt_macoso.Text = dgv_bangcoso.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tencoso.Text = dgv_bangcoso.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_diachi.Text = dgv_bangcoso.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_sdt.Text = dgv_bangcoso.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_email.Text = dgv_bangcoso.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult cauhoi = MessageBox.Show("bạn có muốn xóa không?", "thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cauhoi == DialogResult.Yes)
            {
                buscs.XoaCS(txt_macoso.Text);
                dgv_bangcoso.DataSource = buscs.HienThi();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            buscs.themCS(new DAO_CoSo(txt_macoso.Text, txt_tencoso.Text, txt_diachi.Text, txt_sdt.Text, txt_email.Text));
            dgv_bangcoso.DataSource = buscs.HienThi();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            buscs.CapnhatCS(new DAO_CoSo(txt_macoso.Text, txt_tencoso.Text, txt_diachi.Text, txt_sdt.Text, txt_email.Text));
            dgv_bangcoso.DataSource = buscs.HienThi();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_macoso.Clear();
            txt_tencoso.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
