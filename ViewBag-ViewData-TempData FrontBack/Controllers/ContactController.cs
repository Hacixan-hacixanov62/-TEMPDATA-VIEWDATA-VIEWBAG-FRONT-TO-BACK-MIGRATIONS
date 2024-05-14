using Microsoft.AspNetCore.Mvc;

namespace ViewBag_ViewData_TempData_FrontBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
