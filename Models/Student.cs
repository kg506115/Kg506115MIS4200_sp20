using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public string studentEmail { get; set; }
        public string studentPhone { get; set; }
        public DateTime studentSince { get; set; }

    }
}