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
        }

    }
}
