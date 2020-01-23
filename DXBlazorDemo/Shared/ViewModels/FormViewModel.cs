using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXBlazorDemo.Shared.ViewModels
{
	public class FormViewModel : IFormViewModel
	{
		readonly IFormService formService;
		public FormViewModel(IFormService formService)
		{
			this.formService = formService;
		}
		public FormModel Model { get; set; } = new FormModel();

		public async Task SubmitAction()
		{
			Console.WriteLine("You clicked submit");
			var result = await formService.SubmitAsync(this.Model);
		}
	}
}
