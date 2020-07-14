using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicMainLiterature
    {
        public int Id { get; set; }
        public int MainLiteratureId { get; set; }
        public int CuriculumTopicId { get; set; }

        public MainLiterature MainLiterature { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }
    }
}
