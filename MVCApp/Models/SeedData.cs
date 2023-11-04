using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;


namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Inicialize(IServiceProvider serviceProvider)
        {

            using (var context = new MVCAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCAppContext>>()))

            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Spider Man",
                        RealeseDate = DateTime.Parse("1999-10-01"),
                        Genre = "Action",
                        Price = 3.9M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Spider Man 2",
                        RealeseDate = DateTime.Parse("2001-7-1"),
                        Genre = "Action",
                        Price = 9.9M,
                        Rating = "NA"
                    },
                    new Movie
                    {
                        Title = "Capitan American",
                        RealeseDate = DateTime.Parse("2007-2-20"),
                        Genre = "Adventure",
                        Price = 7.2M,
                        Rating = "PI-11"
                    },
                    new Movie
                    {
                        Title = "El Pianista",
                        RealeseDate = DateTime.Parse("2005-7-19"),
                        Genre = "Action",
                        Price = 1.2M,
                        Rating = "PG-13"
                    }
                    );
                context.SaveChanges();
            }


        }
    }
}
