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
	public partial class FrmTo : Form
	{
		public FrmTo()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		public void BANG_TO()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DanhMucTo order by MaTo");
			dgvTo.DataSource = dta;
		}
		public void HTTT()
		{
			txtMaTo.DataBindings.Clear();
			txtMaTo.DataBindings.Add("Text", dgvTo.DataSource, "MaTo");
			cboMaPhong.DataBindings.Clear();
			cboMaPhong.DataBindings.Add("Text", dgvTo.DataSource, "MaPhong");
			txtTenTo.DataBindings.Clear();
			txtTenTo.DataBindings.Add("Text", dgvTo.DataSource, "TenTo");
			}
		public void BANG_PHONGBAN()
		{
			DataTable dta2 = new DataTable();
			dta2 = kn.Lay_DulieuBang("Select*FROM Tbl_PhongBan order by MaPhong");
			cboMaPhong.DataSource = dta2;
			cboMaPhong.DisplayMember = "MaPhong";
		}

		private void FrmTo_Load(object sender, EventArgs e)
		{
			BANG_TO();
			BANG_PHONGBAN();
		}

		private void dgvTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HTTT();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtMaTo.Text = "";
			cboMaPhong.Text = "";
			txtTenTo.Text = "";
			txtMaTo.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaTo from Tbl_DanhMucTo where MaPhong= '" + txtMaTo.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Tổ Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaTo.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DanhMucTo Values('" + txtMaTo.Text + "','" + cboMaPhong.Text + "','" + txtTenTo.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_TO();
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DanhMucTo Set TenTo='" + txtTenTo.Text + "',";
			SQL_Sua = SQL_Sua + "MaPhong ='" + cboMaPhong.Text + "'where MaTo='" + txtMaTo.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_TO();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DanhMucTo where MaTo ='" + txtMaTo.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_TO();
			}
		}
	}
}
