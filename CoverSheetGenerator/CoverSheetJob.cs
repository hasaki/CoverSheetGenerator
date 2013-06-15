using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoverSheetGenerator
{
	internal class CoverSheetJob
	{
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string JobName { get; set; }
		public int Total { get; set; }
		public int BundleSize { get; set; }
		public string Route { get; set; }

		public string CityStateZip
		{
			get { return string.Format("{0} {1} {2}", City, State, Zip); }
		}

		public string TotalBundleSize
		{
			get { return string.Format("{0}/{1}", Total, BundleSize); }
		}

		public CoverSheetJobListViewItem ListViewItem { get; set; }

		public IEnumerable<CoverSheetData> GetData()
		{
			var remaining = Total;

			while (remaining > 0)
			{
				var data = new CoverSheetData()
					{
						City = this.City,
						State = this.State,
						Zip = this.Zip,
						JobName = this.JobName,
						Route = this.Route,
						Total = this.Total
					};

				var numInBundle = 0;

				if (remaining > BundleSize + 15)
				{
					numInBundle = BundleSize;
				}
				else
				{
					numInBundle = remaining;
				}

				remaining -= numInBundle;

				data.NumInBundle = numInBundle;

				yield return data;
			}
		}
	}
}
