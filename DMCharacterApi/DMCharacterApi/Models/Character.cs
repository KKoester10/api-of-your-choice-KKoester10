namespace DMCharacterApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? PlayerName { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public int Level { get; set; }
        public string? Race { get; set; }
        public string? Allignment { get; set; }
        public string? Background { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Experiance { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int? PartyId { get; set; }
        public virtual Party? Party { get; set; }
        public virtual List<CharacterInventory>? Inventory { get; set; }
    }
}
