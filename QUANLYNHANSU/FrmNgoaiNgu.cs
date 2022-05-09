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
	public partial class FrmNgoaiNgu : Form
	{
		public FrmNgoaiNgu()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();

		public void BANG_NGOAINGU()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMNgoaiNgu");
			dgvNgoaiNgu.DataSource = dta;
		}
		public void HTTT()
		{
			txtMaNgoaiNgu.DataBindings.Clear();
			txtMaNgoaiNgu.DataBindings.Add("Text",dgvNgoaiNgu.DataSource, "MaNgoaiNgu");
			txtTenNgoaiNgu.DataBindings.Clear();
			txtTenNgoaiNgu.DataBindings.Add("Text",dgvNgoaiNgu.DataSource, "TenNgoaiNgu");
		}

		private void FrmNgoaiNgu_Load(object sender, EventArgs e)
		{
			BANG_NGOAINGU();
		}

		private void dgvNgoaiNgu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaNgoaiNgu.Text = "";
			txtTenNgoaiNgu.Text = "";
			txtMaNgoaiNgu.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaNgoaiNgu from Tbl_DMNgoaiNgu where MaNgoaiNgu= '" + txtMaNgoaiNgu.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Ngoại Ngữ Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaNgoaiNgu.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMNgoaiNgu Values('" + txtMaNgoaiNgu.Text + "','" + txtTenNgoaiNgu.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_NGOAINGU();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMNgoaiNgu Set TenNgoaiNgu ='" + txtTenNgoaiNgu.Text + "'where MaNgoaiNgu='" + txtMaNgoaiNgu.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_NGOAINGU();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMNgoaiNgu where MaNgoaiNgu ='" + txtMaNgoaiNgu.Text+ "'";
				kn.ThucThi(SQL_xoa);
				BANG_NGOAINGU();
			}
		}
	}
}
