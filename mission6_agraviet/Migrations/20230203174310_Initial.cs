using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6_agraviet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    submissionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.submissionId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "submissionId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "Joss Whedon", false, "NA", "mid movie", "PG-13", "The Avengers", 2012 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "submissionId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action", "Tim Burton", false, "NA", "better movie", "PG-13", "Batman", 1998 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "submissionId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Comedy", "Jonathan Lynn", false, "NA", "never actually seen this movie", "PG", "Clue", 1985 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
