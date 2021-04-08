using Microsoft.AspNetCore.Http;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace e.moiroServer.Services
{
    public class DocxMergeService
	{
		public DocxMergeService(IFormFile firstDocx, IFormFile secondDocx)
		{
			MemoryStream firstStream = new MemoryStream();
			firstDocx.CopyTo(firstStream);
			firstStream.Position = 0;
			MemoryStream secondStream = new MemoryStream();
			secondDocx.CopyTo(secondStream);
			secondStream.Position = 0;

			using WordDocument document = new WordDocument(firstStream, FormatType.Automatic);
			WordDocument destinationDocument = new WordDocument(secondStream, FormatType.Docx);
			destinationDocument.ImportContent(document, ImportOptions.UseDestinationStyles);
			MemoryStream stream = new MemoryStream();
			destinationDocument.Save(stream, FormatType.Docx);
			destinationDocument.Close();
			document.Close();
			stream.Position = 0;
			Syncfusion.EJ2.DocumentEditor.WordDocument documentResult = Syncfusion.EJ2.DocumentEditor.WordDocument
.Load(stream, Syncfusion.EJ2.DocumentEditor.FormatType.Docx);
			string sfdt = Newtonsoft.Json.JsonConvert.SerializeObject(documentResult);
			Sfdt = sfdt;
			documentResult.Dispose();
		}
		public string Sfdt { get; set; }
	}
}
