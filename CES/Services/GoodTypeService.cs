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
	public class GoodTypeService : IGoodType
	{
		public CesContext _context;

		public GoodTypeService(CesContext context)
		{
			_context = context;
		}

        public async Task<List<GoodType>> GoodTypes()
        {
            return await _context.GoodTypes.ToListAsync();
        }
    }
}
