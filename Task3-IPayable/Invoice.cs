using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_IPayable
{
    class Invoice : IPayable
    {
        //Three fields for the Invoice
        private string _invoiceNumber;
        private int _quantity;
        private decimal _pricePerItem;

        //One read-only properties
        public string InvoiceNumber { get => _invoiceNumber; }

        public Invoice(string invoiceNumber, int quantity, decimal pricePerItem)
        {
            _invoiceNumber = invoiceNumber;
            _quantity = quantity;
            _pricePerItem = pricePerItem;
        }

        public override decimal GetPaymentAmount()
        {
            //Calculate amount
            decimal amount = _quantity * _pricePerItem;

            return amount;

        }
    }
}
