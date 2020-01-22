using DXBlazorDemo.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client.Services
{
	public class FetchDataService : IFetchDataService
	{
		readonly HttpClient http;

		public FetchDataService(HttpClient http)
		{
			this.http = http;
		}
		
		public async Task<IWeatherForecast[]> GetDataAsync()
		{
			Console.WriteLine("Getting Data");
			var result =  await http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
			return result;
		}

	}
}
