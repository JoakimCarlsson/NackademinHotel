using System;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class InvoiceController
    {
        internal Invoice CreateInvoice(DateTime bookedDate)
        {
            return new Invoice(bookedDate);
        }
    }
}