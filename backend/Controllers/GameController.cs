using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameShopContext  _context;

        public GameController(GameShopContext  context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            var games = await _context.Games 
                .Include(g => g.Images)
                .ToListAsync();

            return games;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            var game = await _context.Games
                .Include(g => g.Images)
                .FirstOrDefaultAsync(g => g.GameId == id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        [HttpGet("genre/{genre}")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGamesByGenre(string genre)
        {
            if (Enum.TryParse(genre, true, out Genre genreValue)) 
            {
                return await _context.Games
                    .Where(g => g.GameGenre == genreValue)
                    .Include(g => g.Images)
                    .ToListAsync();
            }

            return BadRequest("Invalid genre provided");
        }
    }
}
