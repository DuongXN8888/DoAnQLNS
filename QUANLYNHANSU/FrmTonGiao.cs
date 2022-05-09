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
	public partial class FrmTonGiao : Form
	{
		public FrmTonGiao()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_TONGIAO()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMTonGiao");
			dgvTonGiao.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaTonGiao.DataBindings.Clear();
			txtMaTonGiao.DataBindings.Add("Text", dgvTonGiao.DataSource, "MaTG");
			txtTenTonGiao.DataBindings.Clear();
			txtTenTonGiao.DataBindings.Add("Text", dgvTonGiao.DataSource, "TenTG");
		}

		private void FrmTonGiao_Load(object sender, EventArgs e)
		{
			BANG_TONGIAO();
		}

		private void dgvTonGiao_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaTonGiao.Text = "";
			txtTenTonGiao.Text = "";
			txtMaTonGiao.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaTG from Tbl_DMTonGiao where MaTG= '" + txtMaTonGiao.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Tôn Giáo Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaTonGiao.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMTonGiao Values('" + txtMaTonGiao.Text + "','" + txtTenTonGiao.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_TONGIAO();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMTonGiao Set TenTG ='" + txtTenTonGiao.Text + "'where MaTG='" + txtMaTonGiao.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_TONGIAO();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMTonGiao where MaTG ='" + txtMaTonGiao.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_TONGIAO();
			}
		}

		private void lblMaTonGiao_Click(object sender, EventArgs e)
		{

		}
	}
}
