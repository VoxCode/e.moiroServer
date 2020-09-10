using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicMainLiterature
    {
        public int Id { get; set; }
        public int MainLiteratureId { get; set; }
        public MainLiterature MainLiterature { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
