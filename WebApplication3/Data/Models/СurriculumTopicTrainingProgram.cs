
using System.ComponentModel.DataAnnotations;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTrainingProgram
    {
        public int Id { get; set; }
        public bool IsVariable { get; set; }
        public int ClassHours { get; set; }
        public int SerialNumber { get; set; }
        [Required]
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
        [Required]
        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        [Required]
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }
        [Required]
        public int TrainingProgrmaCurriculumSectionId { get; set; }
        public TrainingProgramCurriculumSection TrainingProgramCurriculumSection { get; set; }
    }
}

