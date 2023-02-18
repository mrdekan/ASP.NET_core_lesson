using ASP_NET_Core_lesson.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_lesson.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
		public IActionResult Check(Contact contact)
		{
            if (ModelState.IsValid)
            {
				return Redirect("/");
            }
			return View("Index");
		}
	}
}
