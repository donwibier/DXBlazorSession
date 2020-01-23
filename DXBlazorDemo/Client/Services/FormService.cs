using DXBlazorDemo.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client.Services
{
	public class FormService : IFormService
	{
		readonly HttpClient http;
		public FormService(HttpClient http)
		{
			this.http = http;
		}

		public async Task<IFormResponse> SubmitAsync(FormModel model)
		{
			var result = await http.SendJsonAsync<IFormResponse>(HttpMethod.Post, "Form", model);
			return result;
		}
	}
}
