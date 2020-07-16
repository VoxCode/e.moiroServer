using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class ConsultationTopic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<СurriculumTopicConsultationTopic> СurriculumTopicConsultationTopics { get; set; }
        public ConsultationTopic()
        {
            СurriculumTopicConsultationTopics = new List<СurriculumTopicConsultationTopic>();
        }
    }
}
