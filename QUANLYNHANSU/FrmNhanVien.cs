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
	public partial class FrmNhanVien : Form
	{
		public FrmNhanVien()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_NHANVIEN()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_NhanVien1");
			dgvNhanVien.DataSource = dta;
		}
		public void BANG_TONGIAO()
		{
			DataTable dta1 = new DataTable();
			dta1 = kn.Lay_DulieuBang("Select*FROM Tbl_DMTonGiao order by MaTG");
			CboMaTG.DataSource = dta1;
			CboMaTG.DisplayMember = "MaTG";
		}
		public void BANG_DANTOC()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_DMDanToc order by MaDT ");
			CboMaDT.DataSource = dta2;
			CboMaDT.DisplayMember = "MaDT";
		}
		public void BANG_CHUCVU()
		{
			DataTable dta3 = new DataTable();
			dta3 = kn.Lay_DulieuBang("Select*FROM Tbl_DMChucVu order by MaChucVu");
			CboMaCV.DataSource = dta3;
			CboMaCV.DisplayMember = "MaChucVu";
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

		private void FrmNhanVien_Load(object sender, EventArgs e)
		{
			BANG_NHANVIEN();
			BANG_CHUCVU();
			BANG_TONGIAO();
			BANG_PHONG();
			BANG_TO();
			BANG_DANTOC();
		}
		private void HTTT()
		{
			txtMaNV.DataBindings.Clear();
			txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
			txtHo.DataBindings.Clear();
			txtHo.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ho");
			txtTen.DataBindings.Clear();
			txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ten");
			txtGioiTinh.DataBindings.Clear();
			txtGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinh");
			txtSoCMND.DataBindings.Clear();
			txtSoCMND.DataBindings.Add("Text", dgvNhanVien.DataSource, "SoCMND");
			dateNgaySinh.DataBindings.Clear();
			dateNgaySinh.DataBindings.Add("Value", dgvNhanVien.DataSource, "NgaySinh");
			txtNoiSinh.DataBindings.Clear();
			txtNoiSinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NoiSinh");
			CboMaTG.DataBindings.Clear();
			CboMaTG.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaTG");
			CboMaDT.DataBindings.Clear();
			CboMaDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaDT");
			txtDT.DataBindings.Clear();
			txtDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "DienThoai");
			txtDTDD.DataBindings.Clear();
			txtDTDD.DataBindings.Add("Text", dgvNhanVien.DataSource, "DTDD");
			txtHKTT.DataBindings.Clear();
			txtHKTT.DataBindings.Add("Text", dgvNhanVien.DataSource, "HoKhauTT");
			txtChoOHT.DataBindings.Clear();
			txtChoOHT.DataBindings.Add("Text", dgvNhanVien.DataSource, "ChoOHienTai");
			txtTTHN.DataBindings.Clear();
			txtTTHN.DataBindings.Add("Text", dgvNhanVien.DataSource, "TinhtrangHonNhan");
			CboMaCV.DataBindings.Clear();
			CboMaCV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaChucVu");
			CboMaPhong.DataBindings.Clear();
			CboMaPhong.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaPhong");
			CboMaTo.DataBindings.Clear();
			CboMaTo.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaTo");
			dateNgayVaoLam.DataBindings.Clear();
			dateNgayVaoLam.DataBindings.Add("Value", dgvNhanVien.DataSource, "NgayVaoLam");
			txtSoBHYT.DataBindings.Clear();
			txtSoBHYT.DataBindings.Add("Text", dgvNhanVien.DataSource, "SoBHYT");
			txtSoBHXH.DataBindings.Clear();
			txtSoBHXH.DataBindings.Add("Text", dgvNhanVien.DataSource, "SoBHXH");
			txtSoTheATM.DataBindings.Clear();
			txtSoTheATM.DataBindings.Add("Text", dgvNhanVien.DataSource, "SoTheATM");
			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text", dgvNhanVien.DataSource, "GhiChu");
			txtEmail.DataBindings.Clear();
			txtEmail.DataBindings.Add("Text", dgvNhanVien.DataSource, "Email");
			txtAnh.DataBindings.Clear();
			txtAnh.DataBindings.Add("Text", dgvNhanVien.DataSource, "Hinhanh");
		}



		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog();
			openfileDlg.Filter = openfileDlg.Filter = "JPG files (*.jpg)|*.jpg|All files(*.*)|*.*";
			openfileDlg.FilterIndex = 1;
			openfileDlg.RestoreDirectory = true;
			if(openfileDlg.ShowDialog() == DialogResult.OK)
			{
				PicTuNhanVien.ImageLocation = openfileDlg.FileName;
				txtAnh.Text = openfileDlg.FileName;
			}
		}

		private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaNV.Text = "";
			txtHo.Text = "";
			txtTen.Text = "";
			txtGioiTinh.Text = "";
			txtSoCMND.Text = "";
			txtNoiSinh.Text = "";
			CboMaTG.Text = "";
			CboMaDT.Text = "";
			txtDT.Text = "";
			txtDTDD.Text = "";
			txtHKTT.Text = "";
			txtChoOHT.Text = "";
			txtTTHN.Text = "";
			txtAnh.Text = "";
			CboMaCV.Text = "";
			CboMaPhong.Text = "";
			CboMaTo.Text = "";
			txtSoBHYT.Text = "";
			txtSoBHXH.Text = "";
			txtSoTheATM.Text = "";
			txtGhiChu.Text = "";
			txtEmail.Text = "";
			txtMaNV.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaNV from Tbl_NhanVien1 where MaNV= '" + txtMaNV.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Nhân Viên Này Đã Tồn Tại!, Vui Lòng Nhập Mã Khác", "Thông Báo");
				txtMaNV.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_NhanVien1 Values('" + txtMaNV.Text + "','" + txtHo.Text + "','" + txtTen.Text + "','" + txtGioiTinh.Text + "','" + txtSoCMND.Text + "','" + dateNgaySinh.Value + "','" + txtNoiSinh.Text + "','" + CboMaTG.Text + "','" + CboMaDT.Text + "','" + txtDT.Text + "','" + txtDTDD.Text + "','" + txtHKTT.Text + "','" + txtChoOHT.Text + "','" + txtTTHN.Text + "','" + txtAnh.Text + "','" + CboMaCV.Text + "','" + CboMaPhong.Text + "','" + CboMaTo.Text + "','" + dateNgayVaoLam.Value + "','" + txtSoBHYT.Text + "','" + txtSoBHXH.Text + "','" + txtSoTheATM.Text + "','" + txtGhiChu.Text + "','" + txtEmail.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_NHANVIEN();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_NhanVien1 Set Ho='" + txtHo.Text + "',";
			SQL_Sua = SQL_Sua + "Ten ='" + txtTen.Text + "',";
			SQL_Sua = SQL_Sua + "GioiTinh ='" + txtGioiTinh.Text + "',";
			SQL_Sua = SQL_Sua + "SoCMND ='" + txtSoCMND.Text + "',";
			SQL_Sua = SQL_Sua + "NgaySinh ='" + dateNgaySinh.Value + "',";
			SQL_Sua = SQL_Sua + "NoiSinh ='" + txtNoiSinh.Text+ "',";
			SQL_Sua = SQL_Sua + "MaTG ='" + CboMaTG.Text + "',";
			SQL_Sua = SQL_Sua + "MaDT ='" + CboMaDT.Text + "',";
			SQL_Sua = SQL_Sua + "DienThoai ='" + txtDT.Text + "',";
			SQL_Sua = SQL_Sua + "DTDD ='" + txtDTDD.Text + "',";
			SQL_Sua = SQL_Sua + "HoKhauTT ='" + txtHKTT.Text + "',";
			SQL_Sua = SQL_Sua + "ChoOHienTai ='" + txtChoOHT.Text + "',";
			SQL_Sua = SQL_Sua + "TinhTrangHonNhan ='" + txtTTHN.Text + "',";
			SQL_Sua = SQL_Sua + "HinhAnh ='" + txtAnh.Text + "',";
			SQL_Sua = SQL_Sua + "MaChucVu ='" + CboMaCV.Text + "',";
			SQL_Sua = SQL_Sua + "MaPhong ='" + CboMaPhong.Text + "',";
			SQL_Sua = SQL_Sua + "MaTo ='" + CboMaTo.Text + "',";
			SQL_Sua = SQL_Sua + "NgayVaoLam ='" + dateNgayVaoLam.Value + "',";
			SQL_Sua = SQL_Sua + "SoBHYT ='" + txtSoBHYT.Text + "',";
			SQL_Sua = SQL_Sua + "SoBHXH ='" + txtSoBHXH.Text + "',";
			SQL_Sua = SQL_Sua + "SoTheATM ='" + txtSoTheATM.Text + "',";
			SQL_Sua = SQL_Sua + "GhiChu ='" + txtGhiChu.Text + "',";
			SQL_Sua = SQL_Sua + "Email ='" + txtEmail.Text + "'where MaNV='" + txtMaNV.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_NHANVIEN();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Muốn Thoát Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_NhanVien1 where MaNV ='" + txtMaNV.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_NHANVIEN();
			}
		}
	}
}
 