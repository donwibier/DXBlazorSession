using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DXBlazorDemo.Shared
{
	public class FormModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[DateInPast]
		public DateTime DayInPast { get; set; }
	}


	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public class DateInPastAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			return (DateTime)value <= DateTime.Today && (DateTime)value > DateTime.MinValue;
		}
	}
}
