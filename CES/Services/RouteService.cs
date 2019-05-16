using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using CES.Model.Request;
using CES.Model.Response;
using CES.Models;
using CES.Models.FindPath;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CES.Services
{
	public class RouteService : IRoute
	{
        // external service
        private readonly IAirProvider _airProvider;
        private readonly IShipProvider _shipProvider;

        // db context
        private CesContext _context;

        public RouteService(
            CesContext context,
            IAirProvider airProvider,
            IShipProvider shipProvider
            )
        {
            _context = context;
            _airProvider = airProvider;
            _shipProvider = shipProvider;
        }
		
		public List<RouteResponseModel> FindRoute(RouteRequestModel request)
		{
			//Get all routes from database
			//If we dont have data for Air / Ship, use External API to get them
			//Continue get all routes data from database
			//Parse them to Route Model
			var routes = new List<RouteModel>();

			var price = 0; //use second External API to get them
			var nodes = routes.Parse(request.TransportType, price);


			Solution solution = new Solution();
			solution.Start = nodes.GetNode(request.Start);
			var foundRoutes = solution.GetShortestPathDijkstra(request.Destination);
			var result = new List<RouteResponseModel>();

			foreach (var item in foundRoutes)
			{
				result.Add(new RouteResponseModel {
					Start = item.Name, 
				});
			}

			for (int i = 0; i < foundRoutes.Count -1; i++)
			{
				var edge = foundRoutes[0].Connections.FirstOrDefault(c => c.ConnectedNode.Name == foundRoutes[1].Name);
				if (edge == null) continue;
				result.Add(new RouteResponseModel
				{
					Start = foundRoutes[0].Name,
					Destination = foundRoutes[1].Name,
					Price = edge.Price,
					Time = edge.Time,
					Transportation = edge.Transportation.ToString()
				});
			}

			return result;
		}

	}
}
