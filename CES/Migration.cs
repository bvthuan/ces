using CES.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace CES
{
	public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CesContext>
	{
		public CesContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			var builder = new DbContextOptionsBuilder<CesContext>();
			var connectionString = configuration
				.GetSection("ConnectionString")["DB"];
			Console.WriteLine(connectionString);
			builder.UseSqlServer(connectionString);

			return new CesContext(builder.Options);
		}
	}
}
