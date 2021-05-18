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
    public class TrainingProgramIntroductionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramIntroductionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("FromTrainingProgram/{trainingProgramId}")]
        public async Task<ActionResult<TrainingProgramIntroduction>> GetFromTrainingProgram(int trainingProgramId)
        {
            //if (value.Introduction != null)
            //{
            //    value.Introduction = Encoding.UTF8.GetString(value.IntroductionData);
            //    //value.IntroductionData = null;
            //}
            return await _context.TrainingProgramIntroductions.FirstOrDefaultAsync(a => a.TrainingProgramId == trainingProgramId);
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramIntroduction value)
        {
            //if (value.Introduction != null)
            //{
            //    value.IntroductionData = Encoding.UTF8.GetBytes(value.Introduction);
            //    value.Introduction = "";
            //}
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<TrainingProgramIntroduction>> Post(TrainingProgramIntroduction value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramIntroductions.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }
    }
}
