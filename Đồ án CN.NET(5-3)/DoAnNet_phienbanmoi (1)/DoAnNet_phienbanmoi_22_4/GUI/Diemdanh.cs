using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
using BUS;

using System.Windows.Forms;

namespace GUI
{
	public partial class Diemdanh : Form
	{
		public Diemdanh()
		{
			InitializeComponent();
		}
		//
		BUS_DiemDanh BUS_DiemDanh = new BUS_DiemDanh();

		//load thong tin bang
		public void LoadThongTin()
		{
			dgv_bangdiemdanh.DataSource = BUS_DiemDanh.getALlDiemDanh;
		}
		//load thong tin ma hoc vien
		public void LoadThongTinHocVien()
		{
			cbo_MaHocVien.DataSource = BUS_DiemDanh.getAllMaHocVien;
		}
		//load thong tin ma giao vien
		public void LoadThongTinGiaoVien()
		{
			cbo_MaGiaoVien.DataSource = BUS_DiemDanh.getAllMaGiaoVien;
		}
        private void Diemdanh_Load(object sender, EventArgs e)
        {
			LoadThongTin();
			LoadThongTinHocVien();
			LoadThongTinGiaoVien();
        }

		private void btn_them_Click(object sender, EventArgs e)
		{

		}
	}
}
