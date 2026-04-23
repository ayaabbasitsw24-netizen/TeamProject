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


    }
}