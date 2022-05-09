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
	public partial class FrmChuyenMon : Form
	{
		public FrmChuyenMon()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_CHUYENMON()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMChuyenMon");
			dgvChuyenMon.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaChuyenMon.DataBindings.Clear();
			txtMaChuyenMon.DataBindings.Add("Text", dgvChuyenMon.DataSource, "MaChuyenMon");
			txtTenChuyenMon.DataBindings.Clear();
			txtTenChuyenMon.DataBindings.Add("Text", dgvChuyenMon.DataSource, "TenChuyenMon");
		}


		private void FrmChuyenMon_Load(object sender, EventArgs e)
		{
			BANG_CHUYENMON();

		}

		private void dgvChuyenMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaChuyenMon.Text = "";
			txtTenChuyenMon.Text = "";
			txtMaChuyenMon.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaChuyenMon from Tbl_DMChuyenMon where MaChuyenMon= '" + txtMaChuyenMon.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Chuyên Môn Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaChuyenMon.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMChuyenMon Values('" + txtMaChuyenMon.Text + "','" + txtTenChuyenMon.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_CHUYENMON();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMChuyenMon Set TenChuyenMon ='" + txtTenChuyenMon.Text + "'where MaChuyenMon='" + txtMaChuyenMon.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_CHUYENMON();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMChuyenMon where MaChuyenMon ='" + txtMaChuyenMon.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_CHUYENMON();
			}
		}
	}
}
