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
	public partial class FrmSucKhoeNhanVien : Form
	{
		public FrmSucKhoeNhanVien()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_SUCKHOE()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_SucKhoe");
			dgvSucKhoe.DataSource = dta;
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_NHANVIEN order by MaNV");
			cboMaNV.DataSource = dta1;
			cboMaNV.DisplayMember = "MaNV";
		}
		private void HTTT()
		{
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dgvSucKhoe.DataSource, "MaNV");
			txtNgay.DataBindings.Clear();
			txtNgay.DataBindings.Add("Text", dgvSucKhoe.DataSource, "NgayKham");
			txtChieuCao.DataBindings.Clear();
			txtChieuCao.DataBindings.Add("Text", dgvSucKhoe.DataSource, "ChieuCao");
			txtCanNang.DataBindings.Clear();
			txtCanNang.DataBindings.Add("Text", dgvSucKhoe.DataSource, "CanNang");
			txtNhomMau.DataBindings.Clear();
			txtNhomMau.DataBindings.Add("Text", dgvSucKhoe.DataSource, "NhomMau");
			txtThiLuc.DataBindings.Clear();
			txtThiLuc.DataBindings.Add("Text", dgvSucKhoe.DataSource, "ThiLuc");
			txtSoCon.DataBindings.Clear();
			txtSoCon.DataBindings.Add("Text", dgvSucKhoe.DataSource, "SoCon");
			txtDiTat.DataBindings.Clear();
			txtDiTat.DataBindings.Add("Text", dgvSucKhoe.DataSource, "DiTat");
			txtDiChuyen.DataBindings.Clear();
			txtDiChuyen.DataBindings.Add("Text", dgvSucKhoe.DataSource, "DiTruyen");
			txtDiUngThuoc.DataBindings.Clear();
			txtDiUngThuoc.DataBindings.Add("Text", dgvSucKhoe.DataSource, "DiUngThuoc");
			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text", dgvSucKhoe.DataSource, "GhiChu");
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			cboMaNV.Text = "";
			txtNgay.Text = "";
			txtChieuCao.Text = "";
			txtCanNang.Text = "";
			txtNhomMau.Text = "";
			txtThiLuc.Text = "";
			txtSoCon.Text = "";
			txtDiTat.Text = "";
			txtDiChuyen.Text = "";
			txtDiUngThuoc.Text = "";
			txtGhiChu.Text = "";
			cboMaNV.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaNV from Tbl_SucKhoe where MaNV= '" + cboMaNV.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Thông Tin Nhân Viên Này Đã Tồn Tại!,Vui Lòng Chọn Mã Nhân Viên Khác", "Thông Báo");
				cboMaNV.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_SucKhoe Values('" + cboMaNV.Text + "','" + txtNgay.Text + "','" + txtChieuCao.Text + "','" + txtCanNang.Text + "','" + txtNhomMau.Text + "','" + txtThiLuc.Text + "','" + txtSoCon.Text + "','" + txtDiTat.Text + "','" + txtDiChuyen.Text + "','" + txtDiUngThuoc.Text + "','" + txtGhiChu.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_SUCKHOE();
			}
		}

		private void dgvSucKhoe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void FrmSucKhoeNhanVien_Load(object sender, EventArgs e)
		{
			BANG_NHANVIEN();
			BANG_SUCKHOE();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_SucKhoe Set NgayKham='" + txtNgay.Text + "',";
			SQL_Sua = SQL_Sua + "ChieuCao ='" + txtChieuCao.Text + "',";
			SQL_Sua = SQL_Sua + "CanNang ='" + txtCanNang.Text + "',";
			SQL_Sua = SQL_Sua + "NhomMau ='" + txtNhomMau.Text + "',";
			SQL_Sua = SQL_Sua + "ThiLuc ='" + txtThiLuc.Text + "',";
			SQL_Sua = SQL_Sua + "SoCon ='" + txtSoCon.Text + "',";
			SQL_Sua = SQL_Sua + "DiTat ='" + txtDiTat.Text + "',";
			SQL_Sua = SQL_Sua + "DiTruyen ='" + txtDiChuyen.Text + "',";
			SQL_Sua = SQL_Sua + "DiUngThuoc ='" + txtDiUngThuoc.Text + "',";
			SQL_Sua = SQL_Sua + "GhiChu ='" + txtGhiChu.Text + "'where MaNV='" + cboMaNV.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_SUCKHOE();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_SucKhoe where MaNV ='" + cboMaNV.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_SUCKHOE();
		}

		private void btnTK_Click(object sender, EventArgs e)
		{
			DataTable dta = new DataTable();
			string sqltk = "Select * from Tbl_SucKhoe where MaNV = '" + txtTimKiemMaNV.Text + "'";
			dta = kn.Lay_DulieuBang(sqltk);
			dgvTK.DataSource = dta;
		}
	}
}
