using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;
using Microsoft.EntityFrameworkCore;

namespace EsafyCapcitacion.Pages.Exams
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
            TestsList = await _context.CourseTest.ToListAsync();
            CourseList = await _context.Course.ToListAsync();
            ViewData["CourseTestId"] = teid;
            ViewData["TestsList"] = cuid;
            ViewData["Courses"] = new SelectList(_context.Course, "CourseId", "CourseName");
            ViewData["Tests"] = new SelectList(_context.CourseTest, "CourseTestId", "CourseTestName");
            ViewData["Students"] = new SelectList(_context.Student, "PersonId", "ShortName");
            return Page();
        }

        [BindProperty]
        public Examination Examination { get; set; }
        [BindProperty]
        public TestQuestion TestQuestion { get; set; }
        [BindProperty]
        public IList<CourseTest> TestsList { get; set; }
        [BindProperty]
        public IList<Course> CourseList { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Examination.Add(Examination);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}