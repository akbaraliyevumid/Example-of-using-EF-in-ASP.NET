using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationFormASP.Models;
using System.Diagnostics;
using RegistrationFormASP.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RegistrationFormASP.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Users.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}