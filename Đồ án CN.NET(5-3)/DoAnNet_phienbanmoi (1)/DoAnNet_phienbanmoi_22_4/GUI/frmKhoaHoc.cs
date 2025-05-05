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
    public partial class frmKhoaHoc : Form
    {
        public frmKhoaHoc()
        {
            InitializeComponent();
        }
        //
        BUS_KhoaHoc BUS_KhoaHoc = new BUS_KhoaHoc();
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Khoahoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //load thong tin khoa hoc
        public void LoadThongTin()
        {
            dgv_bangkhoahoc.DataSource = BUS_KhoaHoc.getAllKhoaHoc();
        }
        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void dgv_bangkhoahoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            
        }
    }
}
