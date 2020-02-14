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
        public string instructorFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string instructorLastName { get; set; }

        [Display(Name = "Email")]
        public string instructorEmail { get; set; }

        [Display(Name = "Phone")]
        public string instructorPhone { get; set; }

        [Display(Name = "Instructor Since")]
        public DateTime instructorSince { get; set; }

        [Display(Name = "Instructor")]
        public string instructorFullName { get { return instructorLastName + ", " + instructorFirstName; } }


        // can have several classes
        public ICollection<Course> Course { get; set; }
    }
}