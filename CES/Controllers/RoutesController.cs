using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CES.Enums;
using CES.Model.Request;
using CES.Model.Response;
using CES.Services;
using Microsoft.AspNetCore.Mvc;

namespace CES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IRoute _route;

        public RoutesController(IRoute routeService)
        {
            _route = routeService;
        }
        // POST api/routes
        [HttpPost]
        public async Task<IActionResult> PostRoute([FromBody] RouteRequestModel route)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			return Ok(await _route.FindRoute(route));
			///**
   //          * Stub data for initializing the implementation, should be replaced with real data
   //          * @TODO: Mike will replace stub data with real data
   //          **/
			//var routes = new List<RouteResponseModel>() {
   //             new RouteResponseModel()
   //             {
   //                 Start = route.Start,
   //                 Destination = route.Destination,
   //                 Price = 3,
   //                 StartDate = new DateTime(),
   //                 Time = 20, // in hours
   //                 Transportation = Enums.Transportation.Car.ToString()
   //             },
   //             new RouteResponseModel()
   //             {
   //                 Start = route.Start,
   //                 Destination = route.Destination,
   //                 Price = 10,
   //                 StartDate = new DateTime(),
   //                 Time = 4, // in hours
   //                 Transportation = Enums.Transportation.Airborne.ToString()
   //             },
   //         };

   //         var suggestion = new List<RouteResponseModel>();

   //         if (route.TransportType == TransportType.Fastest)
   //         {
   //             suggestion.Add(routes[1]);
   //         } else
   //         {
   //             suggestion.Add(routes[0]);
   //         }
            
   //         return Ok(suggestion);
        }

    }
}
