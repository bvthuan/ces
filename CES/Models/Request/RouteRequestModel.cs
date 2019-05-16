using CES.Enums;
using System;

namespace CES.Model.Request
{
	public class RouteRequestModel                                                                                                                     
	{
		public string Start { get; set; }

		public string Destination { get; set; }

        public TransportType TransportType { get; set; }

    }
}
