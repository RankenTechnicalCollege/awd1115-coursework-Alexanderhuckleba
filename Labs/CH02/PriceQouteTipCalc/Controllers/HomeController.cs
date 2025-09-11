using Microsoft.AspNetCore.Mvc;
using PriceQouteTipCalc.Models;

namespace PriceQouteTipCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // default model values on startup
            var model = new Quotation();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Quotation model)
        {
            if (model.Subtotal == null || model.Subtotal <= 0)
            {
                ModelState.AddModelError("Subtotal", "Subtotal is required and must be greater than 0.");
            }

            if (model.DiscountPercent == null || model.DiscountPercent < 0 || model.DiscountPercent > 100)
            {
                ModelState.AddModelError("DiscountPercent", "Discount percent must be between 0 and 100.");
            }

            return View(model);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
