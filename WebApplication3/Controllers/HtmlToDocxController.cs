using e.moiroServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlToDocxController : ControllerBase
    {
        [AcceptVerbs("Post")]
        public byte[] Import(IFormCollection data)
        {

            IFormFile docx = data.Files[0];

            string html = @"<html><head><title> XHTML to Doc  </title></head>
                               <body><p><b>XHTML to Doc - Strict XHTML example</b></p><p></p>
                               <table style=""margin: 5px"">
                                  <tr>
                                       <th> Firstname </th>
                                       <th> Lastname </th>
                                       <th> Age </th>
                                  </tr>
                                  <tr>
                                       <td> Jill </td>
                                       <td> Smith </td>
                                       <td> 50 </td>
                                  </tr>
                                  <tr>
                                       <td> Eve </td>
                                       <td> Jackson </td>
                                       <td> 94 </td>
                                  </tr>
                               </table>
<p align=""center"" style=""margin - bottom:0cm; text - align:center; margin - top:0cm; margin - right:0cm; margin - left:0cm; line - height:115 %; font - size:11.0pt; font - family:&quot; Calibri & quot;,sans - serif; ""><b><span style=""font - size:14.0pt; line - height:
115 %; font - family:&quot; Times New Roman & quot;,serif; "">ВВЕДЕНИЕ</span></b></p><p><br></p>
                                       < p><b>Essential DocIO</b> now supports converting valid XHTML content to Doc content. The passed in content should be either XHTML 1.0 or 1.1 compliant.</p><p></p>
                               <p><b>XHTML 1.0 Strict</b></p>
                               <p>It is the same as HTML 4.01 Strict, but it follows XML syntax rules.</p>
                               </body></html>";

            HtmlToDocxService htmlToDocxService = new HtmlToDocxService(html, docx);
            var resultDocx = htmlToDocxService.Document;
            return resultDocx;
        }
    }
}
