using Microsoft.EntityFrameworkCore.Migrations;

namespace DrozdArtStore.DataAccess.Migrations
{
    public partial class AddedLargePhotoToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LargeImage",
                table: "MenuItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LargeImage",
                table: "MenuItem");
        }
    }
}
