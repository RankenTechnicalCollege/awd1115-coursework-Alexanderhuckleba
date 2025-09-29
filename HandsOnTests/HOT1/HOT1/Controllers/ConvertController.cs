using Microsoft.AspNetCore.Mvc;
using HOT1.Models;

namespace HOT1.Controllers
{
    public class ConvertController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DistanceModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View("Result", model);
        }
    }
}
