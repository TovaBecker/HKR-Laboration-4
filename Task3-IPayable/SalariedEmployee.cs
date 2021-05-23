using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_IPayable
{
    class SalariedEmployee : Employee
    { 
        //One field for the salary
        private decimal _weeklySalary;

        //One read-only properties
        public decimal WeeklySalary { get => _weeklySalary; }

        public SalariedEmployee(string firstName, string lastName, string ssn, decimal weeklySalary) : base(firstName, lastName, ssn)
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
        public override decimal Earning()
        {
            return WeeklySalary;
        }

        public override decimal GetPaymentAmount()
        {
            //Calculate month salary
            decimal amount = Earning() * 4;

            return amount;
        }
    }
}
