using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public IndexModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }
        [BindProperty]
        public IList<Company> Companies { get; set; }
        public async Task OnGetAsync()
        {
            Companies = await _context.Company.ToListAsync();
            Student = await _context.Student.ToListAsync();
        }
    }
}
