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
    public class SectionNumbersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SectionNumbersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectionNumber>>> Get()
        {
            return await _context.SectionNumbers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SectionNumber>> Get(int id)
        {
            var value = await _context.SectionNumbers.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(SectionNumber value)
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
        public async Task<ActionResult<SectionNumber>> Post(SectionNumber value)
        {
            if (ModelState.IsValid)
            {
                _context.SectionNumbers.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SectionNumber>> Delete(int id)
        {
            var value = await _context.SectionNumbers.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.SectionNumbers.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
