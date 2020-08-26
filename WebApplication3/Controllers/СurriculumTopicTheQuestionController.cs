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
    public class СurriculumTopicTheQuestionController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicTheQuestionController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicTheQuestion>>> Get()
        {
            return await _context.СurriculumTopicTheQuestion.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<СurriculumTopicTheQuestion> Get(int id)
        {
            return _context.СurriculumTopicTheQuestion.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(СurriculumTopicTheQuestion value)
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
        public async Task<ActionResult<СurriculumTopicTheQuestion>> Post(СurriculumTopicTheQuestion value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicTheQuestion.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicTheQuestion>> Delete(int id)
        {
            var value = await _context.СurriculumTopicTheQuestion.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicTheQuestion.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}