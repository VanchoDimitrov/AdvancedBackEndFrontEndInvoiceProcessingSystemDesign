using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public static class Messages
    {
        public static void EmptyRow() => Console.WriteLine();
        public static void WelcomeToInvoiceProcessing() => Console.WriteLine("Welcome to Invoice Processing");
        public static void InvoicesStoredInQueue() => Console.WriteLine("Invoicess stored in queue for further processing!");
        public static void PrintInvoicesFromQueue() => Console.WriteLine("Print stored invoices in queue collection");
        public static void InvoiceProcessing() => Console.WriteLine("Invoice Processing");
        public static void NoInvoicesInQueue() => Console.WriteLine("No more Invoices in queue!");
        public static void ProcessInvoces(string InvoiceNumber) => Console.WriteLine($"Invoice# {InvoiceNumber} processed!");
        public static void EmailNotificastionSent() => Console.WriteLine("Customer Notified by email!");
        public static void UserLogged(bool status) => Console.WriteLine($"User logged?: {status}");

    }
}
