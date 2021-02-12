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
    public class TrainingProgramCurriculumSectionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramCurriculumSectionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramCurriculumSection>>> Get()
        {
            return await _context.TrainingProgramCurriculumSections.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(int id)
        {
            var tmp = from first in _context.TrainingProgramCurriculumSections.Where(a => a.TrainingProgramId == id)
                      join second in _context.CurriculumSections on first.CurriculumSectionId equals second.Id
                      select new
                      {
                          first.Id,
                          first.SectionNumber,
                          first.CurriculumSectionId,
                          first.TrainingProgramId,
                          second.Name
                      };



            return  await tmp.ToListAsync();
        }

        [HttpGet("{departmentId}/{key}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(int departmentId, int key)
        {
            var tmp = from first in _context.TrainingProgramCurriculumSections.Where(a => a.TrainingProgram.DepartmentId == departmentId)
                      join second in _context.CurriculumSections on first.CurriculumSectionId equals second.Id
                      select new
                      {
                          first.Id,
                          first.SectionNumber,
                          first.CurriculumSectionId,
                          first.TrainingProgramId,
                          second.Name
                      };



            return await tmp.ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramCurriculumSection value)
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
        public async Task<ActionResult<TrainingProgramCurriculumSection>> Post(TrainingProgramCurriculumSection value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramCurriculumSections.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramCurriculumSection>> Delete(int id)
        {
            var value = await _context.TrainingProgramCurriculumSections.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramCurriculumSections.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
