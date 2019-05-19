using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsafyCapcitacion.Models;
using Microsoft.EntityFrameworkCore;

namespace EsafyCapcitacion.Pages.Options
{
    public class CreateModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public CreateModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int cuid, int teid, int quid)
        {
            // Course = await _context.Course.Where(cu => cu.CourseId == cuid).First();
            ViewData["QuestionId"] = quid;
            ViewData["CourseId"] = cuid;
            ViewData["TestId"] = teid;
            CourseTest = await   _context.CourseTest.Where(cu => cu.CourseTestId == teid).FirstAsync();
            Course = await   _context.Course.Where(cu => cu.CourseId == cuid).FirstAsync();
            TestQuestion = await _context.TestQuestion.Where(qu => qu.TestQuestionId == quid).FirstAsync();
            return Page();
            
        }

        [BindProperty]
        public QuestionOption QuestionOption { get; set; }

        [BindProperty]
        public Course Course { get; set; }
        [BindProperty]
        public CourseTest CourseTest { get; set; }
        [BindProperty]
        public TestQuestion TestQuestion { get; set; }



        public async Task<IActionResult> OnPostAsync(int cuid, int teid, int quid)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CourseTest = await _context.CourseTest.Where(cu => cu.CourseTestId == teid).FirstAsync();
            Course = await _context.Course.Where(cu => cu.CourseId == cuid).FirstAsync();
            TestQuestion = await _context.TestQuestion.Where(qu => qu.TestQuestionId == quid).Include(q=>q.OptionList).FirstAsync();
            TestQuestion.OptionList.Add(QuestionOption);
            _context.QuestionOption.Add(QuestionOption);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Tests/Details", new { teid });
        }
    }
}