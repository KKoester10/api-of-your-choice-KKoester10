using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DMCharacterApi;
using DMCharacterApi.Models;

namespace DMCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterInventoriesController : ControllerBase
    {
        private readonly CharacterContext _context;

        public CharacterInventoriesController(CharacterContext context)
        {
            _context = context;
        }

        // GET: api/CharacterInventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterInventory>>> GetCharacterInventories()
        {
          if (_context.CharacterInventories == null)
          {
              return NotFound();
          }
            return await _context.CharacterInventories.ToListAsync();
        }

        // GET: api/CharacterInventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterInventory>> GetCharacterInventory(int? id)
        {
          if (_context.CharacterInventories == null)
          {
              return NotFound();
          }
            var characterInventory = await _context.CharacterInventories.FindAsync(id);

            if (characterInventory == null)
            {
                return NotFound();
            }

            return characterInventory;
        }

        // PUT: api/CharacterInventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterInventory(int? id, CharacterInventory characterInventory)
        {
            if (id != characterInventory.Id)
            {
                return BadRequest();
            }

            _context.Entry(characterInventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterInventoryExists(id))
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

        // POST: api/CharacterInventories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharacterInventory>> PostCharacterInventory(CharacterInventory characterInventory)
        {
          if (_context.CharacterInventories == null)
          {
              return Problem("Entity set 'CharacterContext.CharacterInventories'  is null.");
          }
            _context.CharacterInventories.Add(characterInventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterInventory", new { id = characterInventory.Id }, characterInventory);
        }

        // DELETE: api/CharacterInventories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterInventory(int? id)
        {
            if (_context.CharacterInventories == null)
            {
                return NotFound();
            }
            var characterInventory = await _context.CharacterInventories.FindAsync(id);
            if (characterInventory == null)
            {
                return NotFound();
            }

            _context.CharacterInventories.Remove(characterInventory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterInventoryExists(int? id)
        {
            return (_context.CharacterInventories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
