﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Pages.Options
{
    public class EditModel : PageModel
    {
        private readonly EsafyCapcitacion.Models.EsafyCapcitacionContext _context;

        public EditModel(EsafyCapcitacion.Models.EsafyCapcitacionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public QuestionOption QuestionOption { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuestionOption = await _context.QuestionOption.FirstOrDefaultAsync(m => m.QuestionOptionId == id);

            if (QuestionOption == null)
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

            _context.Attach(QuestionOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionOptionExists(QuestionOption.QuestionOptionId))
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

        private bool QuestionOptionExists(int id)
        {
            return _context.QuestionOption.Any(e => e.QuestionOptionId == id);
        }
    }
}