using DnDCharacter.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDCharacter
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterInventory> CharacterInventories { get; set; }
        public DbSet<Party> parties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connection
            string connectionString = "server=(localdb)\\mssqllocaldb;Database=CharacterOfChoiceAPI;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Party>().HasData(
                new Party() {Id = 1, Name = "There can only be one"},
                new Party() {Id = 2, Name = "well there can be another"},
                new Party() { Id = 3, Name = "well there can be another another another" }
            );

            model.Entity<Character>().HasData(
                new Character() { 
                    Id = 1,PlayerName = "John",
                    Name = "Bob" ,
                    Class = "Fighter",
                    Level = 0,
                    Race = "Orc",
                    Allignment = "Neutral Good",
                    Background = "Entertainer",
                    ProficiencyBonus = 2,
                    Initiative = 3,
                    HitPoints = 30,
                    Speed = 30,
                    ArmorClass = 30,
                    Experiance = 0,
                    Strength = 0,
                    Dexterity = 0,
                    Charisma = 0,
                    Constitution = 0,
                    Wisdom = 0,
                    Intelligence = 0,
                    InventoryId =1,
                    PartyId = 1 
                },
                new Character() { 
                    Id = 2,
                    PlayerName = "Chris",
                    Name = "Jedidia",
                    Class = "Paladin",
                    Level = 2,
                    Race = "Human",
                    Allignment = "Lawful Good",
                    Background = "Far Traveler",
                    ProficiencyBonus = -1,
                    Initiative = 2 ,
                    HitPoints = 30,
                    Speed = 30,
                    ArmorClass = 30,
                    Experiance = 250,
                    Strength = 0,
                    Dexterity = 0,
                    Charisma = 0,
                    Constitution = 0,
                    Wisdom = 0,
                    Intelligence = 0,
                    InventoryId = 2,
                    PartyId = 2 
                },
                new Character() { 
                    Id = 3,
                    PlayerName = "Mat",
                    Name = "Keb",
                    Class = "Warlock",
                    Level = 5,
                    Race = "Tiefling",
                    Allignment = "Chaotic Evil",
                    Background = "Soldier",
                    ProficiencyBonus = 5,
                    Initiative = 1,
                    HitPoints = 30,
                    Speed = 30,
                    ArmorClass = 30,
                    Experiance = 150,
                    Strength = 0,
                    Dexterity = 0,
                    Charisma = 0,
                    Constitution = 0,
                    Wisdom = 0,
                    Intelligence = 0,
                    InventoryId = 3,
                    PartyId = 3 
                }
            );
            model.Entity<CharacterInventory>().HasData(
                new CharacterInventory() { 
                    Id = 1,
                    
                },
                new CharacterInventory() { 
                    Id = 2,
                    
                },
                new CharacterInventory() { 
                    Id = 3,
                    
                }
            );
            base.OnModelCreating(model);
        }
    }
}
