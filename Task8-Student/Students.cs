using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Student
{
    class Students
    {
        //Field to hold student information
        protected string _name = "";
        protected DateTime _birthDate;
        protected string _course = "";
        protected int _grade = 0;

        public string Name { get => _name; set => _name = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public string Course { get => _course; set => _course = value; }
        public int Grade { get => _grade; set => _grade = value; }
        
        public Students(string name, DateTime birthDate, string course, int grade)
        {
            Name = name;
            BirthDate = birthDate;
            Course = course;
            Grade = grade;
        }
    }
}
