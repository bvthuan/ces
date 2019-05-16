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

		public DbSet<City> Cities { get; set; }

		public DbSet<Route> Routes { get; set; }

		public DbSet<RouteConfiguration> RouteConfigurations { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>().HasData(new City { Id = 1, Code = "DKO", Name = "DE KANARISKE OER" });
			modelBuilder.Entity<City>().HasData(new City { Id = 2, Code = "TUN", Name = "TUNIS'" });
			modelBuilder.Entity<City>().HasData(new City { Id = 3, Code = "SUA", Name = "SUAKIN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 4, Code = "TAN", Name = "TANGER" });
			modelBuilder.Entity<City>().HasData(new City { Id = 5, Code = "CAI", Name = "CAIRO" });
			modelBuilder.Entity<City>().HasData(new City { Id = 6, Code = "KAG", Name = "KAP GUARDAFUI" });
			modelBuilder.Entity<City>().HasData(new City { Id = 7, Code = "AMA", Name = "AMATAVE" });
			modelBuilder.Entity<City>().HasData(new City { Id = 8, Code = "MOC", Name = "MOCAMBIQUE" });
			modelBuilder.Entity<City>().HasData(new City { Id = 9, Code = "KAM", Name = "KAP ST.MARIE" });
			modelBuilder.Entity<City>().HasData(new City { Id = 10, Code = "KAP", Name = "KAPSTADEN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 11, Code = "HVA", Name = "HVALBUGTEN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 12, Code = "HEL", Name = "ST. HELENA" });
			modelBuilder.Entity<City>().HasData(new City { Id = 13, Code = "SLA", Name = "SLAVEKYSTEN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 14, Code = "GUL", Name = "GULDKYSTEN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 15, Code = "SIL", Name = "SIERRA LEONE" });
			modelBuilder.Entity<City>().HasData(new City { Id = 16, Code = "DAK", Name = "DAKAR" });
			modelBuilder.Entity<City>().HasData(new City { Id = 17, Code = "MAR", Name = "MARRAKESH" });
			modelBuilder.Entity<City>().HasData(new City { Id = 18, Code = "SAH", Name = "SAHARA" });
			modelBuilder.Entity<City>().HasData(new City { Id = 19, Code = "TIM", Name = "TIMBUKTU" });
			modelBuilder.Entity<City>().HasData(new City { Id = 20, Code = "WAD", Name = "WADAI" });
			modelBuilder.Entity<City>().HasData(new City { Id = 21, Code = "DAR", Name = "DARFUR" });
			modelBuilder.Entity<City>().HasData(new City { Id = 22, Code = "CON", Name = "CONGO" });
			modelBuilder.Entity<City>().HasData(new City { Id = 23, Code = "OMD", Name = "OMDURMAN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 24, Code = "TRI", Name = "TRIPOLI" });
			modelBuilder.Entity<City>().HasData(new City { Id = 25, Code = "LUA", Name = "LUANDA" });
			modelBuilder.Entity<City>().HasData(new City { Id = 26, Code = "KAB", Name = "KABALO" });
			modelBuilder.Entity<City>().HasData(new City { Id = 27, Code = "VIF", Name = "VICTORIAFALDENE" });
			modelBuilder.Entity<City>().HasData(new City { Id = 28, Code = "BAG", Name = "BAHREL GHAZAL" });
			modelBuilder.Entity<City>().HasData(new City { Id = 29, Code = "ADA", Name = "ADDIS ABEBA" });
			modelBuilder.Entity<City>().HasData(new City { Id = 30, Code = "VIS", Name = "VICTORIASOEN" });
			modelBuilder.Entity<City>().HasData(new City { Id = 31, Code = "ZAN", Name = "ZANZIBAR" });
			modelBuilder.Entity<City>().HasData(new City { Id = 32, Code = "DRA", Name = "DRAGEBJERGET" });
		}

	}
}
