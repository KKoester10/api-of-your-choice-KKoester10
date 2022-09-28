using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacter.Migrations
{
    public partial class INITCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Experiance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArmorClass", "Experiance", "HitPoints", "Name", "Speed" },
                values: new object[] { 1, 30, 0, 30, "Bob", 30 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArmorClass", "Experiance", "HitPoints", "Name", "Speed" },
                values: new object[] { 2, 30, 250, 30, "Jedidia", 30 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArmorClass", "Experiance", "HitPoints", "Name", "Speed" },
                values: new object[] { 3, 30, 150, 30, "Keb", 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
