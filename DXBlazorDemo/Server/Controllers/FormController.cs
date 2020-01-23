using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DXBlazorDemo.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FormController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> logger;

		public FormController(ILogger<WeatherForecastController> logger)
		{
			this.logger = logger;
		}

		[HttpPost]
		public IFormResponse Register(FormModel model)
		{
			string errors = "";
			if (!ModelState.IsValid)
			{
				errors = String.Join("\n", (from item in ModelState
											  where item.Value.Errors.Any()
											  select item.Value.Errors[0].ErrorMessage).ToList());

			}
			IFormResponse result = new FormResponse
			{
				Success = ModelState.IsValid,
				Errors = errors,
				Result = model
			};

			return result;
		}

	}
}
