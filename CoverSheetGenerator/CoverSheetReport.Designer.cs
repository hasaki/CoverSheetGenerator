namespace CoverSheetGenerator
{
	/// <summary>
	/// Summary description for CoverSheetReport.
	/// </summary>
	partial class CoverSheetReport
	{
		private GrapeCity.ActiveReports.SectionReportModel.Detail detail;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}

		#region ActiveReport Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CoverSheetReport));
			this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.classification = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.cityStateZip = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.route = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.numInBundle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.totalPapers = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.jobName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			((System.ComponentModel.ISupportInitialize)(this.classification)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityStateZip)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.route)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numInBundle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.totalPapers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jobName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// detail
			// 
			this.detail.CanGrow = false;
			this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.classification,
            this.cityStateZip,
            this.route,
            this.numInBundle,
            this.totalPapers,
            this.jobName,
            this.line1});
			this.detail.Height = 3.5F;
			this.detail.KeepTogether = true;
			this.detail.Name = "detail";
			this.detail.Format += new System.EventHandler(this.detail_Format);
			// 
			// classification
			// 
			this.classification.ClassName = "Heading1";
			this.classification.Height = 0.5F;
			this.classification.HyperLink = null;
			this.classification.Left = 0F;
			this.classification.Name = "classification";
			this.classification.ShrinkToFit = true;
			this.classification.Style = "font-family: Arial; vertical-align: middle; ddo-char-set: 1; ddo-shrink-to-fit: t" +
    "rue";
			this.classification.Text = "ECR/WSS";
			this.classification.Top = 0.2500002F;
			this.classification.Width = 2.25F;
			// 
			// cityStateZip
			// 
			this.cityStateZip.CanGrow = false;
			this.cityStateZip.ClassName = "Heading1";
			this.cityStateZip.DataField = "CityStateZip";
			this.cityStateZip.Height = 0.5F;
			this.cityStateZip.Left = 0F;
			this.cityStateZip.Name = "cityStateZip";
			this.cityStateZip.ShrinkToFit = true;
			this.cityStateZip.Style = "font-family: Arial; text-align: center; vertical-align: middle; ddo-char-set: 1; " +
    "ddo-shrink-to-fit: true";
			this.cityStateZip.Text = "CITY STATE ZIP";
			this.cityStateZip.Top = 0.7500002F;
			this.cityStateZip.Width = 6.5F;
			// 
			// route
			// 
			this.route.CanGrow = false;
			this.route.ClassName = "Heading1";
			this.route.DataField = "Route";
			this.route.Height = 0.5F;
			this.route.Left = 0F;
			this.route.Name = "route";
			this.route.ShrinkToFit = true;
			this.route.Style = "font-family: Arial; text-align: center; vertical-align: middle; ddo-char-set: 1; " +
    "ddo-shrink-to-fit: true";
			this.route.Text = "Route";
			this.route.Top = 1.375F;
			this.route.Width = 6.5F;
			// 
			// numInBundle
			// 
			this.numInBundle.CanGrow = false;
			this.numInBundle.ClassName = "Heading1";
			this.numInBundle.DataField = "NumInBundle";
			this.numInBundle.Height = 0.5F;
			this.numInBundle.Left = 0F;
			this.numInBundle.Name = "numInBundle";
			this.numInBundle.ShrinkToFit = true;
			this.numInBundle.Style = "font-family: Arial; text-align: center; vertical-align: middle; ddo-char-set: 1; " +
    "ddo-shrink-to-fit: true";
			this.numInBundle.Text = "NumInBundle";
			this.numInBundle.Top = 2.062F;
			this.numInBundle.Width = 6.5F;
			// 
			// totalPapers
			// 
			this.totalPapers.CanGrow = false;
			this.totalPapers.ClassName = "Heading1";
			this.totalPapers.DataField = "Total";
			this.totalPapers.Height = 0.5F;
			this.totalPapers.Left = 3.937F;
			this.totalPapers.Name = "totalPapers";
			this.totalPapers.ShrinkToFit = true;
			this.totalPapers.Style = "font-family: Arial; text-align: right; vertical-align: middle; ddo-char-set: 1; d" +
    "do-shrink-to-fit: true";
			this.totalPapers.Text = "Total Papers";
			this.totalPapers.Top = 0.2500002F;
			this.totalPapers.Width = 2.563F;
			// 
			// jobName
			// 
			this.jobName.CanGrow = false;
			this.jobName.ClassName = "Heading1";
			this.jobName.DataField = "JobName";
			this.jobName.Height = 0.5F;
			this.jobName.Left = 0F;
			this.jobName.Name = "jobName";
			this.jobName.ShrinkToFit = true;
			this.jobName.Style = "font-family: Arial; vertical-align: middle; ddo-char-set: 1; ddo-shrink-to-fit: t" +
    "rue";
			this.jobName.Text = "Job Name";
			this.jobName.Top = 2.75F;
			this.jobName.Width = 6.5F;
			// 
			// line1
			// 
			this.line1.Height = 0F;
			this.line1.Left = 0F;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.Top = 3.5F;
			this.line1.Width = 6.5F;
			this.line1.X1 = 0F;
			this.line1.X2 = 6.5F;
			this.line1.Y1 = 3.5F;
			this.line1.Y2 = 3.5F;
			// 
			// CoverSheetReport
			// 
			this.MasterReport = false;
			this.PageSettings.Margins.Bottom = 0.25F;
			this.PageSettings.Margins.Left = 0.25F;
			this.PageSettings.Margins.Right = 0.25F;
			this.PageSettings.Margins.Top = 0.25F;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-weight: bold; font-family: \"Arial Black\"; ddo-char-set: 186; font-size: 18pt" +
            "", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
			this.PageStart += new System.EventHandler(this.CoverSheetReport_PageStart);
			this.PageEnd += new System.EventHandler(this.CoverSheetReport_PageEnd);
			((System.ComponentModel.ISupportInitialize)(this.classification)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityStateZip)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.route)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numInBundle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.totalPapers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jobName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private GrapeCity.ActiveReports.SectionReportModel.Label classification;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox cityStateZip;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox route;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox numInBundle;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox totalPapers;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox jobName;
		private GrapeCity.ActiveReports.SectionReportModel.Line line1;
	}
}
