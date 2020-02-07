using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kg506115MIS4200_sp20.Models;  // This is needed to access the models 
using System.Data.Entity;  // this is needed to access the DbContext object
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Kg506115MIS4200_sp20.DAL
{
    public class MIS4200Context : System.Data.Entity.DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}