using DnDCharacter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DnDCharacter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private CharacterContext _db;

        public CharacterController(CharacterContext db)
        {
            _db = db;
        }

        private bool CharacterExists(int id)
        {
            return (_db.Characters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        //Get all Characters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            if (_db.Characters == null)
            {
                return NotFound();
            }
            return await _db.Characters.ToListAsync();
        }
        
        // GET: a single character from the dataBase
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            if (_db.Characters == null)
            {
                return NotFound();
            }
            var character = await _db.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }
            return character;
        }
        //PUT: update a Single Character
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateASingleCharacter(int id, Character character)
        {
            if (id != character.Id)
            {
                return BadRequest();
            }
            _db.Entry(character).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }
            return NoContent();
        }
        //Create a Character
        [HttpPost]
        public async Task<ActionResult<Character>> CreateCharacter(Character character)
        {
            if (_db.Characters == null)
            {
                return Problem("Entity set 'CharacterContext.Characters'  is null.");
            }
            _db.Characters.Add(character);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = character.Id }, character);
        }

        //Delete a Character
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            if (_db.Characters == null)
            {
                return NotFound();
            }
            var character = await _db.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            _db.Characters.Remove(character);
            await _db.SaveChangesAsync();

            return NoContent();
        }



    }
}
