namespace DMCharacterApi.Models
{
    public class Party
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Character>? Characters { get; set; }
    }
}
