using Microsoft.AspNetCore.Mvc;

namespace StudyLovers.Controllers
{
    public class StudentController : Controller
    {
        // 🔹 عرض لوحة الطالب
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult StudentSchedule()
        {
            return View();
        }

        public IActionResult lectures()
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
