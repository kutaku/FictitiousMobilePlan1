﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FictitiousMobilePlan1.Models;

namespace FictitiousMobilePlan1.Pages.Phones
{
    public class EditModel : PageModel
    {
        private readonly FictitiousMobilePlan1.Models.MyContext _context;

        public EditModel(FictitiousMobilePlan1.Models.MyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Phone Phone { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Phone == null)
            {
                return NotFound();
            }

            var phone =  await _context.Phone.FirstOrDefaultAsync(m => m.Id == id);
            if (phone == null)
            {
                return NotFound();
            }
            Phone = phone;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Phone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneExists(Phone.Id))
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

        private bool PhoneExists(int id)
        {
          return _context.Phone.Any(e => e.Id == id);
        }
    }
}
