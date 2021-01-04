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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesEfCrud.Data.MenuContext _context;

        public IndexModel(RazorPagesEfCrud.Data.MenuContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; }

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}
