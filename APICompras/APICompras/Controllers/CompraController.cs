using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICompras.Models;
using TodoApi.Models;

namespace APICompras.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly APIContext _context;

        public CompraController(APIContext context)
        {
            _context = context;
        }

        // GET: Compra
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compra>>> Getcompra()
        {
          if (_context.compra == null)
          {
              return NotFound();
          }
            return await _context.compra.ToListAsync();
        }

        // GET: Compra/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compra>> GetCompra(int id)
        {
          if (_context.compra == null)
          {
              return NotFound();
          }
            var compra = await _context.compra.FindAsync(id);

            if (compra == null)
            {
                return NotFound();
            }

            return compra;
        }

        // PUT: Compra/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompra(int id, Compra compra)
        {
            if (id != compra.compra_id)
            {
                return BadRequest();
            }

            _context.Entry(compra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompraExists(id))
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

        // POST: Compra
        [HttpPost]
        public async Task<ActionResult<Compra>> PostCompra(Compra compra)
        {
          if (_context.compra == null)
          {
              return Problem("Entity set 'APIContext.compra'  is null.");
          }
            _context.compra.Add(compra);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                actionName: "GetCompra",
                routeValues: new { id = compra.compra_id },
                value: compra
                );
        }

        // DELETE: Compra/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompra(int id)
        {
            if (_context.compra == null)
            {
                return NotFound();
            }
            var compra = await _context.compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }

            _context.compra.Remove(compra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompraExists(int id)
        {
            return (_context.compra?.Any(e => e.compra_id == id)).GetValueOrDefault();
        }
    }
}
