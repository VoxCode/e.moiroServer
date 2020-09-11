using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgramTestWork
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int TestWorkId { get; set; }
        public int SerialNumber { get; set; }
    }
}
