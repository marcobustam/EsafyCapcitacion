using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;
using Microsoft.EntityFrameworkCore;

namespace EsafyCapcitacion.Pages.Questions
{
    public class CreateModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public CreateModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int cuid, int teid)
        {
            CourseTest = await _context.CourseTest.FindAsync(teid);
            Course = await _context.Course.FindAsync(cuid);
            ViewData["CourseTestId"] = teid;
            ViewData["CourseId"] = cuid;
            return Page();
        }

        [BindProperty]
        public TestQuestion TestQuestion { get; set; }
        [BindProperty]
        public CourseTest CourseTest { get; set; }
        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync(int cuid, int teid)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Course = await _context.Course.FindAsync(cuid);
            CourseTest = await _context.CourseTest.Where(ct=>ct.CourseTestId==teid && ct.CourseId==cuid).Include(cu=>cu.QuestionList).FirstAsync();
            
            CourseTest.QuestionList.Add(TestQuestion);
            
            _context.TestQuestion.Add(TestQuestion);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Tests/Details", new { teid });
        }
    }
}