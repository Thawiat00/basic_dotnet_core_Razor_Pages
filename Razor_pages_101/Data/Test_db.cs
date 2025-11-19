using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_pages_101.Models;

    public class Test_db : DbContext
    {
        public Test_db (DbContextOptions<Test_db> options)
            : base(options)
        {
        }

        public DbSet<Razor_pages_101.Models.Movie> Movie { get; set; } = default!;
    }
