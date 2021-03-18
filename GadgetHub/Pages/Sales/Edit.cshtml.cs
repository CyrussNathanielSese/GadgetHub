using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.Sales
{
    public class EditModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public EditModel(GadgetHub.Data.GadgetHubContext context)
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
           ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerFirstname");
           ViewData["ProductsID"] = new SelectList(_context.Products, "ProductsID", "ProductName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesExists(Sales.SalesID))
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

        private bool SalesExists(int id)
        {
            return _context.Sales.Any(e => e.SalesID == id);
        }
    }
}
