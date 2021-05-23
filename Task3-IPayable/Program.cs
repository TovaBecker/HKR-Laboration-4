using System;

namespace Task3_IPayable
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            Console.WriteLine("\nInvoice 1");
            //Create an object of my invoice
            Invoice myInvoice1 = new Invoice("AK20311", 5, (decimal) 1400.00);
            //Write the payment amount
            Console.WriteLine($"Invoice number: {myInvoice1.InvoiceNumber}\nPayment amount: {myInvoice1.GetPaymentAmount()}");

            Console.WriteLine("\nInvoice 2");
            //Create an object of my invoice
            Invoice myInvoice2 = new Invoice("AK60840", 40, (decimal) 30.00);
            //Write the payment amount
            Console.WriteLine($"Invoice number: {myInvoice2.InvoiceNumber}\nPayment amount: {myInvoice2.GetPaymentAmount()}");



            //B
            //Create array and set data
            IPayable[] getPaymentAmount = new IPayable[4] {
                                                            new Invoice("AK20311", 5, (decimal) 1400.00) ,
                                                            new SalariedEmployee("Mia", "Begtsson", "9406168005", (decimal) 1400.00),
                                                            new HourlyEmployee("Cicci", "Whilhemsson", "7802019223", 20, (decimal) 50.00),
                                                            new Invoice("AK60840", 40, (decimal) 30.00) };

            Console.WriteLine($"\nPayment Amount");
            //Go through the array and call the method GetPaymentAmount
            for (int i = 0; i < getPaymentAmount.Length; i++)
            {
                Console.WriteLine(getPaymentAmount[i].GetPaymentAmount());
            }
        }
    }
}
