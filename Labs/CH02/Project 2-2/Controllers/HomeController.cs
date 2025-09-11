using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Tip()); // Empty when page loads
        }

        [HttpPost]
        public IActionResult Index(Tip model)
        {
            if (model.MealCost == null || model.MealCost <= 0)
            {
                ModelState.AddModelError("MealCost", "Meal cost is required and must be greater than 0.");
            }

            return View(model);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}

  