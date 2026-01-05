using Microsoft.EntityFrameworkCore;
using MvcMovieFinal.Data;

namespace MvcMovieFinal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                var comedy = new Category { Name = "Romantic Comedy" };
                var action = new Category { Name = "Action" };
                var western = new Category { Name = "Western" };
                var horror = new Category { Name = "Horror" };

                context.Category.AddRange(comedy, action, western, horror);
                context.SaveChanges();

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        CategoryId = comedy.Id,
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        CategoryId = comedy.Id,
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        CategoryId = western.Id,
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}