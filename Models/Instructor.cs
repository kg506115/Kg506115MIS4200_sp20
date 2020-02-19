using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kg506115MIS4200_sp20.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(20)]
        public string instructorFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(20)]
        public string instructorLastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        [StringLength(20)]
        public string instructorEmail { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter a primary phone number.")]
        public string instructorPhone { get; set; }

        [Display(Name = "Instructor Since")]
        [Required]
        public DateTime instructorSince { get; set; }

        [Display(Name = "Instructor")]
        public string instructorFullName { get { return instructorLastName + ", " + instructorFirstName; } }


        // can have several classes
        public ICollection<Course> Course { get; set; }
    }
}