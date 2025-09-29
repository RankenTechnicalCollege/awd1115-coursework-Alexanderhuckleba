using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CH6_Final_Project.Data;
using CH6_Final_Project.Models;

namespace CH6_Final_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CH6_Final_Project.Data.AppDbContext _context;

        public IndexModel(CH6_Final_Project.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
