using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebKelimeOyunu.Controllers
{
    [Authorize(Roles = "Gamer")]
    public class GamerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GameArena()
        {
            return View();
        }
    }
}
