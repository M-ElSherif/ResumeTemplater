using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages

{
	public class AboutMeModel : PageModel
	{
		public string Email { get; set; }
		public string Description { get; set; }
		public void OnGet()
		{
			Description = "Lorem ipsum dolei";
			Email = "placeholder@gmail.com";
		}
	}
}
