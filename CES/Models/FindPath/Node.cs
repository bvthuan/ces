using CES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Models.FindPath
{
	public class Node
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public List<Edge> Connections { get; set; } = new List<Edge>();
		public decimal? MinCostToStart { get; set; }
		public Node NearestToStart { get; set; }
		
		public bool Visited { get; set; }
		public double StraightLineDistanceToEnd { get; set; }
		public bool IsEnd { get; set; }
		public Transportation Transportation { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}

	public class Edge
	{
		/// <summary>
		/// Cost for fastest path
		/// </summary>
		public decimal Cost { get; set; }
		public Node ConnectedNode { get; set; }
		/// <summary>
		/// Price
		/// </summary>
		public decimal Price { get; set; }
		public override string ToString()
		{
			return "-> " + ConnectedNode.ToString();
		}

		public Transportation Transportation { get; set; }
		public int Time { get; set; }
	}

	public class RouteModel
	{
		public long Id { get; set; }
		public string Start { get; set; }
		public string Destination { get; set; }
		public int NumberOfSegments { get; set; }
		public int TotalHours { get; set; }
		public Transportation Transportation { get; set; }
		public decimal Price { get; set; }
	}
}
