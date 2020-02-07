using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kg506115MIS4200_sp20.Models
{
    public class Course
    {
        [Key]
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
        
        // students must tie to a course
        public int studentID { get; set; }
        public virtual Student Student { get; set; }


    }
}