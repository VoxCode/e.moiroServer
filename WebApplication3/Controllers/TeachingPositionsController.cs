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
    public class TeachingPositionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeachingPositionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeachingPosition>>> Get()
        {
            return await _context.TeachingPositions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeachingPosition>> Get(int id)
        {
            var value = await _context.TeachingPositions.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TeachingPosition value)
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
        public async Task<ActionResult<TeachingPosition>> Post(TeachingPosition value)
        {
            if (ModelState.IsValid)
            {
                _context.TeachingPositions.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TeachingPosition>> Delete(int id)
        {
            var value = await _context.TeachingPositions.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TeachingPositions.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
