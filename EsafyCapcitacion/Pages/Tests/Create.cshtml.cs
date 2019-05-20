using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Tests
{
    public class CreateModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public CreateModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int cuid)
        {
            Course = _context.Course.Find(cuid);
            ViewData["CourseId"] = cuid;
            return Page();
        }

        [BindProperty]
        public CourseTest CourseTest { get; set; }
        [BindProperty]
        public Course Course { get; set; }
        public async Task<IActionResult> OnPostAsync(int cuid)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CourseTest.Add(CourseTest);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Courses/Index", new { cuid });
        }
    }
}