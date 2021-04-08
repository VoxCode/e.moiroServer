using e.moiroServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlToDocxController : ControllerBase
    {
        [AcceptVerbs("Post")]
        public object Import(string data)
        {
            HtmlToDocxService htmlToDocxService = new HtmlToDocxService(data);
            var docx = htmlToDocxService.Document;
            return File(docx, "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
          "filename.docx");
        }
    }
}
