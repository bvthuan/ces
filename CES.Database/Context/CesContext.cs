using CES.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CES.Database.Context
{
	public class CesContext : DbContext
	{
		public CesContext(DbContextOptions<CesContext> options) : base(options)
		{
		}
		
		public DbSet<User> Users { get; set; }
		
	}
}
