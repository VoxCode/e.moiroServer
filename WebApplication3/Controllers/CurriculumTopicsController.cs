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
    public class CurriculumTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> GetCurriculumTopics()
        {
            return await _context.CurriculumTopics.ToListAsync();
        }

        // GET: api/CurriculumTopics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopic>> GetCurriculumTopic(int id)
        {
            var curriculumTopic = await _context.CurriculumTopics.FindAsync(id);

            if (curriculumTopic == null)
            {
                return NotFound();
            }

            return curriculumTopic;
        }

        // PUT: api/CurriculumTopics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopic(int id, CurriculumTopic curriculumTopic)
        {
            if (id != curriculumTopic.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicExists(id))
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

        // POST: api/CurriculumTopics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopic>> PostCurriculumTopic(CurriculumTopic curriculumTopic)
        {
            _context.CurriculumTopics.Add(curriculumTopic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopic", new { id = curriculumTopic.Id }, curriculumTopic);
        }

        // DELETE: api/CurriculumTopics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopic>> DeleteCurriculumTopic(int id)
        {
            var curriculumTopic = await _context.CurriculumTopics.FindAsync(id);
            if (curriculumTopic == null)
            {
                return NotFound();
            }

            _context.CurriculumTopics.Remove(curriculumTopic);
            await _context.SaveChangesAsync();

            return curriculumTopic;
        }

        private bool CurriculumTopicExists(int id)
        {
            return _context.CurriculumTopics.Any(e => e.Id == id);
        }
    }
}
