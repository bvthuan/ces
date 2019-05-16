using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CES.Database.Context;
using CES.Database.Models;
using CES.Model;
using CES.Services;
using Microsoft.AspNetCore.Mvc;

namespace CES.Controllers
{

	[Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
		private readonly IPublicService _publicService;

		private readonly CesContext _context;

		public PublicController(CesContext context, IPublicService publicService)
		{
			_context = context;
            _publicService = publicService;
		}

		
		[HttpGet]
        public  ActionResult<List<PublicRouteModel>> PublicRoutes()
        {
			return  _publicService.PublicRoutes();
        }
        
    }
}
