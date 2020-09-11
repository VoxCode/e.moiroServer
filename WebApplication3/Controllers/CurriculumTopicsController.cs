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
    public class CurriculumTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<object>>> Get()
        //{
        //    var tmp = from first in _context.CurriculumTopics
        //              join second in _context.OccupationForms on first.OccupationFormId equals second.Id
        //              join third in _context.CurriculumSections on first.CurriculumSectionId equals third.Id
        //              select new
        //              {
        //                  first.Id,
        //                  first.TopicTitle,
        //                  first.ClassHours,
        //                  first.Annotation,
        //                  first.IsDistanceLearning,
        //                  first.OccupationFormId,
        //                  first.CurriculumSectionId,
        //                  OccupationFormName = second.FullName,
        //                  CurriculumSectionName = third.Name
        //              };

        //    return await tmp.ToListAsync();
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopic>> Get(int id)
        {
            var value = await _context.CurriculumTopics.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopic value)
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
        public async Task<ActionResult<CurriculumTopic>> Post(CurriculumTopic value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopics.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopic>> Delete(int id)
        {
            var value = await _context.CurriculumTopics.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopics.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
