using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainLiterature>>> Get()
        {
            return await _context.MainLiteratures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MainLiterature>> Get(int id)
        {
            var value = await _context.MainLiteratures.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("Author{author}")]
        public async Task<ActionResult<IEnumerable<MainLiterature>>> Get(string author)
        {
            return await _context.MainLiteratures.Where(a => a.AuthorIndex == author).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(MainLiterature value)
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
        public async Task<ActionResult<MainLiterature>> Post(MainLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.MainLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MainLiterature>> Delete(int id)
        {
            var value = await _context.MainLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.MainLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
