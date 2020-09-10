using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class FinalExamination
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CertificationTypeId { get; set; }
    }
}
