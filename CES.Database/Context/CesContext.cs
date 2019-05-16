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

        public DbSet<GoodType> GoodTypes { get; set; }

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

            //insert route data

            modelBuilder.Entity<Route>().HasData(new Route { Id = 1, Start = "TUN", Destination = "TRI", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 2, Start = "TUN", Destination = "TAN", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 3, Start = "SUA", Destination = "ADA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 4, Start = "SUA", Destination = "DAR", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 5, Start = "TAN", Destination = "TUN", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 6, Start = "TAN", Destination = "SAH", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 7, Start = "TAN", Destination = "MAR", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 8, Start = "CAI", Destination = "OMD", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 9, Start = "KAG", Destination = "ADA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 10, Start = "KAG", Destination = "ZAN", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 11, Start = "MOC", Destination = "ZAN", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 12, Start = "MOC", Destination = "VIS", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 13, Start = "MOC", Destination = "DRA", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 14, Start = "MOC", Destination = "VIF", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 15, Start = "MOC", Destination = "LUA", NumberOfSegments = 10 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 16, Start = "KAP", Destination = "HVA", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 17, Start = "HVA", Destination = "VIF", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 18, Start = "SLA", Destination = "CON", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 19, Start = "SLA", Destination = "DAR", NumberOfSegments = 7 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 20, Start = "SLA", Destination = "WAD", NumberOfSegments = 7 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 21, Start = "SLA", Destination = "TIM", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 22, Start = "GUL", Destination = "TIM", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 23, Start = "GUL", Destination = "SIL", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 24, Start = "SIL", Destination = "GUL", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 25, Start = "SIL", Destination = "TIM", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 26, Start = "SIL", Destination = "DAK", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 27, Start = "DAK", Destination = "SIL", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 28, Start = "DAK", Destination = "MAR", NumberOfSegments = 8 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 29, Start = "MAR", Destination = "DAK", NumberOfSegments = 8 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 30, Start = "MAR", Destination = "TAN", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 31, Start = "MAR", Destination = "SAH", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 32, Start = "SAH", Destination = "TAN", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 33, Start = "SAH", Destination = "MAR", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 34, Start = "SAH", Destination = "DAR", NumberOfSegments = 8 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 35, Start = "TIM", Destination = "SLA", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 36, Start = "TIM", Destination = "GUL", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 37, Start = "TIM", Destination = "SIL", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 38, Start = "WAD", Destination = "DAR", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 39, Start = "WAD", Destination = "CON", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 40, Start = "WAD", Destination = "SLA", NumberOfSegments = 7 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 41, Start = "DAR", Destination = "BAG", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 42, Start = "DAR", Destination = "SUA", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 43, Start = "DAR", Destination = "OMD", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 44, Start = "DAR", Destination = "SAH", NumberOfSegments = 8 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 45, Start = "DAR", Destination = "WAD", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 46, Start = "DAR", Destination = "CON", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 47, Start = "DAR", Destination = "SLA", NumberOfSegments = 7 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 48, Start = "CON", Destination = "LUA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 49, Start = "CON", Destination = "DAR", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 50, Start = "CON", Destination = "WAD", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 51, Start = "CON", Destination = "SLA", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 52, Start = "OMD", Destination = "CAI", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 53, Start = "OMD", Destination = "DAR", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 54, Start = "OMD", Destination = "TRI", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 55, Start = "TRI", Destination = "TUN", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 56, Start = "TRI", Destination = "OMD", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 57, Start = "LUA", Destination = "CON", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 58, Start = "LUA", Destination = "KAB", NumberOfSegments = 0 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 59, Start = "LUA", Destination = "MOC", NumberOfSegments = 10 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 60, Start = "LUA", Destination = "VIF", NumberOfSegments = 11 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 61, Start = "LUA", Destination = "DRA", NumberOfSegments = 11 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 62, Start = "KAB", Destination = "VIS", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 63, Start = "KAB", Destination = "LUA", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 64, Start = "VIF", Destination = "HVA", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 65, Start = "VIF", Destination = "DRA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 66, Start = "VIF", Destination = "MOC", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 67, Start = "VIF", Destination = "LUA", NumberOfSegments = 11 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 68, Start = "BAG", Destination = "VIS", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 69, Start = "BAG", Destination = "DAR", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 70, Start = "ADA", Destination = "VIS", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 71, Start = "ADA", Destination = "KAG", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 72, Start = "ADA", Destination = "SUA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 73, Start = "VIS", Destination = "KAB", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 74, Start = "VIS", Destination = "BAG", NumberOfSegments = 2 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 75, Start = "VIS", Destination = "ADA", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 76, Start = "VIS", Destination = "MOC", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 77, Start = "VIS", Destination = "ZAN", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 78, Start = "ZAN", Destination = "KAG", NumberOfSegments = 6 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 79, Start = "ZAN", Destination = "MOC", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 80, Start = "ZAN", Destination = "VIS", NumberOfSegments = 5 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 81, Start = "DRA", Destination = "VIF", NumberOfSegments = 3 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 82, Start = "DRA", Destination = "MOC", NumberOfSegments = 4 });
            modelBuilder.Entity<Route>().HasData(new Route { Id = 83, Start = "DRA", Destination = "LUA", NumberOfSegments = 11 });

            // missing Route Data
            modelBuilder.Entity<Route>().HasData(new Route { Id = 84, Start = "HVA", Destination = "KAP", NumberOfSegments = 4 });

            // insert RouteConfiguration
            modelBuilder.Entity<RouteConfiguration>().HasData(new RouteConfiguration { Id = 1, Key = "PriceBetweenTwoSegments", Value = "3"});
            modelBuilder.Entity<RouteConfiguration>().HasData(new RouteConfiguration { Id = 2, Key = "MaxiumWeight", Value = "40" });
            modelBuilder.Entity<RouteConfiguration>().HasData(new RouteConfiguration { Id = 3, Key = "ShipProviderURL", Value = "" });
            modelBuilder.Entity<RouteConfiguration>().HasData(new RouteConfiguration { Id = 4, Key = "AirProviderURL", Value = "" });

            modelBuilder.Entity<RouteConfiguration>().HasData(new RouteConfiguration { Id = 5, Key = "HourBetweenTwoSegments", Value = "4" });

            //modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 1, Code = "AirProviderURL", Name = "" });

            modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 1, Code = "RED", Name = "Recorded Delivery" });
            modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 2, Code = "WEA", Name = "Weapons" });
            modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 3, Code = "LIA", Name = "Live Animals" });
            modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 4, Code = "CAP", Name = "Cautious Parcels" });
            modelBuilder.Entity<GoodType>().HasData(new GoodType { Id = 5, Code = "REF", Name = "Refrigerated Goods" });





        }

    }
}
