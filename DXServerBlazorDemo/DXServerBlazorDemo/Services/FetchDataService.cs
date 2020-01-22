using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXServerBlazorDemo.Services
{
	public class FetchDataService : IFetchDataService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		public Task<IWeatherForecast[]> GetDataAsync()
		{
			var rng = new Random();
			IWeatherForecast[] result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			}).ToArray();

			return Task.FromResult(result);
		}

	}
}
