using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
	public partial class FrmDoiMatKhau : Form
	{
		public FrmDoiMatKhau()
		{
			InitializeComponent();
		}
		KetNoi kn = new KetNoi();

		private void btnThem_Click(object sender, EventArgs e)
		{
			string update = "update TBL_USER set pass='" + txtMatKhauMoi.Text + "' where(ID=N'" + txtTen.Text + "' and pass='" + txtMatKhauCu.Text + "')";
			string ten = txtTen.Text;
			if (ten == "")
			{
				MessageBox.Show("Bạn chưa nhập tên truy cập");
			}
			else
			{
				if (txtMatKhauCu.Text == "")
				{
					MessageBox.Show("Bạn chưa nhập mật khẩu");
				}
				else
				{
					if (txtMatKhauMoi.Text == "")
					{
						MessageBox.Show("Bạn chưa nhập mật khẩu mới");
					}
					else
					{
						if (txtNhapLaiMatKhauMoi.Text == "")
						{
							MessageBox.Show("Bạn chưa nhập lại mật khẩu");
						}
						else
						{
							if (txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
							{
								kn.ThucThi(update);
								MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
								this.Close();
							}
							else
							{
								MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
							}
						}
					}
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Chắc Chắn Muốn Hủy Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes) this.Close();
		}
	}
	}

