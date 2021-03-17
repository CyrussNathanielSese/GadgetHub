using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public DetailsModel(GadgetHub.Data.GadgetHubContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ProductsID == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
