using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesEfCrud.Data;
using RazorPagesEfCrud.Models;

namespace RazorPagesEfCrud.Pages.Menus
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesEfCrud.Data.MenuContext _context;

        public DetailsModel(RazorPagesEfCrud.Data.MenuContext context)
        {
            _context = context;
        }

        public Menu Menu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = await _context.Menu.FirstOrDefaultAsync(m => m.Id == id);

            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
