using CES.Database.Context;
using CES.Database.Models;
using CES.Enums;
using CES.Model;
using CES.Model.Request;
using CES.Model.Response;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CES.Services
{
	/**
     * This class should be used for communicating external service only,
     * and the communication between Telstar with the 3rd party service can be achieved 
     * by HTTP request
     **/
	public class ShipProviderGatewayService : IShipProvider
	{
		// db context
		private CesContext _context;

		public ShipProviderGatewayService(CesContext context)
		{
			_context = context;
		}


		public async Task GetRoutes()
		{
			var hasData = await _context.Routes.AnyAsync(r => r.Transportation == (int)Transportation.Ship);
			if (hasData)
				return;

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://wa-eitvn.azurewebsites.net/index.php?r=api/routes");

			// Add an Accept header for JSON format.
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			// List data response.
			HttpResponseMessage response = await client.GetAsync("");
			if (response.IsSuccessStatusCode)
			{
				// Parse the response body.
				var dataObjectString = await response.Content.ReadAsStringAsync();

				var dataObjects = JsonConvert.DeserializeObject<List<PublicRouteModel>>(dataObjectString);

				var newData = new List<Route>();
				foreach (var item in dataObjects)
				{
					newData.Add(new Route
					{
						Destination = item.To_city,
						NumberOfSegments = item.Segment,
						Start = item.From_city,
						TotalTime = item.Hours,
						Transportation = (int)Transportation.Ship
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
			try
			{
				using (var client = new HttpClient())
				{
					//client.BaseAddress = new Uri("http://wa-eitvn.azurewebsites.net");
					//var response = client.PostAsJsonAsync("/index.php?r=api/price", request).Result;
					//if (response.IsSuccessStatusCode)
					//{
					//	var dataObjects = response.Content.ReadAsAsync<IEnumerable<PublicRouteResponsetModel>>().Result;
					//	var firstItem = dataObjects.FirstOrDefault();

					//	if (firstItem != null && firstItem.status == 1)
					//	{
					//		return firstItem.price;
					//	}
					//}

					//return 0;


					//var values = new Dictionary<string, string> {
					//	{ "goodsType", request.First().goodsType },
					//	{ "height", request.First().height.ToString() },
					//	{ "length", request.First().length.ToString() },
					//	{ "weight", request.First().weight.ToString() },
					//	{ "width", request.First().width.ToString() }
					//};



					//List<KeyValuePair<string, string>> bodyProperties = new List<KeyValuePair<string, string>>();

					////Add 'single' parameters
					//bodyProperties.Add(new KeyValuePair<string, string>("goodsType", request.First().goodsType));
					//bodyProperties.Add(new KeyValuePair<string, string>("height", request.First().height.ToString()));
					//bodyProperties.Add(new KeyValuePair<string, string>("length", request.First().length.ToString()));
					//bodyProperties.Add(new KeyValuePair<string, string>("weight", request.First().weight.ToString()));
					//bodyProperties.Add(new KeyValuePair<string, string>("width", request.First().width.ToString()));

					//var content = new FormUrlEncodedContent(request.ToArray());

					//var response = await client.PostAsync("http://wa-eitvn.azurewebsites.net/index.php?r=api/price", content);

					//var responseString = await response.Content.ReadAsStringAsync();

					//if (response.IsSuccessStatusCode)
					//{
					//	var dataObjects = response.Content.ReadAsAsync<IEnumerable<PublicRouteResponsetModel>>().Result;
					//	var firstItem = dataObjects.FirstOrDefault();

					//	if (firstItem != null && firstItem.status == 1)
					//	{
					//		return firstItem.price;
					//	}
					//}

					//return 0;


					string URI = string.Format("http://wa-eitvn.azurewebsites.net/index.php?r=api/price");

					var serializedProduct = JsonConvert.SerializeObject(request); //num is an array of integers
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					var result = await client.PostAsync(URI, content);

					var responseString = await result.Content.ReadAsStringAsync();

					if (result.IsSuccessStatusCode)
					{
						var dataObjects = await result.Content.ReadAsAsync<IEnumerable<PublicRouteResponsetModel>>();
						var firstItem = dataObjects.FirstOrDefault();

						if (firstItem != null && firstItem.status == 1)
						{
							return firstItem.price;
						}
					}
					return 0;
				}
			}
			catch (Exception EX)
			{

				throw;
			}
		}
	}
}
