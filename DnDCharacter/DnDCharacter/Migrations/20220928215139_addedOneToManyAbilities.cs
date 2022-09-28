using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacter.Migrations
{
    public partial class addedOneToManyAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Allignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Background",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Initiative",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlayerName",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProficiencyBonus",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterAbilities_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CharacterAbilities",
                columns: new[] { "Id", "CharacterId", "Charisma", "Constitution", "Dexterity", "Intelligence", "Strength", "Wisdom" },
                values: new object[,]
                {
                    { 1, 1, 0, 0, 0, 0, 0, 0 },
                    { 2, 2, 0, 0, 0, 0, 0, 0 },
                    { 3, 3, 0, 0, 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "parties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "There can only be one" },
                    { 2, "well there can be another" }
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Allignment", "Background", "Class", "Initiative", "PartyId", "PlayerName", "ProficiencyBonus", "Race" },
                values: new object[] { "Neutral Good", "Entertainer", "Fighter", 3, 1, "John", 2, "Orc" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Allignment", "Background", "Class", "Initiative", "Level", "PartyId", "PlayerName", "ProficiencyBonus", "Race" },
                values: new object[] { "Lawful Good", "Far Traveler", "Paladin", 2, 2, 1, "Chris", -1, "Human" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Allignment", "Background", "Class", "Initiative", "Level", "PartyId", "PlayerName", "ProficiencyBonus", "Race" },
                values: new object[] { "Chaotic Evil", "Soldier", "Warlock", 1, 5, 2, "Mat", 5, "Tiefling" });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PartyId",
                table: "Characters",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbilities_CharacterId",
                table: "CharacterAbilities",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_parties_PartyId",
                table: "Characters",
                column: "PartyId",
                principalTable: "parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_parties_PartyId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterAbilities");

            migrationBuilder.DropTable(
                name: "parties");

            migrationBuilder.DropIndex(
                name: "IX_Characters_PartyId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Allignment",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Background",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Initiative",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PlayerName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ProficiencyBonus",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Characters");
        }
    }
}
