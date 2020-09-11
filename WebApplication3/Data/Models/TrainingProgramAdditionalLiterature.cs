using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgramAdditionalLiterature
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int AdditionalLiteratureId { get; set; }
        public int SerialNumber { get; set; }
    }
}
