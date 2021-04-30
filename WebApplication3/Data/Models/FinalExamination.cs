using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class FinalExamination
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CertificationTypeId { get; set; }
        public string AuthorIndex { get; set; }
        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }
    }
}
