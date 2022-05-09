using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYNHANSU.Class
{
	[Serializable]
	public class PlantlData
	{
		
		private List<PlantItem> job;

		public List<PlantItem> Job
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
	}
}
