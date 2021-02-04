using System.Collections.Generic;
using System.Threading.Tasks;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestWork>>> Get()
        {
            return await _context.TestWorks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TestWork>> Get(int id)
        {
            var value = await _context.TestWorks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TestWork value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<TestWork>> Post(TestWork value)
        {
            if (ModelState.IsValid)
            {
                _context.TestWorks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TestWork>> Delete(int id)
        {
            var value = await _context.TestWorks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TestWorks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
