using Microsoft.EntityFrameworkCore;
using ViewBag_ViewData_TempData_FrontBack.Models;
namespace ViewBag_ViewData_TempData_FrontBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }


    }
}
