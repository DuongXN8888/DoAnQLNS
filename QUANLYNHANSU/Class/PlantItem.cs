using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QUANLYNHANSU.Class
{
	public class PlantItem
	{
		private DateTime date;
		private string job;

		public string Job
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

		public Point FormTime
		{
			get
			{
				return formTime;
			}

			set
			{
				formTime = value;
			}
		}

		public Point ToTime
		{
			get
			{
				return toTime;
			}

			set
			{
				toTime = value;
			}
		}

		public string Startus
		{
			get
			{
				return startus;
			}

			set
			{
				startus = value;
			}
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

		private Point formTime;
		private Point toTime;
		private string startus;
		public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };
	}
	public enum EPlatlItem{
		DONE,
		DOING,
		COMING,
		MISSED
	}
}
