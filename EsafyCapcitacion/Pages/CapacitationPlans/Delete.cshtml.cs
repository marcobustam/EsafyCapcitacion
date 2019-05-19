using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.CapacitationPlans
{
    public class DeleteModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public DeleteModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CapacitationPlan CapacitationPlan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CapacitationPlan = await _context.CapacitationPlan.FirstOrDefaultAsync(m => m.CapacitationPlanId == id);

            if (CapacitationPlan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CapacitationPlan = await _context.CapacitationPlan.FindAsync(id);

            if (CapacitationPlan != null)
            {
                _context.CapacitationPlan.Remove(CapacitationPlan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
