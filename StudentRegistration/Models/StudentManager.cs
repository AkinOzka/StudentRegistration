using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class StudentManager
    {
        List<Student> students=new List<Student>();
        public void Insert(Student student)
        {
            students.Add(student);
        }
        public List<Student>GetStudents()
        {
            return students;
        }
        
        
    }
}
