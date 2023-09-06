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
                .Include(g => g.GameTags) // Including GameTags
                .Include(g => g.Dlcs)     // Including DLCs
                .Include(g => g.Editions) // Including Editions
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

        // GET: api/games/{gameId}/reviews
        [HttpGet("{gameId}/reviews")]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviewsByGame(int gameId)
        {
            return await _context.Reviews.Where(r => r.GameId == gameId).ToListAsync();
        }

        // GET: api/games/tags
        [HttpGet("tags")]
        public async Task<ActionResult<IEnumerable<Tag>>> GetAllTags()
        {
            return await _context.Tags.ToListAsync();
        }

        // GET: api/games/tag/{tagName}
        [HttpGet("tag/{tagName}")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGamesByTag(string tagName)
        {
            var tag = await _context.Tags
                .Include(t => t.GameTags)
                .ThenInclude(gt => gt.Game)
                .FirstOrDefaultAsync(t => t.Name == tagName);

            if (tag == null)
            {
                return NotFound();
            }

            return tag.GameTags.Select(gt => gt.Game).ToList();
        }

        // POST: api/games/{gameId}/tag
        [HttpPost("{gameId}/tag")]
        public async Task<ActionResult> AddTagToGame(int gameId, [FromBody] Tag tag)
        {
            var game = await _context.Games.FindAsync(gameId);

            if (game == null)
            {
                return NotFound();
            }

            var existingTag = await _context.Tags.FirstOrDefaultAsync(t => t.Name == tag.Name);

            if (existingTag == null)
            {
                _context.Tags.Add(tag);
                await _context.SaveChangesAsync();
            }
            else
            {
                tag = existingTag;
            }

            game.GameTags.Add(new GameTag { Game = game, Tag = tag });
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/games/{gameId}/dlcs
        [HttpGet("{gameId}/dlcs")]
        public async Task<ActionResult<IEnumerable<DLC>>> GetDLCsByGame(int gameId)
        {
            return await _context.DLCs.Where(d => d.GameId == gameId).ToListAsync();
        }

        // GET: api/games/{gameId}/editions
        [HttpGet("{gameId}/editions")]
        public async Task<ActionResult<IEnumerable<Edition>>> GetEditionsByGame(int gameId)
        {
            return await _context.Editions.Where(e => e.GameId == gameId).ToListAsync();
        }

        // POST: api/games/{gameId}/review
        [HttpPost("{gameId}/review")]
        public async Task<ActionResult> AddReviewToGame(int gameId, [FromBody] Review review)
        {
            var game = await _context.Games.FindAsync(gameId);

            if (game == null)
            {
                return NotFound();
            }

            review.GameId = gameId;
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return Ok();
        }



    }
}
