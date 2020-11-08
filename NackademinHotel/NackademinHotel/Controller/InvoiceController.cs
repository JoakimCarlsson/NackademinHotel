using System;
using NackademinHotel.Model;

namespace NackademinHotel.Controller
{
    public class InvoiceController
    {
        internal Invoice CreateInvoice(DateTime bookedDate, bool payed)
        {
            return new Invoice(bookedDate, payed);
        }
    }
}