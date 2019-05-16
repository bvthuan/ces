using CES.Enums;
using CES.Models.FindPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Models
{
	public class Solution
	{
		public Node Start { get; set; }
		public Node End { get; set; }
		public double ShortestPathLength { get; set; }
		public double ShortestPathCost { get; private set; }
		public List<Node> GetShortestPathDijkstra(string desName, TransportType type)
		{
			var end = DijkstraSearch(desName, type);
			var shortestPath = new List<Node>();

			shortestPath.Add(end);
			BuildShortestPath(shortestPath, end);
			shortestPath.Reverse();
			return shortestPath;
		}

		private void BuildShortestPath(List<Node> list, Node node)
		{
			if (node.NearestToStart == null)
				return;
			list.Add(node.NearestToStart);
			BuildShortestPath(list, node.NearestToStart);
		}

		private Node DijkstraSearch(string desName, TransportType type)
		{
			var result = new Node();
			Start.MinCostToStart = 0;
			var prioQueue = new List<Node>();
			prioQueue.Add(Start);
			do
			{
				prioQueue = prioQueue.OrderBy(x => x.MinCostToStart).ToList();
				var node = prioQueue.First();
				prioQueue.Remove(node);
				var data = type == TransportType.Cheapest
					? node.Connections.OrderBy(x => x.Price)
					: node.Connections.OrderBy(x => x.Time);
				foreach (var cnn in data)
				{
					var childNode = cnn.ConnectedNode;
					if (childNode.Visited)
						continue;
					if (childNode.MinCostToStart == null ||
						node.MinCostToStart + cnn.Cost < childNode.MinCostToStart)
					{
						childNode.MinCostToStart = node.MinCostToStart + cnn.Cost;
						childNode.NearestToStart = node;
						if (!prioQueue.Contains(childNode))
						{
							if (childNode.Name == desName)
							{
								childNode.IsEnd = true;
								result = childNode;
							}
							prioQueue.Add(childNode);
						}
					}
				}
				node.Visited = true;
				if (node == End)
				{
					return node;
				}
			} while (prioQueue.Any());

			return result;
		}


	}
}
