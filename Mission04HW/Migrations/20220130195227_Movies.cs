using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission04HW.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Sci-Fi", "Danny Boyle", false, "", "This movie is incredible", "R", "Sunshine", "2007" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama", "Denis Villeneuve", false, "", "Excellent", "R", "Prisoners", "2013" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Thriller", "Steven Spielberg", false, "", "Paved the way for so many great films", "PG", "Jaws", "1975" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
