using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicConsultationTopics
    {
        public int Id { get; set; }
        public int ConsultationTopicsId { get; set; }
        public int CuriculumTopicId { get; set; }

        public ConsultationTopics ConsultationTopics { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }
    }
}
