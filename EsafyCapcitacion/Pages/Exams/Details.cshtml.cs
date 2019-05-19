using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Exams
{
    public class DetailsModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public DetailsModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public Examination Examination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Examination = await _context.Examination.FirstOrDefaultAsync(m => m.ExaminationId == id);

            if (Examination == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
