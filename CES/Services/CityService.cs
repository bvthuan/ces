using CES.Database.Context;
using CES.Database.Models;
using CES.Extension;
using CES.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CES.Services
{
	public class CityService : ICity
	{
		public CesContext _context;
		public CityService(CesContext context)
		{
			_context = context;
		}

		public async Task<List<City>> Cities()
		{
			return await _context.Cities.ToListAsync();
		}

	}
}
