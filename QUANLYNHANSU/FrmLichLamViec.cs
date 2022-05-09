using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYNHANSU.Class;
using System.IO;
using System.Xml.Serialization;

namespace QUANLYNHANSU
{
	public partial class FrmLichLamViec : Form
	{
		#region Peoperties
		//NotifyIcon notify;
		private int apptime;
		private string filePath = "data.xml";
		private List<List<Button>> matrix;
		public List<List<Button>> Matrix
		{
			get { return matrix; }
			set { matrix = value; }
		}

		public PlantlData Job
		{
			get
			{
				return job;
			}

			set
			{
				job = value;
			}
		}

		

		public int Apptime
		{
			get
			{
				return apptime;
			}

			set
			{
				apptime = value;
			}
		}

		private PlantlData job;
		private List<string> dateOfWeek = new List<string>{ "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" ,"Sunday"};
		
		#endregion

		public FrmLichLamViec()
		{
			InitializeComponent();
			//Notify = new NotifyIcon();
			TimeNotyfi.Start();
			apptime = 0;
			LoadMatrix();
			try
			{
				Job =  DeserializeFromXML(filePath) as PlantlData;
			}
			catch
			{
				SetDeFaultJob();
			}
			
		}
		void SetDeFaultJob()
		{
			Job = new PlantlData();
			Job.Job = new List<PlantItem>();
			Job.Job.Add(new PlantItem() {
				Date = DateTime.Now,
				FormTime = new Point(4, 0),
				ToTime = new Point(5, 0),
				Job = "Thử Nghiệm Thôi",
				Startus = PlantItem.ListStatus[(int)EPlatlItem.COMING],

			});
			Job.Job.Add(new PlantItem()
			{
				Date = DateTime.Now,
				FormTime = new Point(4, 0),
				ToTime = new Point(5, 0),
				Job = "Thử Nghiệm Thôi",
				Startus = PlantItem.ListStatus[(int)EPlatlItem.DONE],

			});
			Job.Job.Add(new PlantItem()
			{
				Date = DateTime.Now.AddDays(-1),
				FormTime = new Point(4, 0),
				ToTime = new Point(5, 0),
				Job = "Thử Nghiệm Thôi",
				Startus = PlantItem.ListStatus[(int)EPlatlItem.COMING],

			});
		}
		

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmLichLamViec_Load(object sender, EventArgs e)
		{

		}
		void LoadMatrix()
		{
			Matrix = new List<List<Button>>();
			Button oldButTon = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
			for(int i = 0; i<Cons.DayOfColum; i++)
			{
				Matrix.Add(new List<Button>());
				for (int y = 0; y < Cons.DayOfWeek; y++)
				{
					
					Button btn = new Button() { Width = Cons.dateButtonWidth,Height = Cons.dateButtonHieght};
					btn.Location = new Point(oldButTon.Location.X +oldButTon.Width + Cons.Margin, oldButTon.Location.Y);
					btn.Click += btn_Click;
					panaMatrix.Controls.Add(btn);
					oldButTon = btn;
					Matrix[i].Add(btn);
				}
				oldButTon = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, oldButTon.Location.Y+Cons.dateButtonHieght) };
			}
			SetDefautDate();
		}

		private  void btn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty((sender as Button).Text))
				return;
			FrmLichTrongNgay Lich = new FrmLichTrongNgay(new DateTime(dateDay.Value.Year,dateDay.Value.Month,Convert.ToInt32((sender as Button).Text)),Job);
			Lich.ShowDialog();
		}

		int DayOfMonth(DateTime date)
		{
			switch (date.Month)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 12:
					return 31;
				case 2:
					if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
						return 29;
					else
						return 28;
					
				default:
					return 30; ;

			}
		}
		void AddnumberIntoMatrixByDate(DateTime date)
		{
			ClearMatrix();
			DateTime useDate = new DateTime(date.Year, date.Month, 1);
		//	int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
			int line = 0;
			for(int i = 1; i <= DayOfMonth(date); i++)
			{
				int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
				Button btn = Matrix[line][column];
				btn.Text = i.ToString();
				if (IsEqualDate(useDate, DateTime.Now))
				{
					btn.BackColor = Color.Blue;
				}
				if (IsEqualDate(useDate, date))
				{
					btn.BackColor = Color.Violet;
				}
				if (column >= 6)
				{
					line++;
				}
				useDate = useDate.AddDays(1);

			}
		}
		bool IsEqualDate(DateTime DayA , DateTime DayB)
		{
			return DayA.Year == DayB.Year && DayA.Month == DayB.Month && DayA.Day == DayB.Day;
		}
		void ClearMatrix()
		{
			for(int i = 0; i < Matrix.Count; i++)
			{
				for (int j = 0; j < Matrix[i].Count; j++)
				{
					Button btn = Matrix[i][j];
					btn.Text = "";
					btn.BackColor = Color.Turquoise;
				}
			}
		}
		void SetDefautDate()
		{
			dateDay.Value = DateTime.Now;
		}
		

		private void dateDay_ValueChanged(object sender, EventArgs e)
		{
			AddnumberIntoMatrixByDate((sender as DateTimePicker).Value);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			dateDay.Value = dateDay.Value.AddMonths(1);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			dateDay.Value = dateDay.Value.AddMonths(-1);
		}

		private void btnToDay_Click(object sender, EventArgs e)
		{
			SetDefautDate();
		}
		private void SerializeToXML(object data,string filePath)
		{
			FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

			XmlSerializer sr = new XmlSerializer(typeof(PlantlData));
			sr.Serialize(fs, data);
			fs.Close();
		}
		private object DeserializeFromXML(string filePath)
		{
			FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				XmlSerializer sr = new XmlSerializer(typeof(PlantlData));
				object result = sr.Deserialize(fs);
				fs.Close();
				return result;
			}
			catch(Exception e)
			{
				fs.Close();
				throw new NotImplementedException();
			}
			
			
		}

		private void FrmLichLamViec_FormClosing(object sender, FormClosingEventArgs e)
		{
			SerializeToXML(Job, filePath);
		}

		private void TimeNotyfi_Tick(object sender, EventArgs e)
		{
			if (!chkNoTyFi.Checked)
				return;
			Apptime++;
			if (Apptime < Cons.Notifytime)
				return;
			if (Job == null || Job.Job == null)
				return;
			
			DateTime currentDate = DateTime.Now;
			List<PlantItem> todayjobs = Job.Job.Where(p => p.Date.Year == currentDate.Year && p.Date.Month == currentDate.Month && p.Date.Day == currentDate.Day).ToList();
			Notify.ShowBalloonTip(Cons.notifyTimeOut, "Lịch Công Việc", string.Format("Bạn có {0} công việc trong ngày hôm nay", todayjobs.Count), ToolTipIcon.Info);
			Apptime = 0;
		}

		private void nmNotify_ValueChanged(object sender, EventArgs e)
		{
			Cons.Notifytime = (int)nmNotify.Value;
		}

		private void chkNoTyFi_CheckedChanged(object sender, EventArgs e)
		{
			nmNotify.Enabled = chkNoTyFi.Checked;
		}
	}
}
