using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEfCrud.Data;
using RazorPagesEfCrud.Models;

namespace RazorPagesEfCrud.Pages.Menus
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesEfCrud.Data.MenuContext _context;

        public CreateModel(RazorPagesEfCrud.Data.MenuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Menu Menu { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Menu.Add(Menu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
