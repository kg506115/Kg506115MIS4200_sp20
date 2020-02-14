using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class Student
    {
        public int studentID { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Must enter first name.")]
        [StringLength(20)]
        public string studentFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Must enter last name.")]
        [StringLength(20)]
        public string studentLastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [StringLength(20)]
        public string studentEmail { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string studentPhone { get; set; }

        [Display(Name = "Student Since")]
        public DateTime studentSince { get; set; }

        [Display(Name = "Student")]
        public string studentFullName { get { return studentLastName + ", " + studentFirstName; } }


        // can have several classes
        public ICollection<Course> Course { get; set; }
    }
}