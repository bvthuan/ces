using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CES.Model.Request;
using CES.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace CES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        // POST api/routes
        [HttpPost]
        public IActionResult PostRoute([FromBody] RouteRequestModel route)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            /**
             * Stub data for initializing the implementation, should be replaced with real data
             * @TODO: Mike will replace stub data with real data
             **/
            var routes = new List<RouteResponseModel>() {
                new RouteResponseModel()
                {
                    Start = "Ho chi minh",
                    Destination = "Ha noi",
                    Price = 3,
                    StartDate = new DateTime(),
                    Time = 20, // in hours
                    Transportation = Enums.Transportation.Car
                },
                new RouteResponseModel()
                {
                    Start = "Ho chi minh",
                    Destination = "Ha noi",
                    Price = 10,
                    StartDate = new DateTime(),
                    Time = 4, // in hours
                    Transportation = Enums.Transportation.Airborne
                },
            };
            
            return Ok(routes);
        }

    }
}
