using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kg506115MIS4200_sp20.Models
{
    public class CourseDetails
    {
        [Key]
        public int courseDetailsID { get; set; }
        public string semesterDate { get; set; }

        // link the courseDetails to the Courses
        public int courseID { get; set; }
        public virtual Course { get; set; } 



    }
}