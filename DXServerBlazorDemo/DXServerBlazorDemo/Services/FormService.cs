using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXServerBlazorDemo.Services
{
	public class FormService : IFormService
	{
		public Task<IFormResponse> SubmitAsync(FormModel model)
		{
			IFormResponse result = new FormResponse
			{
				Success = true,
				Errors = "",
				Result = model
			};

			return Task.FromResult(result);
		}
	}
}
