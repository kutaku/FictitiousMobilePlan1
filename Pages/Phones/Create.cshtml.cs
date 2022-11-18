using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FictitiousMobilePlan1.Models;

namespace FictitiousMobilePlan1.Pages.Phones
{
    public class CreateModel : PageModel
    {
        private readonly FictitiousMobilePlan1.Models.MyContext _context;

        public CreateModel(FictitiousMobilePlan1.Models.MyContext context)
        {
            _context = context;
        }

        public SelectList PlanOptions { get; set; }


		public IActionResult OnGet()
        {
            var list = _context.Phone
                .Select(p => new { PlanName = p.PlanName })
                .Distinct();
            PlanOptions = new SelectList(list, "PlanName", "PlanName");
            return Page();
        }

        [BindProperty]
        public Phone Phone { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Phone.Add(Phone);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
