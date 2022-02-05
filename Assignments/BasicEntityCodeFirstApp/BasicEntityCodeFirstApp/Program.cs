using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEntityCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student()
                {
                    StudentName = "Tony",
                    DateOfBirth = new DateTime(1989, 07, 20),
                    Height = 177.8M,
                    Weight = 90.7185f
                };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
                

                foreach(Student student in ctx.Students)
                {
                    Console.WriteLine("Student Name: " + stud.StudentName + ", Student DOB: " + stud.DateOfBirth + ", Student Height: " + stud.Height + ", Student weight: " + stud.Weight);
                }
            }
            
            Console.ReadLine();
        }
    }
}
