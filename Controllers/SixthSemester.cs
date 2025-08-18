using Microsoft.AspNetCore.Mvc;
using SamriddhaNew.Models;
namespace SamriddhaNew.Controllers
{
    public class SixthSemester : Controller
    {
        public string  Index()
        {
            return "Hello World";
        }
        public IActionResult AddStudents(AddStudentsModel model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("geting values from user");
                Console.WriteLine(model.FullName);
                Console.WriteLine(model.Address);

                ViewBag.Message = "Student added successfully!";
                ModelState.Clear();

                return View(new AddStudentsModel());
            }
            return View(model);
        }
    }
}
