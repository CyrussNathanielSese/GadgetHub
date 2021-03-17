using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GadgetHub.Data;
using GadgetHub.Models;

namespace GadgetHub.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly GadgetHub.Data.GadgetHubContext _context;

        public IndexModel(GadgetHub.Data.GadgetHubContext context)
        {
            _context = context;
        }

        public IList<Models.Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
