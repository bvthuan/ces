using CES.Database.Context;
using CES.Model.Request;
using CES.Model.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using CES.Constant;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CES.Enums;
using System.Net.Http.Headers;
using CES.Model;
using CES.Database.Models;
using Newtonsoft.Json;

namespace CES.Services
{
	/**
     * This class should be used for communicating external service only,
     * and the communication between Telstar with the 3rd party service can be achieved 
     * by HTTP request
     **/
	public class AirProviderGatewayService : IAirProvider
	{
		// db context
		private CesContext _context;

		public AirProviderGatewayService(CesContext context)
		{
			_context = context;
		}

		public async Task GetRoutes()
		{
			var hasData = await _context.Routes.AnyAsync(r => r.Transportation == (int)Transportation.Airborne);
			if (hasData)
				return;

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("http://wa-oavn.azurewebsites.net/api/exportedRoutes");

			// Add an Accept header for JSON format.
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			// List data response.
			HttpResponseMessage response = await client.GetAsync("");
			if (response.IsSuccessStatusCode)
			{
				var dataObjects = response.Content.ReadAsAsync<IEnumerable<PublicRouteModel>>().Result;

				var newData = new List<Route>();
				foreach (var item in dataObjects)
				{
					newData.Add(new Route
					{
						Destination = item.To_city,
						NumberOfSegments = item.Segment,
						Start = item.From_city,
						TotalTime = item.Hours,
						Transportation = (int)Transportation.Airborne
					});
				}

				_context.Routes.AddRange(newData);
				await _context.SaveChangesAsync();
			}
			else
			{
				Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
			}

			//Make any other calls using HttpClient here.

			//Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
			client.Dispose();
		}


		public async Task<decimal> GetPrice(List<PublicRouteRequestModel> request)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://wa-oavn.azurewebsites.net");
				var response = await client.PostAsJsonAsync("api/calculatePrices", request);
				if (response.IsSuccessStatusCode)
				{
					var dataObjects = response.Content.ReadAsAsync<IEnumerable<PublicRouteResponsetModel>>().Result;
					var firstItem = dataObjects.FirstOrDefault();

					if (firstItem != null && firstItem.status == 1)
					{
						return firstItem.price;
					}
				}

				return 0;
			}
		}
	}
}
