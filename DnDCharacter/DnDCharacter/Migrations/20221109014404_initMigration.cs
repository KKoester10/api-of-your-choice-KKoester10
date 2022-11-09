using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacter.Migrations
{
    public partial class initMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProficiencyBonus = table.Column<int>(type: "int", nullable: false),
                    Experiance = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    Initiative = table.Column<int>(type: "int", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    PartyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "parties",
                        principalColumn: "Id");
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
                table: "parties",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "There can only be one" });

            migrationBuilder.InsertData(
                table: "parties",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "well there can be another" });

            migrationBuilder.InsertData(
                table: "parties",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "well there can be another another another" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Allignment", "ArmorClass", "Background", "Charisma", "Class", "Constitution", "Dexterity", "Experiance", "HitPoints", "Initiative", "Intelligence", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed", "Strength", "Wisdom" },
                values: new object[] { 1, "Neutral Good", 30, "Entertainer", 0, "Fighter", 0, 0, 0, 30, 3, 0, 0, "Bob", 1, "John", 2, "Orc", 30, 0, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Allignment", "ArmorClass", "Background", "Charisma", "Class", "Constitution", "Dexterity", "Experiance", "HitPoints", "Initiative", "Intelligence", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed", "Strength", "Wisdom" },
                values: new object[] { 2, "Lawful Good", 30, "Far Traveler", 0, "Paladin", 0, 0, 250, 30, 2, 0, 2, "Jedidia", 2, "Chris", -1, "Human", 30, 0, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Allignment", "ArmorClass", "Background", "Charisma", "Class", "Constitution", "Dexterity", "Experiance", "HitPoints", "Initiative", "Intelligence", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed", "Strength", "Wisdom" },
                values: new object[] { 3, "Chaotic Evil", 30, "Soldier", 0, "Warlock", 0, 0, 150, 30, 1, 0, 5, "Keb", 3, "Mat", 5, "Tiefling", 30, 0, 0 });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 1, 50, 3, "thing" });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 2, 50, 3, "thing" });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "CharacterId", "ItemName" },
                values: new object[] { 3, 50, 3, "thing" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInventories_CharacterId",
                table: "CharacterInventories",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PartyId",
                table: "Characters",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterInventories");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "parties");
        }
    }
}
