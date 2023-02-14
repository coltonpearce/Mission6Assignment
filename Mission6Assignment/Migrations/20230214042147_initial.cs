using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6Assignment.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "newMovies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    MovieTitle = table.Column<string>(nullable: true),
                    YearCreated = table.Column<int>(nullable: false),
                    IsEdited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newMovies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "Category", "IsEdited", "LentTo", "MovieTitle", "Notes", "Rating", "YearCreated" },
                values: new object[] { 1, "Sports", "No", "Sarah Pearce", "Remember The Titans", "None", "PG", 2001 });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "Category", "IsEdited", "LentTo", "MovieTitle", "Notes", "Rating", "YearCreated" },
                values: new object[] { 2, "Historical", "No", "N/A", "Darkest Hour", "None", "PG-13", 2018 });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "Category", "IsEdited", "LentTo", "MovieTitle", "Notes", "Rating", "YearCreated" },
                values: new object[] { 3, "Thriller", "No", "N/A", "Inception", "None", "PG-13", 2008 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newMovies");
        }
    }
}
