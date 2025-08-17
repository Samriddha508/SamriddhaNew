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
            return View(new AddStudentsModel());
        }
    }
}
