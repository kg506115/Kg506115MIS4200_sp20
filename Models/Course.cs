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
        [Required(ErrorMessage = "Please provide the course abbreviation. (Ex. MATH 1350)")]
        [StringLength(10)]
        public string courseAbbreviation { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please provide the course title. (Ex. Business Calculus)")]
        [StringLength(50)]
        public string courseTitle { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide a relevant course description.")]
        [StringLength(500)]
        public string courseDescription { get; set; }

        [Display(Name = "Credit Hours")]
        [Required]
        public int numberOfCreditHours { get; set; }

        // one relationship
        public ICollection<CourseDetails> CourseDetails { get; set; }

        // instructor can teach many classes
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

    }
}