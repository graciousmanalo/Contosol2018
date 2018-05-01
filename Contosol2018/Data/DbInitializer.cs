using ContosoUniversity2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity2018.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //EnsureCreated method will automatically create the database 
            //if it does not already exist
            context.Database.EnsureCreated();

            //First look for any students
            //======================= STUDENTS =======================//
            if (context.Students.Any())
            {
                //Database has already been seeded(means populated) with students
                return; //exits
            }
            //if we get here - students do not already exist - seed(populate)
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Email = "calexander@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 0KC"

                },

                new Student
                {
                    FirstName = "Meridith",
                    LastName = "Alonzo",
                    Email = "malonzo@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "205 Argyle Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 0KC"

                }
            };
            //Loop the students array and add each student to the database context
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            //Save context
            context.SaveChanges();


            //======================= INSTRUCTORS =======================//
            var instructors = new Instructor[]
            {
                new Instructor
                {
                    FirstName = "Gracious Camille",
                    LastName = "Manalo",
                    Email = "graciousmanalo@gmail.com",
                    HireDate = DateTime.Parse("2013-06-11"),
                    Address = "123 Main Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 4E5"

                },

                new Instructor
                {
                    FirstName = "Frank",
                    LastName = "Bekkering",
                    Email = "frankbekekring@gmail.com",
                    HireDate = DateTime.Parse("1999-07-05"),
                    Address = "456 Main Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 2KC"

                }
            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }

            //Save context
            context.SaveChanges();

            //======================= COURSES =======================//
            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3 },
                new Course{CourseID=4022, Title="MicroEconomics",Credits=3 },


            };
            foreach(Course c in courses)
            {
                context.Add(c);
            }

            //Save context
            context.SaveChanges();

            //======================= ENROLLMENT =======================//
            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID = 1050,
                               StudentID = students.Single(s=>s.LastName=="Manalo").ID,
                               Grade = Grade.A },
                 new Enrollment{CourseID = 4022,
                               StudentID = students.Single(s=>s.LastName=="Alonzo").ID,
                               Grade = Grade.B },
            };
            foreach(Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            //Save context
            context.SaveChanges();
        }

    }
}
