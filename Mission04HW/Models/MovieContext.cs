using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04HW.Models
{
    public class MovieContext :DbContext
    {
        public MovieContext (DbContextOptions <MovieContext> options) : base (options)
        {
            //lEbLaNc
        }    
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding the batadase
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Sci-Fi",
                    Title = "Sunshine",
                    Year = "2007",
                    Director = "Danny Boyle",
                    Rating = "R",
                    Edited = false,
                    Lent_To = "",
                    Notes = "This movie is incredible"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Drama",
                    Title = "Prisoners",
                    Year = "2013",
                    Director = "Denis Villeneuve",
                    Rating = "R",
                    Edited = false,
                    Lent_To = "",
                    Notes = "Excellent"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Thriller",
                    Title = "Jaws",
                    Year = "1975",
                    Director = "Steven Spielberg",
                    Rating = "PG",
                    Edited = false,
                    Lent_To = "",
                    Notes = "Paved the way for so many great films"
                }
            );
        }
    }
}
