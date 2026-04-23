using Microsoft.AspNetCore.Mvc;

namespace StudyLovers.Controllers
{
    public class AccountController : Controller
    {
        // 🔹 عرض صفحة الدخول
        public IActionResult Login()
        {
            return View();
        }

        // 🔹 استلام بيانات تسجيل الدخول من النموذج
        [HttpPost]
        public IActionResult Login(string Email, string Password, string UserType)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                ViewBag.Error = "يرجى إدخال البريد وكلمة المرور";
                return View();
            }

            // توجيه حسب النوع (بسيط مؤقتاً)
            if (UserType == "Doctor")
                return RedirectToAction("Dashboard", "Doctor");
            else
                return RedirectToAction("Dashboard", "Student");
        }

        // 🔹 استلام نموذج إنشاء الحساب
        [HttpPost]
        public IActionResult Register(string FullName, string Email, string Password, string UserType)
        {
            // للتجربة فقط: نتجاوز الحفظ ونوجه مباشرة
            if (UserType == "Doctor")
                return RedirectToAction("Dashboard", "Doctor");
            else
                return RedirectToAction("Dashboard", "Student");
        }
    }
}