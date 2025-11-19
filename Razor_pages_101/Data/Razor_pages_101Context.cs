using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_pages_101.Models;

namespace Razor_pages_101.Data
{
    public class Razor_pages_101Context : DbContext
    {
        public Razor_pages_101Context (DbContextOptions<Razor_pages_101Context> options)
            : base(options)
        {
        }

        public DbSet<Razor_pages_101.Models.Movie> Movie { get; set; } = default!;
    }
}
