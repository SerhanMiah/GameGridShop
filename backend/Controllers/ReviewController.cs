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
    public class ReviewController : ControllerBase
    {
        private readonly GameShopContext _context;

        public ReviewController(GameShopContext context) 
        {
            _context = context;
        }

        // GET: api/reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        // GET: api/games/{gameId}/reviews
        [HttpGet("game/{gameId}")]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviewsByGame(int gameId)
        {
            return await _context.Reviews.Where(r => r.GameId == gameId).ToListAsync();
        }

    }
}