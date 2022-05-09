using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QUANLYNHANSU.Reports
{
	public partial class FrmReportLuong : DevExpress.XtraEditors.XtraForm
	{
		public FrmReportLuong()
		{
			InitializeComponent();
		}

		private void documentViewer1_Load(object sender, EventArgs e)
		{
			var xrp = new ReportLuong();
			xrp.CreateDocument();
			documentViewer1.PrintingSystem = xrp.PrintingSystem;
		}
	}
}