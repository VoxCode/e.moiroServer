using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class ConsultationTopics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<СurriculumTopicConsultationTopics> СurriculumTopicConsultationTopics { get; set; }
        public ConsultationTopics()
        {
            СurriculumTopicConsultationTopics = new List<СurriculumTopicConsultationTopics>();
        }
    }
}
