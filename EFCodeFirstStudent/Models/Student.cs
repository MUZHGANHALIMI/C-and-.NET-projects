using System;

namespace EFCodeFirstStudent.Models
{
    public class Student
    {
        public int StudentId { get; set; }  // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
