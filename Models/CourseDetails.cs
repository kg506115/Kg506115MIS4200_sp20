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

        [Display(Name = "Semester")]
        [Required(ErrorMessage = "Please provide the semester of when the course is taken. (Ex. Fall 2018)")]
        [StringLength(50)]
        public string semesterDate { get; set; }


        // link the courseDetails to the Courses
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // link the courseDetails to the Students
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}