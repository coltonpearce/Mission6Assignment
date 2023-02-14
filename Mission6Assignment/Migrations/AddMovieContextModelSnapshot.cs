﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6Assignment.Models;

namespace Mission6Assignment.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    partial class AddMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6Assignment.Models.NewMovie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsEdited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearCreated")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("newMovies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Sports",
                            IsEdited = "No",
                            LentTo = "Sarah Pearce",
                            MovieTitle = "Remember The Titans",
                            Notes = "None",
                            Rating = "PG",
                            YearCreated = 2001
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Historical",
                            IsEdited = "No",
                            LentTo = "N/A",
                            MovieTitle = "Darkest Hour",
                            Notes = "None",
                            Rating = "PG-13",
                            YearCreated = 2018
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Thriller",
                            IsEdited = "No",
                            LentTo = "N/A",
                            MovieTitle = "Inception",
                            Notes = "None",
                            Rating = "PG-13",
                            YearCreated = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
