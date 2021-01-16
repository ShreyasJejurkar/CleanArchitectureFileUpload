using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebUI.ViewModels
{
	public class StudentViewModel
	{
		[Required]
		public string Name { get;set; }

		[Required]
		public IFormFile File { get; set; }
	}
}