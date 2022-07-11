using Microsoft.EntityFrameworkCore.Migrations;

namespace RatingViewCSS.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RatingDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    OneStarCount = table.Column<int>(type: "int", nullable: false),
                    OneStarTotal = table.Column<int>(type: "int", nullable: false),
                    TwoStarCount = table.Column<int>(type: "int", nullable: false),
                    TwoStarTotal = table.Column<int>(type: "int", nullable: false),
                    ThreeStarCcount = table.Column<int>(type: "int", nullable: false),
                    ThreeStarTotal = table.Column<int>(type: "int", nullable: false),
                    FourStarCount = table.Column<int>(type: "int", nullable: false),
                    FourStarTotal = table.Column<int>(type: "int", nullable: false),
                    FiveStarCount = table.Column<int>(type: "int", nullable: false),
                    FiveStarTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingDatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "RatingDatas");
        }
    }
}
