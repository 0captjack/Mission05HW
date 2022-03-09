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
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding the batadase
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 5,
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
                    CategoryId = 3,
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
                    CategoryId = 4,
                    Title = "Jaws",
                    Year = "1975",
                    Director = "Steven Spielberg",
                    Rating = "PG",
                    Edited = false,
                    Lent_To = "",
                    Notes = "Paved the way for so many great films"
                }
            );
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Comedy" },
                new Category { CategoryId = 2, CategoryName = "Crime" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Thriller" },
                new Category { CategoryId = 5, CategoryName = "Sci-Fi" },
                new Category { CategoryId = 6, CategoryName = "Undefined" }
                //this seeds the database with categories and their IDs I think
            );
        }
    }
}
