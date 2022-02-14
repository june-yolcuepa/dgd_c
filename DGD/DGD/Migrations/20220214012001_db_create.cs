using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGD.Migrations
{
    public partial class db_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerMin",
                table: "Boardgame",
                newName: "MinPlayer");

            migrationBuilder.RenameColumn(
                name: "PlayerMax",
                table: "Boardgame",
                newName: "MaxPlayer");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Boardgame",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "GeekLink",
                table: "Boardgame",
                newName: "GeekURL");

            migrationBuilder.RenameColumn(
                name: "EstDuration",
                table: "Boardgame",
                newName: "Duration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Boardgame",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MinPlayer",
                table: "Boardgame",
                newName: "PlayerMin");

            migrationBuilder.RenameColumn(
                name: "MaxPlayer",
                table: "Boardgame",
                newName: "PlayerMax");

            migrationBuilder.RenameColumn(
                name: "GeekURL",
                table: "Boardgame",
                newName: "GeekLink");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Boardgame",
                newName: "EstDuration");
        }
    }
}
