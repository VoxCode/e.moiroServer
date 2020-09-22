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
    public class FinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/FinalExaminations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinalExamination>>> GetFinalExaminations()
        {
            return await _context.FinalExaminations.ToListAsync();
        }

        // GET: api/FinalExaminations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FinalExamination>> GetFinalExamination(int id)
        {
            var finalExamination = await _context.FinalExaminations.FindAsync(id);

            if (finalExamination == null)
            {
                return NotFound();
            }

            return finalExamination;
        }

        // PUT: api/FinalExaminations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFinalExamination(int id, FinalExamination finalExamination)
        {
            if (id != finalExamination.Id)
            {
                return BadRequest();
            }

            _context.Entry(finalExamination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinalExaminationExists(id))
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

        // POST: api/FinalExaminations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FinalExamination>> PostFinalExamination(FinalExamination finalExamination)
        {
            _context.FinalExaminations.Add(finalExamination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinalExamination", new { id = finalExamination.Id }, finalExamination);
        }

        // DELETE: api/FinalExaminations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FinalExamination>> DeleteFinalExamination(int id)
        {
            var finalExamination = await _context.FinalExaminations.FindAsync(id);
            if (finalExamination == null)
            {
                return NotFound();
            }

            _context.FinalExaminations.Remove(finalExamination);
            await _context.SaveChangesAsync();

            return finalExamination;
        }

        private bool FinalExaminationExists(int id)
        {
            return _context.FinalExaminations.Any(e => e.Id == id);
        }
    }
}
