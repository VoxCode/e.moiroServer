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
    public class TestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TestWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestWork>>> GetTestWorks()
        {
            return await _context.TestWorks.ToListAsync();
        }

        // GET: api/TestWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestWork>> GetTestWork(int id)
        {
            var testWork = await _context.TestWorks.FindAsync(id);

            if (testWork == null)
            {
                return NotFound();
            }

            return testWork;
        }

        // PUT: api/TestWorks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestWork(int id, TestWork testWork)
        {
            if (id != testWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(testWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestWorkExists(id))
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

        // POST: api/TestWorks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TestWork>> PostTestWork(TestWork testWork)
        {
            _context.TestWorks.Add(testWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestWork", new { id = testWork.Id }, testWork);
        }

        // DELETE: api/TestWorks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TestWork>> DeleteTestWork(int id)
        {
            var testWork = await _context.TestWorks.FindAsync(id);
            if (testWork == null)
            {
                return NotFound();
            }

            _context.TestWorks.Remove(testWork);
            await _context.SaveChangesAsync();

            return testWork;
        }

        private bool TestWorkExists(int id)
        {
            return _context.TestWorks.Any(e => e.Id == id);
        }
    }
}
