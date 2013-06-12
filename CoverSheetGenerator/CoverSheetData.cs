using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoverSheetGenerator
{
	class CoverSheetData
	{
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string JobName { get; set; }
		public int Total { get; set; }
		public int NumInBundle { get; set; }
		public string Route { get; set; }

		public string CityStateZip
		{
			get { return string.Format("{0} {1} {2}", City, State, Zip); }
		}
	}
}
