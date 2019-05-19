using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Tests
{
    public class DetailsModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public DetailsModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public CourseTest CourseTest { get; set; }

        public async Task<IActionResult> OnGetAsync(int teid)
        {
            if (teid == null)
            {
                return NotFound();
            }

            CourseTest = await _context.CourseTest.Where(m => m.CourseTestId == teid).Include(co=>co.QuestionList).ThenInclude(cu=>cu.OptionList).FirstAsync();

            if (CourseTest == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
