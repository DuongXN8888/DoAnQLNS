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
	public partial class FrmKhenThuongKyLuat : Form
	{
		public FrmKhenThuongKyLuat()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();
		private void BANG_DMKHENTHUONGKYLUAT()
		{
			DataTable dta = new DataTable();
			dta = kn.Lay_DulieuBang("Select*FROM Tbl_DMKhenThuongKyLuat ");
			dgvDMKTKL.DataSource = dta;
		}
		private void HIENTHI()
		{
			txtMaLoai.DataBindings.Clear();
			txtMaLoai.DataBindings.Add("Text", dgvDMKTKL.DataSource, "MaLoai");
			txtTenLoai.DataBindings.Clear();
			txtTenLoai.DataBindings.Add("Text", dgvDMKTKL.DataSource, "TenLoai");
		}

		private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
		{
			BANG_DMKHENTHUONGKYLUAT();
		}


		private void btnThoat1_Click_1(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes) this.Close();
		}

		private void dgvDMKTKL_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			HIENTHI();
		}

		private void btnThem1_Click(object sender, EventArgs e)
		{
			txtMaLoai.Text = "";
			txtTenLoai.Text = "";
			txtMaLoai.Focus();
		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void btnLuu1_Click(object sender, EventArgs e)
		{
			string strkra = "Select MaLoai from Tbl_DMKhenThuongKyLuat where MaLoai= '" + txtMaLoai.Text + "'";
			SqlCommand cmd = new SqlCommand(strkra, kn.cnn);
			SqlDataReader doc_dl = cmd.ExecuteReader();
			if (doc_dl.Read() == true)
			{
				MessageBox.Show("Mã Loại Này Đã Tồn Tại!,Vui Lòng Nhập Lại Mã Khác", "Thông Báo");
				txtMaLoai.Focus();
				doc_dl.Close();
				doc_dl.Dispose();
			}
			else
			{
				string sql_luu;
				sql_luu = "Insert into Tbl_DMKhenThuongKyLuat Values('" + txtMaLoai.Text + "','" + txtTenLoai.Text + "')";
				kn.ThucThi(sql_luu);
				BANG_DMKHENTHUONGKYLUAT();
			}
		}

		private void btnSua1_Click(object sender, EventArgs e)
		{
			string SQL_Sua;
			SQL_Sua = "Update Tbl_DMKhenThuongKyLuat Set TenLoai ='" + txtTenLoai.Text + "'where MaLoai='" + txtMaLoai.Text + "'";
			kn.ThucThi(SQL_Sua);
			BANG_DMKHENTHUONGKYLUAT();
		}

		private void btnXoa1_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes)
			{
				string SQL_xoa;
				SQL_xoa = "Delete Tbl_DMKhenThuongKyLuat where MaLoai ='" + txtMaLoai.Text + "'";
				kn.ThucThi(SQL_xoa);
				BANG_DMKHENTHUONGKYLUAT();
			}
		}
	}
}
