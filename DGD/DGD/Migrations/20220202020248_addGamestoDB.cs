using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGD.Migrations
{
    public partial class addGamestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boardgame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Illustrator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PlayerMin = table.Column<int>(type: "int", nullable: false),
                    PlayerMax = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subgenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Collection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeekLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardgame", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boardgame");
        }
    }
}
