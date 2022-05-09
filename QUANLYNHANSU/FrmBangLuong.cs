using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
	public partial class FrmBangLuong : Form
	{
		public FrmBangLuong()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_LUONG()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_BangLuong");
			dgvBangLuong.DataSource = dta;
		}
		public void BANG_THANG()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Thang order by Thang");
			CbThang.DataSource = dta1;
			CbThang.DisplayMember = "Thang";
		}
		public void BANG_NAM()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Nam order by Nam");
			CboNam.DataSource = dta2;
			CboNam.DisplayMember = "Nam";
		}
		public void BANG_NHANVIEN()
		{
			DataTable dta3 = new DataTable();
			dta3 = kn.Lay_DulieuBang("Select*FROM Tbl_NhanVien order by MaNV");
			cboMaNV.DataSource = dta3;
			cboMaNV.DisplayMember = "MaNV";
		}
		public void BANG_PHONG()
		{
			DataTable dta4 = new DataTable();
			dta4 = kn.Lay_DulieuBang("Select*FROM Tbl_PhongBan order by MaPhong");
			CboMaPhong.DataSource = dta4;
			CboMaPhong.DisplayMember = "MaPhong";
		}
		public void BANG_TO()
		{
			DataTable dta5 = new DataTable();
			dta5 = kn.Lay_DulieuBang("Select*FROM Tbl_DanhMucTo order by mato");
			CboMaTo.DataSource = dta5;
			CboMaTo.DisplayMember = "mato";
		}
		public void BANG_HQ()
		{
			DataTable dta6 = new DataTable();
			dta6 = kn.Lay_DulieuBang("Select*FROM Tbl_HIeuQua order by MaHieuQua");
			CboMaHQ.DataSource = dta6;
			CboMaHQ.DisplayMember = "MaHieuQua";
		}
		private void HTTT()
		{
			CbThang.DataBindings.Clear();
			CbThang.DataBindings.Add("Text", dgvBangLuong.DataSource, "Thang");
			CboNam.DataBindings.Clear();
			CboNam.DataBindings.Add("Text", dgvBangLuong.DataSource, "Nam");
			cboMaNV.DataBindings.Clear();
			cboMaNV.DataBindings.Add("Text", dgvBangLuong.DataSource, "MaNV");
			CboMaPhong.DataBindings.Clear();
			CboMaPhong.DataBindings.Add("Text", dgvBangLuong.DataSource, "maphong");
			CboMaTo.DataBindings.Clear();
			CboMaTo.DataBindings.Add("Text", dgvBangLuong.DataSource, "mato");
			txtLuongCoBan.DataBindings.Clear();
			txtLuongCoBan.DataBindings.Add("Text", dgvBangLuong.DataSource, "LuongCoBan");
			CboMaHQ.DataBindings.Clear();
			CboMaHQ.DataBindings.Add("Text", dgvBangLuong.DataSource, "MaHieuQua");
			txtTiLeHieuQua.DataBindings.Clear();
			txtTiLeHieuQua.DataBindings.Add("Text", dgvBangLuong.DataSource, "tilehq");
			txtNgayLamViec.DataBindings.Clear();
			txtNgayLamViec.DataBindings.Add("Text", dgvBangLuong.DataSource, "SongayLV");
			txtGioTangCa.DataBindings.Clear();
			txtGioTangCa.DataBindings.Add("Text", dgvBangLuong.DataSource, "SogioTangCa");
			txtGioTangCaCN.DataBindings.Clear();
			txtGioTangCaCN.DataBindings.Add("Text", dgvBangLuong.DataSource, "SogioTangCaCN");
			txtNghiCoPhep.DataBindings.Clear();
			txtNghiCoPhep.DataBindings.Add("Text", dgvBangLuong.DataSource, "SoNgayNghiPhep");
			txtNghiKhongPhep.DataBindings.Clear();
			txtNghiKhongPhep.DataBindings.Add("Text", dgvBangLuong.DataSource, "songaynghingungviec");
			txtChuCap.DataBindings.Clear();
			txtChuCap.DataBindings.Add("Text", dgvBangLuong.DataSource, "tileccvasinhhoat");
			txtLuongLamViec.DataBindings.Clear();
			txtLuongLamViec.DataBindings.Add("Text", dgvBangLuong.DataSource, "LuongLamViec");
			txtLuongTangCa.DataBindings.Clear();
			txtLuongTangCa.DataBindings.Add("Text", dgvBangLuong.DataSource, "LuongTangCa");
			txtBH.DataBindings.Clear();
			txtBH.DataBindings.Add("Text", dgvBangLuong.DataSource, "BHXHvaBHYT");
			txtPhuCap.DataBindings.Clear();
			txtPhuCap.DataBindings.Add("Text", dgvBangLuong.DataSource, "phucapcv");
			txtPhuCapCC.DataBindings.Clear();
			txtPhuCapCC.DataBindings.Add("Text", dgvBangLuong.DataSource, "pcsinhhoatcc");
			txtPhuCapKhac.DataBindings.Clear();
			txtPhuCapKhac.DataBindings.Add("Text", dgvBangLuong.DataSource, "phucapkhac");
			txtThucLanh.DataBindings.Clear();
			txtThucLanh.DataBindings.Add("Text", dgvBangLuong.DataSource, "ThucLanh");
		}

		private void FrmBangLuong_Load(object sender, EventArgs e)
		{
			BANG_HQ();
			BANG_LUONG();
			BANG_NAM();
			BANG_THANG();
			BANG_TO();
			BANG_NHANVIEN();
			BANG_PHONG();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPhuCap_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			CbThang.Text = "";
			CboNam.Text = "";
			cboMaNV.Text = "";
			CboMaPhong.Text = "";
			CboMaTo.Text = "";
			txtLuongCoBan.Text = "";
			CboMaHQ.Text = "";
			txtTiLeHieuQua.Text = "";
			txtNgayLamViec.Text = "";
			txtGioTangCa.Text = "";
			txtGioTangCaCN.Text = "";
			txtNghiCoPhep.Text = "";
			txtNghiKhongPhep.Text = "";
			txtChuCap.Text = "";
			txtLuongLamViec.Text = "";
			txtLuongTangCa.Text = "";
			txtBH.Text = "";
			txtPhuCap.Text = "";
			txtPhuCapCC.Text = "";
			txtPhuCapKhac.Text = "";
			txtThucLanh.Text = "";
			cboMaNV.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaNV from Tbl_BangLuong where MaNV= '" + cboMaNV.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Thông Tin Lương Nhân Viên này đã có!, Bạn có chắc vẫn muốn nhập không", "Thông Báo");
				cboMaNV.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_BangLuong Values('" + CbThang.Text + "','" + CboNam.Text + "','" + cboMaNV.Text + "','" + CboMaPhong.Text + "','" + CboMaTo.Text + "','" + txtLuongCoBan.Text + "','" + CboMaHQ.Text + "','" + txtTiLeHieuQua.Text + "','" + txtNgayLamViec.Text + "','" + txtGioTangCa.Text + "','" + txtGioTangCaCN.Text + "','" + txtNghiCoPhep.Text + "','" + txtNghiKhongPhep.Text + "','" + txtChuCap.Text + "','" + txtLuongLamViec.Text + "','" + txtLuongTangCa.Text + "','" + txtBH.Text + "','" + txtPhuCap.Text + "','" + txtPhuCapCC.Text + "','" + txtPhuCapKhac.Text + "','" + txtThucLanh.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_LUONG();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_BangLuong Set Thang='" + CbThang.Text + "',";
			SQL_Sua = SQL_Sua + "Nam ='" + CboNam.Text + "',";
			SQL_Sua = SQL_Sua + "maphong ='" + CboMaPhong.Text + "',";
			SQL_Sua = SQL_Sua + "mato ='" + CboMaTo.Text + "',";
			SQL_Sua = SQL_Sua + "LuongCoBan ='" + txtLuongCoBan.Text + "',";
			SQL_Sua = SQL_Sua + "MaHieuQua ='" + CboMaHQ.Text + "',";
			SQL_Sua = SQL_Sua + "tilehq ='" + txtTiLeHieuQua.Text + "',";
			SQL_Sua = SQL_Sua + "SongayLV ='" + txtNgayLamViec.Text + "',";
			SQL_Sua = SQL_Sua + "SogioTangCa ='" + txtGioTangCa.Text + "',";
			SQL_Sua = SQL_Sua + "SogioTangCaCN ='" + txtGioTangCaCN.Text + "',";
			SQL_Sua = SQL_Sua + "SoNgayNghiPhep ='" + txtNghiCoPhep.Text + "',";
			SQL_Sua = SQL_Sua + "songaynghingungviec ='" + txtNghiKhongPhep.Text + "',";
			SQL_Sua = SQL_Sua + "tileccvasinhhoat ='" + txtChuCap.Text + "',";
			SQL_Sua = SQL_Sua + "LuongLamViec ='" + txtLuongLamViec.Text + "',";
			SQL_Sua = SQL_Sua + "LuongTangCa ='" + txtLuongTangCa.Text + "',";
			SQL_Sua = SQL_Sua + "BHXHvaBHYT ='" + txtBH.Text + "',";
			SQL_Sua = SQL_Sua + "phucapcv ='" + txtPhuCap.Text + "',";
			SQL_Sua = SQL_Sua + "pcsinhhoatcc ='" + txtPhuCapCC.Text + "',";
			SQL_Sua = SQL_Sua + "phucapkhac ='" + txtPhuCapKhac.Text + "',";
			SQL_Sua = SQL_Sua + "ThucLanh ='" + txtThucLanh.Text + "'where MaNV='" + cboMaNV.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_LUONG();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string SQL_xoa;
			SQL_xoa = "Delete Tbl_BangLuong where MaNV ='" + cboMaNV.Text + "'";
			kn.ThucThi(SQL_xoa);
			BANG_LUONG();
		}
	}
}
