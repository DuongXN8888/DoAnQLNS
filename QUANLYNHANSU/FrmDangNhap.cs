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
	public partial class FrmDangNhap : Form
	{
		public FrmDangNhap()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Chắc Chắn Muốn Hủy Đăng Nhập Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes) this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			kn.KetNoi_Dulieu();
			string DN = txtTenDN.Text;
			string MK = txtMatKhau.Text;
			string SQL_Login = "Select ID , pass From TBL_USER where ID ='" + DN + "' and PASS = '" + MK + "'";
			SqlCommand cmd = new SqlCommand(SQL_Login, kn.cnn);
			SqlDataReader datRed = cmd.ExecuteReader();
			if (datRed.Read() == true)
			{
				MessageBox.Show("Bạn Đã Đăng Nhập Thành Công");
				Form FrmMDI = new FrmMain();
				FrmMDI.Show();
				Hide();
			}
			else
			{
				MessageBox.Show("Hãy Kiểm Tra Lại Thông Tin Đăng Nhập");
				txtTenDN.Focus();
			}
		}

		private void FrmDangNhap_Load(object sender, EventArgs e)
		{

		}
	}
}

