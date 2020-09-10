using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTheQuestion
    {
        public int Id { get; set; }
        public int TheQuestionId { get; set; }
        public TheQuestion TheQuestion { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
