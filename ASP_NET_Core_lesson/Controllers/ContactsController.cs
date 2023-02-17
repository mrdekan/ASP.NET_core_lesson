using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_lesson.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
