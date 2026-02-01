using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
	public class MeetingMemberController : Controller
	{
        public IActionResult Save(MeetingMemberModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("MeetingMemberAddEdit", model);
            }
            return RedirectToAction("MeetingMemberList", model);
        }
        public IActionResult MeetingMemberList()
		{
			return View();
		}
		public IActionResult MeetingMemberAddEdit()
		{
			return View();
		}
     
    }
  
}
