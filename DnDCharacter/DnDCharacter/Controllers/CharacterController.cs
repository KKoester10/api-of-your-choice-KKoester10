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
        //Get all Characters
        [HttpGet]
        public async Task<ActionResult <IEnumerable<Character>>> GetCharacters()
        {
            if (_db.Characters == null)
            {
                return NotFound();
            }
            return await _db.Characters.ToListAsync();
        }


    }
}
