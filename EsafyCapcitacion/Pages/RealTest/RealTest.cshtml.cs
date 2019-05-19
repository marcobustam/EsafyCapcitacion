using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsafyCapcitacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EsafyCapcitacion.Pages.RealTest
{
    public class RealTestModel : PageModel
    {
        [BindProperty]
        public TestQuestion TestQuestion { get; set; }
        [BindProperty]
        public CourseTest CourseTest { get; set; }
        [BindProperty]
        public Course Course { get; set; }
        [BindProperty]
        public IList<QuestionOption> OptionList { get; set; }

        private readonly EsafyCapcitacionContext _context;

        public RealTestModel(EsafyCapcitacionContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int exid, int cuid, int teid, int quid)
        {
            CourseTest = await _context.CourseTest.FindAsync(teid);
            Course = await _context.Course.FindAsync(cuid);
            TestQuestion = await _context.TestQuestion.Where(op => op.TestQuestionId == quid).Include(cu=>cu.OptionList).FirstAsync();
            OptionList = await _context.QuestionOption.Where(op => op.TestQuestionId == quid).ToListAsync();
            return Page();
        }
    }
}