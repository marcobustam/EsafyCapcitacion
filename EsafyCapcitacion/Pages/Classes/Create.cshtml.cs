using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Classes
{
    public class CreateModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public CreateModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CapacitationClass CapacitationClass { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CapacitationClass.Created = DateTime.Now;
            CapacitationClass.Modified = DateTime.Now;
            _context.CapacitationClass.Add(CapacitationClass);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}