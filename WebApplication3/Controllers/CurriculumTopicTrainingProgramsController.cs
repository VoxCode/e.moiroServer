﻿using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumTopicTrainingProgramsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicTrainingProgramsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTrainingProgram>>> Get()
        {
            return await _context.CurriculumTopicTrainingPrograms.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Get(int id)
        {
            var value = await _context.CurriculumTopicTrainingPrograms.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("TrainingProgramCurriculumSection/{trainingProgramCurriculumSectionId}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTrainingProgram>>> GetFromTrainingProgramCurriculumSection(int trainingProgramCurriculumSectionId)
        {
            return await _context.CurriculumTopicTrainingPrograms
                .Where(a => a.TrainingProgramCurriculumSectionId == trainingProgramCurriculumSectionId).OrderBy(e => e.SerialNumber).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPut("SerialNumbers")]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> PutSerialNumbers([FromBody] List<CurriculumTopicTrainingProgram> values)
        {
            if (ModelState.IsValid)
            {
                foreach (var value in values)
                {
                    _context.Update(value);
                }
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Post(CurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTrainingPrograms.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("FromCurriculumSections")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTrainingProgram>>> GetFromCurriculumSections([FromBody] int[] curriculumSectionIdArray)
        {
            IEnumerable<CurriculumTopicTrainingProgram> result = new List<CurriculumTopicTrainingProgram>();
            foreach (var curriculumSectionId in curriculumSectionIdArray.AsParallel())
            {
                var res = await _context.CurriculumTopicTrainingPrograms
                    .Where(a => a.TrainingProgramCurriculumSectionId == curriculumSectionId && a.IsVariable == false)
                    .OrderBy(b => b.SerialNumber).ToListAsync();
                result = result.Union(res);
            }
            return result.ToList();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTrainingProgram>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTrainingPrograms.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTrainingPrograms.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
