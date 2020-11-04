using System.Collections.Generic;

namespace BackEnd
{
    public interface IInvoice
    {
        string InvoiceNumber { get; set; }
        List<Invoice> invoices { get; set; }

        List<Invoice> InvoicesToProcess(List<Invoice> _invoices);
    }
}