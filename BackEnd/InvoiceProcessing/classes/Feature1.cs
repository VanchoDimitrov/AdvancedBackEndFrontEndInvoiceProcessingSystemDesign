using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Feature1 : IFeature1
    {
        public void WelcomeToFeature1()
        {
            Messages.WelcomeToInvoiceProcessing();
            IInvoice i = new Invoice();
            var listInvoices = i.InvoicesToProcess(i.invoices);

            //Queue<T>
            // Add invoices for processing in queue
            var invs = new Queue<string>();
            foreach (var o in listInvoices)
            {
                invs.Enqueue(o.InvoiceNumber);
            }

            Messages.InvoicesStoredInQueue();
            Messages.EmptyRow();

            Messages.PrintInvoicesFromQueue();
            // Print invoices from queue
            foreach (var inv in invs)
            {
                Console.WriteLine(inv);
            }

            Messages.EmptyRow();
            Messages.InvoiceProcessing();
            Messages.EmptyRow();

            // process invoices algorythm from queue!
            try
            {
                var count = invs.Count;
                for (int ii = 0; ii <= count; ii++)
                {
                    if (count > 0)
                    {
                        ProcessInvoice(invs.Dequeue());
                        Console.WriteLine(invs.Peek());
                    }
                }
            }
            catch (Exception e)
            {
                Messages.NoInvoicesInQueue();
            }

            void ProcessInvoice(string InvoiceNumber)
            {
                // do something                
                Messages.ProcessInvoces(InvoiceNumber);
                NotifyCustomer();
            }

            void NotifyCustomer()
            {
                // do something
                Messages.EmailNotificastionSent();
                Messages.EmptyRow();
            }
        }
    }
}
