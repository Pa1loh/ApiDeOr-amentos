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
    public class OrcamentoItemsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public OrcamentoItemsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/OrcamentoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrcamentoItem>>> GetOrcamentoItem()
        {
            return await _context.OrcamentoItem.ToListAsync();
        }

        // GET: api/OrcamentoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrcamentoItem>> GetOrcamentoItem(int id)
        {
            var orcamentoItem = await _context.OrcamentoItem.FindAsync(id);

            if (orcamentoItem == null)
            {
                return NotFound();
            }

            return orcamentoItem;
        }

        // PUT: api/OrcamentoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrcamentoItem(int id, OrcamentoItem orcamentoItem)
        {
            if (id != orcamentoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(orcamentoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoItemExists(id))
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

        // POST: api/OrcamentoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrcamentoItem>> PostOrcamentoItem(OrcamentoItem orcamentoItem)
        {
            _context.OrcamentoItem.Add(orcamentoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrcamentoItem", new { id = orcamentoItem.Id }, orcamentoItem);
        }

        // DELETE: api/OrcamentoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrcamentoItem(int id)
        {
            var orcamentoItem = await _context.OrcamentoItem.FindAsync(id);
            if (orcamentoItem == null)
            {
                return NotFound();
            }

            _context.OrcamentoItem.Remove(orcamentoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrcamentoItemExists(int id)
        {
            return _context.OrcamentoItem.Any(e => e.Id == id);
        }
    }
}
