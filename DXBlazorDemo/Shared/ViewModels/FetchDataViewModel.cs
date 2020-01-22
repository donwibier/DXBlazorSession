using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXBlazorDemo.Shared;

namespace DXBlazorDemo.Shared.ViewModels
{
	public class FetchDataViewModel: IFetchDataViewModel
	{
		private bool dispFahr;

		readonly IFetchDataService dataService;
		public FetchDataViewModel(IFetchDataService dataService)
		{
			Console.WriteLine("FetchDataViewModel Constructor Executing");
			this.dataService = dataService;
			dispFahr = true;
		}

		public IWeatherForecast[] Forecasts { get; private set; }

		public async Task RetrieveDataAsync()
		{
			Forecasts =  await dataService.GetDataAsync();
			
		}
		public void ToggleScaleAction()
		{
			dispFahr = !dispFahr;
		}
		public bool IsFahrenheit { get => dispFahr; }
		public string TempTitle { get => dispFahr ? "F" : "C"; }
		public string OtherTempScale { get => !dispFahr ? "Fahrenheit" : "Celsius"; }
		public int PrintTemperature(int t)
		{
			return dispFahr ? 32 + (int)(t / 0.5556) : t;
		} 

	}
}
