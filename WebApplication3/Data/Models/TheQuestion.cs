using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TheQuestion
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<СurriculumTopicTheQuestion> СurriculumTopicTheQuestions { get; set; }
        public TheQuestion()
        {
            СurriculumTopicTheQuestions = new List<СurriculumTopicTheQuestion>();
        }
    }
}
