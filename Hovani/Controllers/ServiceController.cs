using Hovani.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hovani.Controllers
{
    public class ServiceController : Controller
    {
        public List<Service> Services { get; set; } = new List<Service>()
        {
            new Service(){Id = 1, Name = "Kare", price = 500.50f, Sex = GenderType.Female },
            new Service(){Id = 2, Name = "Tenis", price = 300, Sex = GenderType.Male },
        };

        [HttpGet]
        public IActionResult ServiceView()
        {
            return View(Services);
        }
    }
}
