using System;
using EFCodeFirstStudent.Data;
using EFCodeFirstStudent.Models;

namespace EFCodeFirstStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student object
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add to database
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("✅ Student added successfully!");
                Console.ReadLine();
            }
        }
    }
}
