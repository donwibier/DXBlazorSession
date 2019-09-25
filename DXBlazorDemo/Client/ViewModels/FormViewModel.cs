using DXBlazorDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client.ViewModels
{
	public interface IFormViewModel
	{
		void SubmitAction();

		FormModel Model { get; set; }
	}

	public class FormViewModel : IFormViewModel
	{
		public FormModel Model { get; set; } = new FormModel();

		public void SubmitAction()
		{
			Console.WriteLine("You clicked submit");
		}
	}
}
