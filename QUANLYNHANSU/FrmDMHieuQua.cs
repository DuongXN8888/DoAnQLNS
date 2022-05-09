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
	public partial class FrmDMHieuQua : Form
	{
		public FrmDMHieuQua()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_HIEUQUA()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_HIeuQua");
			dgvDanhMucHQ.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaHieuQua.DataBindings.Clear();
			txtMaHieuQua.DataBindings.Add("Text", dgvDanhMucHQ.DataSource, "MaHieuQua");
			txtPhuCap.DataBindings.Clear();
			txtPhuCap.DataBindings.Add("Text", dgvDanhMucHQ.DataSource, "PhuCap");
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_HIeuQua where MaHieuQua ='" + txtMaHieuQua.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_HIEUQUA();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaHieuQua.Text = "";
			txtPhuCap.Text = "";
			txtMaHieuQua.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaHieuQua from Tbl_HIeuQua where MaHieuQua= '" + txtMaHieuQua.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Hiệu Qủa Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaHieuQua.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_HIeuQua Values('" + txtMaHieuQua.Text + "','" + txtPhuCap.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_HIEUQUA();
			}
		}

		private void dgvDanhMucHQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void FrmDMHieuQua_Load(object sender, EventArgs e)
		{
			BANG_HIEUQUA();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_HIeuQua Set PhuCap ='" + txtPhuCap.Text + "'where MaHieuQua='" + txtMaHieuQua.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_HIEUQUA();
		}
	}
}
