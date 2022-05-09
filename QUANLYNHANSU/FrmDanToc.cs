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
	public partial class FrmDanToc : Form
	{
		public FrmDanToc()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_DANTOC()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMDanToc");
			dgvDanToc.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaDanToc.DataBindings.Clear();
			txtMaDanToc.DataBindings.Add("Text", dgvDanToc.DataSource, "MaDT");
			txtTenDanToc.DataBindings.Clear();
			txtTenDanToc.DataBindings.Add("Text", dgvDanToc.DataSource, "TenDT");
		}

		private void FrmDanToc_Load(object sender, EventArgs e)
		{
			BANG_DANTOC();

		}

		private void dgvDanToc_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaDanToc.Text = "";
			txtTenDanToc.Text = "";
			txtMaDanToc.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaDT from Tbl_DMDanToc where MaDT= '" + txtMaDanToc.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Dân Tộc Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaDanToc.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMDanToc Values('" + txtMaDanToc.Text + "','" + txtTenDanToc.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_DANTOC();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMDanToc Set TenDT ='" + txtTenDanToc.Text + "'where MaDT='" + txtMaDanToc.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_DANTOC();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMDanToc where MaDT ='" + txtMaDanToc.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_DANTOC();
			}
		}
	}
}
