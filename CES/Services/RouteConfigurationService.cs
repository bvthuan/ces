using CES.Constant;
using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public class RouteConfiguratoinService : IRouteConfiguration
    {
		public CesContext _context;
		public RouteConfiguratoinService(CesContext context)
		{
			_context = context;
		}

        public async Task<List<RouteConfiguration>> RouteConfigurations()
        {
            return await _context.RouteConfigurations.ToListAsync();
        }

        public int getHourBetweenTwoSegments()
        {
            List<RouteConfiguration> routeConfigurations = _context.RouteConfigurations.ToList();

            int hourBetweenTwoSegments = 0;

            foreach (var config in routeConfigurations)
            {
                if (AppConstant.TIME_BETWEEN_TWO_SEGMENTS.Equals(config.Key))
                {
                    hourBetweenTwoSegments = int.Parse(config.Value);
                }
            }

            return hourBetweenTwoSegments;
        }

        public int getPriceBetweenTwoSegments()
        {
            List<RouteConfiguration> routeConfigurations = _context.RouteConfigurations.ToList();

            int priceBetweenTwoSegments = 0;

            foreach (var config in routeConfigurations)
            {
                if (AppConstant.PRICE_BETWEEN_TWO_SEGMENTS.Equals(config.Key))
                {
                    priceBetweenTwoSegments = int.Parse(config.Value);
                }
            }

            return priceBetweenTwoSegments;
        }
    }
}
