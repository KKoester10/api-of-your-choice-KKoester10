using DnDCharacter.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDCharacter
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterInventory> CharacterInventories { get; set; }
        public DbSet<Abilities> CharacterAbilities { get; set; }
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
                new Party() { },
                new Party() { }
                );

            model.Entity<Character>().HasData(
                new Character() { Id = 1, Name = "Bob", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 0 },
                new Character() { Id = 2, Name = "Jedidia", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 250},
                new Character() { Id = 3, Name = "Keb", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 150}
                );

            model.Entity<Abilities>().HasData(
                new Abilities() { },
                new Abilities() { },
                new Abilities() { }
                );

            model.Entity<CharacterInventory>().HasData(
                new CharacterInventory() { Id = 1, ItemName = "Gold", Amount = 150, CharacterId = 1 },
                new CharacterInventory() { Id = 2, ItemName = "Gold", Amount = 250, CharacterId = 2 },
                new CharacterInventory() { Id = 3, ItemName = "Gold", Amount = 350, CharacterId = 3 }
                );
        }
    }
}
