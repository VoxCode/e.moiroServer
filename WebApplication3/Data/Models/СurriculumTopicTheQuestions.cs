using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTheQuestions
    {
        public int TheQuestionsId { get; set; }
        public int CurriculumTopicId { get; set; }
        public TheQuestions TheQuestions { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
