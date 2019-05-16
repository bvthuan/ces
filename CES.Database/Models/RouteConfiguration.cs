using System;
using System.Collections.Generic;

namespace CES.Database.Models
{
	public class RouteConfiguration : Entity
	{
		public string PriceBetweenTwoSegments { get; set; }
		public string MaxiumWeight { get; set; }
	}
}
