using System;

namespace Task2_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSalaried Employee");
            //Create an object of my salaried employee
            SalariedEmployee mySalaried = new SalariedEmployee("Mia", "Begtsson", "9406168005", 1400.00);
            //Write the represents of the employee
            Console.WriteLine(mySalaried.ToString());

            Console.WriteLine("\n\tHourly Employee");
            //Create an object of my hourly employee
            HourlyEmployee myHourly = new HourlyEmployee("Cicci", "Whilhemsson", "7802019223", 20, 50.00);
            //Write the represents of the employee
            Console.WriteLine(myHourly.ToString());
        }
    }
}
