﻿
namespace e.moiroServer.Data.Models
{
    public class TrainingProgramFinalExamination
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int FinalExaminationId { get; set; }
        public int SerialNumber { get; set; }
    }
}
