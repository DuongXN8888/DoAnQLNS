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
	public partial class FrmLoaiHopDong : Form
	{
		public FrmLoaiHopDong()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_LOAIHOPDONG()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_LoaiHD");
			dgvLoaiHD.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaLoaiHD.DataBindings.Clear();
			txtMaLoaiHD.DataBindings.Add("Text", dgvLoaiHD.DataSource, "MaLoaiHD");
			txtTenLoaiHD.DataBindings.Clear();
			txtTenLoaiHD.DataBindings.Add("Text", dgvLoaiHD.DataSource, "TenLoaiHD");
		}

		private void btnThoatTK_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Chắc Chắn Muốn Hủy Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes) this.Close();
		}

		private void FrmLoaiHopDong_Load(object sender, EventArgs e)
		{
			BANG_LOAIHOPDONG();
		}

		private void dgvLoaiHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaLoaiHD.Text = "";
			txtTenLoaiHD.Text = "";
			txtMaLoaiHD.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaLoaiHD from Tbl_LoaiHD where MaLoaiHD= '" + txtMaLoaiHD.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Loại Hợp Đồng Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaLoaiHD.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_LoaiHD Values('" + txtMaLoaiHD.Text + "','" + txtTenLoaiHD.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_LOAIHOPDONG();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_LoaiHD Set TenLoaiHD ='" + txtTenLoaiHD.Text + "'where MaLoaiHD='" + txtMaLoaiHD.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_LOAIHOPDONG();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_LoaiHD where MaLoaiHD ='" + txtMaLoaiHD.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_LOAIHOPDONG();
			}
		}

		private void btnTKHD_Click(object sender, EventArgs e)
		{
			DataTable dta = new DataTable();
			string sqltk = "Select * from Tbl_LoaiHD where MaLoaiHD = '" + txtTimKiemMaHD.Text + "'";
			dta = kn.Lay_DulieuBang(sqltk);
			dgvTKLoaiHD.DataSource = dta;
		}

		private void txtTenLoaiHD_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void txtMaLoaiHD_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
