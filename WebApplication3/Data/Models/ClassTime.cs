using System;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class ClassTime
    {
        public int Id { get; set; }
        public DateTime ClassTimeStart { get; set; }
        public DateTime ClassTimeEnd { get; set; }
        public List<ScheduleBlockClassTime> ScheduleBlockClassTimes { get; set; }
    }
}
