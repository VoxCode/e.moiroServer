using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using HtmlToOpenXml;
using System.IO;

namespace e.moiroServer.Services
{
    public class HtmlToDocxService
    {
        public HtmlToDocxService(string htmlData)
        {
            using MemoryStream generatedDocument = new MemoryStream();
            using WordprocessingDocument package =
                           WordprocessingDocument.Create(generatedDocument,
                           WordprocessingDocumentType.Document);
            MainDocumentPart mainPart = package.MainDocumentPart;
            if (mainPart == null)
            {
                mainPart = package.AddMainDocumentPart();
                new Document(new Body()).Save(mainPart);
            }
            HtmlConverter converter = new HtmlConverter(mainPart);
            converter.ParseHtml(htmlData);
            mainPart.Document.Save();
            generatedDocument.Position = 0;
            Document = generatedDocument.ToArray();
        }

        public byte[] Document { get; set; }
    }
}
