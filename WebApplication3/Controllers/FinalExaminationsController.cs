﻿using System;
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
    public class FinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.FinalExaminations
                      join second in _context.CertificationTypes on first.CertificationTypeId equals second.Id
                      select new
                      {
                          first.Id,
                          first.Content,
                          first.CertificationTypeId,
                          CertificationTypeName = second.Name
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FinalExamination>>> Get(int id)
        {
            return await _context.FinalExaminations.Where(a => a.CertificationTypeId == id).ToListAsync();
        }

        [HttpGet("{curriculumTopicId}/{certificationTypeId}")]
        public ActionResult<IEnumerable<FinalExamination>> Get(int curriculumTopicId, int certificationTypeId)
        {
            var result = _context.FinalExaminations.Where(a => a.CurriculumTopicFinalExaminations
            .Any(r => r.CurriculumTopicId == curriculumTopicId && r.FinalExamination.CertificationTypeId == certificationTypeId));
            return result.ToList();
        }

        [HttpPut]
        public async Task<IActionResult> Put(FinalExamination value)
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
        public async Task<ActionResult<FinalExamination>> Post(FinalExamination value)
        {
            if (ModelState.IsValid)
            {
                _context.FinalExaminations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FinalExamination>> Delete(int id)
        {
            var value = await _context.FinalExaminations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.FinalExaminations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
