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
        public List<CurriculumTopicTheQuestion> CurriculumTopicTheQuestions { get; set; }
        public TheQuestion()
        {
            CurriculumTopicTheQuestions = new List<CurriculumTopicTheQuestion>();
        }
    }
}
