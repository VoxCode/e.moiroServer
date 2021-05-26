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
			destinationDocument.Settings.MaintainImportedListCache = true;
			foreach (WSection section in document.Sections)
			{
				foreach (TextBodyItem bodyItem in section.Body.ChildEntities)
				{
					destinationDocument.LastSection.Body.ChildEntities.Add(bodyItem.Clone());
				}
			}
			destinationDocument.Settings.MaintainImportedListCache = false;
			MemoryStream stream = new MemoryStream();
			destinationDocument.Save(stream, FormatType.Docx);
			destinationDocument.Close();
			document.Close();
			stream.Position = 0;
			ResultDocx = stream.ToArray();

		}
		public byte[] ResultDocx { get; set; }
	}
}
