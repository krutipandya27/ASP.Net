using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
	public class MeetingVenueController : Controller
	{
        public IActionResult Save(MeetingVenueModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("MeetingVenueAddEdit", model);
            }
            return RedirectToAction("MeetingVenueList", model);
        }


        public IActionResult MeetingVenueList()
		{
			return View();
		}
		public IActionResult MeetingVenueAddEdit()
		{
			return View();
		}
	}
}
