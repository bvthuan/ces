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

	[Route("api/public")]
    [ApiController]
    public class PublicController : ControllerBase
    {
		private readonly IPublicService _publicService;

        private readonly IPrice _priceService;

        private readonly CesContext _context;

		public PublicController(CesContext context, IPublicService publicService, IPrice priceService)
		{
			_context = context;
            _publicService = publicService;
            _priceService = priceService;

        }

		
		[HttpGet("configuredRoutes")]
        public  ActionResult<List<PublicRouteModel>> GetConfiguredRoutes()
        {
            return _publicService.PublicRoutes();
        }


        [HttpPost("caculatePrices")]
        public List<PublicRouteResponsetModel> CalculatePrices([FromBody] List<PublicRouteRequestModel> publicRouteRequestModels)
        {
            return _priceService.CalculatePrices(publicRouteRequestModels);

        }
    }
}
