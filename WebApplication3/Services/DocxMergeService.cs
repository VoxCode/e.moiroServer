using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace e.moiroServer.Services
{
	public class DocxMergeService
	{
		public DocxMergeService(WordDocument firstDocx, WordDocument secondDocx)
		{
			firstDocx.ImportContent(secondDocx, ImportOptions.UseDestinationStyles);
			MemoryStream stream = new MemoryStream();
			firstDocx.Save(stream, FormatType.Docx);
			firstDocx.Close();
			secondDocx.Close();
			stream.Position = 0;
			Syncfusion.EJ2.DocumentEditor.WordDocument document = 
				Syncfusion.EJ2.DocumentEditor.WordDocument.Load(stream, Syncfusion.EJ2.DocumentEditor.FormatType.Docx);
			string sfdt = Newtonsoft.Json.JsonConvert.SerializeObject(document);
			Sfdt = sfdt;
			document.Dispose();
		}
		public string Sfdt { get; set; }
	}
}
