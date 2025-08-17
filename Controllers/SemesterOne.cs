using Microsoft.AspNetCore.Mvc; 
namespace SamriddhaNew.Controllers
{
    public class SemesterOne : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}