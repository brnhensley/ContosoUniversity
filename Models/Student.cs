using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //The Enrollments property is a navigation property.Navigation properties link to other entities that are related to this entity.In this case, the Enrollments property of a Student entity holds all of the Enrollment entities that are related to that Student.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}