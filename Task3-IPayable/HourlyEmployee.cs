using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_IPayable
{
    class HourlyEmployee : Employee
    {
        //Tow field for the salary
        private int _hours;
        private decimal _wage;

        public HourlyEmployee(string firstName, string lastName, string ssn, int hours, decimal wage) : base(firstName, lastName, ssn)
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
        public override decimal Earning()
        {
            //Calculate weeks salery
            decimal weeklySalary = _hours * _wage;

            return weeklySalary;
        }

        public override decimal GetPaymentAmount()
        {
            //The company pays weekly for hourly employees
            decimal amount = Earning();

            return amount;
        }
    }
}
