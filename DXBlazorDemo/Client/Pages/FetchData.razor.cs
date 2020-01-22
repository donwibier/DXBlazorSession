using DXBlazorDemo.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client.Pages
{
	public partial class FetchData
	{
		[Inject]
		public HttpClient Http { get; set; }
		
		private WeatherForecast[] forecasts;

		protected override async Task OnInitializedAsync()
		{
			forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
		}
	}
}
