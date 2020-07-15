using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/MainLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainLiterature>>> GetMainLiteratures()
        {
            return await _context.MainLiteratures.ToListAsync();
        }

        // GET: api/MainLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainLiterature>> GetMainLiterature(int id)
        {
            var mainLiterature = await _context.MainLiteratures.FindAsync(id);

            if (mainLiterature == null)
            {
                return NotFound();
            }

            return mainLiterature;
        }

        // PUT: api/MainLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainLiterature(int id, MainLiterature mainLiterature)
        {
            if (id != mainLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainLiteratureExists(id))
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

        // POST: api/MainLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MainLiterature>> PostMainLiterature(MainLiterature mainLiterature)
        {
            _context.MainLiteratures.Add(mainLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMainLiterature", new { id = mainLiterature.Id }, mainLiterature);
        }

        // DELETE: api/MainLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MainLiterature>> DeleteMainLiterature(int id)
        {
            var mainLiterature = await _context.MainLiteratures.FindAsync(id);
            if (mainLiterature == null)
            {
                return NotFound();
            }

            _context.MainLiteratures.Remove(mainLiterature);
            await _context.SaveChangesAsync();

            return mainLiterature;
        }

        private bool MainLiteratureExists(int id)
        {
            return _context.MainLiteratures.Any(e => e.Id == id);
        }
    }
}
