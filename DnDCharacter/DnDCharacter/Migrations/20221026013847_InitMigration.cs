using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacter.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInventories", x => x.Id);
                });

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
                    PartyId = table.Column<int>(type: "int", nullable: false),
                    AbilitiesId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterAbilities_AbilitiesId",
                        column: x => x.AbilitiesId,
                        principalTable: "CharacterAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterInventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "CharacterInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterAbilities",
                columns: new[] { "Id", "Charisma", "Constitution", "Dexterity", "Intelligence", "Strength", "Wisdom" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0 },
                    { 2, 0, 0, 0, 0, 0, 0 },
                    { 3, 0, 0, 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "CharacterInventories",
                columns: new[] { "Id", "Amount", "ItemName" },
                values: new object[,]
                {
                    { 1, 150, "Gold" },
                    { 2, 250, "Gold" },
                    { 3, 350, "Gold" }
                });

            migrationBuilder.InsertData(
                table: "parties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "There can only be one" },
                    { 2, "well there can be another" },
                    { 3, "well there can be another another another" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AbilitiesId", "Allignment", "ArmorClass", "Background", "Class", "Experiance", "HitPoints", "Initiative", "InventoryId", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed" },
                values: new object[] { 1, 1, "Neutral Good", 30, "Entertainer", "Fighter", 0, 30, 3, 1, 0, "Bob", 1, "John", 2, "Orc", 30 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AbilitiesId", "Allignment", "ArmorClass", "Background", "Class", "Experiance", "HitPoints", "Initiative", "InventoryId", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed" },
                values: new object[] { 2, 2, "Lawful Good", 30, "Far Traveler", "Paladin", 250, 30, 2, 2, 2, "Jedidia", 2, "Chris", -1, "Human", 30 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AbilitiesId", "Allignment", "ArmorClass", "Background", "Class", "Experiance", "HitPoints", "Initiative", "InventoryId", "Level", "Name", "PartyId", "PlayerName", "ProficiencyBonus", "Race", "Speed" },
                values: new object[] { 3, 3, "Chaotic Evil", 30, "Soldier", "Warlock", 150, 30, 1, 3, 5, "Keb", 3, "Mat", 5, "Tiefling", 30 });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilitiesId",
                table: "Characters",
                column: "AbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_InventoryId",
                table: "Characters",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PartyId",
                table: "Characters",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterAbilities");

            migrationBuilder.DropTable(
                name: "CharacterInventories");

            migrationBuilder.DropTable(
                name: "parties");
        }
    }
}
