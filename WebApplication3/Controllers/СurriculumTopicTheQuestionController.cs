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
        public async Task<ActionResult<IEnumerable<CurriculumTopicTheQuestion>>> Get()
        {
            return await _context.CurriculumTopicTheQuestion.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<CurriculumTopicTheQuestion> Get(int id)
        {
            return _context.CurriculumTopicTheQuestion.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTheQuestion value)
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
        public async Task<ActionResult<CurriculumTopicTheQuestion>> Post(CurriculumTopicTheQuestion value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTheQuestion.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTheQuestion>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTheQuestion.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTheQuestion.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}