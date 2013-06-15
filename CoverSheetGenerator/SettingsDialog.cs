using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoverSheetGenerator
{
	public partial class SettingsDialog : Form
	{
		public SettingsDialog()
		{
			InitializeComponent();
		}

		private void generate_Click(object sender, EventArgs e)
		{
			var data = GenerateSheetData();

			var sheet = new CoverSheetReport();
			sheet.DataSource = data;
			sheet.Run();

			using (var dlg = new ViewerForm(sheet))
			{
				dlg.ShowDialog();
			}
		}

		private List<CoverSheetData> GenerateSheetData()
		{
			var sheetData = new List<CoverSheetData>();

			foreach (CoverSheetJobListViewItem item in _jobsList.Items)
			{
				sheetData.AddRange(item.Job.GetData());
			}

			return sheetData;
		}

		private void addJob_Click(object sender, EventArgs e)
		{
			var job = CreateJobFromData();

			var item = new CoverSheetJobListViewItem(job);
			_jobsList.Items.Add(item);
		}

		private CoverSheetJob CreateJobFromData()
		{
			var job = new CoverSheetJob();
			job.City = _city.Text;
			job.State = _state.Text;
			job.Zip = _zip.Text;
			job.JobName = _jobName.Text;
			job.Route = _route.Text;
			job.Total = Convert.ToInt32(_total.Text);
			job.BundleSize = Convert.ToInt32(_bundleSize.Text);
			return job;
		}

		private void _jobsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			removeJob.Enabled = _jobsList.SelectedItems.Count > 0;
		}

		private void removeJob_Click(object sender, EventArgs e)
		{
			while (_jobsList.SelectedItems.Count > 0)
			{
				var item = (CoverSheetJobListViewItem) _jobsList.SelectedItems[0];

				item.Remove();
			}
		}
	}
}
