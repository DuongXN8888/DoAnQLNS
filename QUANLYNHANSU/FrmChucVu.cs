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
	public partial class FrmChucVu : Form
	{
		public FrmChucVu()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		public void BANG_CHUCVU()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMChucVu");
			dgvChucVu.DataSource = dta;
		}
		public void HTTT()
		{
			txtMaChucVu.DataBindings.Clear();
			txtMaChucVu.DataBindings.Add("Text", dgvChucVu.DataSource, "MaChucVu");
			txtTenChucVu.DataBindings.Clear();
			txtTenChucVu.DataBindings.Add("Text", dgvChucVu.DataSource, "TenChucVu");
			txtPhuCap.DataBindings.Clear();
			txtPhuCap.DataBindings.Add("Text", dgvChucVu.DataSource, "PhuCap");
		}
		private void FrmChucVu_Load(object sender, EventArgs e)
		{
			BANG_CHUCVU();
		}

		private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaChucVu.Text = "";
			txtTenChucVu.Text = "";
			txtPhuCap.Text = "";
			txtMaChucVu.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaChucVu from Tbl_DMChucVu where MaChucVu= '" + txtMaChucVu.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Chức Vụ Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaChucVu.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMChucVu Values('" + txtMaChucVu.Text + "','" + txtTenChucVu.Text + "','" + txtPhuCap.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_CHUCVU();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMChucVu Set TenChucVu='" + txtTenChucVu.Text + "',";
			SQL_Sua = SQL_Sua + "PhuCap ='" + txtPhuCap.Text + "'where MaChucVu='" + txtMaChucVu.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CHUCVU();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMChucVu where MaChucVu ='" + txtMaChucVu.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_CHUCVU();
			}
		}
	}
}
