using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.DocumentEditor;
using System;
using System.IO;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordToSDFTController : ControllerBase
    {
        [AcceptVerbs("Post")]
        public string Import(IFormCollection data)
        {
            if (data.Files.Count == 0)
                return null;
            Stream stream = new MemoryStream();
            IFormFile file = data.Files[0];
            int index = file.FileName.LastIndexOf('.');
            string type = index > -1 && index < file.FileName.Length - 1 ?
                file.FileName.Substring(index) : ".docx";
            file.CopyTo(stream);
            stream.Position = 0;

            WordDocument document = WordDocument.Load(stream, GetFormatType(type.ToLower()));
            string sfdt = Newtonsoft.Json.JsonConvert.SerializeObject(document);
            document.Dispose();
            return sfdt;
        }

        internal static FormatType GetFormatType(string format)
        {
            if (string.IsNullOrEmpty(format))
                throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
            return format.ToLower() switch
            {
                ".dotx" or ".docx" or ".docm" or ".dotm" => FormatType.Docx,
                ".dot" or ".doc" => FormatType.Doc,
                ".rtf" => FormatType.Rtf,
                ".txt" => FormatType.Txt,
                ".xml" => FormatType.WordML,
                _ => throw new NotSupportedException("EJ2 DocumentEditor does not support this file format."),
            };
        }
        [AcceptVerbs("Post")]

        [Route("SystemClipboard")]
        public string SystemClipboard([FromBody] CustomParameter param)
        {
            if (param.content != null && param.content != "")
            {
                try
                {
                    //Hooks MetafileImageParsed event.
                    //WordDocument.MetafileImageParsed += OnMetafileImageParsed;
                    WordDocument document = WordDocument.LoadString(param.content, GetFormatType(param.type.ToLower()));
                    //Unhooks MetafileImageParsed event.
                    //WordDocument.MetafileImageParsed -= OnMetafileImageParsed;
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
                    document.Dispose();
                    return json;
                }
                catch (Exception)
                {
                    return "";
                }
            }
            return "";
        }

        public class CustomParameter
        {
            public string content { get; set; }
            public string type { get; set; }
        }

        //Converts Metafile to raster image.
    }
}
