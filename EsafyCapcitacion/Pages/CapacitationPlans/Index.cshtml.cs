﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.CapacitationPlans
{
    public class IndexModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public IndexModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        public IList<CapacitationPlan> CapacitationPlan { get;set; }

        public async Task OnGetAsync()
        {
            CapacitationPlan = await _context.CapacitationPlan.ToListAsync();
        }
    }
}
