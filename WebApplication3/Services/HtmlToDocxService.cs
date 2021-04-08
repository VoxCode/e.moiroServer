using Microsoft.AspNetCore.Http;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using System.Text;

namespace e.moiroServer.Services
{
    public class HtmlToDocxService
    {
        public HtmlToDocxService(string html, IFormFile docx)
        {

            //UnicodeEncoding uniEncoding = new UnicodeEncoding();

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    var sw = new StreamWriter(ms, uniEncoding);
            //    try
            //    {
            //        sw.Write(htmlData);
            //        sw.Flush();
            //        ms.Seek(0, SeekOrigin.Begin);
            //    }
            //    finally
            //    {
            //        sw.Dispose();
            //    }
            //    ms.Position = 0;

            MemoryStream firstStream = new MemoryStream();
            docx.CopyTo(firstStream);
            firstStream.Position = 0;

            WordDocument document = new WordDocument(firstStream, FormatType.Automatic);


            document.Sections[0].Body.InsertXHTML(html);


            MemoryStream stream = new MemoryStream();
            document.Save(stream, FormatType.Docx);
            document.Close();
            stream.Position = 0;


            //// document.HTMLImportSettings.ImageNodeVisited += OpenImage;

            //document.Open(ms, FormatType.Automatic);

            //// document.HTMLImportSettings.ImageNodeVisited -= OpenImage;

            //MemoryStream stream = new MemoryStream();

            //document.Save(stream, FormatType.Docx);

            //document.Close();
            //stream.Position = 0;

            Document = stream.ToArray();
        }

        public byte[] Document { get; set; }
    }
}
