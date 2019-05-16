using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace CES.Services
{
	public class RouteService : IRoute
	{
        // external service
        private readonly IAirProvider _airProvider;
        private readonly IShipProvider _shipProvider;

        // db context
        private CesContext _context;

        public RouteService(
            CesContext context,
            IAirProvider airProvider,
            IShipProvider shipProvider
            )
        {
            _context = context;
            _airProvider = airProvider;
            _shipProvider = shipProvider;
        }

        //@TODO: Viet will implement FindPath
        //===================================


    }
}
