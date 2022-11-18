using FictitiousMobilePlan1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FictitiousMobilePlan1.Pages.Basic
{
    public class ListModel : PageModel
    {
        public IEnumerable<Phone> Phone { get; set; }
        private readonly MyContext _context;
        public ListModel(MyContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Phone = _context.Phone;
        }
    }
}
