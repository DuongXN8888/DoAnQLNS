using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QUANLYNHANSU.Reports;

namespace QUANLYNHANSU
{
	public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public FrmMain()
		{
			InitializeComponent();
		}
		void OpenForm(Type typeform)
		{
			foreach (Form frm in MdiChildren)
			{
				if (frm.GetType() == typeform)
				{
					frm.Activate();
					return; ;
				}
			}
			Form f = (Form)Activator.CreateInstance(typeform);
			f.MdiParent = this;
			f.Show();
		}

		private void BtnTTPM_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmThongTin));
		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmChiTietChuyenMon));
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{

		}

		private void BtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
		{
			DialogResult thongbao;
			thongbao = MessageBox.Show("Bạn Có Muốn Đăng Xuất Khỏi Phần Mềm Không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (thongbao == DialogResult.Yes) this.Close();
		}

		private void BtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmDoiMatKhau));
		}

		private void BtnTCTT_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmTraCuuTT));
		}

		private void BtnLichLamViec_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmLichLamViec));
		}

		private void BtnCTHD_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmChiTietHopDong));
		}

		private void BtnCTNN_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmChiTietNgoaiNgu));
		}

		private void BtnCTKTKL_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmCTKhenThuongKyLuat));
		}

		private void BtnSKNV_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmSucKhoeNhanVien));
		}

		private void BtnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmTonGiao));
		}

		private void BtnDanToc_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmDanToc));
		}

		private void BtnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmTrinhDo));
		}

		private void BtnChuyenMon_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmChuyenMon));
		}

		private void BtnNgoaiNgu_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmNgoaiNgu));
		}

		private void BtnChucVu_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmChucVu));
		}

		private void BtnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmPhongBan));
		}

		private void BtnTo_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmTo));
		}

		private void BtnLoaiHopDong_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmLoaiHopDong));
		}

		private void BtnKTKL_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmKhenThuongKyLuat));
		}

		private void BtnLLNV_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmNhanVien));
		}

		private void BtnTiLeLuong_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmDMHieuQua));
		}

		private void BtnLuongTheoPhong_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmBangTiLeLuong));
		}

		private void BtnBangLuong_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmBangLuong));
		}

		private void BtnBCNV_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmReportNhanVien));
		}

		private void BtnBCSucKhoe_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmReportSucKhoe));
		}

		private void BtnBCHDHH_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmReportHDHH));
		}

		private void BtnLuong_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmReportLuong));
		}

		private void BtnBCBH_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenForm(typeof(FrmReportBaoHiem));
		}
	}
}