using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXBlazorDemo.Shared.ViewModels
{
	public class FormViewModel : IFormViewModel
	{
		public FormModel Model { get; set; } = new FormModel();

		public void SubmitAction()
		{
			Console.WriteLine("You clicked submit");
		}
	}
}
