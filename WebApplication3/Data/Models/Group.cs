using System;

namespace e.moiroServer.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int GroupNumber { get; set; }
        public DateTime CalendarYear { get; set; }
        public string TheTopicOfContinuingEducation { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public int FormOfEducationId { get; set; }
        public int TrainingProgramId { get; set; }
    }
}
