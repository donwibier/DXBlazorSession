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
		public DateTime DayInPast { get; set; } = DateTime.Now;
	}
}
