using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Dog.Data;
using System.Threading.Tasks;
using Dog.Models;

namespace Dog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (!await _context.Dogs.AnyAsync())
            {
                _context.Dogs.Add(new Models.Dog
                {
                    Name = "Maxwell",
                    Breed = "Golden Retriever",
                    Age = 3,
                    MainDescription = "Friendly golden retriever",
                    DetailedDescription = "Loves playing fetch and swimming",
                    FavoriteFood = "Peanut butter",
                    FavoriteToy = "Tennis ball",
                    SpecialSkills = "Can catch treats mid-air"
                });
                await _context.SaveChangesAsync();
            }

            var dogs = await _context.Dogs.ToListAsync();
            return View(dogs);
        }

        [Authorize]
        public async Task<IActionResult> MoreInfo(int id)
        {
            var dog = await _context.Dogs.FirstOrDefaultAsync(d => d.Id == id);
            if (dog == null) return NotFound();
            return View(dog);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
