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

	public interface IPostFormService
	{
		Task<IFormResponse> SubmitForm(FormModel model);
	}

	public interface IWeatherForecast
	{
		string Summary { get; set; }
		int TemperatureC { get; set; }
		DateTime Date { get; set; }
	}

	public interface IFormService
	{
		Task<IFormResponse> SubmitAsync(FormModel model);
	}
	public interface IFormResponse
	{
		FormModel Result { get; set; }
		bool Success { get; set; }
		string Errors { get; set; }

	}
}
