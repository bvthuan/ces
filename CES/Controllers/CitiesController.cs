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
    public class CitiesController : ControllerBase
    {
		private readonly ICity _cityService;

		private readonly CesContext _context;

		public CitiesController(CesContext context, ICity cityService)
		{
			_context = context;
			_cityService = cityService;
		}

		// GET api/values
		[HttpGet]
        public async Task<ActionResult<List<City>>> Cities()
        {
			return await _cityService.Cities();

        }
        
    }
}
