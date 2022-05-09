using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
	public partial class FrmTraCuuTT : Form
	{
		public FrmTraCuuTT()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();

		private void radMaNV_CheckedChanged(object sender, EventArgs e)
		{
			cboMaNV.Focus();
			cboMaNV.Enabled = true;
			cboMaChuyenMon.Enabled = false;
			cboMaTrinhDo.Enabled = false;
		}

		private void radMaChuyenMon_CheckedChanged(object sender, EventArgs e)
		{
			cboMaChuyenMon.Focus();
			cboMaChuyenMon.Enabled = true;
			cboMaNV.Enabled = false;
			cboMaTrinhDo.Enabled = false;
		}

		private void radMaTrinhDo_CheckedChanged(object sender, EventArgs e)
		{
			cboMaTrinhDo.Focus();
			cboMaTrinhDo.Enabled = true;
			cboMaChuyenMon.Enabled = false;
			cboMaNV.Enabled = false;
		}

		private void FrmTraCuuTT_Load(object sender, EventArgs e)
		{
			radMaNV.Checked = true;
			radioButton3.Checked = true;

			DataTable dta = kn.Lay_DulieuBang("select * from Tbl_NhanVien order by MaNV ");
			cboMaNV.DataSource = dta;
			cboMaNV.DisplayMember = "MaNV";
			DataTable dta1 = kn.Lay_DulieuBang("select * from Tbl_DMChuyenMon order by MaChuyenMon ");
			cboMaChuyenMon.DataSource = dta1;
			cboMaChuyenMon.DisplayMember = "MaChuyenMon";
			DataTable dta2 = kn.Lay_DulieuBang("select * from Tbl_DMTrinhDo order by MaTrinhDo ");
			cboMaTrinhDo.DataSource = dta2;
			cboMaTrinhDo.DisplayMember = "MaTrinhDo";

			DataTable dta3 = kn.Lay_DulieuBang("select * from Tbl_DMNgoaiNgu order by MaNgoaiNgu ");
			cboMaNgoaiNgu.DataSource = dta3;
			cboMaNgoaiNgu.DisplayMember = "MaNgoaiNgu";
			DataTable dta4 = kn.Lay_DulieuBang("select * from Tbl_NhanVien order by MaNV ");
			cboMaNhanVien.DataSource = dta4;
			cboMaNhanVien.DisplayMember = "MaNV";
		}

		private void btnTC_Click(object sender, EventArgs e)
		{
			DataTable dta = new DataTable();
			string sqltk;
			if (radMaNV.Checked == true)
			{
				sqltk = "select * from Tbl_ChiTietChuyenMon where MaNV like'" + cboMaNV.Text + "'";
				dta = kn.Lay_DulieuBang(sqltk);
			}
			if (radMaChuyenMon.Checked == true)
			{
				sqltk = "select * from Tbl_ChiTietChuyenMon where MaChuyenMon like'" + cboMaChuyenMon.Text + "'";
				dta = kn.Lay_DulieuBang(sqltk);
			}
			if (radMaTrinhDo.Checked == true)
			{
				sqltk = "select * from Tbl_ChiTietChuyenMon where MaTrinhDo like'" + cboMaTrinhDo.Text + "'";
				dta = kn.Lay_DulieuBang(sqltk);
			}
			dgvChuyenMon.DataSource = dta;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			cboMaNhanVien.Focus();
			cboMaNhanVien.Enabled = true;
			cboMaNgoaiNgu.Enabled = false;
		}

		private void radNgoaiNgu_CheckedChanged(object sender, EventArgs e)
		{
			cboMaNgoaiNgu.Focus();
			cboMaNgoaiNgu.Enabled = true;
			cboMaNhanVien.Enabled = false;
		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			DataTable dta = new DataTable();
			string sqltk;
			if (radioButton3.Checked == true)
			{
				sqltk = "select * from Tbl_ChiTietNgoaiNgu where MaNV like'" + cboMaNhanVien.Text + "'";
				dta = kn.Lay_DulieuBang(sqltk);
			}
			if (radNgoaiNgu.Checked == true)
			{
				sqltk = "select * from Tbl_ChiTietNgoaiNgu where MaNgoaiNgu like'" + cboMaNgoaiNgu.Text + "'";
				dta = kn.Lay_DulieuBang(sqltk);
			}
			dgvChiTietNgoaiNgu.DataSource = dta;
		}
	}
}
