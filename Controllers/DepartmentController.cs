using Microsoft.AspNetCore.Mvc;
using MOM.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MOM.Controllers
{
	public class DepartmentController : Controller
	{
		public IActionResult Save(DepartmentModel model)
		{
			ModelState.Remove("DepartmentName");
			if (string.IsNullOrEmpty(model.DepartmentName))
			{
				ModelState.AddModelError("DepartmentName", "Name can't be empty");
			}
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                }
            }
            if (!ModelState.IsValid)	
			{
				return View("DepartmentAddEdit", model);
			}
			return RedirectToAction("DepartmentList", model);
		}


		public IActionResult DepartmentList()
		{
			return View();
		}
		public IActionResult DepartmentAddEdit()
		{
			return View();
		}
	}
}
