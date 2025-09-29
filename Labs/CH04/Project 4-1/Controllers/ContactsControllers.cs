using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project4_1.Data;
using Project4_1.Models;
using System.Threading.Tasks;

namespace Project4_1.Controllers
{
    public class ContactsController : Controller
    {
        private readonly AppDbContext _context;
        public ContactsController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var contacts = _context.Contacts.Include(c => c.Category);
            return View(await contacts.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CategoryId = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Categories, "CategoryId", "Name", contact.CategoryId);
            return View(contact);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();

            ViewBag.CategoryId = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Categories, "CategoryId", "Name", contact.CategoryId);
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Contact contact)
        {
            if (id != contact.ContactId) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CategoryId = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Categories, "CategoryId", "Name", contact.CategoryId);
            return View(contact);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var contact = await _context.Contacts.Include(c => c.Category).FirstOrDefaultAsync(c => c.ContactId == id);
            if (contact == null) return NotFound();
            return View(contact);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var contact = await _context.Contacts.Include(c => c.Category).FirstOrDefaultAsync(c => c.ContactId == id);
            if (contact == null) return NotFound();
            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
