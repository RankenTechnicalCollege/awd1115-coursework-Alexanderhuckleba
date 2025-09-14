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
                return View(model);
            }
            return View(new QuotationViewModel());
        }
    }
}
