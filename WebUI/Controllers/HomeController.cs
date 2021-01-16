using Microsoft.AspNetCore.Mvc;
using WebUI.Services;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SubmitForm(StudentViewModel model,[FromServices] IStudentService studentService)
		{
			if (ModelState.IsValid)
			{
				if (model.File.Length > 0)
				{
					var response = studentService.SaveStudent(model);

					// Don't return domain model like this, this is purely for DEMO purpose
					return Ok(new { response });
				}
			}

			return View("Index");
		}
	}
}
