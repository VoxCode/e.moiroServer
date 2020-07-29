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
    public class СurriculumTopicAdditionalLiteratureController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicAdditionalLiteratureController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicAdditionalLiterature>>> Get()
        {
            return await _context.СurriculumTopicAdditionalLiterature.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<СurriculumTopicAdditionalLiterature>> Get(int id)
        {
            var value = await _context.СurriculumTopicAdditionalLiterature.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(СurriculumTopicAdditionalLiterature value)
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
        public async Task<ActionResult<СurriculumTopicAdditionalLiterature>> Post(СurriculumTopicAdditionalLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicAdditionalLiterature.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicAdditionalLiterature>> Delete(int id)
        {
            var value = await _context.СurriculumTopicAdditionalLiterature.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicAdditionalLiterature.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
