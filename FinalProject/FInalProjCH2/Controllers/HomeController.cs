using Microsoft.AspNetCore.Mvc;
using FinalProjCH2.Models;

namespace FinalProjCH2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Quotation());
        }

        [HttpPost]
        public IActionResult Index(Quotation model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View(new Quotation());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = HttpContext.TraceIdentifier
            });
        }
    }
}
