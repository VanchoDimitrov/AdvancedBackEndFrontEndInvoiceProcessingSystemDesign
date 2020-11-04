using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Invoice : IInvoice
    {
        public string InvoiceNumber { get; set; }

        public List<Invoice> invoices { get; set; } = new List<Invoice>();

        public List<Invoice> InvoicesToProcess(List<Invoice> _invoices)
        {
            _invoices = new List<Invoice>()
            {
                new Invoice{ InvoiceNumber= "Inv 1"},
                new Invoice{ InvoiceNumber= "Inv 2"},
                new Invoice{ InvoiceNumber= "Inv 3"},
                new Invoice{ InvoiceNumber= "Inv 4"},
                new Invoice{ InvoiceNumber= "Inv 5"},
            };
            return _invoices;
        }
    }
}
