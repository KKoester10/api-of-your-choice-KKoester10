namespace DnDCharacter.Models
{
    public class CharacterInventory
    {
        public int Id { get; set; }
        public Dictionary<string,int> Inventory = new Dictionary<string,int>();

    }
}
