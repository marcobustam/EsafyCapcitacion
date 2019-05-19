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
    public class DetailsModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public DetailsModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }
        [BindProperty]
        public CapacitationPlan CapacitationPlan { get; set; }
        public IList<Course> CourseList { get; set; }
        [BindProperty]
        public Course AddCourse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CourseList = await _context.Course.ToListAsync();
            CapacitationPlan = await _context.CapacitationPlan.FirstOrDefaultAsync(m => m.CapacitationPlanId == id);

            if (CapacitationPlan == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            CapacitationPlan.CourseList.Add(AddCourse);
            CapacitationPlan.Modified = DateTime.Now;


            _context.Attach(CapacitationPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapacitationPlanExists(CapacitationPlan.CapacitationPlanId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CapacitationPlanExists(int id)
        {
            return _context.CapacitationPlan.Any(e => e.CapacitationPlanId == id);
        }
    }
}
