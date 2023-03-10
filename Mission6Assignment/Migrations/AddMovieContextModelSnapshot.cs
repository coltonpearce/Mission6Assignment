// <auto-generated />
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

            modelBuilder.Entity("Mission6Assignment.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Western"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryName = "Crime"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryName = "Historical"
                        },
                        new
                        {
                            CategoryID = 13,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryID = 14,
                            CategoryName = "Romantic Comedy"
                        },
                        new
                        {
                            CategoryID = 15,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 16,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission6Assignment.Models.NewMovie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IsEdited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearCreated")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("newMovies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 15,
                            Director = "Boaz Yakin",
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
                            CategoryID = 12,
                            Director = "Joe Wright",
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
                            CategoryID = 1,
                            Director = "Christopher Nolan",
                            IsEdited = "No",
                            LentTo = "N/A",
                            MovieTitle = "Inception",
                            Notes = "None",
                            Rating = "PG-13",
                            YearCreated = 2008
                        });
                });

            modelBuilder.Entity("Mission6Assignment.Models.NewMovie", b =>
                {
                    b.HasOne("Mission6Assignment.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
