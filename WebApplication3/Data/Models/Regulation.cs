using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e.moiroServer.Data.Models
{
    public class Regulation
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AuthorIndex { get; set; }
        public DateTime AccessDate { get; set; }
        public Boolean AccessDateEnabled { get; set; }
        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }

        //public DateTime AccessDate
        //{
        //    get
        //    {
        //        return this.accessDate.HasValue
        //           ? this.accessDate.Value
        //           : DateTime.Now;
        //    }

        //    set { this.accessDate = value; }
        //}

    }
}
