using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorDemo.Shared.ViewModels
{
	public interface ICounterViewModel
	{
		void IncrementCountAction();

		int CurrentCount { get; }
	}

	public interface IFetchDataViewModel
	{
		bool IsFahrenheit { get; }

		int PrintTemperature(int t);
		string OtherTempScale { get; }
		string TempTitle { get; }

		void ToggleScaleAction();
		Task RetrieveDataAsync();

		IWeatherForecast[] Forecasts { get; }
	}

	public interface IFormViewModel
	{
		void SubmitAction();
		FormModel Model { get; set; }
	}
}
