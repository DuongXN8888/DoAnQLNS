using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
	public partial class FrmChiTietNgoaiNgu : Form
	{
		public FrmChiTietNgoaiNgu()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		

		private void BANG_CHITIETNGOAINGU()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_ChiTietNgoaiNgu order by ID");
			dgvChiTietNgoaiNgu.DataSource = dta;
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_NHANVIEN order by MaNV");
			cboMaNV.DataSource = dta1;
			cboMaNV.DisplayMember = "MaNV";
		}
		public void BANG_DMNGOAINGU()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DMNgoaiNgu order by MaNgoaiNgu");
			cboMaNgoaiNgu.DataSource = dta2;
			cboMaNgoaiNgu.DisplayMember = "MaNgoaiNgu";

		}
		private void HTTT()
		{
			txtID.DataBindings.Clear();
			txtID.DataBindings.Add("Text", dgvChiTietNgoaiNgu.DataSource, "ID");
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dgvChiTietNgoaiNgu.DataSource, "MaNV");
			cboMaNgoaiNgu.DataBindings.Clear();
			cboMaNgoaiNgu.DataBindings.Add("Text", dgvChiTietNgoaiNgu.DataSource, "MaNgoaiNgu");
			txtTrinhDo.DataBindings.Clear();
			txtTrinhDo.DataBindings.Add("Text", dgvChiTietNgoaiNgu.DataSource, "TrinhDo");
			txtNoiCap.DataBindings.Clear();
			txtNoiCap.DataBindings.Add("Text", dgvChiTietNgoaiNgu.DataSource, "NoiCap");
			dateNgayCap.DataBindings.Clear();
			dateNgayCap.DataBindings.Add("Value", dgvChiTietNgoaiNgu.DataSource, "NgayCap");
		}


		private void FrmChiTietNgoaiNgu_Load(object sender, EventArgs e)
		{
			BANG_CHITIETNGOAINGU();
			BANG_NHANVIEN();
			BANG_DMNGOAINGU();
		}

		private void dgvChiTietNgoaiNgu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			cboMaNV.Text = "";
			cboMaNgoaiNgu.Text = "";
			txtTrinhDo.Text = "";
			txtNoiCap.Text = "";
			txtID.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select ID from Tbl_ChiTietNgoaiNgu where ID= '" + txtID.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Số ID Này Đã Tồn Tại!,Vui Lòng Nhập Lại Số Khác", "Thông Báo");
				txtID.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_ChiTietNgoaiNgu Values('" + txtID.Text + "','" + cboMaNV.Text + "','" + cboMaNgoaiNgu.Text + "','" + txtTrinhDo.Text + "','" + txtNoiCap.Text + "','" + dateNgayCap.Value + "')";
				kn.ThucThi(sql_luu);
				BANG_CHITIETNGOAINGU();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_ChiTietNgoaiNgu where ID ='" + txtID.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_CHITIETNGOAINGU();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_ChiTietNgoaiNgu Set MaNV='" + cboMaNV.Text + "',";
			SQL_Sua = SQL_Sua + "MaNgoaiNgu ='" + cboMaNgoaiNgu.Text + "',";
			SQL_Sua = SQL_Sua + "TrinhDo ='" + txtTrinhDo.Text + "',";
			SQL_Sua = SQL_Sua + "NoiCap ='" + txtNoiCap.Text + "',";
			SQL_Sua = SQL_Sua + "NgayCap ='" + dateNgayCap.Value + "'where ID='" + txtID.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CHITIETNGOAINGU();
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
