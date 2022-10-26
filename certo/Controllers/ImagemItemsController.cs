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
    public class ImagemItemsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ImagemItemsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ImagemItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImagemItem>>> GetImagemItem()
        {
            return await _context.ImagemItem.ToListAsync();
        }

        // GET: api/ImagemItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImagemItem>> GetImagemItem(int id)
        {
            var imagemItem = await _context.ImagemItem.FindAsync(id);

            if (imagemItem == null)
            {
                return NotFound();
            }

            return imagemItem;
        }

        // PUT: api/ImagemItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImagemItem(int id, ImagemItem imagemItem)
        {
            if (id != imagemItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(imagemItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagemItemExists(id))
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

        // POST: api/ImagemItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImagemItem>> PostImagemItem(ImagemItem imagemItem)
        {
            _context.ImagemItem.Add(imagemItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImagemItem", new { id = imagemItem.Id }, imagemItem);
        }

        // DELETE: api/ImagemItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImagemItem(int id)
        {
            var imagemItem = await _context.ImagemItem.FindAsync(id);
            if (imagemItem == null)
            {
                return NotFound();
            }

            _context.ImagemItem.Remove(imagemItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ImagemItemExists(int id)
        {
            return _context.ImagemItem.Any(e => e.Id == id);
        }
    }
}
