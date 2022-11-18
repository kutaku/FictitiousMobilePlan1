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
    public class IndexModel : PageModel
    {
        private readonly FictitiousMobilePlan1.Models.MyContext _context;

        public IndexModel(FictitiousMobilePlan1.Models.MyContext context)
        {
            _context = context;
        }

        public IList<Phone> Phone { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Phone != null)
            {
                Phone = await _context.Phone.ToListAsync();
            }
        }
    }
}
