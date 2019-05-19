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
    public class IndexModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public IndexModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IList<CourseTest> CourseTest { get;set; }

        public async Task OnGetAsync(int cuid)
        {
            CourseTest = await _context.CourseTest.Where(ct=>ct.CourseTestId==cuid).ToListAsync();
        }
    }
}
