using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTranningProgram
    {
        public int CurriculumTopicId { get; set; }
        public int TranningProgramId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
        public TrainingProgram TranningProgram { get; set; }
    }
}

