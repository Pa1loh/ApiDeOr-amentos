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
    public class OrcamentoesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public OrcamentoesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Orcamentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orcamento>>> GetOrcamento()
        {
            return await _context.Orcamento.ToListAsync();
        }

        // GET: api/Orcamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orcamento>> GetOrcamento(int id)
        {
            var orcamento = await _context.Orcamento.FindAsync(id);

            if (orcamento == null)
            {
                return NotFound();
            }

            return orcamento;
        }

        // PUT: api/Orcamentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrcamento(int id, Orcamento orcamento)
        {
            if (id != orcamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(orcamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoExists(id))
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

        // POST: api/Orcamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orcamento>> PostOrcamento(Orcamento orcamento)
        {
            _context.Orcamento.Add(orcamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrcamento", new { id = orcamento.Id }, orcamento);
        }

        // DELETE: api/Orcamentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrcamento(int id)
        {
            var orcamento = await _context.Orcamento.FindAsync(id);
            if (orcamento == null)
            {
                return NotFound();
            }

            _context.Orcamento.Remove(orcamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrcamentoExists(int id)
        {
            return _context.Orcamento.Any(e => e.Id == id);
        }
    }
}
