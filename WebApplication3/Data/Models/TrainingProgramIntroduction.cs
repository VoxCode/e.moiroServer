namespace e.moiroServer.Data.Models
{
    public class TrainingProgramIntroduction
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public byte[] IntroductionDocx { get; set; }
    }
}
