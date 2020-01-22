using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorDemo.Shared
{
	public interface IFetchDataService
	{
		Task<IWeatherForecast[]> GetDataAsync();
	}

	public interface IWeatherForecast
	{
		string Summary { get; set; }
		int TemperatureC { get; set; }
		DateTime Date { get; set; }
	}
}
