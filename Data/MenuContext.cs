using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesEfCrud.Models;

namespace RazorPagesEfCrud.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext (DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesEfCrud.Models.Menu> Menu { get; set; }
    }
}
