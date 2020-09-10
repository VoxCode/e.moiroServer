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
    public class СurriculumTopicMainLiteratureController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicMainLiteratureController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicMainLiterature>>> Get()
        {
            return await _context.CurriculumTopicMainLiterature.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<CurriculumTopicMainLiterature> Get(int id)
        {
            return _context.CurriculumTopicMainLiterature.Where(a => a.CurriculumTopicId == id);
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
                _context.CurriculumTopicMainLiterature.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> Delete(int id)
        {
            var value = await _context.CurriculumTopicMainLiterature.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicMainLiterature.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}