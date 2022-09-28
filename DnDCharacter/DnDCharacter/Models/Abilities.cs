﻿namespace DnDCharacter.Models
{
    public class Abilities
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}