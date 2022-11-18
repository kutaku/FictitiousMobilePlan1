using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FictitiousMobilePlan1.Models;

namespace FictitiousMobilePlan1.Pages.Phones
{
    public class DeleteModel : PageModel
    {
        private readonly FictitiousMobilePlan1.Models.MyContext _context;

        public DeleteModel(FictitiousMobilePlan1.Models.MyContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Phone == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone.FirstOrDefaultAsync(m => m.Id == id);

            if (phone == null)
            {
                return NotFound();
            }
            else 
            {
                Phone = phone;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Phone == null)
            {
                return NotFound();
            }
            var phone = await _context.Phone.FindAsync(id);

            if (phone != null)
            {
                Phone = phone;
                _context.Phone.Remove(Phone);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
