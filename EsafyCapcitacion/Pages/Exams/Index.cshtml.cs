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
    public class IndexModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public IndexModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {

            _context = context;
        }

        public IList<Examination> Examination { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Examination = await _context.Examination.ToListAsync();
            // Course = await _context.Course.Where(cu => cu.CourseId == cuid).First();
            //ViewData["QuestionId"] = quid;
            //ViewData["CourseId"] = cuid;
            //ViewData["TestId"] = teid;
            CourseTests = await _context.CourseTest.ToListAsync();
            Courses = await _context.Course.ToListAsync();
            // TestQuestion = await _context.TestQuestion.Where(qu => qu.TestQuestionId == quid).FirstAsync();
            Students = await _context.Student.ToListAsync();
            return Page();

        }

        [BindProperty]
        public QuestionOption QuestionOption { get; set; }

        [BindProperty]
        public IList<Course> Courses { get; set; }
        [BindProperty]
        public IList<CourseTest> CourseTests { get; set; }
        [BindProperty]
        public IList<Student> Students { get; set; }
    }
}
