using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Employee
{
    class SalariedEmployee : Employee
    { 
        //One field for the salary
        private double _weeklySalary;

        //One read-only properties
        public double WeeklySalary { get => _weeklySalary; }

        public SalariedEmployee(string firstName, string lastName, string ssn, double weeklySalary) : base(firstName, lastName, ssn)
        {
            _weeklySalary = weeklySalary;
        }
        public override string ToString()
        {
            //Create string that represents the employee
            string text = base.ToString();

            //Return string
            return text;
        }
        public override double Earning()
        {
            return WeeklySalary;
        }
    }
}
