using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.Sales
{
    public class DeleteModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public DeleteModel(GadgetHub.Data.GadgetHubContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Sales Sales { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sales = await _context.Sales
                .Include(s => s.Customer)
                .Include(s => s.Products).FirstOrDefaultAsync(m => m.SalesID == id);

            if (Sales == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sales = await _context.Sales.FindAsync(id);

            if (Sales != null)
            {
                _context.Sales.Remove(Sales);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
