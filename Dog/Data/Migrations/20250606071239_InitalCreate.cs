using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dog.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteToy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
