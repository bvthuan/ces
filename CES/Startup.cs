using Autofac;
using Autofac.Extensions.DependencyInjection;
using CES.Database.Context;
using CES.Extension;
using CES.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace CES
{
	public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

		public IContainer ApplicationContainer { get; private set; }

		public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
			services.AddRouting(opt => opt.LowercaseUrls = true);
			services.ConfigureCors();

			services.ConfigureIISIntegration();
			services.AddDbContext<CesContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:DB"]));
			ConfigureToken(services);
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


			var builder = new ContainerBuilder();
			builder.RegisterInstance<IConfiguration>(Configuration);
			builder.RegisterModule<ServiceModule>();
			//builder.WithOrigins("http://localhost:44301");
			builder.Populate(services);
			ApplicationContainer = builder.Build();

			// PrintSettings();
			// Create the IServiceProvider based on the container.
			return new AutofacServiceProvider(ApplicationContainer);
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

			app.UseHttpsRedirection();
			app.UseAuthentication();
			app.UseHttpsRedirection();
			app.UseCors("CorsPolicy");
			//app.UseForwardedHeaders(new ForwardedHeadersOptions
			//{
			//	ForwardedHeaders = ForwardedHeaders.All
			//});			
			
			app.UseMvc();
		}

		public void ConfigureToken(IServiceCollection services)
		{
			string secretKey = "mysite_supersecret_secretkey!8050";

			var key = Encoding.ASCII.GetBytes(secretKey);

			services.AddAuthentication(x =>
			{
				x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(x =>
			{
				x.RequireHttpsMetadata = false;
				x.SaveToken = true;
				x.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = false,
					ValidateAudience = false
				};
			});

		}
	}
}
