using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicConsultationTopics
    {
        public int ConsultationTopicsId { get; set; }
        public int CurriculumTopicId { get; set; }

        public ConsultationTopics ConsultationTopics { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
