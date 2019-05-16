using CES.Enums;
using System;

namespace CES.Model.Request
{
	public class RouteRequestModel                                                                                                                     
	{
		public string Start { get; set; }

		public string Destination { get; set; }

        public TransportType TransportType { get; set; }

		public string PackageType { get; set; }
		public PackageSize PackageSizes { get; set; }

	}

	public class PackageSize
	{
		public int Weight { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int Length { get; set; }
	}
}
