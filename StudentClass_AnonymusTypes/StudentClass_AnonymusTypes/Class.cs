using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass_AnonymusTypes
{
    class Class
    {

        private List<Student> students = new List<Student>();

        /// <summary>
        /// Adds student tıo class
        /// If given student's name and surname already exists in the class,
        /// ask user if she/he still want to add that student
        /// </summary>
        /// <param name="std"></param>
        public void Add(Student std)
        {

            bool isStudentExist = false;
            string addQuestion;
            foreach (var student in students)
            {
                if(student.Name==std.Name && student.Surname == std.Surname)
                {
                    isStudentExist = true;
                }
            }
            if (isStudentExist)
            {
                Console.WriteLine("This student already recorded to class. Do you still want to add it to class? (Yes/No)");
                addQuestion = Console.ReadLine().ToLower();
                if (addQuestion == "yes")
                    students.Add(std);
                else
                    Console.WriteLine("Student not added to class.");
            }
            else
            {
                students.Add(std);
            }
        }
        /// <summary>
        /// Gets student in the class with given name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Student> GetStudentsByName(string name)
        {
            return students.Where(s => s.Name.Contains(name)).ToList();
        }
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Number == id);
        }

        /// <summary>
        /// Removes student from the class with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Student> RemoveStudentById(int id)
        {
            var toRemove = students.SingleOrDefault(s => s.Number == id);
            if (toRemove != null)
                students.Remove(toRemove);
            return students;
        }

        /// <summary>
        /// Shows students in the class
        /// </summary>
        public void showStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Student name: {item.Name}, surname:{item.Surname}, semester:{item.Semester}, number:{item.Number}");
            }
        }

    }
}
