using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacter.Migrations
{
    public partial class addedOneToOneInventoryRelationship : Migration
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

            migrationBuilder.CreateTable(
                name: "CharacterInventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterInventories_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 1, 150, 1, "Gold" });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 2, 250, 2, "Gold" });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 3, 350, 3, "Gold" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInventories_CharacterId",
                table: "CharacterInventories",
                column: "CharacterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterInventories");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
