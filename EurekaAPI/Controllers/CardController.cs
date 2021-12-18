using EurekaAPI.Classes;
using EurekaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaAPI.Controllers
{
    [Route("api/cards")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetCards([FromQuery] CardQueryParameters queryParameters)
        {
            IQueryable<Card> cards = _context.Cards;

            //Query by Topic
            if(!string.IsNullOrEmpty(queryParameters.Topic))
            {
                cards = cards.Where(p => p.Topic == queryParameters.Topic);
            }

            //Query by Title (Contains paremeter)
            if (!string.IsNullOrEmpty(queryParameters.Title))
            {
                cards = cards.Where(
                    p => p.Title.ToLower().Contains(queryParameters.Title.ToLower()));
            }

            //Query by Size and Page
            cards = cards
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);

            return await cards.ToListAsync();
        }

        //Display all cards
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return card;
        }

        //Display by specific Card Id
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCard(int id, Card card)
        {
            if (id != card.CardId)
            {
                return BadRequest();
            }

            _context.Entry(card).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(id))
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

        private bool CardExists(int id)
        {
            return _context.Cards.Any(e => e.CardId == id);
        }

    }
}
