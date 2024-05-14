using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ViewBag_ViewData_TempData_FrontBack.Data;
using ViewBag_ViewData_TempData_FrontBack.Models;

namespace ViewBag_ViewData_TempData_FrontBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

      
    }
}
