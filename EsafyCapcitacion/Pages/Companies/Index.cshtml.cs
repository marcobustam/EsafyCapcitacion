using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public IndexModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IList<Company> CompanyList { get;set; }

        public async Task OnGetAsync()
        {
            CompanyList = await _context.Company.ToListAsync();
        }
        [BindProperty]
        public Company NewCompany { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            NewCompany.Created = DateTime.Now;
            NewCompany.Modified = DateTime.Now;
            _context.Company.Add(NewCompany);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
