using CES.Database.Context;
using CES.Database.Models;
using CES.Enums;
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
using System.Threading.Tasks;

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

		public async Task<List<RouteResponseModel>> FindRoute(RouteRequestModel request)
		{
			//If we dont have data for Air / Ship, use External API to get them
			if (!_context.Routes.Any(r => r.Transportation == (int)Transportation.Airborne))
			{
				await _airProvider.GetRoutes();
			}

			if (!_context.Routes.Any(r => r.Transportation == (int)Transportation.Ship))
			{
				await _shipProvider.GetRoutes();
			}

			var requestModel = new List<PublicRouteRequestModel>() {
				new PublicRouteRequestModel
				{
					goods_type = request.PackageType,
					height = request.PackageSizes.Height,
					length = request.PackageSizes.Length,
					weight = request.PackageSizes.Weight,
					width = request.PackageSizes.Width
				} };
			//Get all routes from database
			var airPrice = await _airProvider.GetPrice(requestModel);

			var shipPrice = 0;// await _shipProvider.GetPrice(requestModel);
			var routeData = await _context.Routes.ToListAsync();

			if (airPrice < 0)
				routeData = routeData.Where(r => r.Transportation != (int)Transportation.Airborne).ToList();

			if (shipPrice < 0)
				routeData = routeData.Where(r => r.Transportation != (int)Transportation.Ship).ToList();

			//Parse them to Route Model
			var routes = new List<RouteModel>();
			var config = await _context.RouteConfigurations.FirstAsync(rg => rg.Key == "TimeBetweenTwoSegments");
			var configPrice = await _context.RouteConfigurations.FirstAsync(rg => rg.Key == "PriceBetweenTwoSegments");

			foreach (var item in routeData)
			{
				routes.Add(new RouteModel
				{
					Destination = item.Destination,
					Start = item.Start,
					NumberOfSegments = item.NumberOfSegments,
					TotalHours = item.Transportation == (int)Transportation.Car
						? item.NumberOfSegments * Int32.Parse(config.Value)
						: item.TotalTime,
					Transportation = (Transportation)item.Transportation,
					Price = item.Transportation == (int)Transportation.Car
						? item.NumberOfSegments * Int32.Parse(configPrice.Value)
						: item.Transportation == (int)Transportation.Ship
							? item.NumberOfSegments * shipPrice
							: item.NumberOfSegments * airPrice,
				});
			}


			var nodes = routes.Parse(request.TransportType);


			Solution solution = new Solution();
			solution.Start = nodes.GetNode(request.Start);
			var foundRoutes = solution.GetShortestPathDijkstra(request.Destination);
			var result = new List<RouteResponseModel>();

			for (int i = 0; i < foundRoutes.Count - 1; i++)
			{
				var edge = foundRoutes[i].Connections.FirstOrDefault(c => c.ConnectedNode.Name == foundRoutes[i + 1].Name);
				if (edge == null) continue;
				result.Add(new RouteResponseModel
				{
					Start = foundRoutes[i].Name,
					Destination = foundRoutes[i + 1].Name,
					Price = edge.Price,
					Time = edge.Time,
					Transportation = edge.Transportation.ToString()
				});
			}

			return result;
		}

	}
}
