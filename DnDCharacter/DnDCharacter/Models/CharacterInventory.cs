namespace DnDCharacter.Models
{
    public class CharacterInventory
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public int? CharacterId { get; set; }
        public virtual Character? Character { get; set; }
        /*public Dictionary<string,int> Inventory = new Dictionary<string,int>();*/

    }
}
