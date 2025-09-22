using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project3_1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_1.Controllers
{
    public class QuotationController : Controller
    {
        private readonly Project3_1Context _context;
        public QuotationController(Project3_1Context context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var quotations = await _context.Quotations
                .Include(q => q.Customer)
                .Include(q => q.QuotationProducts)
                    .ThenInclude(qp => qp.Product)
                .ToListAsync();
            return View(quotations);
        }

        public IActionResult Create()
        {
            ViewData["Customers"] = new SelectList(_context.Customers, "CustomerId", "CustomerName");
            ViewData["Products"] = new MultiSelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Quotation quotation, int[] SelectedProductIds)
        {
            if (ModelState.IsValid)
            {
                quotation.DiscountAmount = quotation.Subtotal * (quotation.DiscountPercent / 100);
                quotation.Total = quotation.Subtotal - quotation.DiscountAmount;

                _context.Quotations.Add(quotation);
                await _context.SaveChangesAsync();

                foreach (var pid in SelectedProductIds)
                {
                    _context.QuotationProducts.Add(new QuotationProduct
                    {
                        QuotationId = quotation.QuotationId,
                        ProductId = pid
                    });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customers"] = new SelectList(_context.Customers, "CustomerId", "CustomerName");
            ViewData["Products"] = new MultiSelectList(_context.Products, "ProductId", "ProductName");
            return View(quotation);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var quotation = await _context.Quotations
                .Include(q => q.QuotationProducts)
                .FirstOrDefaultAsync(q => q.QuotationId == id);
            if (quotation == null) return NotFound();

            ViewData["Customers"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", quotation.CustomerId);
            ViewData["Products"] = new MultiSelectList(_context.Products, "ProductId", "ProductName", quotation.QuotationProducts.Select(qp => qp.ProductId));
            return View(quotation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Quotation quotation, int[] SelectedProductIds)
        {
            if (id != quotation.QuotationId) return NotFound();

            if (ModelState.IsValid)
            {
                quotation.DiscountAmount = quotation.Subtotal * (quotation.DiscountPercent / 100);
                quotation.Total = quotation.Subtotal - quotation.DiscountAmount;

                _context.Update(quotation);
                await _context.SaveChangesAsync();

                var existing = _context.QuotationProducts.Where(qp => qp.QuotationId == id);
                _context.QuotationProducts.RemoveRange(existing);
                foreach (var pid in SelectedProductIds)
                {
                    _context.QuotationProducts.Add(new QuotationProduct { QuotationId = id, ProductId = pid });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customers"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", quotation.CustomerId);
            ViewData["Products"] = new MultiSelectList(_context.Products, "ProductId", "ProductName", SelectedProductIds);
            return View(quotation);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var quotation = await _context.Quotations
                .Include(q => q.Customer)
                .Include(q => q.QuotationProducts)
                    .ThenInclude(qp => qp.Product)
                .FirstOrDefaultAsync(q => q.QuotationId == id);
            if (quotation == null) return NotFound();
            return View(quotation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quotation = await _context.Quotations.FindAsync(id);
            _context.Quotations.Remove(quotation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
