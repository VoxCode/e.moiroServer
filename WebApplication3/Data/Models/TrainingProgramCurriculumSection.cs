
namespace e.moiroServer.Data.Models
{
    public class TrainingProgramCurriculumSection
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public int CurriculumSectionId { get; set; }
        public int SectionNumber { get; set; }
    }
}
