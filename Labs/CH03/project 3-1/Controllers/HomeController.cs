using Microsoft.AspNetCore.Mvc;

namespace Project3_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redirect to Quotation form
            return RedirectToAction("Index", "Quotation");
        }
    }
}
