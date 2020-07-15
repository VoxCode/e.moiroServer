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
    public class TheQuestionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TheQuestionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TheQuestions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TheQuestions>>> GetTheQuestions()
        {
            return await _context.TheQuestions.ToListAsync();
        }

        // GET: api/TheQuestions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TheQuestions>> GetTheQuestions(int id)
        {
            var theQuestions = await _context.TheQuestions.FindAsync(id);

            if (theQuestions == null)
            {
                return NotFound();
            }

            return theQuestions;
        }

        // PUT: api/TheQuestions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheQuestions(int id, TheQuestions theQuestions)
        {
            if (id != theQuestions.Id)
            {
                return BadRequest();
            }

            _context.Entry(theQuestions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheQuestionsExists(id))
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

        // POST: api/TheQuestions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TheQuestions>> PostTheQuestions(TheQuestions theQuestions)
        {
            _context.TheQuestions.Add(theQuestions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheQuestions", new { id = theQuestions.Id }, theQuestions);
        }

        // DELETE: api/TheQuestions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TheQuestions>> DeleteTheQuestions(int id)
        {
            var theQuestions = await _context.TheQuestions.FindAsync(id);
            if (theQuestions == null)
            {
                return NotFound();
            }

            _context.TheQuestions.Remove(theQuestions);
            await _context.SaveChangesAsync();

            return theQuestions;
        }

        private bool TheQuestionsExists(int id)
        {
            return _context.TheQuestions.Any(e => e.Id == id);
        }
    }
}
