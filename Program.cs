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
                // Create database if it doesn't exist
                context.Database.EnsureCreated();

                // Create and add one student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("✅ Student added successfully!");
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}");
            }

            Console.ReadLine();
        }
    }
}
