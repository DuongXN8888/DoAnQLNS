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
	public partial class FrmBangTiLeLuong : Form
	{
		public FrmBangTiLeLuong()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();

		private void BANG_TILELUONG()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_TiLeLuongTheoPhong order by id");
			dgvBangTiLeLuong.DataSource = dta;
		}
		public void BANG_PHONG()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_PhongBan order by MaPhong");
			cboMaPhong.DataSource = dta1;
			cboMaPhong.DisplayMember = "MaPhong";
		}
		public void BANG_TO()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DanhMucTo order by MaTo");
			cboMaTo.DataSource = dta2;
			cboMaTo.DisplayMember = "MaTo";

		}
		public void BANG_NAM()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Nam order by Nam");
			cboNam.DataSource = dta1;
			cboNam.DisplayMember = "Nam";
		}
		public void BANG_THANG()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Thang order by Thang");
			cboThang.DataSource = dta2;
			cboThang.DisplayMember = "Thang";

		}
		private void HTTT()
		{
			txtID.DataBindings.Clear();
			txtID.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "id");
			cboThang.DataBindings.Clear();
			cboThang.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "Thang");
			cboNam.DataBindings.Clear();
			cboNam.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "Nam");
			cboMaPhong.DataBindings.Clear();
			cboMaPhong.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "MaPhong");
			cboMaTo.DataBindings.Clear();
			cboMaTo.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "MaTo");
			txtTiLeLuong.DataBindings.Clear();
			txtTiLeLuong.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "TiLeLuong");
			txtSoNgayCong.DataBindings.Clear();
			txtSoNgayCong.DataBindings.Add("Text", dgvBangTiLeLuong.DataSource, "SoNgayCongThang");
		}

		private void FrmBangTiLeLuong_Load(object sender, EventArgs e)
		{
			BANG_TILELUONG();
			BANG_PHONG();
			BANG_TO();
			BANG_NAM();
			BANG_THANG();
		}

		private void dgvBangTiLeLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			cboThang.Text = "";
			cboNam.Text = "";
			cboMaPhong.Text = "";
			cboMaTo.Text = "";
			txtTiLeLuong.Text = "";
			txtSoNgayCong.Text = "";
			txtID.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select id from Tbl_TiLeLuongTheoPhong where id= '" + txtID.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Số id Này Đã Tồn Tại!,Vui Lòng Nhập Lại Số Khác", "Thông Báo");
				txtID.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_TiLeLuongTheoPhong Values('" + txtID.Text + "','" + cboThang.Text + "','" + cboNam.Text + "','" + cboMaPhong.Text + "','" + cboMaTo.Text + "','" + txtTiLeLuong.Text + "','" + txtSoNgayCong.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_TILELUONG();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_TiLeLuongTheoPhong Set Thang='" + cboThang.Text + "',";
			SQL_Sua = SQL_Sua + "Nam ='" + cboNam.Text + "',";
			SQL_Sua = SQL_Sua + "MaPhong ='" + cboMaPhong.Text + "',";
			SQL_Sua = SQL_Sua + "MaTo ='" + cboMaTo.Text + "',";
			SQL_Sua = SQL_Sua + "tileluong ='" + txtTiLeLuong.Text + "',";
			SQL_Sua = SQL_Sua + "SoNgayCongThang ='" + txtSoNgayCong.Text + "'where id='" + txtID.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_TILELUONG();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_TiLeLuongTheoPhong where id ='" + txtID.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_TILELUONG();
		}
	}
}
