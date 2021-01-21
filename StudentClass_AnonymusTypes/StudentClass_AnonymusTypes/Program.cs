using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass_AnonymusTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // we can create anonymus objects using var
            var anonymous = new { Name = "ESra", Surname = "Arican", Number = 28 };
            
            //adding students to classroom
            var classroom= new Class();
            classroom.Add(new Student { Name = "Esra Nur", Surname = "Arican", Semester = 7, Number = 23 });
            classroom.Add(new Student { Name = "Esra", Surname = "Arican", Semester = 7, Number = 33 });
            classroom.Add(new Student { Name = "fatih", Surname = "Arican", Semester = 7, Number = 22 });
            classroom.Add(new Student { Name = "merve", Surname = "cicek", Semester = 7, Number = 21 });
            classroom.Add(new Student { Name = " ayse", Surname = "boz", Semester = 7, Number = 20 });
            classroom.Add(new Student { Name = "Rabia", Surname = "Dogan", Semester = 7, Number = 19 });
            classroom.Add(new Student { Name = "ali", Surname = "can", Semester = 7, Number = 18 });

            Console.WriteLine("******Students in the classroom after adding******");
            classroom.showStudents();

            //fins students by name
            var findings = classroom.GetStudentsByName("Esra");
            findings.ForEach(stud => Console.WriteLine($"{stud.Name} named student's semester is:{stud.Semester} ."));
            
            //find student by ıd(student number)
            var getStudId = classroom.GetStudentById(33);
            Console.WriteLine(getStudId.Name + " , " + getStudId.Number);

            //remove student with ıd(student number)
            classroom.RemoveStudentById(33);
            Console.WriteLine("******Students in the classroom after removing******");
            classroom.showStudents();

            Console.WriteLine("******Test adding a student which already exists in the same name and surname*****");
            classroom.Add(new Student  {Name = " ayse", Surname = "boz", Semester = 7, Number = 20 });
            classroom.showStudents();

            Console.ReadLine();

        }
    }
}
