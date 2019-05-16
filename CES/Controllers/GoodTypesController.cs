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
    public class GoodTypesController : ControllerBase
    {
		private readonly IGoodType _goodType;

		private readonly CesContext _context;

		public GoodTypesController(CesContext context, IGoodType goodType)
		{
			_context = context;
            _goodType = goodType;
		}

		// GET api/values
		[HttpGet]
        public async Task<ActionResult<List<GoodType>>> GoodTypes()
        {
			return await _goodType.GoodTypes();

        }
        
    }
}
