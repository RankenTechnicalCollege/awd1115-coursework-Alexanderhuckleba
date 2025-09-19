using Microsoft.AspNetCore.Mvc;

namespace project_3_1.Controllers
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
