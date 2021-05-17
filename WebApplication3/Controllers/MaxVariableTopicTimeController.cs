using e.moiroServer.Data.Models;
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
    public class MaxVariableTopicTimeController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MaxVariableTopicTimeController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("{trainingProgramCurriculumSectionId}")]
        public async Task<ActionResult<IEnumerable<MaxVariableTopicTime>>> Get(int trainingProgramCurriculumSectionId)
        {

            return await _context.MaxVariableTopicTimes
                .Where(a => a.TrainingProgramCurriculumSectionId == trainingProgramCurriculumSectionId).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(MaxVariableTopicTime value)
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
        public async Task<ActionResult<MaxVariableTopicTime>> Post(MaxVariableTopicTime value)
        {
            if (ModelState.IsValid)
            {
                _context.MaxVariableTopicTimes.Add(value);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpPost("Delete")]
        public async Task<ActionResult<MaxVariableTopicTime>> Delete(MaxVariableTopicTime value)
        {
            _context.Remove(value);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
