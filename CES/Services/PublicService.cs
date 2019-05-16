using CES.Constant;
using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public class PublicService : IPublicService
	{
		public CesContext _context;
		public PublicService(CesContext context)
		{
			_context = context;
		}

        public List<PublicRouteModel> PublicRoutes()
        {
            List<RouteConfiguration>   routeConfigurations = _context.RouteConfigurations.ToList();


            int hourBetweenTwoSegments = 0;

            foreach (var config in routeConfigurations)
            {
                if (AppConstant.HOUR_BETWEEN_TWO_SEGMENTS.Equals(config.Key))
                {
                    hourBetweenTwoSegments = int.Parse(config.Value);
                }
            }

            List<Route> routes =  _context.Routes.ToList();

            List<PublicRouteModel> publicRoutes = new List<PublicRouteModel>();

            foreach (var route in routes)
            {
                PublicRouteModel publicRouteModel = new PublicRouteModel() { From_city = route.Start, To_city = route.Destination, Hours = hourBetweenTwoSegments * route.NumberOfSegments, Segment = route.NumberOfSegments };
                publicRoutes.Add(publicRouteModel);
            }

            return publicRoutes;
        }
    }
}
