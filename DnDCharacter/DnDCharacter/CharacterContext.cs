using DnDCharacter.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDCharacter
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connection
            string connectionString = "server=(localdb)\\mssqllocaldb;Database=CharacterOfChoiceAPI;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Character>().HasData(
                new Character() { Id = 1, Name = "Bob", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 0, Inventory = {Id = 1,Name = "Gold", Amount = 50 } },
                new Character() { Id = 2, Name = "Jedidia", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 250, Inventory = { Id = 2, Name = "Gold", Amount = 50 } },
                new Character() { Id = 3, Name = "Keb", HitPoints = 30, Speed = 30, ArmorClass = 30, Experiance = 150, Inventory = { Id = 3, Name = "Gold", Amount = 50 } }
                );
        }
    }
}
