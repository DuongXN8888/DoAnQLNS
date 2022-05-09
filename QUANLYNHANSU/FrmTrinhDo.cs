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
	public partial class FrmTrinhDo : Form
	{
		public FrmTrinhDo()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_TRINHDO()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMTrinhDo");
			dgvTrinhDo.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaTrinhDo.DataBindings.Clear();
			txtMaTrinhDo.DataBindings.Add("Text", dgvTrinhDo.DataSource, "MaTrinhDo");
			txtTenTrinhDo.DataBindings.Clear();
			txtTenTrinhDo.DataBindings.Add("Text", dgvTrinhDo.DataSource, "TenTrinhDo");
		}


		private void FrmTrinhDo_Load(object sender, EventArgs e)
		{
			BANG_TRINHDO();
		}

		private void dgvTrinhDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaTrinhDo.Text = "";
			txtTenTrinhDo.Text = "";
			txtMaTrinhDo.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaTrinhDo from Tbl_DMTrinhDo where MaTrinhDo= '" + txtMaTrinhDo.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Loại Hợp Đồng Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaTrinhDo.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMTrinhDo Values('" + txtMaTrinhDo.Text + "','" + txtTenTrinhDo.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_TRINHDO();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMTrinhDo Set TenTrinhDo ='" + txtTenTrinhDo.Text + "'where MaTrinhDo='" + txtMaTrinhDo.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_TRINHDO();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMTrinhDo where MaTrinhDo ='" + txtMaTrinhDo.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_TRINHDO();
			}
		}
	}
}
