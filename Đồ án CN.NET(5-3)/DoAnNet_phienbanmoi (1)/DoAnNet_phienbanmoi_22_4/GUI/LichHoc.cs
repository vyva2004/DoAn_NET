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
    public partial class LichHoc : Form
    {
        public LichHoc()
        {
            InitializeComponent();
        }
        //

        BUS_LichHoc lhoc = new BUS_LichHoc();
        
        //ham load thong tin
        public void LoadThongTin()
        {
            dgvLichHoc.DataSource = lhoc.GetAllLichHoc(); 
        }
        
		private void LichHoc_Load(object sender, EventArgs e)
		{
            LoadThongTin();
		}

        private void txtMaLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            LichHoc lh = new LichHoc
            {
                
            };
        }

        private void dgvLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaLichHoc.Text = dgvLichHoc.Rows[iDong].Cells[0].Value.ToString();
            txtMaLopHoc.Text = dgvLichHoc.Rows[iDong].Cells[1].Value.ToString();
            dtpNgayHoc.Text = dgvLichHoc.Rows[iDong].Cells[2].Value.ToString();
            txt_CaHoc.Text = dgvLichHoc.Rows[iDong].Cells[3].Value.ToString();
            txtMaPhong.Text = dgvLichHoc.Rows[iDong].Cells[4].Value.ToString();
            txtMaNhanVien.Text = dgvLichHoc.Rows[iDong].Cells[5].Value.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
