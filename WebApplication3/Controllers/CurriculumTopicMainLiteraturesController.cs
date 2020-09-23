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
    public class CurriculumTopicMainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicMainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicMainLiterature>>> Get()
        {
            return await _context.CurriculumTopicMainLiteratures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> Get(int id)
        {
            var value = await _context.CurriculumTopicMainLiteratures.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicMainLiterature value)
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
        public async Task<ActionResult<CurriculumTopicMainLiterature>> Post(CurriculumTopicMainLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicMainLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> Delete(int id)
        {
            var value = await _context.CurriculumTopicMainLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicMainLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
