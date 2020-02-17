using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXBlazorDemo.Shared;

namespace DXBlazorDemo.Shared.ViewModels
{
	//.bl100
	public class FetchDataViewModel : IFetchDataViewModel
	{
		private readonly IFetchDataService dataService;

		public FetchDataViewModel(IFetchDataService dataService)
		{
			this.dataService = dataService;
			IsFahrenheit = true;
		}

		public IWeatherForecast[] Forecasts { get; private set; }
		public bool IsFahrenheit { get; private set; }
		public string TempTitle { get => IsFahrenheit ? "F" : "C"; }
		public string OtherTempScale { get => !IsFahrenheit ? "Fahrenheit" : "Celsius"; }
		public async Task RetrieveDataAsync()
		{
			Forecasts = await dataService.GetDataAsync();
		}
		public void ToggleScaleAction()
		{
			IsFahrenheit = !IsFahrenheit;
		}
		public int PrintTemperature(int t)
		{
			return IsFahrenheit ? 32 + (int)(t / 0.5556) : t;
		}
	}
}
