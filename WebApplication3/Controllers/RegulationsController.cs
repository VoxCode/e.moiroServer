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
    public class RegulationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public RegulationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Regulation>>> Get()
        {
            return await _context.Regulations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Regulation>> Get(int id)
        {
            var value = await _context.Regulations.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("{curriculumTopicId}/{key}")]
        public async Task<ActionResult<IEnumerable<Regulation>>> Get(int curriculumTopicId, int key)
        {
            var result = await _context.Regulations.Where(a => a.CurriculumTopicRegulations
            .Any(r => r.CurriculumTopicId == curriculumTopicId)).ToListAsync();
            return result;
        }

        [HttpPut]
        public async Task<IActionResult> Put(Regulation value)
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
        public async Task<ActionResult<Regulation>> Post(Regulation value)
        {
            if (ModelState.IsValid)
            {
                _context.Regulations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Regulation>> Delete(int id)
        {
            var value = await _context.Regulations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Regulations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
