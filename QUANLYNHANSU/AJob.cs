using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYNHANSU.Class;

namespace QUANLYNHANSU
{
	public partial class AJob : UserControl
	{
		private PlantItem job;
		public AJob(PlantItem job)
		{
			InitializeComponent();
			cboStatus.DataSource = PlantItem.ListStatus;
			this.job = job;
			ShowInFo();
		}
		void ShowInFo()
		{
			txtJob.Text = Job.Job;
			nmFormHours.Value = Job.FormTime.X;
			nmFormMin.Value = Job.FormTime.Y;
			nmToHours.Value = Job.ToTime.X;
			nmToMin.Value = Job.ToTime.Y;
			cboStatus.SelectedIndex = PlantItem.ListStatus.IndexOf(Job.Startus);
			chkDone.Checked = PlantItem.ListStatus.IndexOf(Job.Startus)==(int)EPlatlItem.DONE ? true :false;
		}

		public PlantItem Job
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

		private void AJob_Load(object sender, EventArgs e)
		{

		}
		private event EventHandler edited;
		public event EventHandler Edited
		{
			add
			{
				edited += value;
			}
			remove
			{
				edited -= value;
			}
		}
		private event EventHandler deleted;
		public event EventHandler Deleted
		{
			add
			{
				deleted += value;
			}
			remove
			{
				deleted -= value;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (deleted != null)
				deleted(this, new EventArgs());
			
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Job.Job = txtJob.Text;
			Job.FormTime = new Point((int)nmFormHours.Value, (int)nmFormMin.Value);
			Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMin.Value);
			//	Job.Startus = cboStatus.SelectedItem.ToString();
			Job.Startus = PlantItem.ListStatus[cboStatus.SelectedIndex];
			if (edited != null)
				edited(this, new EventArgs());
		}

		private void chkDone_CheckedChanged(object sender, EventArgs e)
		{
			cboStatus.SelectedIndex = chkDone.Checked ? (int)EPlatlItem.DONE : (int)EPlatlItem.DOING;
		}
	}
}
