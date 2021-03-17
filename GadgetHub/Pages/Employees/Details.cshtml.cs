using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public DetailsModel(GadgetHub.Data.GadgetHubContext context)
        {
            _context = context;
        }

        public Models.Employees Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employees = await _context.Employees.FirstOrDefaultAsync(m => m.EmployeesID == id);

            if (Employees == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
