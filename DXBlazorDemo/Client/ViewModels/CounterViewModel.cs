using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client.ViewModels
{
	public interface ICounterViewModel
	{
		void IncrementCountAction();

		int CurrentCount { get; }
	}

	public class CounterViewModel: ICounterViewModel
	{
		public CounterViewModel()
		{

		}

		public int CurrentCount { get; private set; } = 0;

		public void IncrementCountAction()
		{
			CurrentCount++;
		}
	}
}
