using System;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class MainLiterature
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AuthorIndex { get; set; }
        public DateTime AccessDate { get; set; }
        public Boolean AccessDateEnabled { get; set; }
        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }
    }
}
