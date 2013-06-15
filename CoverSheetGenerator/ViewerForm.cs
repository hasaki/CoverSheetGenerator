using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;

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
			viewer1.Toolbar.ToolStrip.Items.Add("Export to PDF", Properties.Resources.PDFIcon, ExportToPdf);
			viewer1.LoadDocument(_report.Document);

			base.OnLoad(e);
		}

		private void ExportToPdf(object sender, EventArgs e)
		{
			string filename = "";

			using (var dlg = new SaveFileDialog())
			{
				dlg.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";

				if (dlg.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				filename = dlg.FileName;
			}

			var pdf = new PdfExport();
			viewer1.Export(pdf, new FileInfo(filename));
		}
	}
}
