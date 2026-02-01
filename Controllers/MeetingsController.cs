using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
	public class MeetingsController : Controller
	{
        public IActionResult Savee(MeetingsModel model)
        {
         
            if (!ModelState.IsValid)
            {
                return View("MeetingsAddEdit", model);
            }
            return View("MeetingsList", model);
        }
        public IActionResult MeetingsList()
		{
			return View();
		}
		public IActionResult MeetingsAddEdit()
		{
			return View();
		}
	}
}
