using CES.Constant;
using CES.Database.Context;
using CES.Database.Models;
using CES.Enums;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public class PriceService : IPrice
	{
		public CesContext _context;

        public IRouteConfiguration _routeConfiguration;

		public PriceService(CesContext context, IRouteConfiguration routeConfiguration)
		{
			_context = context;
            _routeConfiguration = routeConfiguration;
        }

        public List<PublicRouteResponsetModel> CalculatePrices(List<PublicRouteRequestModel> publicRouteRequestModels)
        {
            int priceBetweenTwoSegments = _routeConfiguration.getPriceBetweenTwoSegments();
            List<PublicRouteResponsetModel> publicRouteResponsetModels = new List<PublicRouteResponsetModel>();
            foreach(var routeRequestModel in publicRouteRequestModels)
            {
                publicRouteResponsetModels.Add(new PublicRouteResponsetModel() { price = priceBetweenTwoSegments, status = (int) AcceptStatus.ACCEPTED });
            }

            return publicRouteResponsetModels;
        }

    }
}
