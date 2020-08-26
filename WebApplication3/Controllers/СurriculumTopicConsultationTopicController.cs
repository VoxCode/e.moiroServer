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
    public class СurriculumTopicConsultationTopicController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicConsultationTopicController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicConsultationTopic>>> Get()
        {
            return await _context.СurriculumTopicConsultationTopic.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<СurriculumTopicConsultationTopic> Get(int id)
        {
            return _context.СurriculumTopicConsultationTopic.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(СurriculumTopicConsultationTopic value)
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
        public async Task<ActionResult<СurriculumTopicConsultationTopic>> Post(СurriculumTopicConsultationTopic value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicConsultationTopic.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicConsultationTopic>> Delete(int id)
        {
            var value = await _context.СurriculumTopicConsultationTopic.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicConsultationTopic.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}