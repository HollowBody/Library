using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryApi.DAL;
using LibraryApi.Models;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PenaltiesAccountingsController : ControllerBase
    {
        private readonly LibraryContext _context;

        public PenaltiesAccountingsController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/PenaltiesAccountings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PenaltiesAccounting>>> GetPenaltiesAccounting()
        {
            return await _context.PenaltiesAccountings.ToListAsync();
        }

        // GET: api/PenaltiesAccountings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PenaltiesAccounting>> GetPenaltiesAccounting(int id)
        {
            var penaltiesAccounting = await _context.PenaltiesAccountings.FindAsync(id);

            if (penaltiesAccounting == null)
            {
                return NotFound();
            }

            return penaltiesAccounting;
        }

        // PUT: api/PenaltiesAccountings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPenaltiesAccounting(int id, PenaltiesAccounting penaltiesAccounting)
        {
            if (id != penaltiesAccounting.PenaltiesAccountingID)
            {
                return BadRequest();
            }

            _context.Entry(penaltiesAccounting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PenaltiesAccountingExists(id))
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

        // POST: api/PenaltiesAccountings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PenaltiesAccounting>> PostPenaltiesAccounting(PenaltiesAccounting penaltiesAccounting)
        {
            _context.PenaltiesAccountings.Add(penaltiesAccounting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPenaltiesAccounting", new { id = penaltiesAccounting.PenaltiesAccountingID }, penaltiesAccounting);
        }

        // DELETE: api/PenaltiesAccountings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PenaltiesAccounting>> DeletePenaltiesAccounting(int id)
        {
            var penaltiesAccounting = await _context.PenaltiesAccountings.FindAsync(id);
            if (penaltiesAccounting == null)
            {
                return NotFound();
            }

            _context.PenaltiesAccountings.Remove(penaltiesAccounting);
            await _context.SaveChangesAsync();

            return penaltiesAccounting;
        }

        private bool PenaltiesAccountingExists(int id)
        {
            return _context.PenaltiesAccountings.Any(e => e.PenaltiesAccountingID == id);
        }
    }
}
