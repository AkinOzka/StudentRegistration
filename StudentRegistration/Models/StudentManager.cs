using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class StudentManager
    {
        public static List<Student> students = new List<Student>();
        public void Insert(Student student)
        {
            students.Add(student);
        }
        public  List<Student> GetStudents()
        {
            //List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, FirstName = "Anass", SecondName = "El Lamzi", Gender = "Male", Age = 28 });
            students.Add(new Student { Id = 2, FirstName = "Florian", SecondName = "Esprit", Gender = "Male", Age = 21 });
            students.Add(new Student { Id = 3, FirstName = "Tibo", SecondName = "Vuyst", Gender = "Male", Age = 24 });
            students.Add(new Student { Id = 4, FirstName = "Akin", SecondName = "Ozkan", Gender = "Male", Age = 32 });
            students.Add(new Student { Id = 5, FirstName = "Olga", SecondName = "Kharchuk", Gender = "female", Age = 25 });
            return students;
        }
        public void Update(Student student, int index)
        {
            students[index].Id = student.Id;
            students[index].FirstName = student.FirstName;
            students[index].SecondName = student.SecondName;
            students[index].Gender = student.Gender;
            students[index].Age = student.Age;
        }

    }
}
