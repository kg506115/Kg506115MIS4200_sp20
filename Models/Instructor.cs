using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        public string instructorFirstName { get; set; }
        public string instructorLastName { get; set; }
        public string instructorEmail { get; set; }
        public string instructorPhone { get; set; }
        public DateTime instructorSince { get; set; }
        public string instructorFullName { get { return instructorLastName + ", " + instructorFirstName; } }

        // can have several classes
        public ICollection<Course> Course { get; set; }
    }
}