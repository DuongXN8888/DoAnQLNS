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
	public partial class FrmCTKhenThuongKyLuat : Form
	{
		public FrmCTKhenThuongKyLuat()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_CTKHENTHUONGKYLUAT()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_CTKhenThuongKyLuat order by SoQD");
			dgvCTKTKL.DataSource = dta;
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_NHANVIEN order by MaNV");
			cboMaNV.DataSource = dta1;
			cboMaNV.DisplayMember = "MaNV";
		}
		public void BANG_LOAI()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DMKhenThuongKyLuat order by MaLoai");
			cboMaLoai.DataSource = dta2;
			cboMaLoai.DisplayMember = "MaLoai";
		}
		private void HTTT()
		{
			txtSoQD.DataBindings.Clear();
			txtSoQD.DataBindings.Add("Text", dgvCTKTKL.DataSource, "SoQD");
			txtNgay.DataBindings.Clear();
			txtNgay.DataBindings.Add("Text", dgvCTKTKL.DataSource, "NgayQD");
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dgvCTKTKL.DataSource, "MaNV");
			cboMaLoai.DataBindings.Clear();
			cboMaLoai.DataBindings.Add("Text", dgvCTKTKL.DataSource, "MaLoai");
			txtNoiDung.DataBindings.Clear();
			txtNoiDung.DataBindings.Add("Text", dgvCTKTKL.DataSource, "NoiDung");
			txtHinhThuc.DataBindings.Clear();
			txtHinhThuc.DataBindings.Add("Text", dgvCTKTKL.DataSource, "HinhThuc");
			txtThuongPhat.DataBindings.Clear();
			txtThuongPhat.DataBindings.Add("Text", dgvCTKTKL.DataSource, "mucthuongphat");
			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text", dgvCTKTKL.DataSource, "GhiChu");
		}

		private void FrmCTKhenThuongKyLuat_Load(object sender, EventArgs e)
		{
			BANG_CTKHENTHUONGKYLUAT();
			BANG_LOAI();
			BANG_NHANVIEN();
		}

		private void dgvCTKTKL_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem1_Click(object sender, EventArgs e)
		{
			txtSoQD.Text = "";
			txtNgay.Text = "";
			cboMaNV.Text = "";
			cboMaLoai.Text = "";
			txtNoiDung.Text = "";
			txtHinhThuc.Text = "";
			txtThuongPhat.Text = "";
			txtGhiChu.Text = "";
			txtSoQD.Focus();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnLuu1_Click(object sender, EventArgs e)
		{
			string strkra = "Select SoQD from Tbl_CTKhenThuongKyLuat where SoQD= '" + txtSoQD.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Số Quyết Định Này Đã Tồn Tại!,Vui Lòng Nhập Lại Số Khác", "Thông Báo");
				txtSoQD.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_CTKhenThuongKyLuat Values('" + txtSoQD.Text + "','" + txtNgay.Text+ "','" + cboMaNV.Text + "','" + cboMaLoai.Text + "','" + txtNoiDung.Text + "','" + txtHinhThuc.Text + "','" + txtThuongPhat.Text + "','" + txtGhiChu.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_CTKHENTHUONGKYLUAT();
			}
		}

		private void btnSua1_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_CTKhenThuongKyLuat Set NgayQD='" + txtNgay.Text + "',";
			SQL_Sua = SQL_Sua + "MaNV ='" + cboMaNV.Text + "',";
			SQL_Sua = SQL_Sua + "MaLoai ='" + cboMaLoai.Text + "',";
			SQL_Sua = SQL_Sua + "NoiDung ='" + txtNoiDung.Text + "',";
			SQL_Sua = SQL_Sua + "HinhThuc ='" + txtHinhThuc.Text + "',";
			SQL_Sua = SQL_Sua + "mucthuongphat ='" + txtThuongPhat.Text + "',";
			SQL_Sua = SQL_Sua + "GhiChu ='" + txtGhiChu.Text + "'where SoQD='" + txtSoQD.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CTKHENTHUONGKYLUAT();
		}

		private void btnXoa1_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_CTKhenThuongKyLuat where SoQD ='" + txtSoQD.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_CTKHENTHUONGKYLUAT();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
