using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Model.VideoGame;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemController : ControllerBase
    {
        private readonly GameShopContext _context;

        public CartItemController(GameShopContext context)
        {
            _context = context;
        }

        // GET: api/cartitem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartItem>>> GetAllCartItems()
        {
            return await _context.CartItems.Include(ci => ci.Game).ToListAsync();
        }

        // GET: api/cartitem/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CartItem>> GetCartItemById(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem == null)
            {
                return NotFound();
            }

            return cartItem;
        }

        // POST: api/cartitem
        [HttpPost]
        public async Task<ActionResult<CartItem>> AddCartItem(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCartItemById), new { id = cartItem.CartItemId }, cartItem);
        }

        // PUT: api/cartitem/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCartItem(int id, CartItem cartItem)
        {
            if (id != cartItem.CartItemId)
            {
                return BadRequest();
            }

            _context.Entry(cartItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartItemExists(id))
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

        // DELETE: api/cartitem/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return NotFound();
            }

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItems.Any(e => e.CartItemId == id);
        }
    }
}
