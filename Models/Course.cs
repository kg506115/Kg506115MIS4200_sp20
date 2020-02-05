using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseAbbreviation { get; set; }
        public string courseTitle { get; set; }
        public string courseDescription { get; set; }
        public int numberOfCreditHours { get; set; }

        // one relationship
        public ICollection<CourseDetails> CourseDetails { get; set; }

        // instructor can teach many classes
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
        
        // students can take many classes
        public int studentID { get; set; }
        public virtual Student Student { get; set; }


    }
}