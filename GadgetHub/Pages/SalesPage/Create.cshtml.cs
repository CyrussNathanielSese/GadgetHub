using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.SalesPage
{
    public class CreateModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public CreateModel(GadgetHub.Data.GadgetHubContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerFullname");
        ViewData["EmployeesID"] = new SelectList(_context.Employees, "EmployeesID", "EmployeeFullname");
        ViewData["ProductsID"] = new SelectList(_context.Products, "ProductsID", "ProductName");
            return Page();
        }

        [BindProperty]
        public Sales Sales { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sales.Add(Sales);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
