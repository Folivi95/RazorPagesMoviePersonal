using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviePersonal.Models;

namespace RazorPagesMoviePersonal.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMoviePersonalContext _context;

        public IndexModel(RazorPagesMoviePersonalContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
