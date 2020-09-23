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
    public class CurriculumTopicTestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicTestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTestWork>>> Get()
        {
            return await _context.CurriculumTopicTestWorks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicTestWork>> Get(int id)
        {
            var value = await _context.CurriculumTopicTestWorks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTestWork value)
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
        public async Task<ActionResult<CurriculumTopicTestWork>> Post(CurriculumTopicTestWork value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTestWorks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTestWork>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTestWorks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTestWorks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
