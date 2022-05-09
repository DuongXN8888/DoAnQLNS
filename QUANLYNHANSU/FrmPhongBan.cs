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
	public partial class FrmPhongBan : Form
	{
		public FrmPhongBan()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		public void BANG_PHONGBAN()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_PhongBan");
			dgvPhongBan.DataSource = dta;
		}
		public void HTTT()
		{
			txtMaPhong.DataBindings.Clear();
			txtMaPhong.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaPhong");
			txtTenPhong.DataBindings.Clear();
			txtTenPhong.DataBindings.Add("Text", dgvPhongBan.DataSource, "TenPhong");
			txtDienThoai.DataBindings.Clear();
			txtDienThoai.DataBindings.Add("Text", dgvPhongBan.DataSource, "DienThoai");
		}

		private void FrmPhongBan_Load(object sender, EventArgs e)
		{
			BANG_PHONGBAN();
		}

		private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaPhong.Text = "";
			txtTenPhong.Text = "";
			txtDienThoai.Text = "";
			txtMaPhong.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaPhong from Tbl_PhongBan where MaPhong= '" + txtMaPhong.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Phòng Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaPhong.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_PhongBan Values('" + txtMaPhong.Text + "','" + txtTenPhong.Text + "','" + txtDienThoai.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_PHONGBAN();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_PhongBan Set TenPhong='" + txtTenPhong.Text + "',";
			SQL_Sua = SQL_Sua + "DienThoai ='" + txtDienThoai.Text + "'where MaPhong='" + txtMaPhong.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_PHONGBAN();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_PhongBan where MaPhong ='" + txtMaPhong.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_PHONGBAN();
			}
		}
	}
}
