using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Models
{
    public class AddMovieContext : DbContext
    {
        //constructor
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base(options)
        {

        }
        public DbSet<NewMovie> newMovies { get; set; }
        public DbSet<Category> Categories { get; set; }
        //this is where I will seed my database entries with my top 3

        //this is my category table with the possible values that could be found in it
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category {CategoryID=1, CategoryName="Action" },
                new Category { CategoryID = 2, CategoryName = "Thriller" },
                new Category { CategoryID = 3, CategoryName = "Western" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Drama" },
                new Category { CategoryID = 6, CategoryName = "Romance" },
                new Category { CategoryID = 7, CategoryName = "Science Fiction" },
                new Category { CategoryID = 8, CategoryName = "Comedy" },
                new Category { CategoryID = 9, CategoryName = "Adventure" },
                new Category { CategoryID = 10, CategoryName = "Documentary" },
                new Category { CategoryID = 11, CategoryName = "Crime" },
                new Category { CategoryID = 12, CategoryName = "Historical" },
                new Category { CategoryID = 13, CategoryName = "Musical" },
                new Category { CategoryID = 14, CategoryName = "Romantic Comedy" },
                new Category { CategoryID = 15, CategoryName = "Sports" },
                new Category { CategoryID = 16, CategoryName = "Other" }
                );
            mb.Entity<NewMovie>().HasData(

                new NewMovie
                {
                    MovieID = 1,
                    MovieTitle = "Remember The Titans",
                    YearCreated = 2001,
                    Director = "Boaz Yakin",
                    Rating = "PG",
                    Notes = "None",
                    LentTo = "Sarah Pearce",
                    CategoryID = 15,
                    IsEdited = "No"
                },

                new NewMovie
                {
                    MovieID = 2,
                    MovieTitle = "Darkest Hour",
                    YearCreated = 2018,
                    Director = "Joe Wright",
                    Rating = "PG-13",
                    Notes = "None",
                    LentTo = "N/A",
                    CategoryID = 12,
                    IsEdited = "No"
                },

                new NewMovie
                {
                    MovieID = 3,
                    MovieTitle = "Inception",
                    YearCreated = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Notes = "None",
                    LentTo = "N/A",
                    CategoryID = 1,
                    IsEdited = "No"
                } 
            );
        }
    }
}
