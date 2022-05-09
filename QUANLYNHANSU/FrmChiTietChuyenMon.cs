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
	public partial class FrmChiTietChuyenMon : Form
	{
		public FrmChiTietChuyenMon()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_CHITIETCHUYENMON()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_ChiTietChuyenMon order by ID");
			dgvChiTietChuyenMon.DataSource = dta;
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_NHANVIEN order by MaNV");
			cboMaNV.DataSource = dta1;
			cboMaNV.DisplayMember = "MaNV";
		}
		public void BANG_CHUYENMON()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DMChuyenMon order by MaChuyenMon");
			cboMaChuyenMon.DataSource = dta2;
			cboMaChuyenMon.DisplayMember = "MaChuyenMon";
		}
		public void BANG_TRINHDO()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DMTrinhDo order by MaTrinhDo");
			cboMaTrinhDo.DataSource = dta2;
			cboMaTrinhDo.DisplayMember = "MaTrinhDo";
		}
		private void HTTT()
		{
			txtID.DataBindings.Clear();
			txtID.DataBindings.Add("Text", dgvChiTietChuyenMon.DataSource, "ID");
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dgvChiTietChuyenMon.DataSource, "MaNV");
			cboMaChuyenMon.DataBindings.Clear();
			cboMaChuyenMon.DataBindings.Add("Text", dgvChiTietChuyenMon.DataSource, "MaChuyenMon");
			cboMaTrinhDo.DataBindings.Clear();
			cboMaTrinhDo.DataBindings.Add("Text", dgvChiTietChuyenMon.DataSource, "MaTrinhDo");
			dateNgayCap.DataBindings.Clear();
			dateNgayCap.DataBindings.Add("Value", dgvChiTietChuyenMon.DataSource, "NgayCap");
			txtTruong.DataBindings.Clear();
			txtTruong.DataBindings.Add("Text", dgvChiTietChuyenMon.DataSource, "Truong");
		}
		private void FrmChiTietChuyenMon_Load(object sender, EventArgs e)
		{
			BANG_CHITIETCHUYENMON();
			BANG_CHUYENMON();
			BANG_NHANVIEN();
			BANG_TRINHDO();
		}
		private void dgvChiTietChuyenMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			cboMaNV.Text = "";
			cboMaChuyenMon.Text = "";
			cboMaTrinhDo.Text = "";
			txtTruong.Text = "";
			txtID.Focus();
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select ID from Tbl_ChiTietChuyenMon where ID= '" + txtID.Text + "'";
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
				sql_luu = "Insert into Tbl_ChiTietChuyenMon Values('" + txtID.Text + "','" + cboMaNV.Text + "','" + cboMaChuyenMon.Text + "','" + cboMaTrinhDo.Text + "','" + dateNgayCap.Value + "','" + txtTruong.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_CHITIETCHUYENMON();
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_ChiTietChuyenMon Set MaNV='" + cboMaNV.Text + "',";
			SQL_Sua = SQL_Sua + "MaChuyenMon ='" + cboMaChuyenMon.Text + "',";
			SQL_Sua = SQL_Sua + "MaTrinhDo ='" + cboMaTrinhDo.Text+ "',";
			SQL_Sua = SQL_Sua + "NgayCap ='" + dateNgayCap.Value + "',";
			SQL_Sua = SQL_Sua + "Truong ='" + txtTruong.Text + "'where ID='" + txtID.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CHITIETCHUYENMON();
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_ChiTietChuyenMon where ID ='" + txtID.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_CHITIETCHUYENMON();
		}
		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
