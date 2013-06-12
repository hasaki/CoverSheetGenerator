using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrapeCity.ActiveReports;

namespace CoverSheetGenerator
{
	public partial class ViewerForm : Form
	{
		private readonly SectionReport _report;

		public ViewerForm(SectionReport report)
		{
			InitializeComponent();

			_report = report;
		}

		protected override void OnLoad(EventArgs e)
		{
			viewer1.LoadDocument(_report.Document);

			base.OnLoad(e);
		}
	}
}
