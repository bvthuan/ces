using CES.Database.Models;
using CES.Model;
using CES.Model.Request;
using CES.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public interface IRoute
	{
		Task<List<RouteResponseModel>> FindRoute(RouteRequestModel request);
	}
}
