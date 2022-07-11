using Microsoft.EntityFrameworkCore.Migrations;

namespace RatingViewCSS.Data.Migrations
{
    public partial class UpdateRatongColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThreeStarCcount",
                table: "RatingDatas",
                newName: "ThreeStarCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThreeStarCount",
                table: "RatingDatas",
                newName: "ThreeStarCcount");
        }
    }
}
