using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Employee
{
    public abstract class Employee
    {
        //Three fields for the employee
        private string _firstName;
        private string _lastName;
        private string _ssn;

        //Three read-only properties
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string SSN { get => _ssn; }

        //Constructor that takes three arguments to initialize the attributes. 
        public Employee(string firstName, string lastName, string ssn)
        {
            _firstName = firstName;
            _lastName = lastName;
            _ssn = ssn;
        }

        public override string ToString()
        {
            //Create string that represents the employee
            string text = $"Name: {FirstName} {LastName}\nSocial Security Number: {SSN}\nEarning: {Earning()}";

            //Return string
            return text;
        }

        public abstract double Earning();

    }
}
