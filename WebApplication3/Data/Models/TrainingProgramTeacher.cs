
namespace e.moiroServer.Data.Models
{
    public class TrainingProgramTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int TrainingProgramId { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
    }
}
