using CES.Database.Models;
using CES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public interface IRouteConfiguration
    {
		Task<List<RouteConfiguration>> RouteConfigurations();
		
	}
}
