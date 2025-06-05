using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Dog.Data;

namespace Dog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize] // Requires login
        public IActionResult MoreInfo()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
