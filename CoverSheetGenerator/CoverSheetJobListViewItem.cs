using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoverSheetGenerator
{
	class CoverSheetJobListViewItem : ListViewItem
	{
		public CoverSheetJobListViewItem(CoverSheetJob job)
		{
			Job = job; 
			UpdateBindings();
		}

		public CoverSheetJob Job { get; private set; }

		private void UpdateBindings()
		{
			if (SubItems.Count == 1)
			{
				Text = Job.CityStateZip;
				SubItems.Add(Job.Route);
				SubItems.Add(Job.JobName);
				SubItems.Add(Job.TotalBundleSize);
			}
			else
			{
				SubItems[0].Text = Job.CityStateZip;
				SubItems[1].Text = Job.Route;
				SubItems[2].Text = Job.JobName;
				SubItems[3].Text = Job.TotalBundleSize;
			}
		}
	}
}
