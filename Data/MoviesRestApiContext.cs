using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesRestApi.Models;

namespace MoviesRestApi.Data
{
    public class MoviesRestApiContext : DbContext
    {
        public MoviesRestApiContext (DbContextOptions<MoviesRestApiContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesRestApi.Models.Movie> Movie { get; set; }
    }
}
