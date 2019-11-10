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
    public class LibraryAccountingsController : ControllerBase
    {
        private readonly LibraryContext _context;

        public LibraryAccountingsController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/LibraryAccountings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibraryAccounting>>> GetLibraryAccounting()
        {
            return await _context.LibraryAccounting.ToListAsync();
        }

        // GET: api/LibraryAccountings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LibraryAccounting>> GetLibraryAccounting(int id)
        {
            var libraryAccounting = await _context.LibraryAccounting.FindAsync(id);

            if (libraryAccounting == null)
            {
                return NotFound();
            }

            return libraryAccounting;
        }

        // PUT: api/LibraryAccountings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibraryAccounting(int id, LibraryAccounting libraryAccounting)
        {
            if (id != libraryAccounting.LibraryAccountingID)
            {
                return BadRequest();
            }

            _context.Entry(libraryAccounting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryAccountingExists(id))
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

        // POST: api/LibraryAccountings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LibraryAccounting>> PostLibraryAccounting(LibraryAccounting libraryAccounting)
        {
            _context.LibraryAccounting.Add(libraryAccounting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryAccounting", new { id = libraryAccounting.LibraryAccountingID }, libraryAccounting);
        }

        // DELETE: api/LibraryAccountings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LibraryAccounting>> DeleteLibraryAccounting(int id)
        {
            var libraryAccounting = await _context.LibraryAccounting.FindAsync(id);
            if (libraryAccounting == null)
            {
                return NotFound();
            }

            _context.LibraryAccounting.Remove(libraryAccounting);
            await _context.SaveChangesAsync();

            return libraryAccounting;
        }

        private bool LibraryAccountingExists(int id)
        {
            return _context.LibraryAccounting.Any(e => e.LibraryAccountingID == id);
        }
    }
}
