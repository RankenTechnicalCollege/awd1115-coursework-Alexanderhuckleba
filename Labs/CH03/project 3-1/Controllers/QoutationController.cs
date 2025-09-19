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
                model.DiscountAmount = model.Subtotal * (model.DiscountPercent / 100);
                model.Total = model.Subtotal - model.DiscountAmount;
            }
            return View(model);
        }
    }
}
