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
    }
}
