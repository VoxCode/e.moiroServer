using System;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int GroupNumber { get; set; }
        public DateTime CalendarYear { get; set; }        
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public int TrainingProgramId { get; set; }
        public ICollection<ScheduleDate> ScheduleDates { get; set; }
    }
}
