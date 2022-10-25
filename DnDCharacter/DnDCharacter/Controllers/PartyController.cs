using DnDCharacter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DnDCharacter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        private CharacterContext _db;

        public PartyController(CharacterContext db)
        {
            _db = db;
        }

        private bool PartyExists(int id)
        {
            return (_db.parties?.Any(party => party.Id == id)).GetValueOrDefault();
        }
        // GET: this will get all the Parties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Party>>> GetParties()
        {
            if (_db.parties == null)
            {
                return NotFound();
            }
            return await _db.parties.ToListAsync();
        }
        //GET: This is getting a single party by its "ID"
        [HttpGet("{id}")]
        public async Task<ActionResult<Party>> GetParty(int id)
        {
            if (_db.parties == null)
            {
                return NotFound();
            }
            var party = await _db.parties.FindAsync(id);
            if (party == null)
            {
                return NotFound();
            }
            return party;
        }
        //PUT: Updating a single party
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateASingleParty(int id, Party party)
        {
            if (id != party.Id)
            {
                return BadRequest();
            }
            _db.Entry(party).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartyExists(id))
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
        //POST: Create a Character
        [HttpPost]
        public async Task<ActionResult<Party>> CreateParty(Party party)
        {
            if (_db.parties == null)
            {
                return Problem("Entity set 'CharacterContext.Characters'  is null.");
            }
            _db.parties.Add(party);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetParty", new { id = party.Id }, party);
        }

        //Delete a Character
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParty(int id)
        {
            if (_db.parties == null)
            {
                return NotFound();
            }
            var party = await _db.parties.FindAsync(id);
            if (party == null)
            {
                return NotFound();
            }
            _db.parties.Remove(party);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
