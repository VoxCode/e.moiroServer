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
    public class CurriculumTopicFinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicFinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicFinalExamination>>> Get()
        {
            return await _context.CurriculumTopicFinalExaminations.ToListAsync();
        }

        [HttpGet("{certificationTypeIndex}/{id}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicFinalExamination>>> Get(int certificationTypeIndex, int id)
        {
            return await _context.CurriculumTopicFinalExaminations.Where(a => a.CurriculumTopicId == id 
            && a.FinalExamination.CertificationTypeId == certificationTypeIndex).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicFinalExamination value)
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
        public async Task<ActionResult<CurriculumTopicFinalExamination>> Post(CurriculumTopicFinalExamination value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicFinalExaminations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicFinalExamination>> Delete(int id)
        {
            var value = await _context.CurriculumTopicFinalExaminations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicFinalExaminations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
