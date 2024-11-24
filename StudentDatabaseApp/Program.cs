using System;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

                // Add the student to the database
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }
        }
    }
}
