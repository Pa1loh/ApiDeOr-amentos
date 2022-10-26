using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDeOrcamento.Data;
using ApiDeOrcamento.Models;

namespace ApiDeOrcamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComposicaoItemsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ComposicaoItemsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ComposicaoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComposicaoItem>>> GetComposicaoItem()
        {
            return await _context.ComposicaoItem.ToListAsync();
        }

        // GET: api/ComposicaoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComposicaoItem>> GetComposicaoItem(int id)
        {
            var composicaoItem = await _context.ComposicaoItem.FindAsync(id);

            if (composicaoItem == null)
            {
                return NotFound();
            }

            return composicaoItem;
        }

        // PUT: api/ComposicaoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComposicaoItem(int id, ComposicaoItem composicaoItem)
        {
            if (id != composicaoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(composicaoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComposicaoItemExists(id))
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

        // POST: api/ComposicaoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComposicaoItem>> PostComposicaoItem(ComposicaoItem composicaoItem)
        {
            _context.ComposicaoItem.Add(composicaoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComposicaoItem", new { id = composicaoItem.Id }, composicaoItem);
        }

        // DELETE: api/ComposicaoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComposicaoItem(int id)
        {
            var composicaoItem = await _context.ComposicaoItem.FindAsync(id);
            if (composicaoItem == null)
            {
                return NotFound();
            }

            _context.ComposicaoItem.Remove(composicaoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComposicaoItemExists(int id)
        {
            return _context.ComposicaoItem.Any(e => e.Id == id);
        }
    }
}
