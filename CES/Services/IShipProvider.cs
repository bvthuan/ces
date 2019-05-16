using CES.Database.Models;
using CES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public interface IShipProvider
	{
		Task GetRoutes();
		Task<decimal> GetPrice(List<PublicRouteRequestModel> request);
	}
}
