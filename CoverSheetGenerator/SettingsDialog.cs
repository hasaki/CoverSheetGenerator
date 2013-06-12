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

			var bundleSize = Convert.ToInt32(_bundleSize.Text);
			var total = Convert.ToInt32(_total.Text);

			var remaining = total;
			while (remaining > 0)
			{
				var data = new CoverSheetData()
					{
						City = _city.Text,
						State = _state.Text,
						Zip = _zip.Text,
						JobName = _jobName.Text,
						Route = _route.Text,
						Total = total
					};

				var numInBundle = 0;

				if (remaining > bundleSize + 15)
				{
					numInBundle = bundleSize;
				}
				else
				{
					numInBundle = remaining;
				}

				remaining -= numInBundle;

				data.NumInBundle = numInBundle;

				sheetData.Add(data);
			}

			return sheetData;
		}
	}
}
