using Microsoft.AspNetCore.Mvc;
using HOT1.Models;

namespace HOT1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.CalculateTotal();
            return View(model);
        }
    }
}
