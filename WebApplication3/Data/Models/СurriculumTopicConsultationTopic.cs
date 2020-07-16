using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicConsultationTopic
    {
        public int ConsultationTopicId { get; set; }
        public ConsultationTopic ConsultationTopics { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
