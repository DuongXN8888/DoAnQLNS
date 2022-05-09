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
	public partial class FrmChiTietHopDong : Form
	{
		public FrmChiTietHopDong()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_CHITIETHOPDONG()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_ChiTietHopDong order by SoHD");
			dtaChiTietHD.DataSource = dta;
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_NHANVIEN order by MaNV");
			cboMaNV.DataSource = dta1;
			cboMaNV.DisplayMember = "MaNV";
		}
		public void BANG_LOAIHD()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_LoaiHD order by MaLoaiHD");
			cboMaLoaiHD.DataSource = dta2;
			cboMaLoaiHD.DisplayMember = "MaLoaiHD";
		}
		private void HTTT()
		{
			txtSoHD.DataBindings.Clear();
			txtSoHD.DataBindings.Add("Text", dtaChiTietHD.DataSource, "SoHD");
			cboMaLoaiHD.DataBindings.Clear();
			cboMaLoaiHD.DataBindings.Add("Text", dtaChiTietHD.DataSource, "MaLoaiHD");
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dtaChiTietHD.DataSource, "MaNV");
			dateNgayKy.DataBindings.Clear();
			dateNgayKy.DataBindings.Add("Value", dtaChiTietHD.DataSource, "NgayKy");
			dateNgayKT.DataBindings.Clear();
			dateNgayKT.DataBindings.Add("Value", dtaChiTietHD.DataSource, "NgayKetThuc");
			txtLuongCoBan.DataBindings.Clear();
			txtLuongCoBan.DataBindings.Add("Text", dtaChiTietHD.DataSource, "LuongCoBan");
		}
		private void FrmChiTietHopDong_Load(object sender, EventArgs e)
		{
			BANG_CHITIETHOPDONG();
			BANG_NHANVIEN();
			BANG_LOAIHD();
		}

		private void dtaChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtSoHD.Text = "";
			cboMaLoaiHD.Text = "";
			cboMaNV.Text = "";
			txtLuongCoBan.Text = "";
			txtSoHD.Focus();
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select SoHD from Tbl_ChiTietHopDong where SoHD= '" + txtSoHD.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Số Hợp Đồng Này Đã Tồn Tại!,Vui Lòng Nhập Lại Số Khác", "Thông Báo");
				txtSoHD.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_ChiTietHopDong Values('" + txtSoHD.Text + "','" + cboMaLoaiHD.Text + "','" + cboMaNV.Text + "','" + dateNgayKy.Value + "','" + dateNgayKT.Value + "','" + txtLuongCoBan.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_CHITIETHOPDONG();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_ChiTietHopDong Set MaLoaiHD='" + cboMaLoaiHD.Text + "',";
			SQL_Sua = SQL_Sua + "MaNV ='" + cboMaNV.Text + "',";
			SQL_Sua = SQL_Sua + "NgayKy ='" + dateNgayKy.Value + "',";
			SQL_Sua = SQL_Sua + "NgayKetThuc ='" + dateNgayKT.Value + "',";
			SQL_Sua = SQL_Sua + "LuongCoBan ='" + txtLuongCoBan.Text + "'where SoHD='" + txtSoHD.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CHITIETHOPDONG();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_ChiTietHopDong where SoHD ='" + txtSoHD.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_CHITIETHOPDONG();
		}
	}
}
