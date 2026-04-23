using Microsoft.AspNetCore.Mvc;

namespace StudyLovers.Controllers
{
    public class DoctorController : Controller
    {
        // 🔹 عرض لوحة الدكتور
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult DoctorSchedule()
        {
            return View(); // ✅ يعود لملف DoctorSchedule.cshtml
        }
    }
}