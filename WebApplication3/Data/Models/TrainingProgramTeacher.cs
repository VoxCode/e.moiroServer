using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgramTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int TrainingProgramId { get; set; }

    }
}
