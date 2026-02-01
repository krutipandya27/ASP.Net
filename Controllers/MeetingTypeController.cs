using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{

	public class MeetingTypeController : Controller
	{
        public IActionResult Save(MeetingTypeModel model)
        {
            if (!ModelState.IsValid)
            {
				Console.WriteLine("fail");
                Console.WriteLine(ModelState);
                return View("MeetingTypeAddEdit", model);
            }
            Console.WriteLine("passR");
            return View("MeetingTypeList", model);
        }

        public IActionResult MeetingTypeList()
		{
			return View();
		}
		public IActionResult MeetingTypeAddEdit()
		{
			return View();
		}
	}
}
