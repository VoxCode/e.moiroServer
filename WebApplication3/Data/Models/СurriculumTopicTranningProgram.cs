using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTranningProgram
    {
        public int Id { get; set; }
        public int CuriculumTopicId { get; set; }
        public int TrainingProgramId { get; set; }

        public CuriculumTopic CuriculumTopic { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
    }
}
