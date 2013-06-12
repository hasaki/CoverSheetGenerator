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

		public CoverSheetReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
			var txt = cityStateZip.Text;
		}
	}
}
