using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoverSheetGenerator
{
	/// <summary>
	/// Summary description for CoverSheetReport.
	/// </summary>
	public partial class CoverSheetReport : GrapeCity.ActiveReports.SectionReport
	{
		private int count;

		public CoverSheetReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
			count = (count + 1) % 3;
			var txt = cityStateZip.Text;
			line1.Visible = (count) != 0;
		}

		private void CoverSheetReport_PageStart(object sender, EventArgs e)
		{
			line1.Visible = false;
		}

		private void CoverSheetReport_PageEnd(object sender, EventArgs e)
		{
			line1.Visible = false;
		}
	}
}
