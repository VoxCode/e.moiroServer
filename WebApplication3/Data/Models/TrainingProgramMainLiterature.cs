using System;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgramMainLiterature
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int SerialNumber { get; set; }
        public string Content { get; set; }
        public DateTime AccessDate { get; set; }
        public Boolean AccessDateEnabled { get; set; }
    }
}
