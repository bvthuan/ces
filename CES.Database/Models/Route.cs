using System;
using System.Collections.Generic;

namespace CES.Database.Models
{
	public class Route : Entity
	{
		public string Start { get; set; }
		public string Destination { get; set; }
		public int NumberOfSegments { get; set; }
		public int Transportation { get; set; }
		public int TotalTime { get; set; }
	}
}
