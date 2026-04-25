using Microsoft.AspNetCore.Mvc;

namespace StudyLovers.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult DoctorSchedule()
        {
            return View(); 
        }


       
        public IActionResult subjects()
        {
            return View(); 
        }

        public IActionResult assignment()
        {
            return View();
        }

        public IActionResult chat()
        {
            return View();
        }

        public IActionResult profile()
        {
            return View();
        }

    }
}
