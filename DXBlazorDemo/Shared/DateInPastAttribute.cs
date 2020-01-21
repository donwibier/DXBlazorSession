using System;
using System.ComponentModel.DataAnnotations;

namespace DXBlazorDemo.Shared
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public class DateInPastAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			return (DateTime)value <= DateTime.Today && (DateTime)value > DateTime.MinValue;
		}
	}
}
