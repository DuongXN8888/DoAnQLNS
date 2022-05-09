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
	public partial class FrmReportBaoHiem : DevExpress.XtraEditors.XtraForm
	{
		public FrmReportBaoHiem()
		{
			InitializeComponent();
		}
		
		private void documentViewer1_Load(object sender, EventArgs e)
		{
			var xrp = new ReportBaoHiem();
			xrp.CreateDocument();
			documentViewer1.PrintingSystem = xrp.PrintingSystem;
		}
	}
}