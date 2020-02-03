using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class CourseDetails
    {
        public int courseDetailID { get; set; }
        public string semesterDate { get; set; }


        // link to other tables
        // Course
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // Student
        public int studentID { get; set; }
        public virtual Student { get; set; }
        // Instructor
        public int instructorID { get; set; }
        public virtual Instructor { get; set; }

    }
}