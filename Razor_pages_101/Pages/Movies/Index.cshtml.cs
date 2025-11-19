using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_pages_101.Data;
using Razor_pages_101.Models;

namespace Razor_pages_101.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Razor_pages_101.Data.Razor_pages_101Context _context;

        public IndexModel(Razor_pages_101.Data.Razor_pages_101Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
