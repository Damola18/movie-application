using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace WebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var context = new WebAppContext (
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppContext>>()))
            {
                if( context == null || context.Movie == null)
                {
                    throw new ArgumentException("Null WebAppContext");
                }

                // Look for any movies
                if( context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Power",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Sitcom",
                        Price = 10.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
