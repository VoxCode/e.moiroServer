using e.moiroServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.DocIO.DLS;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocxMergeController : ControllerBase
    {
        [AcceptVerbs("Post")]
        public string Import(IFormCollection data)
        {
            IFormFile firstDocx = data.Files[0];
            IFormFile secondDocx = data.Files[1];
            DocxMergeService docxMergeService = new DocxMergeService(firstDocx, secondDocx);
            string sfdt = docxMergeService.Sfdt;
            return sfdt;
        }
    }
}
