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
        //this is where I will seed my database entries with my top 3
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData(
         
                new NewMovie
                {
                    MovieID = 1,
                    MovieTitle = "Remember The Titans",
                    YearCreated = 2001,
                    Rating = "PG",
                    Notes = "None",
                    LentTo = "Sarah Pearce",
                    Category = "Sports",
                    IsEdited = "No"
                },

                new NewMovie
                {
                    MovieID = 2,
                    MovieTitle = "Darkest Hour",
                    YearCreated = 2018,
                    Rating = "PG-13",
                    Notes = "None",
                    LentTo = "N/A",
                    Category = "Historical",
                    IsEdited = "No"
                },

                new NewMovie
                {
                    MovieID = 3,
                    MovieTitle = "Inception",
                    YearCreated = 2008,
                    Rating = "PG-13",
                    Notes = "None",
                    LentTo = "N/A",
                    Category = "Thriller",
                    IsEdited = "No"
                }
            );
        }
    }
}
