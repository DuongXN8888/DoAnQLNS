using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYNHANSU.Class;

namespace QUANLYNHANSU
{
	public partial class FrmLichTrongNgay : Form
	{
		private DateTime date;
		public FrmLichTrongNgay(DateTime date, PlantlData job)
		{
			InitializeComponent();
			this.Date = date;
			this.Job = job;

			fPanel.Width = panJob.Width;
			fPanel.Height = panJob.Height;
			panJob.Controls.Add(fPanel);

			dateDay.Value = Date;

		}
		public DateTime Date
		{
			get
			{
				return date;
			}

			set
			{
				date = value;
			}
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
		

		FlowLayoutPanel fPanel = new FlowLayoutPanel();

		private PlantlData job;

		private void FrmLichTrongNgay_Load(object sender, EventArgs e)
		{

		}
		void ShowjobByDay(DateTime date)
		{
			fPanel.Controls.Clear();
			if (Job != null && Job.Job != null)
			{
				List<PlantItem> toDayjob = GetJobByDay(date);
				for (int i = 0; i < toDayjob.Count; i++)
				{
					AddJob(toDayjob[i]);
					
				}
			}
		}
		void AddJob(PlantItem job)
		{
			AJob aJob = new AJob(job);
			aJob.Edited += AJob_Edited;
			aJob.Deleted += AJob_Deleted;
			fPanel.Controls.Add(aJob);
		}
		private void AJob_Edited(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
		}

		private void AJob_Deleted(object sender, EventArgs e)
		{
			AJob uc = sender as AJob;
			PlantItem job = uc.Job;
			fPanel.Controls.Remove(uc);
			Job.Job.Remove(job);
		}

		List<PlantItem> GetJobByDay(DateTime date)
		{
			return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
		}

		private void dateDay_ValueChanged(object sender, EventArgs e)
		{
			ShowjobByDay((sender as DateTimePicker).Value);
		}

		private void btnNextDay_Click(object sender, EventArgs e)
		{
			dateDay.Value = dateDay.Value.AddDays(1);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			dateDay.Value = dateDay.Value.AddDays(-1);
		}

		private void MnuThemViec_Click(object sender, EventArgs e)
		{
			PlantItem item = new PlantItem() { Date = dateDay.Value };
			Job.Job.Add(item);
			AddJob(item);
		}

		private void MnuHomNay_Click(object sender, EventArgs e)
		{
			dateDay.Value = DateTime.Now;
		}
	}
}
