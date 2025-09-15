using HOT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HOT1.Controllers
{
    public class ConverterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new DistanceModel());
        }

        [HttpPost]
        public IActionResult Index(DistanceModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View(model);
        }
    }
}

