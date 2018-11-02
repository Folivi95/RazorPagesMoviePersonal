using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviePersonal.Models;

namespace RazorPagesMoviePersonal.Models
{
    public class RazorPagesMoviePersonalContext : DbContext
    {
        public RazorPagesMoviePersonalContext (DbContextOptions<RazorPagesMoviePersonalContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
