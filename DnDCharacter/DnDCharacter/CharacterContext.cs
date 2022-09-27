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
                new Character() {Id = 1, },
                new Character() { },
                new Character() { }
                );
        }
    }
}
