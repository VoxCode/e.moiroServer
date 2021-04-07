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
            WordDocument firstDocx = (WordDocument)data.Files[0];
            WordDocument secondDocx = (WordDocument)data.Files[1];
            DocxMergeService docxMergeService = new DocxMergeService(firstDocx, secondDocx);
            string sfdt = docxMergeService.Sfdt;
            return sfdt;
        }
    }
}
