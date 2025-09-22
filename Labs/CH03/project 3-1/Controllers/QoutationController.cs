using Microsoft.AspNetCore.Mvc;
using project_3_1.Models;

namespace project_3_1.Controllers
{
    public class QuotationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new QuotationViewModel());
        }

        [HttpPost]
        public IActionResult Index(QuotationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Safely handle nullable decimals
                var subtotal = model.Subtotal ?? 0;
                var discountPercent = model.DiscountPercent ?? 0;

                model.DiscountAmount = subtotal * (discountPercent / 100);
                model.Total = subtotal - model.DiscountAmount;
            }

            return View(model);
        }
    }
}
