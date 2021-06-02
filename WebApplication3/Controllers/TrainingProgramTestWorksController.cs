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
    public class TrainingProgramTestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramTestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("FromTrainingProgram/{trainingProgramId}")]
        public async Task<ActionResult<TrainingProgramTestWorkResponse>> GetFromTrainingProgram(int trainingProgramId)
        {
            var model = await _context.TrainingProgramTestWorks.FirstOrDefaultAsync(a => a.TrainingProgramId == trainingProgramId);
            if (model == null)
            {
                return Ok();
            }

            var responseModel = new TrainingProgramTestWorkResponse()
            {
                Id = model.Id,
                TrainingProgramId = model.TrainingProgramId,
                Content = Encoding.UTF8.GetString(model.ContentDocx)
            };
            return responseModel;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramTestWorkResponse responseModel)
        {
            var model = new TrainingProgramTestWork()
            {
                Id = responseModel.Id,
                TrainingProgramId = responseModel.TrainingProgramId,
                ContentDocx = Encoding.UTF8.GetBytes(responseModel.Content)
            };

            if (ModelState.IsValid)
            {
                _context.Update(model);
                await _context.SaveChangesAsync();
                responseModel.Content = Encoding.UTF8.GetString(model.ContentDocx);
                return Ok(responseModel);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<TrainingProgramTestWorkResponse>> Post(TrainingProgramTestWorkResponse responseModel)
        {
            var model = new TrainingProgramTestWork()
            {
                Id = responseModel.Id,
                TrainingProgramId = responseModel.TrainingProgramId,
                ContentDocx = Encoding.UTF8.GetBytes(responseModel.Content)
            };

            if (ModelState.IsValid)
            {
                _context.TrainingProgramTestWorks.Add(model);
                await _context.SaveChangesAsync();
                responseModel.Id = model.Id;
                responseModel.Content = Encoding.UTF8.GetString(model.ContentDocx);
                return Ok(responseModel);
            }
            return BadRequest(ModelState);
        }
    }
}
