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

	[Route("api/price")]
    [ApiController]
    public class PricesController : ControllerBase
    {
		private readonly CesContext _context;

        private readonly IPrice _priceService;

        public PricesController(CesContext context, IPrice priceService)
        {
            _context = context;
            _priceService = priceService;
        }

		
		[HttpPost]
        public  List<PublicRouteResponsetModel> CalculatePrices([FromBody] List<PublicRouteRequestModel> publicRouteRequestModels)
        {
            return  _priceService.CalculatePrices(publicRouteRequestModels);
        }
        
    }
}
