using HOT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HOT1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new OrderModel());
        }

        [HttpPost]
        public IActionResult Index(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                decimal discountPercent = 0m;

                if (!string.IsNullOrEmpty(model.DiscountCode))
                {
                    switch (model.DiscountCode)
                    {
                        case "6175": discountPercent = 0.30m; break;
                        case "1390": discountPercent = 0.20m; break;
                        case "BB88": discountPercent = 0.10m; break;
                        default:
                            model.ErrorMessage = "Invalid discount code.";
                            discountPercent = 0m;
                            break;
                    }
                }

                int quantity = model.Quantity.GetValueOrDefault();
                model.Subtotal = quantity * model.ShirtPrice * (1 - discountPercent);
                model.Tax = model.Subtotal * 0.08m;
                model.Total = model.Subtotal + model.Tax;

                return View("Receipt", model);
            }

            return View(model);
        }
    }
}

