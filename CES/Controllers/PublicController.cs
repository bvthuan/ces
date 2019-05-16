using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CES.Database.Context;
using CES.Database.Models;
using CES.Services;
using Microsoft.AspNetCore.Mvc;

namespace CES.Controllers
{

	[Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
		private readonly IRouteConfiguration _routeConfigurationService;

		private readonly CesContext _context;

		public PublicController(CesContext context, IRouteConfiguration routeConfigurationService)
		{
			_context = context;
            _routeConfigurationService = routeConfigurationService;
		}

		// GET api/values
		[HttpGet]
        public async Task<ActionResult<List<RouteConfiguration>>> RouteConfiguration()
        {
			return await _routeConfigurationService.RouteConfigurations();
        }
        
    }
}
