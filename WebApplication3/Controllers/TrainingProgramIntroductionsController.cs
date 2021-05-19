using e.moiroServer.Data.Models;
using e.moiroServer.Data.Models.ResponseModels;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
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
        public async Task<ActionResult<TrainingProgramIntroductionResponse>> GetFromTrainingProgram(int trainingProgramId)
        {
            var model = await _context.TrainingProgramIntroductions.FirstOrDefaultAsync(a => a.TrainingProgramId == trainingProgramId);
            if (model == null)
            {
                return Ok();
            }

            var responseModel = new TrainingProgramIntroductionResponse()
            {
                Id = model.Id,
                TrainingProgramId = model.TrainingProgramId,
                Introduction = Encoding.UTF8.GetString(model.IntroductionDocx)
            };
            return responseModel;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramIntroductionResponse responseModel)
        {
            var model = new TrainingProgramIntroduction()
            {
                Id = responseModel.Id,
                TrainingProgramId = responseModel.TrainingProgramId,
                IntroductionDocx = Encoding.UTF8.GetBytes(responseModel.Introduction)
            };

            if (ModelState.IsValid)
            {
                _context.Update(model);
                await _context.SaveChangesAsync();
                responseModel.Introduction = Encoding.UTF8.GetString(model.IntroductionDocx);
                return Ok(responseModel);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<TrainingProgramIntroductionResponse>> Post(TrainingProgramIntroductionResponse responseModel)
        {
            var model = new TrainingProgramIntroduction()
            {
                Id = responseModel.Id,
                TrainingProgramId = responseModel.TrainingProgramId,
                IntroductionDocx = Encoding.UTF8.GetBytes(responseModel.Introduction)
            };

            if (ModelState.IsValid)
            {
                _context.TrainingProgramIntroductions.Add(model);
                await _context.SaveChangesAsync();
                responseModel.Id = model.Id;
                responseModel.Introduction = Encoding.UTF8.GetString(model.IntroductionDocx);
                return Ok(responseModel);
            }
            return BadRequest(ModelState);
        }
    }
}
