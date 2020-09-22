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
    public class CurriculumSectionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumSectionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumSection>>> GetCurriculumSections()
        {
            return await _context.CurriculumSections.ToListAsync();
        }

        // GET: api/CurriculumSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumSection>> GetCurriculumSection(int id)
        {
            var curriculumSection = await _context.CurriculumSections.FindAsync(id);

            if (curriculumSection == null)
            {
                return NotFound();
            }

            return curriculumSection;
        }

        // PUT: api/CurriculumSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumSection(int id, CurriculumSection curriculumSection)
        {
            if (id != curriculumSection.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumSectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CurriculumSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumSection>> PostCurriculumSection(CurriculumSection curriculumSection)
        {
            _context.CurriculumSections.Add(curriculumSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumSection", new { id = curriculumSection.Id }, curriculumSection);
        }

        // DELETE: api/CurriculumSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumSection>> DeleteCurriculumSection(int id)
        {
            var curriculumSection = await _context.CurriculumSections.FindAsync(id);
            if (curriculumSection == null)
            {
                return NotFound();
            }

            _context.CurriculumSections.Remove(curriculumSection);
            await _context.SaveChangesAsync();

            return curriculumSection;
        }

        private bool CurriculumSectionExists(int id)
        {
            return _context.CurriculumSections.Any(e => e.Id == id);
        }
    }
}
