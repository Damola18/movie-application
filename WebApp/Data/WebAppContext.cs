#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
    #pragma warning disable CS8618
        public WebAppContext (DbContextOptions<WebAppContext> options)
    #pragma warning restore CS8618
            : base(options)
        {
        }

        public DbSet<WebApp.Models.Movie> Movie { get; set; }
    }
}
