using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.CapacitationPlans
{
    public class CreateModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;
        public Company Company { get; set; }

        public CreateModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int comid)
        {
            Company = await _context.Company.FindAsync(comid);
            if(Company == null)
            {
                return Redirect("Error");
            }
            return Page();
        }

        [BindProperty]
        public CapacitationPlan CapacitationPlan { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CapacitationPlan.Created = DateTime.Now;
            CapacitationPlan.Modified = DateTime.Now;
            _context.CapacitationPlan.Add(CapacitationPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}