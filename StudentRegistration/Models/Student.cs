using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName} {Gender} {Age}";
        }

    }
}
