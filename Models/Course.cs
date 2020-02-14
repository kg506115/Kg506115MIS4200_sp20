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

        [Display (Name ="Course")]
        public string courseAbbreviation { get; set; }

        [Display(Name = "Title")]
        public string courseTitle { get; set; }

        [Display(Name = "Course Description")]
        public string courseDescription { get; set; }

        [Display(Name = "Credit Hours")]
        public int numberOfCreditHours { get; set; }

        // one relationship
        public ICollection<CourseDetails> CourseDetails { get; set; }

        // instructor can teach many classes
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

    }
}