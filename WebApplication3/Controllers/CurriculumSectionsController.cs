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
    public class CurriculumSectionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumSectionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.CurriculumSections
                      join second in _context.SectionNumbers on first.SectionNumberId equals second.Id
                      select new
                      {
                          first.Id,
                          first.Name,
                          first.SectionNumberId,
                          SectionNumberName = second.Name
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumSection>> Get(int id)
        {
            var value = await _context.CurriculumSections.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumSection value)
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
        public async Task<ActionResult<CurriculumSection>> Post(CurriculumSection value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumSections.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumSection>> Delete(int id)
        {
            var value = await _context.CurriculumSections.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumSections.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
