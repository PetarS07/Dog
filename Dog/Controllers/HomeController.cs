using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Dog.Data;
using System.Threading.Tasks;

namespace Dog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Началната страница
        public IActionResult Index()
        {
            return View();
        }

        // Показване на информация за куче
        [Authorize] // Requires login
        public async Task<IActionResult> MoreInfo(int id)
        {
            var dog = await _context.Dogs.FirstOrDefaultAsync(d => d.Id == id);
            if (dog == null)
            {
                return NotFound();
            }
            return View(dog);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
