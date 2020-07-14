using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTheQuestions
    {
        public int Id { get; set; }
        public int TheQuestionsId { get; set; }
        public int CuriculumTopicId { get; set; }

        public TheQuestions TheQuestions { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }

    }
}
