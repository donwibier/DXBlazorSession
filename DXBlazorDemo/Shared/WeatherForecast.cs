﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DXBlazorDemo.Shared
{
	public interface IWeatherForecast
	{
		string Summary { get; set; }
		int TemperatureC { get; set; }
		DateTime Date { get; set; }
	}
    public class WeatherForecast: IWeatherForecast
	{
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
