using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class StaffController : Controller
	{

        public IActionResult Save(StaffModel model)
        {

            if (!ModelState.IsValid)
            {
                return View("StaffAddEdit", model);
            }
            return View("StaffList", model);
        }
        public IActionResult StaffList()
		{
			return View();
		}
		public IActionResult StaffAddEdit()
		{
			return View();
		}
	}
}
