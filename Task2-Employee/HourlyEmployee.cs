using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Employee
{
    class HourlyEmployee : Employee
    {
        //Tow field for the salary
        private int _hours;
        private double _wage;

        public HourlyEmployee(string firstName, string lastName, string ssn, int hours, double wage) : base(firstName, lastName, ssn)
        {
            _hours = hours;
            _wage = wage;
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
            //Calculate weeks salery
            double weeklySalary = _hours * _wage;

            return weeklySalary;
        }
    }
}
